using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.Fragment.App;
using Squelch.Activities;
using Squelch.Library;
using Squelch.Library.Interfaces;
using Squelch.Library.Singletons;
using Squelch.Library.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Squelch.Fragments
{
    public class OpenSourceDialogFragment : DialogFragment
    {
        #region Instance Variables
        private static readonly string _tag = typeof(OpenSourceDialogFragment).FullName;

        // Parent view items
        private LinearLayout _rootLayout;
        private LinearLayout _attributionLayout;
        #endregion

        #region Native Events
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view;

            //
            // Inflate the layour
            view = inflater.Inflate(Resource.Layout.dialog_fragment_open_source, container, false);

            try
            {
                //
                // Get Controls
                _rootLayout = view.FindViewById<LinearLayout>(Resource.Id.fragment_open_source_root_layout);
                _attributionLayout = view.FindViewById<LinearLayout>(Resource.Id.fragment_open_source_attribution_layout);

                //
                // Call ui methods
                BuildAttributionList();
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"OnCreateView: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }

            //
            // Return the inflated view
            return view;
        }

        public override void OnResume()
        {
            base.OnResume();

            FirebaseAnalyticsManager firebaseAnalyticsManager;

            try
            {
                //
                // Set firebase screen
                firebaseAnalyticsManager = FirebaseAnalyticsManager.GetInstance();
                firebaseAnalyticsManager.SetCurrentScreen(this);
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"OnResume: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
        }
        #endregion

        #region Helper Methods
        /// <summary>
        /// Displays the working progress indicator
        /// </summary>
        /// <param name="bIsWorking"></param>
        private void SetIsWorking(bool isWorking)
        {
            // Toggle views
            ViewUtils.SetViewAndChildrenEnabled(_rootLayout, !isWorking);

            // Report to parent
            if (this.Activity is IIndeterminateProgressReporter)
                ((IIndeterminateProgressReporter)this.Activity).SetProgressBarState(isWorking);
        }

        /// <summary>
        /// Builds the attribution list
        /// </summary>
        private void BuildAttributionList()
        {
            // dev name, software name, license name, link
            List<(string, string, string, string)> _attributionList;
            Android.Util.TypedValue selectableItemBackgroundValue;

            try
            {
                SetIsWorking(true);

                //
                // Add various software attributions
                _attributionList = new List<(string, string, string, string)>
                {
                    ("JamesNK", "Newtonsoft.Json", "MIT", "https://github.com/JamesNK/Newtonsoft.Json"),
                    ("James Montemagno", "InAppBillingPlugin", "MIT", "https://github.com/jamesmontemagno/InAppBillingPlugin"),
                    ("Xamarin", "Essentials", "MIT", "https://github.com/xamarin/Essentials"),
                    ("James Montemagno", "Settings Plugin", "MIT", "https://github.com/jamesmontemagno/SettingsPlugin"),
                    ("TwinCoders S.L.", "sqlite-net-extensions", "(C) 2013", "https://bitbucket.org/twincoders/sqlite-net-extensions/src/master/"),
                    ("Praeclarum", "sqlite-net-pcl", "MIT", "https://github.com/praeclarum/sqlite-net"),
                    ("Microsoft", "Google Play Services", "MIT", "https://github.com/xamarin/GooglePlayServicesComponents"),
                    ("Microsoft", "AndroidX", "MIT", "https://github.com/xamarin/AndroidX"),
                };

                //
                // Get theme attribute
                selectableItemBackgroundValue = new Android.Util.TypedValue();
                this.Context.Theme.ResolveAttribute(Resource.Attribute.selectableItemBackground, selectableItemBackgroundValue, true);

                //
                // Build the list items
                foreach (string developer in _attributionList.Select(x => x.Item1).Distinct().OrderBy(x => x))
                {
                    //
                    // Create attribution title
                    var titleLabel = new TextView(this.Context)
                    {
                        LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent),
                        Text = developer
                    };
                    titleLabel.SetTypeface(Android.Graphics.Typeface.DefaultBold, Android.Graphics.TypefaceStyle.Bold);
                    titleLabel.SetPadding(15, 10, 10, 10);
                    titleLabel.SetTextColor(Android.Graphics.Color.ParseColor(this.Resources.GetString(Resource.Color.White)));
                    titleLabel.SetBackgroundColor(Android.Graphics.Color.ParseColor(this.Resources.GetString(Resource.Color.colorAccent)));
                    _attributionLayout.AddView(titleLabel);

                    //
                    // Iterate over each project
                    foreach ((string, string, string, string) attribution in _attributionList.Where(x => x.Item1.Equals(developer)).OrderBy(x => x.Item2))
                    {
                        //
                        // Create attribution row
                        var projectRow = new LinearLayout(this.Context)
                        {
                            LayoutParameters = new ViewGroup.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent),
                            Orientation = Orientation.Horizontal,
                            WeightSum = 2,
                            Clickable = true,
                            Focusable = true
                        };
                        projectRow.SetPadding(20, 10, 10, 20);
                        projectRow.SetBackgroundResource(selectableItemBackgroundValue.ResourceId);
                        projectRow.Click += delegate
                        {
                            try
                            {
                                SetIsWorking(true);

                                Intent linkIntent = new Intent(Intent.ActionView);
                                linkIntent.SetData(Android.Net.Uri.Parse(attribution.Item4));
                                StartActivity(linkIntent);
                            }
                            finally { SetIsWorking(false); }
                        };

                        var projectName = new TextView(this.Context)
                        {
                            LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.WrapContent, 1),
                            TextSize = 20,
                            Gravity = GravityFlags.Left,
                            Text = attribution.Item2
                        };
                        projectName.SetTypeface(Android.Graphics.Typeface.DefaultBold, Android.Graphics.TypefaceStyle.Bold);
                        projectName.SetPadding(20, 10, 10, 10);
                        projectRow.AddView(projectName);

                        var projectLicense = new TextView(this.Context)
                        {
                            LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.WrapContent, 1),
                            TextSize = 20,
                            Gravity = GravityFlags.Right,
                            Text = attribution.Item3
                        };
                        projectLicense.SetPadding(10, 10, 20, 10);
                        projectRow.AddView(projectLicense);

                        // Add to parents
                        _attributionLayout.AddView(projectRow);
                    }

                    //
                    // Add spacer
                    _attributionLayout.AddView(new View(this.Context)
                    {
                        LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, 20)
                    });
                }
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"BuildAttributionList: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
            finally
            {
                SetIsWorking(false);
            }
        }
        #endregion
    }
}