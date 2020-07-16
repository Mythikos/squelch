using System;
using System.Collections.Generic;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Squelch.Library.Entities
{
    [Table("BlackoutItems")]
    internal class BlackoutItem : IComparable<BlackoutItem>
    {
        public enum BlackoutStatusCode { Pending = 1, Active = 2, Finished = 3 }
        public enum BlackoutResultCode { Pending = 1, Success = 2, Failed = 3, Cancelled = 4, Skipped = 5 }
        public enum BlackoutDifficultyCode { Novice = 1, Veteran = 2, Master = 3, Nightmare = 4 }

        #region Properties
        [PrimaryKey, AutoIncrement] public int Id { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public int Bid { get; set; }
        public BlackoutStatusCode StatusCode { get; set; }
        public BlackoutResultCode ResultCode { get; set; }
        public BlackoutDifficultyCode DifficultyCode { get; set; }
        
        [TextBlob(nameof(BlacklistBlob))] public List<string> Blacklist { get; set; }
        public string BlacklistBlob { get; set; }
        #endregion

        #region Constructors
        public BlackoutItem()
        {
            this.Id = 0;
            this.StartDateTime = default(DateTime);
            this.EndDateTime = default(DateTime);
            this.Bid = default(int);
            this.Blacklist = new List<string>();
            this.StatusCode = BlackoutStatusCode.Pending;
            this.ResultCode = BlackoutResultCode.Pending;
            this.DifficultyCode = BlackoutDifficultyCode.Veteran;
        }

        public BlackoutItem(BlackoutItem blackoutItem)
        {
            this.Id = blackoutItem.Id;
            this.StartDateTime = blackoutItem.StartDateTime;
            this.EndDateTime = blackoutItem.EndDateTime;
            this.Bid = blackoutItem.Bid;
            this.Blacklist = blackoutItem.Blacklist;
            this.StatusCode = blackoutItem.StatusCode;
            this.ResultCode = blackoutItem.ResultCode;
            this.DifficultyCode = BlackoutDifficultyCode.Veteran;
        }

        public BlackoutItem(DateTime startDateTime, DateTime endDateTime, int bid, List<string> blockedApps, BlackoutStatusCode statusCode, BlackoutResultCode resultCode, BlackoutDifficultyCode difficultyCode)
        {
            this.Id = 0;
            this.StartDateTime = startDateTime;
            this.EndDateTime = endDateTime;
            this.Bid = bid;
            this.Blacklist = blockedApps;
            this.StatusCode = statusCode;
            this.ResultCode = resultCode;
            this.DifficultyCode = difficultyCode;
        }
        #endregion

        #region Helper Methods
        public BlackoutItem Copy(BlackoutItem blackoutItem)
        {
            this.Id = blackoutItem.Id;
            this.StartDateTime = blackoutItem.StartDateTime;
            this.EndDateTime = blackoutItem.EndDateTime;
            this.Bid = blackoutItem.Bid;
            this.Blacklist = blackoutItem.Blacklist;
            this.StatusCode = blackoutItem.StatusCode;
            this.ResultCode = blackoutItem.ResultCode;
            this.DifficultyCode = blackoutItem.DifficultyCode;

            return this;
        }

        public BlackoutItem SetBlackoutPending()
        {
            this.StatusCode = BlackoutStatusCode.Pending;
            this.ResultCode = BlackoutResultCode.Pending;

            return this;
        }

        public BlackoutItem SetBlackoutActive()
        {
            this.StatusCode = BlackoutStatusCode.Active;
            this.ResultCode = BlackoutResultCode.Pending;

            return this;
        }

        public BlackoutItem SetBlackoutFinished(BlackoutResultCode resultCode)
        {
            this.StatusCode = BlackoutStatusCode.Finished;
            this.ResultCode = resultCode;

            return this;
        }

        public bool IsBlackoutPending() => this.StatusCode == BlackoutStatusCode.Pending && this.ResultCode == BlackoutResultCode.Pending;

        public bool IsBlackoutActive() => this.StatusCode == BlackoutStatusCode.Active && this.ResultCode == BlackoutResultCode.Pending;

        public bool IsBlackoutFailed() => this.StatusCode == BlackoutStatusCode.Finished && this.ResultCode == BlackoutResultCode.Failed;

        public bool IsBlackoutSuccessful() => this.StatusCode == BlackoutStatusCode.Finished && this.ResultCode == BlackoutResultCode.Success;

        public bool IsBlackoutSkipped() => this.StatusCode == BlackoutStatusCode.Finished && this.ResultCode == BlackoutResultCode.Skipped;

        public bool IsBlackoutCancelled() => this.StatusCode == BlackoutStatusCode.Finished && this.ResultCode == BlackoutResultCode.Cancelled;
        #endregion

        #region Validation
        /// <summary>
        /// Runs all validation routines and returns a k/v response with result.
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, bool> ValidateInstanceData()
        {
            Dictionary<string, bool> objResults = new Dictionary<string, bool>();
            objResults.Add("Start Date", IsStartDateValid());
            objResults.Add("End Date", IsEndDateValid());
            objResults.Add("Date range (Start Date > End Date)", IsDateRangeValid());

            return objResults;
        }

        /// <summary>
        /// Calls ValidateInstanceData but throws any exceptions found.
        /// </summary>
        public void ValidateInstanceDataAndThrow()
        {
            // Validate the data
            string sResults = string.Empty;
            foreach (KeyValuePair<string, bool> objResult in ValidateInstanceData())
                if (objResult.Value == false)
                    sResults += objResult.Key + " is not valid. ";

            // If validate errors occured, throw format exception
            if (!string.IsNullOrWhiteSpace(sResults))
                throw new FormatException(sResults);
        }

        /// <summary>
        /// Validates the start date value
        /// </summary>
        /// <returns></returns>
        private bool IsStartDateValid()
        {
            bool bResult = false;

            try
            {
                if (!this.StartDateTime.Equals(DateTime.MinValue) && !this.StartDateTime.Equals(DateTime.MaxValue))
                    bResult = true;
            }
            catch
            {
                bResult = false;
            }

            return bResult;
        }

        /// <summary>
        /// Validates the end date value
        /// </summary>
        /// <returns></returns>
        private bool IsEndDateValid()
        {
            bool bResult = false;

            try
            {
                if (!this.EndDateTime.Equals(DateTime.MinValue) && !this.EndDateTime.Equals(DateTime.MaxValue))
                    bResult = true;
            }
            catch
            {
                bResult = false;
            }

            return bResult;
        }

        /// <summary>
        /// Validates that the start date is not beyond the end date. 
        /// </summary>
        /// <returns></returns>
        private bool IsDateRangeValid()
        {
            bool bResult = false;

            try
            {
                if (this.StartDateTime < this.EndDateTime)
                    if ((this.EndDateTime - this.StartDateTime).TotalMinutes >= 1)
                        bResult = true;
            }
            catch
            {
                bResult = false;
            }

            return bResult;
        }
        #endregion

        #region Comparable Methods
        public int CompareTo(BlackoutItem otherBlackoutItem) => this.StartDateTime.CompareTo(otherBlackoutItem.StartDateTime);
        #endregion
    }
}