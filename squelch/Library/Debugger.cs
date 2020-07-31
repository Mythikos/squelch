using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.App.Usage;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Squelch.Library.Data;
using Squelch.Library.Entities;
using Squelch.Receivers;

namespace Squelch.Library
{
    internal static class Debugger
    {
        private static bool _isRunning = false;
        private static System.Threading.Timer _timer;
        private static readonly string _tag = typeof(Debugger).FullName;

#if DEBUG
        public static void Toggle(Context context, int interval)
        {
            try
            {
                if (_isRunning == false)
                {
                    //
                    // Usage data
                    _timer = new System.Threading.Timer(delegate (object state)
                    {
                        UsageEvents usageEvents;
                        UsageEvents.Event @event;
                        UsageStatsManager usageStatsManager;

                        usageStatsManager = (UsageStatsManager)context.GetSystemService(Context.UsageStatsService);
                        usageEvents = usageStatsManager.QueryEvents(Java.Lang.JavaSystem.CurrentTimeMillis() - interval, Java.Lang.JavaSystem.CurrentTimeMillis() + interval);
                        while (usageEvents.HasNextEvent)
                        {
                            @event = new UsageEvents.Event();
                            usageEvents.GetNextEvent(@event);
                            Logger.Write(_tag, $"{@event.PackageName} reported event {@event.EventType}", Logger.Severity.Debug);
                        }
                    }, null, 0, interval);

                    //
                    // Receivers
                    foreach (FieldInfo field in typeof(Intent).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy))
                    {
                        if (field.IsLiteral && field.FieldType.Equals(typeof(string)))
                        {
                            string filter = (string)field.GetRawConstantValue();
                            Logger.Write(_tag, $"Registering Receiver: {filter}", Logger.Severity.Info);
                            context.RegisterReceiver(
                                new GenericBroadcastReceiver(delegate (Context c, Intent i)
                                {
                                    Logger.Write(_tag, $"Broadcast Received: {i.Action}", Logger.Severity.Info);
                                }),
                                new IntentFilter(filter)
                            );
                        }
                    }

                    //
                    // Toggle
                    _isRunning = true;
                }
                else
                {
                    if (_timer != null)
                        _timer.Dispose();
                    _isRunning = false;
                }
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"Toggle: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
        }

        public static async Task InsertTestBlackoutData(Context context)
        {
            int testDataCount = 100;
            List<BlackoutItem> blackouts;
            List<string> blacklist;

            try
            {
                if (await BlackoutDatabase.CountAsync() >= testDataCount)
                {
                    Logger.Write(_tag, "Test data already exists, skipping insertion.", Logger.Severity.Info);
                    return;
                }

                Logger.Write(_tag, "Building test data...", Logger.Severity.Info);
                blackouts = new List<BlackoutItem>();
                blacklist = getRandomPackages(context.PackageManager.GetInstalledPackages(PackageInfoFlags.MatchAll), false);
                for (int i = testDataCount; i > 0; i--)
                {
                    var blackoutItem = new BlackoutItem()
                    {
                        ScheduledStartDateTime = DateTime.Today.AddDays(i - 50),
                        ScheduledEndDateTime = DateTime.Today.AddDays(i - 50).AddHours(12),
                        DifficultyCode = ((i%10==0) ? BlackoutItem.BlackoutDifficultyCode.Master : ((i%5==0) ? BlackoutItem.BlackoutDifficultyCode.Veteran : BlackoutItem.BlackoutDifficultyCode.Novice)),
                        Bid = i,
                        Blacklist = blacklist
                    }.SetBlackoutPending();
                    blackouts.Add(blackoutItem);
                }

                Logger.Write(_tag, "Adding test data...", Logger.Severity.Info);
                await BlackoutDatabase.InsertOrReplaceAllAsync(blackouts);
                Logger.Write(_tag, "Test data added and saved!", Logger.Severity.Info);
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"InsertTestBlackoutData: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
        }

        public static async Task SqliteDatabaseTest(Context context)
        {
            BlackoutItem item = new BlackoutItem();
            item.Bid = 5;
            item.ScheduledStartDateTime = DateTime.Now.AddDays(1);
            item.ScheduledEndDateTime = DateTime.Now.AddDays(2);
            item.SetBlackoutPending();
            item.Blacklist = getRandomPackages(context.PackageManager.GetInstalledPackages(PackageInfoFlags.MatchAll), false);

            await BlackoutDatabase.UpsertAsync(item);
            var testItem1 = await BlackoutDatabase.FindAllAsync();
            var testItem2 = await BlackoutDatabase.FindAsync((int)item.Id);
            var testItem3 = await BlackoutDatabase.FindAllAsync(BlackoutItem.BlackoutStatusCode.Pending);
            var testItem31 = await BlackoutDatabase.GetFirstPendingBlackoutAsync();

            // Update and test result
            item.Bid = 25;
            await BlackoutDatabase.UpsertAsync(item);
            var testItem4 = await BlackoutDatabase.FindAllAsync();
            var testItem5 = await BlackoutDatabase.FindAsync((int)item.Id);
            var testItem6 = await BlackoutDatabase.FindAllAsync(BlackoutItem.BlackoutStatusCode.Pending);

            // Remove and test
            await BlackoutDatabase.RemoveAsync(item);
            var testItem7 = await BlackoutDatabase.FindAllAsync();
            var testItem8 = await BlackoutDatabase.FindAsync((int)item.Id);
            var testItem9 = await BlackoutDatabase.FindAllAsync(BlackoutItem.BlackoutStatusCode.Pending);
        }

        private static List<string> getRandomPackages(IList<PackageInfo> packages, bool includeSystem = false)
        {
            bool isSystem;
            List<string> possiblePackages;
            List<string> result;
            Random random;

            result = new List<string>();
            possiblePackages = new List<string>();
            random = new Random(Guid.NewGuid().GetHashCode());
            try
            {
                // get list of possibilities
                foreach (PackageInfo package in packages)
                {
                    isSystem = (package.ApplicationInfo.Flags & ApplicationInfoFlags.System) == ApplicationInfoFlags.System;
                    if (isSystem && !includeSystem)
                        continue;
                    possiblePackages.Add(package.PackageName);
                }

                // shuffle the list
                int n = possiblePackages.Count;
                while (n > 1)
                {
                    n--;
                    int k = random.Next(n + 1);
                    string value = possiblePackages[k];
                    possiblePackages[k] = possiblePackages[n];
                    possiblePackages[n] = value;
                }

                // select n number of items from that shuffled list
                for (int i = 0; i < random.Next(0, possiblePackages.Count + 1); i++)
                    result.Add(possiblePackages[i]);
            }
            catch { }

            return result;
        }
#endif
    }
}