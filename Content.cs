using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AndroidX.AppCompat.Widget;
using AndroidX.ViewPager.Widget;
using Google.Android.Material.Tabs;
using PeriodicoDigitalApp.Fragmentos;
using AndroidX.Fragment.App;
using PeriodicoDigitalApp.Negocio;
using FragmentManager = AndroidX.Fragment.App.FragmentManager;
using Fragment = AndroidX.Fragment.App.Fragment;
using ActionBar = Android.App.ActionBar;
using PeriodicoDigitalApp.Adaptadores;

namespace PeriodicoDigitalApp
{
    [Activity(Label = "Content")]
    public class Content : AppCompatActivity
    {

        ListaNoticias negocios = new ListaNoticias();
        ListView lstNoticias;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.content_main);


            //ActionBar.NavigationMode = ActionBarNavigationMode.Tabs;

            //AddTab("Actualidad", new ActualidadFragment());

            //AddTab("Sucesos", new ActualidadFragment();

            //SupportFragmentManager.BeginTransaction()
            //.Add(Resource.Id.FragmentContainer, new ActualidadFragment(), "Actualidad")
            //.Commit();


            //var transaction = FragmentManager.BeginTransaction();

            //transaction.Add(Resource.Id.FragmentContainer, new ActualidadFragment()); //content_main traemos el container

            //transaction.Commit(); //le decimos si queremos que se ejucte. Es muy importante
        }

        private void AddTab(string TabTittle, Android.App.Fragment fragment)
        {
            var tab = ActionBar.NewTab();
            tab.SetText(TabTittle);

            tab.TabSelected += delegate (object sender, ActionBar.TabEventArgs e)
            {


               var previousFragment = FragmentManager.FindFragmentById(Resource.Id.FragmentContainer);

                if (previousFragment != null)
                {

                    e.FragmentTransaction.Remove(previousFragment);

                }


                e.FragmentTransaction.Add(Resource.Id.FragmentContainer, fragment);

            };

            tab.TabUnselected += delegate (object sender, ActionBar.TabEventArgs e)
            {


                var previousFragment = FragmentManager.FindFragmentById(Resource.Id.FragmentContainer);

                if (previousFragment != null)
                {

                    e.FragmentTransaction.Remove(fragment);

                }



                ActionBar.AddTab(tab);

            };

        }

    }
}