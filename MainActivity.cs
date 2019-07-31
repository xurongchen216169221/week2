using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.Drawing;
using System.Collections.Generic;
using System;
using Android.Content;

namespace _2
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            Button buttonlogin = FindViewById<Button>(Resource.Id.useLogo);
            Button buttonvistior = FindViewById<Button>(Resource.Id.buttonVisitor);
            EditText editUserName = FindViewById<EditText>(Resource.Id.useLogo);
            EditText editPassword = FindViewById<EditText>(Resource.Id.password);
            buttonvistior.Click += (sender, e) =>
            {
                Intent intent1 = new Intent(this, typeof(Activity1));
               StartActivity(intent1);
            };

            bool pass = false;
            bool pass2 = false;

            string name = "313";
            string password = "123";




            
                Toast.MakeText(this, "login function are not avaliable now plaese try again later!", ToastLength.Long).Show();
            
            

            

                  
            

        }








        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}