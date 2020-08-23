using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SQLiteNetExtensionsAsync.Extensions;
using SQLiteNetExtensions.Extensions;
using Squelch.Library.Entities;
using Xamarin.Essentials;
using System.Threading;

namespace Squelch.Library.Data
{
    internal static class BlackoutDatabase
    {
        #region Instance Variables
        private static readonly string s_tag = typeof(BlackoutDatabase).FullName;
        private static readonly SQLiteAsyncConnection s_database;
        private static SemaphoreSlim s_databaseMaintenanceLock;
        #endregion

        #region Constructors
        static BlackoutDatabase()
        {
            s_databaseMaintenanceLock = new SemaphoreSlim(1, 1);
            s_database = new SQLiteAsyncConnection(new SQLiteConnectionString(Path.Combine(FileSystem.AppDataDirectory, "blackouts.db")));
            var result = s_database.CreateTableAsync<BlackoutItem>(CreateFlags.ImplicitPK | CreateFlags.AutoIncPK).Result;
        }
        #endregion

        #region Sql Methods
        public static async Task<bool> InsertOrReplaceAllAsync(List<BlackoutItem> blackoutItems)
        {
            bool result = false;

            try
            {
                await s_database.RunInTransactionAsync(transaction =>
                {
                    transaction.InsertOrReplaceAllWithChildren(blackoutItems, true);
                });

                result = true;

                if (result)
                    OnBlackoutTableChanged();
            }
            catch (Exception ex)
            {
                Logger.Write(s_tag, $"UpdateOrInsert: Unexpected error occured: {ex.Message}", Logger.Severity.Error);
                result = false;
            }

            return result;
        }

        public static async Task<bool> UpsertAsync(BlackoutItem blackoutItem)
        {
            bool result = false;

            try
            {
                await s_database.RunInTransactionAsync(transaction =>
                {
                    if (blackoutItem.Id != 0)
                        transaction.UpdateWithChildren(blackoutItem);
                    else
                        transaction.InsertWithChildren(blackoutItem);
                });

                result = true;

                if (result)
                    OnBlackoutTableChanged();
            }
            catch (Exception ex)
            {
                Logger.Write(s_tag, $"UpdateOrInsert: Unexpected error occured: {ex.Message}", Logger.Severity.Error);
                result = false;
            }

            return result;
        }

        public static async Task<bool> RemoveAsync(BlackoutItem blackoutItem)
        {
            bool result = false;
            int affectedRows = 0;

            try
            {
                await s_database.RunInTransactionAsync(transaction =>
                {
                    affectedRows = transaction.Delete<BlackoutItem>(blackoutItem.Id);
                });

                if (affectedRows > 0)
                    result = true;

                if (result)
                    OnBlackoutTableChanged();
            }
            catch (Exception ex)
            {
                Logger.Write(s_tag, $"Remove: Unexpected error occured: {ex.Message}", Logger.Severity.Error);
                result = false;
            }

            return result;
        }

        public static async Task<BlackoutItem> FindAsync(int blackoutId)
        {
            BlackoutItem result = default;

            try
            {
                result = await s_database.FindWithChildrenAsync<BlackoutItem>(blackoutId);
            }
            catch (Exception ex)
            {
                Logger.Write(s_tag, $"Find: Unexpected error occured: {ex.Message}", Logger.Severity.Error);
                result = default;
            }

            return result;
        }

        public static async Task<List<BlackoutItem>> FindAllAsync()
        {
            List<BlackoutItem> result = new List<BlackoutItem>();

            try
            {
                result = await s_database.GetAllWithChildrenAsync<BlackoutItem>();
            }
            catch (Exception ex)
            {
                Logger.Write(s_tag, $"FindAll: Unexpected error occured: {ex.Message}", Logger.Severity.Error);
                result = new List<BlackoutItem>();
            }

            return result;
        }

        public static async Task<List<BlackoutItem>> FindAllAsync(BlackoutItem.BlackoutStatusCode statusCode)
        {
            List<BlackoutItem> result = new List<BlackoutItem>();

            try
            {
                result = await s_database.GetAllWithChildrenAsync<BlackoutItem>(x => x.StatusCode.Equals(statusCode));
            }
            catch (Exception ex)
            {
                Logger.Write(s_tag, $"FindAll: Unexpected error occured: {ex.Message}", Logger.Severity.Error);
                result = new List<BlackoutItem>();
            }

            return result;
        }

        public static async Task<List<BlackoutItem>> FindAllAsync(DateTime startDateTime, DateTime endDateTime)
        {
            List<BlackoutItem> result = new List<BlackoutItem>();

            try
            {
                result = await s_database.GetAllWithChildrenAsync<BlackoutItem>(x =>
                    (startDateTime >= x.ScheduledStartDateTime && startDateTime <= x.ScheduledEndDateTime) // Overlapping
                    || (endDateTime >= x.ScheduledStartDateTime && endDateTime <= x.ScheduledEndDateTime) // After or overlapping
                    || (startDateTime <= x.ScheduledEndDateTime && endDateTime >= x.ScheduledStartDateTime) // Before or overlapping
                );
            }
            catch (Exception ex)
            {
                Logger.Write(s_tag, $"FindAll: Unexpected error occured: {ex.Message}", Logger.Severity.Error);
                result = new List<BlackoutItem>();
            }

            return result;
        }
        #endregion

        #region Helper Methods
        /// <summary>
        /// Returns a count of all blackouts in the database
        /// </summary>
        /// <returns></returns>
        public static async Task<long> CountAsync()
            => (await BlackoutDatabase.FindAllAsync()).Count;

        /// <summary>
        /// Returns the first pending blackout found
        /// </summary>
        /// <param name="minimumStartTime">The earliest a StartDateTime could be for a blackout.</param>
        /// <returns></returns>
        public static async Task<BlackoutItem> GetFirstPendingBlackoutAsync(DateTime? minimumStartTime = null)
        {
            BlackoutItem blackoutItem = default;
            List<BlackoutItem> blackoutItems;

            try
            {
                blackoutItems = await BlackoutDatabase.FindAllAsync(BlackoutItem.BlackoutStatusCode.Pending);
                if (blackoutItems != null)
                {
                    if (blackoutItems.Count > 0)
                    {
                        if (minimumStartTime != null)
                            blackoutItem = blackoutItems.Where(x => x.ScheduledStartDateTime <= minimumStartTime.Value).OrderBy(x => x.ScheduledStartDateTime).FirstOrDefault();
                        else
                            blackoutItem = blackoutItems.OrderBy(x => x.ScheduledStartDateTime).FirstOrDefault();
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Write(s_tag, $"GetFirstPendingBlackout: Unexpected error occured: {ex.Message}", Logger.Severity.Error);
                blackoutItem = default;
            }

            return blackoutItem;
        }

        /// <summary>
        /// Returns the first active blackout found
        /// </summary>
        /// <returns></returns>
        public static async Task<BlackoutItem> GetFirstActiveBlackoutAsync()
        {
            BlackoutItem blackoutItem = default;
            List<BlackoutItem> blackoutItems;

            try
            {
                blackoutItems = await BlackoutDatabase.FindAllAsync(BlackoutItem.BlackoutStatusCode.Active);
                if (blackoutItems != null)
                    if (blackoutItems.Count > 0)
                        blackoutItem = blackoutItems.OrderBy(x => x.ScheduledStartDateTime).FirstOrDefault();
            }
            catch (Exception ex)
            {
                Logger.Write(s_tag, $"GetFirstActiveBlackout: Unexpected error occured: {ex.Message}", Logger.Severity.Error);
                blackoutItem = default;
            }

            return blackoutItem;
        }

        /// <summary>
        /// Returns the first blackout found that encapsulates the target datetime and has the same status code
        /// </summary>
        /// <param name="targetDateTime">A point in time encapsulated by the blackout</param>
        /// <param name="statusCode">Status of the blackout</param>
        /// <returns></returns>
        public static async Task<BlackoutItem> GetFirstBlackoutAsync(DateTime targetDateTime, BlackoutItem.BlackoutStatusCode statusCode)
        {
            BlackoutItem blackoutItem = default;
            List<BlackoutItem> blackoutItems;

            try
            {
                blackoutItems = (await BlackoutDatabase.FindAllAsync(statusCode)).Where(x => x.ScheduledStartDateTime <= targetDateTime && x.ScheduledEndDateTime >= targetDateTime).ToList();
                if (blackoutItems != null)
                    if (blackoutItems.Count > 0)
                        blackoutItem = blackoutItems.OrderBy(x => x.ScheduledStartDateTime).FirstOrDefault();
            }
            catch (Exception ex)
            {
                Logger.Write(s_tag, $"GetFirstBlackout: Unexpected error occured: {ex.Message}", Logger.Severity.Error);
                blackoutItem = default;
            }

            return blackoutItem;
        }

        /// <summary>
        /// Checks to see if there is a conflict with another blackout at the the start and end datetimes
        /// </summary>
        /// <param name="startDateTime">The start datetime to check for</param>
        /// <param name="endDateTime">The end datetime to check for</param>
        /// <returns></returns>
        public static async Task<bool> HasConflictInRangeAsync(DateTime startDateTime, DateTime endDateTime)
        {
            bool result = false;
            List<BlackoutItem> blackoutItems;

            try
            {
                blackoutItems = (await BlackoutDatabase.FindAllAsync(startDateTime, endDateTime)).Where(x => x.StatusCode.Equals(BlackoutItem.BlackoutStatusCode.Finished) == false).ToList();
                if (blackoutItems != null)
                    if (blackoutItems.Count > 0)
                        result = true;
            }
            catch (Exception ex)
            {
                Logger.Write(s_tag, $"HasConflictInRange: Unexpected error occured: {ex.Message}", Logger.Severity.Error);
                result = false;
            }

            return result;
        }

        /// <summary>
        /// Checks to see if there is an active blackout
        /// </summary>
        /// <returns></returns>
        public static async Task<bool> HasActiveBackoutAsync()
            => (await BlackoutDatabase.GetFirstActiveBlackoutAsync()) != default;

        /// <summary>
        /// Checks to see if the specified blackout is still active and valid for this time 
        /// </summary>
        /// <param name="blackoutId">The id of the blackout</param>
        /// <param name="current">The datetime you are checking validity for</param>
        /// <returns></returns>
        public static async Task<bool> BlackoutIsActiveAsync(int blackoutId, DateTime current)
        {
            BlackoutItem blackoutItem;
            bool result = false;

            try
            {
                blackoutItem = await BlackoutDatabase.FindAsync(blackoutId);
                if (blackoutItem != default)
                {
                    if (blackoutItem.ScheduledStartDateTime < current)
                    {
                        if (blackoutItem.ScheduledEndDateTime >= current)
                        {
                            if (blackoutItem.StatusCode != BlackoutItem.BlackoutStatusCode.Finished)
                            {
                                result = true;
                            }
                        }
                    }
                }
            }
            catch { result = false; }

            return result;
        }

        public static async Task<Dictionary<string, string>> GetBlackoutStatistics(DateTime startDateTime, DateTime endDateTime)
        {
            Dictionary<string, string> result;
            List<BlackoutItem> blackouts;

            try
            {
                //
                // Initialize
                result = new Dictionary<string, string>();
                blackouts = await BlackoutDatabase.FindAllAsync(startDateTime, endDateTime);

                //
                // Get Totals
                result.Add("total_bids_all", blackouts.Sum(x => x.Bid).ToString());
                result.Add("total_blackouts_all", blackouts.Count().ToString());
                result.Add("total_milliseconds_actual_all", blackouts.Sum(x => (x.ActualEndDateTime - x.ActualStartDateTime).TotalMilliseconds).ToString());
                result.Add("total_milliseconds_scheduled__all", blackouts.Sum(x => (x.ScheduledEndDateTime - x.ScheduledStartDateTime).TotalMilliseconds).ToString());

                foreach (BlackoutItem.BlackoutDifficultyCode difficultyCode in Enum.GetValues(typeof(BlackoutItem.BlackoutDifficultyCode)))
                {
                    result.Add($"total_bids_{difficultyCode.ToString().ToLower()}", blackouts.Where(x => x.DifficultyCode.Equals(difficultyCode)).Sum(x => x.Bid).ToString());
                    result.Add($"total_blackouts_{difficultyCode.ToString().ToLower()}", blackouts.Count(x => x.DifficultyCode.Equals(difficultyCode)).ToString());
                    result.Add($"total_milliseconds_actual_{difficultyCode.ToString().ToLower()}", blackouts.Where(x => x.DifficultyCode.Equals(difficultyCode)).Sum(x => (x.ActualEndDateTime - x.ActualStartDateTime).TotalMilliseconds).ToString());
                    result.Add($"total_milliseconds_scheduled_{difficultyCode.ToString().ToLower()}", blackouts.Where(x => x.DifficultyCode.Equals(difficultyCode)).Sum(x => (x.ScheduledEndDateTime - x.ScheduledStartDateTime).TotalMilliseconds).ToString());
                }

                foreach (BlackoutItem.BlackoutResultCode resultCode in Enum.GetValues(typeof(BlackoutItem.BlackoutResultCode)))
                {
                    result.Add($"total_bids_{resultCode.ToString().ToLower()}", blackouts.Where(x => x.ResultCode.Equals(resultCode)).Sum(x => x.Bid).ToString());
                    result.Add($"total_blackouts_{resultCode.ToString().ToLower()}", blackouts.Count(x => x.ResultCode.Equals(resultCode)).ToString());
                    result.Add($"total_milliseconds_actual_{resultCode.ToString().ToLower()}", blackouts.Where(x => x.ResultCode.Equals(resultCode)).Sum(x => (x.ActualEndDateTime - x.ActualStartDateTime).TotalMilliseconds).ToString());
                    result.Add($"total_milliseconds_scheduled_{resultCode.ToString().ToLower()}", blackouts.Where(x => x.ResultCode.Equals(resultCode)).Sum(x => (x.ScheduledEndDateTime - x.ScheduledStartDateTime).TotalMilliseconds).ToString());
                }
            }
            catch (Exception ex)
            {
                result = new Dictionary<string, string>();
            }

            return result;
        }
        #endregion

        #region Maintenance Methods
        /// <summary>
        /// Scrubs the database for all blackouts that are no longer valid or fall outside the retention period
        /// </summary>
        /// <returns></returns>
        public static async Task<bool> Scrub()
        {
            bool result = false;

            // Call wait on semaphore
            await s_databaseMaintenanceLock.WaitAsync();

            try
            {
                //
                // Step 1 : Look for blackouts that are still pending but have already elapsed
                foreach (BlackoutItem item in (await BlackoutDatabase.FindAllAsync(BlackoutItem.BlackoutStatusCode.Pending)).OrderBy(x => x.ScheduledEndDateTime))
                {
                    // Has this blackout item elapsed yet?
                    if (item.ScheduledEndDateTime >= DateTime.Now.AddMinutes(5))
                        break;

                    // Update it
                    Logger.Write(s_tag, $"Scrub: Found that blackout {item.Id} is still pending but its end datetime is {item.ScheduledEndDateTime}. Marking blackout as skipped.", Logger.Severity.Info);
                    item.SetBlackoutFinished(BlackoutItem.BlackoutResultCode.Skipped);
                    await BlackoutDatabase.UpsertAsync(item);
                }

                //
                // Step 2 : Find and remove blackout data that is over 1 year old from its end datetime
                foreach(BlackoutItem item in (await BlackoutDatabase.FindAllAsync()).Where(x => x.ScheduledEndDateTime < DateTime.Now.AddYears(-1)).ToList())
                {
                    // Remove it
                    Logger.Write(s_tag, $"Scrub: Found that blackout {item.Id} is from over a year ago. Removing blackout from database.", Logger.Severity.Info);
                    await BlackoutDatabase.RemoveAsync(item);
                }
            }
            catch (Exception ex)
            {
                Logger.Write(s_tag, $"Scrub: Unexpected error occured: {ex.Message}", Logger.Severity.Error);
                result = false;
            }
            finally
            {
                // Release the semaphore
                s_databaseMaintenanceLock.Release();
            }

            return result;
        }
        #endregion

        #region Events
        /// <summary>
        /// Called when the blackout table changed
        /// </summary>
        internal static event Action BlackoutTableChanged;
        private static void OnBlackoutTableChanged() => BlackoutTableChanged?.Invoke();
        #endregion
    }
}