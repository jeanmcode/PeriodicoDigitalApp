using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Google.Android.Material.TextField;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PeriodicoDigitalApp
{
    [Activity(Label = "LoginActivity", MainLauncher = true)]
    public class LoginActivity : Activity
    {
        Button btnIngresar;
         
        TextInputLayout edtPass, edtUser;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Login);

            // Create your application here

            btnIngresar = (Button)FindViewById(Resource.Id.btnIngresar);
            edtUser = (TextInputLayout)FindViewById(Resource.Id.edtUSer);
            edtPass = (TextInputLayout)FindViewById(Resource.Id.edtPass);

            btnIngresar.Click += BtnIngresar_Click;
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(MainActivity));
        }
    }
}