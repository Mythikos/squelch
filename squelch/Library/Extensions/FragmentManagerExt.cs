using Android.App;
using System;
using System.Runtime.CompilerServices;

namespace Squelch.Library.Extensions
{
    internal static class FragmentManagerExt
    {
        /// <summary>
        /// Sets the active fragment of the specified activity
        /// </summary>
        /// <param name="fragmentManager"></param>
        /// <param name="fragmentType"></param>
        /// <param name="addToBackStack"></param>
        /// <param name="useExisting"></param>
        public static void SetFragment(this AndroidX.Fragment.App.FragmentManager fragmentManager, Type fragmentType, bool addToBackStack, bool useExisting)
        {
            AndroidX.Fragment.App.Fragment fragment;

            //
            // Get existing or create a new instance of a fragment
            if (useExisting == true && fragmentManager.FindFragmentByTag(fragmentType.Name) != null)
                fragment = fragmentManager.FindFragmentByTag(fragmentType.Name);
            else
                fragment = (AndroidX.Fragment.App.Fragment)Activator.CreateInstance(fragmentType);

            //
            // Set fragment
            SetFragment(fragmentManager, fragment, fragmentType, addToBackStack);
        }

        /// <summary>
        /// Sets the active fragment of the specified activity
        /// </summary>
        /// <param name="fragmentManager"></param>
        /// <param name="fragment"></param>
        /// <param name="fragmentType"></param>
        /// <param name="addToBackStack"></param>
        public static void SetFragment(this AndroidX.Fragment.App.FragmentManager fragmentManager, AndroidX.Fragment.App.Fragment fragment, Type fragmentType, bool addToBackStack)
        {
            AndroidX.Fragment.App.FragmentTransaction transaction;

            //
            // Start transaciton
            transaction = fragmentManager.BeginTransaction();

            //
            // Set the transaction animation
            // transaction.SetCustomAnimations(Resource.Animator.enter_from_left, Resource.Animator.exit_to_right, Resource.Animator.enter_from_right, Resource.Animator.exit_to_left);

            //
            // Replace the current fragment
            transaction.Replace(Resource.Id.activity_main_fragment_layout, fragment, fragmentType.Name);

            //
            // Add the fragment to the back stack if defined
            if (addToBackStack) transaction.AddToBackStack(null);

            //
            // Commit the transaction
            transaction.CommitAllowingStateLoss();
            //transaction.Commit();
        }

        /// <summary>
        /// Shows the specified dialog fragment
        /// </summary>
        /// <param name="fragmentManager"></param>
        /// <param name="dialogFragmentType"></param>
        public static void ShowDialogFragment(this AndroidX.Fragment.App.FragmentManager fragmentManager, Type dialogFragmentType)
        {
            ShowDialogFragment(fragmentManager, (AndroidX.Fragment.App.DialogFragment)Activator.CreateInstance(dialogFragmentType), dialogFragmentType);
        }

        /// <summary>
        /// Shows the specified dialog fragment
        /// </summary>
        /// <param name="fragmentManager"></param>
        /// <param name="dialogFragment"></param>
        /// <param name="dialogFragmentType"></param>
        public static void ShowDialogFragment(this AndroidX.Fragment.App.FragmentManager fragmentManager, AndroidX.Fragment.App.DialogFragment dialogFragment, Type dialogFragmentType)
        {
            dialogFragment.Show(fragmentManager, dialogFragmentType.Name);
        }

        /// <summary>
        /// Refreshes the fragment it receives
        /// </summary>
        /// <param name="fragmentManager"></param>
        /// <param name="fragmentType"></param>
        public static void RefreshFragment(this AndroidX.Fragment.App.FragmentManager fragmentManager, AndroidX.Fragment.App.Fragment fragment)
        {
            AndroidX.Fragment.App.FragmentTransaction transaction;

            transaction = fragmentManager.BeginTransaction();
            transaction.Detach(fragment);
            transaction.Attach(fragment);
            transaction.Commit();
        }
    }
}