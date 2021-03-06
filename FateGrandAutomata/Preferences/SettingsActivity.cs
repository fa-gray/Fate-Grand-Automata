﻿using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;

namespace FateGrandAutomata
{
    [Activity(Label = "Settings")]
    [Register("fgautomata." + nameof(SettingsActivity))]
    public class SettingsActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle SavedInstanceState)
        {
            base.OnCreate(SavedInstanceState);

            SetContentView(Resource.Layout.settings);

            // Add the fragment only on first launch
            if (SavedInstanceState == null)
            {
                SupportFragmentManager
                    .BeginTransaction()
                    .Replace(Resource.Id.settings_container, new SettingsFragment())
                    .Commit();
            }
        }
    }
}