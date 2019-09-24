using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using Android.Content;

namespace Task3.Droid
{
    [Activity(Label = "Task3", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        static readonly List<string> studentNames = new List<string>();
        static readonly List<string> studentIDs = new List<string>();
        protected override void OnCreate(Bundle savedInstanceState)
        {
            Button viewAllButton = FindViewById<Button>(Resource.Id.ViewAllButton);
            Button saveButton = FindViewById<Button>(Resource.Id.SaveButton);
            TextView name = FindViewById<EditText>(Resource.Id.nameText);
            TextView id = FindViewById<EditText>(Resource.Id.idText);

            viewAllButton.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(Lab2_4.ViewAllActivity));
                intent.PutStringArrayListExtra("student_name", studentNames);
                intent.PutStringArrayListExtra("student_id", studentIDs);
                StartActivity(intent);
            };
            saveButton.Click += (sender, e) =>
            {
                string newName = "";
                string newID = "";
                if (string.IsNullOrWhiteSpace(name.Text) || string.IsNullOrWhiteSpace(id.Text))
                {
                    newName = "";
                    newID = "";

                }
                else
                {
                    studentNames.Add(name.Text);
                    studentIDs.Add(id.Text);
                }
            };
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}