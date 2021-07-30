using Android.Content;
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;
using Squelch.Library.Entities;
using System;
using System.Collections.Generic;

namespace Squelch.Library.UI
{
    /// <summary>
    /// UI Model objects for the appication list
    /// </summary>
    internal class UIBlackoutItem
    {
        public Context Context { get; private set; }
        public BlackoutItem BlackoutItem { get; private set; }
        public bool IsSelected { get; set; }
        public UIBlackoutListHolder Holder { get; set; }

        public UIBlackoutItem(Context context, BlackoutItem blackoutItem)
        {
            this.Context = context;
            this.BlackoutItem = blackoutItem;
            this.IsSelected = false;
            this.Holder = null;
        }

        public void SetupHolder(UIBlackoutListHolder holder)
        {
            //
            // Set this holder as the ui item's holder
            this.Holder = holder;

            //
            // If its not null, default view items
            if (this.Holder != null)
            {
                this.Holder.IconImage.SetImageDrawable(null);
                this.Holder.OutcomeText.Text = string.Empty;
                this.Holder.BidText.Text = string.Empty;

                this.Holder.RootLayout.SetBackgroundResource(Resource.Color.recyclerColorBackground);
                this.Holder.IconImage.Visibility = ViewStates.Visible;
                this.Holder.OutcomeText.Visibility = ViewStates.Visible;
                this.Holder.BidText.Visibility = ViewStates.Visible;

                if (this.BlackoutItem.ResultCode == BlackoutItem.BlackoutResultCode.Success)
                {
                    this.Holder.IconImage.SetImageResource(Resource.Drawable.ic_mood_good);
                }
                else if (this.BlackoutItem.ResultCode == BlackoutItem.BlackoutResultCode.Failed)
                {
                    this.Holder.IconImage.SetImageResource(Resource.Drawable.ic_mood_bad);
                }
                else
                {
                    this.Holder.IconImage.SetImageResource(Resource.Drawable.ic_mood_neutral);
                }

                this.Holder.OutcomeText.Text = this.BlackoutItem.ResultCode.ToString();
                this.Holder.BidText.Text = $"${this.BlackoutItem.Bid}";

                if (this.IsSelected)
                {
                    this.Holder.ItemView.SetBackgroundResource(Resource.Color.recyclerColorBackgroundAlt);
                }
                else
                {
                    this.Holder.ItemView.SetBackgroundResource(Resource.Color.recyclerColorBackground);
                }
            }
        }
    }

    /// <summary>
    /// UI view holder
    /// </summary>
    internal class UIBlackoutListHolder : RecyclerView.ViewHolder
    {
        public LinearLayout RootLayout { get; private set; }
        public ImageView IconImage { get; private set; }
        public TextView OutcomeText { get; private set; }
        public TextView BidText { get; private set; }

        public UIBlackoutListHolder(View rowItem, Action<int> selectedEvent) : base(rowItem)
        {
            //
            // Get controls
            this.RootLayout = rowItem.FindViewById<LinearLayout>(Resource.Id.template_history_row_root_layout);
            this.IconImage = rowItem.FindViewById<ImageView>(Resource.Id.template_history_row_icon);
            this.OutcomeText = rowItem.FindViewById<TextView>(Resource.Id.template_history_row_result);
            this.BidText = rowItem.FindViewById<TextView>(Resource.Id.template_history_row_bid);

            //
            // Hookup events
            rowItem.Click += (sender, e) => selectedEvent(base.LayoutPosition);
        }
    }

    /// <summary>
    /// Recycler view adapter
    /// </summary>
    internal class UIBlackoutListAdapter : RecyclerView.Adapter
    {
        #region Instance variables
        public event EventHandler<int> OnBlackoutItemSelected;
        public List<UIBlackoutItem> BlackoutList;
        #endregion

        public override int ItemCount => this.BlackoutList.Count;

        public UIBlackoutListAdapter(List<UIBlackoutItem> historyList)
        {
            //
            // Set the adapter's list
            this.BlackoutList = historyList;
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            //
            // Create the holder
            View historyRowTemplate = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.template_history_row, parent, false);
            return new UIBlackoutListHolder(historyRowTemplate, this.OnSelect);
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            //
            // Cast as a friend list holder and set up the ui holder
            UIBlackoutListHolder objHolder = holder as UIBlackoutListHolder;
            this.BlackoutList[position].SetupHolder(objHolder);
        }

        #region Events
        private void OnSelect(int position)
        {
            //
            // Call event if subscribed
            if (OnBlackoutItemSelected != null)
            {
                OnBlackoutItemSelected(this, position);
            }
        }
        #endregion
    }
}