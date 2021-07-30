using Android.Content;
using Android.Content.PM;
using Android.Graphics.Drawables;
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Squelch.Library.UI
{
    /// <summary>
    /// UI Model objects for the appication list
    /// </summary>
    internal class UIApplicationItem : IEquatable<UIApplicationItem>
    {
        public string PackageName { get; set; }
        public string Name { get; set; }
        public Drawable Icon { get; set; }
        public bool IsSelected { get; set; }
        public bool IsDifficultyLocked { get; set; }
        public string Category { get; set; }
        public bool IsSystem { get; set; }

        private UIApplicationListHolder _viewHolder;
        private Context _context;

        public UIApplicationItem(Context context, ApplicationInfo application)
        {
            this.PackageName = this.Name = application.PackageName; // Init name and package name to the package name
            this.Category = string.Empty;
            this.IsSelected = false;
            this.IsDifficultyLocked = false;
            this.Icon = null;

            this._viewHolder = null;
            this._context = context;

            // On another thread, start loading the icon and name
            Task.Factory.StartNew(() =>
            {
                this.Icon = application.LoadIcon(this._context.PackageManager);
                this.Name = application.LoadLabel(this._context.PackageManager);

                // Call setup holder
                // If the holder has already been set, this will update it, if not, itll do nothing
                this.SetupHolder();
            });
        }

        public void SetupHolder(UIApplicationListHolder holder = null)
        {
            //
            // Set this holder as the ui item's holder
            if (holder != null)
            {
                this._viewHolder = holder;
            }

            //
            // If its not null, default view items
            if (this._viewHolder != null)
            {
                //
                // Reset holder items
                this._viewHolder.IconImage.SetImageDrawable(null);
                this._viewHolder.NameText.Text = string.Empty;
                this._viewHolder.CategoryText.Text = string.Empty;

                this._viewHolder.RootLayout.SetBackgroundResource(Resource.Color.recyclerColorBackground);
                this._viewHolder.RootLayout.Visibility = ViewStates.Visible;
                this._viewHolder.IconImage.Visibility = ViewStates.Visible;
                this._viewHolder.NameText.Visibility = ViewStates.Visible;
                this._viewHolder.CategoryText.Visibility = ViewStates.Visible;

                //
                // Set instance values
                this._viewHolder.NameText.Text = this.Name;
                if (this.Icon != null)
                {
                    this._viewHolder.IconImage.SetImageDrawable(this.Icon);
                }

                if (string.IsNullOrWhiteSpace(this.Category) == false)
                {
                    this._viewHolder.CategoryText.Text = this.Category;
                }
                else
                {
                    this._viewHolder.CategoryText.Visibility = ViewStates.Gone;
                }

                if (this.IsSelected)
                {
                    this._viewHolder.ItemView.SetBackgroundResource(Resource.Color.recyclerColorBackgroundAlt);
                }
                else
                {
                    this._viewHolder.ItemView.SetBackgroundResource(Resource.Color.recyclerColorBackground);
                }
            }
        }

        public void SetSelected(bool isSelected)
        {
            this.IsSelected = isSelected;
            this.SetupHolder();
        }

        public void ToggleSelected()
        {
            this.SetSelected(!this.IsSelected);
        }

        public bool Equals(UIApplicationItem other)
        {
            return this.PackageName.Equals(other.PackageName)
                && this.IsSelected.Equals(other.IsSelected)
                && this.IsDifficultyLocked.Equals(other.IsDifficultyLocked)
                && this.Category.Equals(other.Category);
        }
    }

    /// <summary>
    /// UI view holder
    /// </summary>
    internal class UIApplicationListHolder : RecyclerView.ViewHolder
    {
        public LinearLayout RootLayout { get; private set; }
        public ImageView IconImage { get; private set; }
        public TextView NameText { get; private set; }
        public TextView CategoryText { get; private set; }

        public UIApplicationListHolder(View rowItem, Action<int> selectedEvent) : base(rowItem)
        {
            //
            // Initialize
            this.RootLayout = rowItem.FindViewById<LinearLayout>(Resource.Id.template_application_row_root_layout);
            this.IconImage = rowItem.FindViewById<ImageView>(Resource.Id.template_application_row_icon);
            this.NameText = rowItem.FindViewById<TextView>(Resource.Id.template_application_row_name);
            this.CategoryText = rowItem.FindViewById<TextView>(Resource.Id.template_application_row_category);

            //
            // Hookup events
            rowItem.Click += (sender, e) => selectedEvent(base.LayoutPosition);
        }
    }

    /// <summary>
    /// Recycler view adapter
    /// </summary>
    internal class UIApplicationListAdapter : RecyclerView.Adapter
    {
        #region Instance variables
        public event EventHandler<int> OnApplicationSelected;
        public List<UIApplicationItem> ApplicationList;
        #endregion

        public override int ItemCount => this.ApplicationList.Count;

        public UIApplicationListAdapter(List<UIApplicationItem> applicationList)
        {
            //
            // Set the adapter's list
            this.ApplicationList = applicationList;
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            //
            // Create the holder
            View applicationRowTemplate = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.template_application_row, parent, false);
            return new UIApplicationListHolder(applicationRowTemplate, this.OnSelect);
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            //
            // Cast as a friend list holder and set up the ui holder
            UIApplicationListHolder objHolder = holder as UIApplicationListHolder;
            this.ApplicationList[position].SetupHolder(objHolder);
        }

        #region Events
        private void OnSelect(int position)
        {
            //
            // Call event if subscribed
            if (OnApplicationSelected != null)
            {
                OnApplicationSelected(this, position);
            }
        }
        #endregion
    }

    /// <summary>
    /// Useds a a DiffUtil callback for small list updates
    /// </summary>
    internal class UIApplicationDiffCallback : DiffUtil.Callback
    {
        public List<UIApplicationItem> NewList;
        public List<UIApplicationItem> OldList;
        public override int NewListSize => this.NewList.Count;
        public override int OldListSize => this.OldList.Count;

        public UIApplicationDiffCallback()
        {
            this.NewList = new List<UIApplicationItem>();
            this.OldList = new List<UIApplicationItem>();
        }

        public UIApplicationDiffCallback(List<UIApplicationItem> newList, List<UIApplicationItem> oldList)
        {
            this.NewList = newList;
            this.OldList = oldList;
        }

        public override bool AreContentsTheSame(int oldItemPosition, int newItemPosition)
        {
            return this.NewList[newItemPosition].Equals(this.OldList[oldItemPosition]);
        }

        public override bool AreItemsTheSame(int oldItemPosition, int newItemPosition)
        {
            return this.NewList[newItemPosition].PackageName.Equals(this.OldList[oldItemPosition].PackageName);
        }
    }
}