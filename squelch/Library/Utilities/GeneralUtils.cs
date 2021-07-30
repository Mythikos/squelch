using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Views;
using Squelch.Activities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Squelch.Library.Utilities
{
    internal static class GeneralUtils
    {
        #region Instance Variables
        private static readonly string s_tag = typeof(GeneralUtils).FullName;
        #endregion

        /// <summary>
        /// Checks to see if this app is in the foreground
        /// </summary>
        /// <returns></returns>
        internal static bool SelfIsInForeground(Context context)
        {
            ActivityManager activityManager;
            ActivityManager.RunningAppProcessInfo foregroundApplication;

            try
            {
                activityManager = (ActivityManager)context.GetSystemService(Context.ActivityService);
                foregroundApplication = activityManager.RunningAppProcesses.Where(x => x.Importance == Importance.Foreground).FirstOrDefault();

                if (foregroundApplication != null)
                {
                    foreach (string packageName in foregroundApplication.PkgList)
                    {
                        if (packageName.Equals(context.PackageName, StringComparison.OrdinalIgnoreCase))
                        {
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Write(s_tag, $"SelfIsInForeground: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }

            return false;
        }

        /// <summary>
        /// Opens the main activity for Squelch
        /// </summary>
        /// <param name="context"></param>
        internal static bool OpenSelfActivity(Context context, Bundle extras = null)
        {
            bool result = false;
            Intent intent;

            try
            {
                //
                // Build intent
                intent = new Intent(context, typeof(MainActivity));
                intent.SetAction(Intent.ActionMain);
                intent.AddFlags(ActivityFlags.NewTask);
                intent.AddCategory(Intent.CategoryLauncher);
                if (extras != null)
                {
                    intent.PutExtras(extras);
                }

                //
                // Open the activity
                context.StartActivity(intent);
            }
            catch (Exception ex)
            {
                Logger.Write(s_tag, $"OpenSelfActivity: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
                result = false;
            }

            return result;
        }

        /// <summary>
        /// Opens the home screen for the device
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        internal static bool OpenLauncherActivity(Context context, Bundle extras = null)
        {
            bool result = false;
            Intent intent;

            try
            {
                //
                // Build intent
                intent = new Intent(Intent.ActionMain);
                intent.AddFlags(ActivityFlags.NewTask);
                intent.AddCategory(Intent.CategoryHome);
                intent.PutExtras(extras ?? new Bundle());

                //
                // Open the activity
                context.StartActivity(intent);
            }
            catch (Exception ex)
            {
                Logger.Write(s_tag, $"OpenLauncherActivity: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
                result = false;
            }

            return result;
        }

        /// <summary>
        /// Sends an email with the provided content
        /// </summary>
        internal static async Task SendEmailAsync(string subject, string body, List<string> recipients)
        {
            Xamarin.Essentials.EmailMessage message;

            try
            {
                message = new Xamarin.Essentials.EmailMessage()
                {
                    Subject = subject,
                    Body = body,
                    To = recipients
                };

                await Xamarin.Essentials.Email.ComposeAsync(message);
            }
            catch (Exception ex)
            {
                Logger.Write(s_tag, $"SendEmailAsync: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
        }

        /// <summary>
        /// Sends a web request and returns the response
        /// </summary>
        /// <param name="uri"></param>
        /// <returns></returns>
        internal static string SendWebRequest(string uri, string method, Dictionary<string, string> parameters)
        {
            string result = string.Empty;
            string dataString = string.Empty;
            byte[] data;
            HttpWebRequest webRequest;
            HttpWebResponse webResponse;

            try
            {
                //
                // Build data string
                for (int i = 0; i < parameters.Count; i++)
                {
                    if (i == 0)
                    {
                        dataString += $"{WebUtility.UrlEncode(parameters.Keys.ElementAt(i))}={WebUtility.UrlEncode(parameters.Values.ElementAt(i))}";
                    }
                    else
                    {
                        dataString += "&" + $"{WebUtility.UrlEncode(parameters.Keys.ElementAt(i))}={WebUtility.UrlEncode(parameters.Values.ElementAt(i))}";
                    }
                }

                //
                // Init web request
                if (method.Equals("GET", StringComparison.OrdinalIgnoreCase))
                {
                    if (string.IsNullOrWhiteSpace(dataString) == false)
                    {
                        uri += "?" + dataString;
                    }

                    webRequest = (HttpWebRequest)HttpWebRequest.Create(uri);
                    webRequest.Method = "GET";
                }
                else if (method.Equals("POST", StringComparison.OrdinalIgnoreCase))
                {
                    data = Encoding.ASCII.GetBytes(dataString);
                    webRequest = (HttpWebRequest)HttpWebRequest.Create(uri);
                    webRequest.Method = "POST";
                    webRequest.ContentType = "application/x-www-form-urlencoded";
                    webRequest.ContentLength = data.Length;
                    using (Stream stream = webRequest.GetRequestStream())
                    {
                        stream.Write(data, 0, data.Length);
                    }
                }
                else
                {
                    throw new ArgumentException("Method argument is invalid.");
                }

                //
                // Submit request
                webRequest.Timeout = 10000;
                webResponse = (HttpWebResponse)webRequest.GetResponse();
                if (webResponse.StatusCode == HttpStatusCode.OK)
                {
                    using (StreamReader reader = new StreamReader(webResponse.GetResponseStream()))
                    {
                        result = reader.ReadToEnd();
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Write(s_tag, $"SendWebRequest: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }

            return result;
        }

        /// <summary>
        /// Sends a web request async and returns the response
        /// </summary>
        /// <param name="uri"></param>
        /// <returns></returns>
        internal static async Task<string> SendWebRequestAsync(string uri, string method, Dictionary<string, string> parameters)
        {
            string result = string.Empty;

            try
            {
                await Task.Factory.StartNew(() =>
                {
                    result = SendWebRequest(uri, method, parameters);
                });
            }
            catch (Exception ex)
            {
                Logger.Write(s_tag, $"SendWebRequestAsync: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }

            return result;
        }

        /// <summary>
        /// Returns the identifier for a resource provided the resource's name
        /// </summary>
        /// <param name="context"></param>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        internal static int GetResourceId(Context context, string name, string type)
        {
            int result = -1;

            try
            {
                result = context.Resources.GetIdentifier(name, type, context.PackageName);
            }
            catch (Exception ex)
            {
                Logger.Write(s_tag, $"GetResourceId: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }

            return result;
        }

        /// <summary>
        /// Shows the soft keyboard
        /// </summary>
        /// <param name="activity"></param>
        /// <param name="context"></param>
        internal static void ShowSoftKeyboard(Activity activity, Context context, bool isDialog = false)
        {
            try
            {
                if (activity.CurrentFocus != null)
                {
                    Android.Views.InputMethods.InputMethodManager inputManager = (Android.Views.InputMethods.InputMethodManager)context.GetSystemService(Activity.InputMethodService);
                    inputManager.ShowSoftInput(activity.CurrentFocus, (isDialog) ? Android.Views.InputMethods.ShowFlags.Forced : Android.Views.InputMethods.ShowFlags.Implicit);
                }
            }
            catch (Exception ex)
            {
                Logger.Write(s_tag, $"ShowSoftKeyboard: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
        }

        /// <summary>
        /// Shows the soft keyboard
        /// </summary>
        /// <param name="view"></param>
        /// <param name="context"></param>
        internal static void ShowSoftKeyboard(View view, Context context, bool isDialog = false)
        {
            try
            {
                if (view != null)
                {
                    Android.Views.InputMethods.InputMethodManager inputManager = (Android.Views.InputMethods.InputMethodManager)context.GetSystemService(Activity.InputMethodService);
                    inputManager.ShowSoftInput(view, (isDialog) ? Android.Views.InputMethods.ShowFlags.Forced : Android.Views.InputMethods.ShowFlags.Implicit);
                }
            }
            catch (Exception ex)
            {
                Logger.Write(s_tag, $"ShowSoftKeyboard: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
        }

        /// <summary>
        /// Hides the soft keyboard
        /// </summary>
        /// <param name="activity"></param>
        /// <param name="context"></param>
        internal static void HideSoftKeyboard(Activity activity, Context context, bool isDialog = false)
        {
            try
            {
                if (activity.CurrentFocus != null)
                {
                    Android.Views.InputMethods.InputMethodManager inputManager = (Android.Views.InputMethods.InputMethodManager)context.GetSystemService(Activity.InputMethodService);
                    inputManager.HideSoftInputFromWindow(activity.CurrentFocus.WindowToken, (isDialog) ? Android.Views.InputMethods.HideSoftInputFlags.ImplicitOnly : Android.Views.InputMethods.HideSoftInputFlags.NotAlways);
                }
            }
            catch (Exception ex)
            {
                Logger.Write(s_tag, $"HideSoftKeyboard: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
        }

        /// <summary>
        /// Hides the soft keyboard
        /// </summary>
        /// <param name="view"></param>
        /// <param name="context"></param>
        internal static void HideSoftKeyboard(View view, Context context, bool isDialog = false)
        {
            try
            {
                if (view != null)
                {
                    Android.Views.InputMethods.InputMethodManager inputManager = (Android.Views.InputMethods.InputMethodManager)context.GetSystemService(Activity.InputMethodService);
                    inputManager.HideSoftInputFromWindow(view.WindowToken, (isDialog) ? Android.Views.InputMethods.HideSoftInputFlags.ImplicitOnly : Android.Views.InputMethods.HideSoftInputFlags.NotAlways);
                }
            }
            catch (Exception ex)
            {
                Logger.Write(s_tag, $"HideSoftKeyboard: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
        }

        /// <summary>
        /// Gets the version name of this app
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        internal static string SelfVersionName(Context context)
        {
            PackageInfo packageInfo;

            try
            {
                packageInfo = context.PackageManager.GetPackageInfo(context.PackageName, 0);
                return packageInfo.VersionName;
            }
            catch (Exception ex)
            {
                Logger.Write(s_tag, $"SelfVersionName: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }

            return string.Empty;
        }

        /// <summary>
        /// Gets the version name of this app async
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        internal static async Task<string> SelfVersionNameAsync(Context context)
        {
            string result = string.Empty;

            await Task.Factory.StartNew(() =>
            {
                result = SelfVersionName(context);
            });

            return result;
        }

        /// <summary>
        /// Gets the version code of this app
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        internal static int SelfVersionCode(Context context)
        {
            PackageInfo packageInfo;
            try
            {
                packageInfo = context.PackageManager.GetPackageInfo(context.PackageName, 0);
                return packageInfo.VersionCode;
            }
            catch (Exception ex)
            {
                Logger.Write(s_tag, $"SelfVersionCode: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }

            return int.MinValue;
        }

        /// <summary>
        /// Gets the version code this app async
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        internal static async Task<int> SelfVersionCodeAsync(Context context)
        {
            int result = int.MinValue;

            await Task.Factory.StartNew(() =>
            {
                result = SelfVersionCode(context);
            });

            return result;
        }

        /// <summary>
        /// Returns app and android version info string
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        internal static string GetVersionInfo(Context context)
        {
            StringBuilder stringBuilder;

            try
            {
                stringBuilder = new StringBuilder();

                stringBuilder.Append($"Versioning Info\r\n");
                stringBuilder.Append($"Squelch: {GeneralUtils.SelfVersionName(context)} {GeneralUtils.SelfVersionCode(context)}\r\n");
                stringBuilder.Append($"Android: {Build.VERSION.Release} (Sdk {Build.VERSION.SdkInt})\r\n");

                return stringBuilder.ToString();
            }
            catch (Exception ex)
            {
                Logger.Write(s_tag, $"GetVersionInfo: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }

            return string.Empty;
        }

        /// <summary>
        /// Returns app and android version info string async
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        internal static async Task<string> GetVersionInfoAsync(Context context)
        {
            string result = string.Empty;

            await Task.Factory.StartNew(() =>
            {
                result = GetVersionInfo(context);
            });

            return result;
        }

        /// <summary>
        /// Returns device info string
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        internal static string GetDeviceInfo()
        {
            StringBuilder stringBuilder;

            try
            {
                stringBuilder = new StringBuilder();
                stringBuilder.Append($"Device Info\r\n");
                stringBuilder.Append($"Brand: {Build.Brand}\r\n");
                stringBuilder.Append($"Manufacturer: {Build.Manufacturer}\r\n");
                stringBuilder.Append($"Model: {Build.Model}\r\n");
                stringBuilder.Append($"Product: {Build.Product}\r\n");
                stringBuilder.Append($"Device: {Build.Device}\r\n");
                stringBuilder.Append($"Host: {Build.Host}\r\n");
                stringBuilder.Append($"Display: {Build.Display}\r\n");
                stringBuilder.Append($"Id: {Build.Id}\r\n");
                if (Build.VERSION.SdkInt < BuildVersionCodes.Lollipop)
                {
                    stringBuilder.Append($"ABI: {Build.CpuAbi}\r\n");
                }
                else
                {
                    stringBuilder.Append($"ABI: {(Build.SupportedAbis.Count > 0 ? Build.SupportedAbis[0] : "?")}\r\n");
                }

                stringBuilder.Append($"\r\n\r\n\r\n");

                return stringBuilder.ToString();
            }
            catch (Exception ex)
            {
                Logger.Write(s_tag, $"GetDeviceInfo: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }

            return string.Empty;
        }

        /// <summary>
        /// Returns device info string async
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        internal static async Task<string> GetDeviceInfoAsync(Context context)
        {
            string result = string.Empty;

            await Task.Factory.StartNew(() =>
            {
                result = GetDeviceInfo();
            });

            return result;
        }
    }
}