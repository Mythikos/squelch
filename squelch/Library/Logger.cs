using Android.Util;
using Firebase.Crashlytics;
using Squelch.Library.Data;
using System;
using System.Diagnostics;
using System.Text;

namespace Squelch.Library
{
    internal static class Logger
    {
        internal enum Severity { Info, Warn, Debug, Error, Wtf }

        internal static void Write(string tag, Exception ex, Severity severity)
        {
            string messageFromException = string.Empty;

            if (string.IsNullOrWhiteSpace(tag))
            {
                throw new ArgumentNullException("tag");
            }

            messageFromException = CreateExceptionString(ex);
            if (string.IsNullOrWhiteSpace(messageFromException))
            {
                throw new ArgumentNullException("message");
            }

            Logger.Write(tag, messageFromException, severity);
            FirebaseCrashlytics.Instance.RecordException(Java.Lang.Throwable.FromException(ex));
        }

        internal static void Write(string tag, string message, Severity severity)
        {
            if (string.IsNullOrWhiteSpace(tag))
            {
                throw new ArgumentNullException("tag");
            }

            if (string.IsNullOrWhiteSpace(message))
            {
                throw new ArgumentNullException("message");
            }

            switch (severity)
            {
                case Severity.Info:
#if DEBUG
                    Log.Info(tag, message);
#endif
                    break;
                case Severity.Warn:
#if DEBUG
                    Log.Warn(tag, message);
#endif
                    break;
                case Severity.Debug:
#if DEBUG
                    Log.Debug(tag, message);
#endif
                    break;
                case Severity.Error:
#if DEBUG
                    Log.Error(tag, message);
#endif
                    FirebaseCrashlytics.Instance.Log(message);
                    break;
                case Severity.Wtf:
#if DEBUG
                    Log.Wtf(tag, message);
#endif
                    FirebaseCrashlytics.Instance.Log(message);
                    break;
            }
        }

        /// <summary>
        /// Takes the exception and builds a 'nice' exception string
        /// </summary>
        /// <param name="ex"></param>
        /// <returns></returns>
        internal static string CreateExceptionString(Exception ex)
        {
            StringBuilder stringBuilder = new StringBuilder();
            CreateExceptionString(stringBuilder, ex);

            return stringBuilder.ToString();
        }

        /// <summary>
        /// Recursive function to build exceptions, including all inner exceptions
        /// </summary>
        /// <param name="stringBuilder"></param>
        /// <param name="ex"></param>
        /// <param name="indent"></param>
        private static void CreateExceptionString(StringBuilder stringBuilder, Exception ex, string indent = "->")
        {
            StackTrace stackTrace;

            if (string.IsNullOrEmpty(indent))
            {
                indent = string.Empty;
            }
            else if (indent.Length > 2)
            {
                stringBuilder.AppendFormat("{0}Inner ", indent);
            }

            stackTrace = new StackTrace(ex);
            stringBuilder.AppendFormat("Exception Found:");
            stringBuilder.AppendFormat("\n{0}Type: {1}", indent, ex.GetType().FullName);
            stringBuilder.AppendFormat("\n{0}Message: {1}", indent, ex.Message);
            stringBuilder.AppendFormat("\n{0}Source: {1}", indent, ex.Source);
            stringBuilder.AppendFormat("\n{0}Stacktrace: {1}", indent, ex.StackTrace);

            if (ex.InnerException != null)
            {
                stringBuilder.Append("\n");
                CreateExceptionString(stringBuilder, ex.InnerException, $"    {indent}");
            }
        }
    }
}