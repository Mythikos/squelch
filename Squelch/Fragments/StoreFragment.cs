using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.Fragment.App;
using Google.Android.Material.Snackbar;
using Squelch.Activities;
using Squelch.Library;
using Squelch.Library.Interfaces;
using Squelch.Library.Singletons;
using Squelch.Library.Utilities;
using System;
using System.Collections.Generic;

namespace Squelch.Fragments
{
    public class StoreFragment : Fragment
    {
        #region Instance Variables
        private static readonly string _tag = typeof(StoreFragment).FullName;

        // Parent view items
        private LinearLayout _rootLayout;
        private LinearLayout _productLayout;
        #endregion

        #region Native Methods
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view;

            //
            // Inflate the layour
            view = inflater.Inflate(Resource.Layout.fragment_store, container, false);

            try
            {
                _rootLayout = view.FindViewById<LinearLayout>(Resource.Id.fragment_store_root_layout);
                _productLayout = view.FindViewById<LinearLayout>(Resource.Id.fragment_store_product_layout);
                UIBuildStoreList();

                //
                // Setup navbar
                ((MainActivity)this.Activity).SetupNavigation(Resource.String.title_store, true, false);
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
        /// Builds the store list
        /// </summary>
        private void UIBuildStoreList()
        {
            List<ListingCategory> _listingCategories;
            Android.Util.TypedValue selectableItemBackgroundValue;

            try
            {
                this.SetIsWorking(true);

                //
                // Add various listings
                _listingCategories = new List<ListingCategory>()
                {
                    new ListingCategory()
                    {
                        Name = "Products"
                    },
                    new ListingCategory()
                    {
                        Name = "Donations",
                        Listings = new List<Listing>()
                        {
                            new Listing() { Name = "Cup of Coffee", Price = 1, Description = "Nothing says thanks like a cup of joe. Your $1 donation will brighten the day for one of our dev team members!", ProductId = "squelch_store_donation_001", SortOrder = 0 },
                            new Listing() { Name = "Energy Drink", Price = 5, Description = "It is dev team fuel. Your $5 donation will kick the tires and light the fires on new Squelch updates!", ProductId = "squelch_store_donation_005", SortOrder = 1 },
                            new Listing() { Name = "Pizza & Refreshments", Price = 25, Description = "This is next level motivation for the Squelch team. Your $25 donation will drive our entire team of creatives towards a bigger, better, and bolder Squelch experience!", ProductId = "squelch_store_donation_025", SortOrder = 2 }
                        }
                    }
                };

                //
                // Get theme attribute
                selectableItemBackgroundValue = new Android.Util.TypedValue();
                this.Context.Theme.ResolveAttribute(Resource.Attribute.selectableItemBackground, selectableItemBackgroundValue, true);

                //
                // Build the list items
                foreach (ListingCategory category in _listingCategories)
                {
                    //
                    // Create listing title
                    var titleLabel = new TextView(this.Context)
                    {
                        LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent),
                        Text = category.Name
                    };
                    titleLabel.SetTypeface(Android.Graphics.Typeface.DefaultBold, Android.Graphics.TypefaceStyle.Bold);
                    titleLabel.SetPadding(15, 10, 10, 10);
                    titleLabel.SetTextColor(Android.Graphics.Color.ParseColor(this.Resources.GetString(Resource.Color.White)));
                    titleLabel.SetBackgroundColor(Android.Graphics.Color.ParseColor(this.Resources.GetString(Resource.Color.colorAccent)));
                    _productLayout.AddView(titleLabel);

                    if (category.Listings.Count > 0)
                    {
                        //
                        // Iterate over each project
                        foreach (Listing listing in category.Listings)
                        {
                            //
                            // Create listing row
                            var listingRow = new LinearLayout(this.Context)
                            {
                                LayoutParameters = new ViewGroup.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent),
                                Orientation = Orientation.Vertical,
                                WeightSum = 2,
                                Clickable = true,
                                Focusable = true
                            };
                            listingRow.SetPadding(20, 10, 10, 20);
                            listingRow.SetBackgroundResource(selectableItemBackgroundValue.ResourceId);
                            listingRow.Click += async delegate
                            {
                                // Validate we have a product id
                                if (string.IsNullOrWhiteSpace(listing.ProductId) == true)
                                    return;

                                // Set working
                                this.SetIsWorking(true);

                                // Init purchase util and process purchase
                                (bool, string) result = await InAppPurchaseUtils.PurchaseAsync(listing.ProductId, true);

                                if (string.IsNullOrWhiteSpace(result.Item2) == false)
                                    DisplayUtils.ShowSnackbar(this.View, result.Item2, Snackbar.LengthIndefinite);

                                // Set no longer working
                                this.SetIsWorking(false);
                            };

                            //
                            // Create line one, containing the item title and price
                            var rowLineOne = new LinearLayout(this.Context)
                            {
                                LayoutParameters = new ViewGroup.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent),
                                Orientation = Orientation.Horizontal,
                                Clickable = false,
                                Focusable = false
                            };

                            var listingName = new TextView(this.Context)
                            {
                                LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.WrapContent, 1),
                                TextSize = 20,
                                Gravity = GravityFlags.Left,
                                Text = listing.Name
                            };
                            listingName.SetTypeface(Android.Graphics.Typeface.DefaultBold, Android.Graphics.TypefaceStyle.Bold);
                            listingName.SetPadding(20, 10, 10, 10);
                            rowLineOne.AddView(listingName);

                            var listingPrice = new TextView(this.Context)
                            {
                                LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.WrapContent, 1),
                                TextSize = 20,
                                Gravity = GravityFlags.Right,
                                Text = $"${listing.Price}"
                            };
                            listingPrice.SetPadding(10, 10, 20, 10);
                            rowLineOne.AddView(listingPrice);

                            //
                            // Create line two, containing the item description
                            var rowLineTwo = new LinearLayout(this.Context)
                            {
                                LayoutParameters = new ViewGroup.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent),
                                Orientation = Orientation.Horizontal,
                                Clickable = false,
                                Focusable = false
                            };

                            var listingDescription = new TextView(this.Context)
                            {
                                LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent, 1),
                                TextSize = 16,
                                Gravity = GravityFlags.Left,
                                Text = listing.Description
                            };
                            listingDescription.SetPadding(20, 0, 10, 10);
                            rowLineTwo.AddView(listingDescription);

                            //
                            // Add to parents
                            listingRow.AddView(rowLineOne);
                            listingRow.AddView(rowLineTwo);
                            _productLayout.AddView(listingRow);
                        }
                    }
                    else
                    {
                        //
                        // Create placeholder listing row
                        var listingRow = new LinearLayout(this.Context)
                        {
                            LayoutParameters = new ViewGroup.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent),
                            Orientation = Orientation.Vertical,
                            WeightSum = 2,
                            Clickable = true,
                            Focusable = true
                        };
                        listingRow.SetPadding(20, 10, 10, 20);

                        var listingDescription = new TextView(this.Context)
                        {
                            LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent, 1),
                            TextSize = 16,
                            Gravity = GravityFlags.Center,
                            Text = "Nothing here yet, check back later!"
                        };
                        listingDescription.SetPadding(20, 0, 10, 10);

                        //
                        // Add to parents
                        listingRow.AddView(listingDescription);
                        _productLayout.AddView(listingRow);
                    }

                    //
                    // Add spacer
                    _productLayout.AddView(new View(this.Context)
                    {
                        LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, 20)
                    });
                }
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"BuildStoreList: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
            finally
            {
                this.SetIsWorking(false);
            }
        }
        #endregion

        #region Classes
        private class Listing
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public long Price { get; set; }
            public string ProductId { get; set; }
            public long SortOrder { get; set; }

            public Listing()
            {
                this.Name = string.Empty;
                this.Description = string.Empty;
                this.Price = 0;
                this.ProductId = string.Empty;
                this.SortOrder = 0;
            }
        }

        private class ListingCategory
        {
            public string Name { get; set; }
            public List<Listing> Listings { get; set; }

            public ListingCategory()
            {
                this.Name = string.Empty;
                this.Listings = new List<Listing>();
            }
        }
        #endregion
    }
}