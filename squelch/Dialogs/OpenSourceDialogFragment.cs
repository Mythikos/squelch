using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.Fragment.App;
using Squelch.Library;
using Squelch.Library.Interfaces;
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
        private Button _negativeButton;
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
                this._rootLayout = view.FindViewById<LinearLayout>(Resource.Id.fragment_open_source_root_layout);
                this._attributionLayout = view.FindViewById<LinearLayout>(Resource.Id.fragment_open_source_attribution_layout);
                this._negativeButton = view.FindViewById<Button>(Resource.Id.fragment_open_source_negative_button);

                //
                // Hook events
                this._negativeButton.Click += delegate
                {
                    this.Dismiss();
                };

                //
                // Call ui methods
                this.BuildAttributionList();
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

            try
            {
                //
                // Set firebase screen
                FirebaseAnalyticsUtils.SetCurrentScreen(this);
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
            ViewUtils.SetViewAndChildrenEnabled(this._rootLayout, !isWorking);

            // Report to parent
            if (this.Activity is IIndeterminateProgressReporter)
            {
                ((IIndeterminateProgressReporter)this.Activity).SetProgressBarState(isWorking);
            }
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
                this.SetIsWorking(true);

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
                    ("PhilJay", "MPAndroidChart", "Apache 2", "https://github.com/PhilJay/MPAndroidChart"),
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
                    TextView titleLabel = new TextView(this.Context)
                    {
                        LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent),
                        Text = developer
                    };
                    titleLabel.SetTypeface(Android.Graphics.Typeface.DefaultBold, Android.Graphics.TypefaceStyle.Bold);
                    titleLabel.SetPadding(15, 10, 10, 10);
                    titleLabel.SetTextColor(Android.Graphics.Color.ParseColor(this.Resources.GetString(Resource.Color.White)));
                    titleLabel.SetBackgroundColor(Android.Graphics.Color.ParseColor(this.Resources.GetString(Resource.Color.colorAccent)));
                    this._attributionLayout.AddView(titleLabel);

                    //
                    // Iterate over each project
                    foreach ((string, string, string, string) attribution in _attributionList.Where(x => x.Item1.Equals(developer)).OrderBy(x => x.Item2))
                    {
                        //
                        // Create attribution row
                        LinearLayout projectRow = new LinearLayout(this.Context)
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
                                this.SetIsWorking(true);

                                Intent linkIntent = new Intent(Intent.ActionView);
                                linkIntent.SetData(Android.Net.Uri.Parse(attribution.Item4));
                                this.StartActivity(linkIntent);
                            }
                            finally { this.SetIsWorking(false); }
                        };

                        TextView projectName = new TextView(this.Context)
                        {
                            LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.WrapContent, 1),
                            TextSize = 20,
                            Gravity = GravityFlags.Left,
                            Text = attribution.Item2
                        };
                        projectName.SetTypeface(Android.Graphics.Typeface.DefaultBold, Android.Graphics.TypefaceStyle.Bold);
                        projectName.SetPadding(20, 10, 10, 10);
                        projectRow.AddView(projectName);

                        TextView projectLicense = new TextView(this.Context)
                        {
                            LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.WrapContent, 1),
                            TextSize = 20,
                            Gravity = GravityFlags.Right,
                            Text = attribution.Item3
                        };
                        projectLicense.SetPadding(10, 10, 20, 10);
                        projectRow.AddView(projectLicense);

                        // Add to parents
                        this._attributionLayout.AddView(projectRow);
                    }

                    //
                    // Add spacer
                    this._attributionLayout.AddView(new View(this.Context)
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
                this.SetIsWorking(false);
            }
        }
        #endregion
    }
}