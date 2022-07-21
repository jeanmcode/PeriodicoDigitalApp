using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using AndroidX.AppCompat.Widget;
using AndroidX.Core.View;
using AndroidX.DrawerLayout.Widget;
using Google.Android.Material.FloatingActionButton;
using Google.Android.Material.Navigation;
using Google.Android.Material.Tabs;
using Google.Android.Material.Snackbar;
using PeriodicoDigitalApp.Fragmentos;
using PeriodicoDigitalApp.Negocio;

namespace PeriodicoDigitalApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = false)]
    public class MainActivity : AppCompatActivity, NavigationView.IOnNavigationItemSelectedListener
    {
        ListaNoticias negocio = new ListaNoticias();

        FloatingActionButton fab;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);


            negocio.SetNoticias();



            //SupportFragmentManager.BeginTransaction()
            //.Add(Resource.Id.FragmentContainer, new ActualidadFragment(), "Actualidad")
            //.Commit();

            var transaction = FragmentManager.BeginTransaction();

            transaction.Add(Resource.Id.FragmentContainer, new ActualidadFragment()); //content_main traemos el container

            transaction.Commit(); //le decimos si queremos que se ejucte. Es muy importante

            AndroidX.AppCompat.Widget.Toolbar toolbar = FindViewById<AndroidX.AppCompat.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            DrawerLayout drawer = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            ActionBarDrawerToggle toggle = new ActionBarDrawerToggle(this, drawer, toolbar, Resource.String.navigation_drawer_open, Resource.String.navigation_drawer_close);
            drawer.AddDrawerListener(toggle);
            toggle.SyncState();

            NavigationView navigationView = FindViewById<NavigationView>(Resource.Id.nav_view);
            navigationView.SetNavigationItemSelectedListener(this);

            fab = (FloatingActionButton)FindViewById(Resource.Id.fabEntrar);

            fab.Click += Fab_Click;

            TabLayout tab = FindViewById<TabLayout>(Resource.Id.tabLayout);
            tab.AddOnTabSelectedListener();

        }

        private void Fab_Click(object sender, EventArgs e)
        {
            View view = (View) sender;

            Toast.MakeText(this, negocio.GetNoticias()[0].Titulo, ToastLength.Long).Show();

            //Snackbar.Make(view, "Hi guys", Snackbar.LengthLong)
            //    .SetAction("Action", (Android.Views.View.IOnClickListener)null).Show();
        }

        public override void OnBackPressed()
        {
            DrawerLayout drawer = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            if(drawer.IsDrawerOpen(GravityCompat.Start))
            {
                drawer.CloseDrawer(GravityCompat.Start);
            }
            else
            {
                base.OnBackPressed();
            }
        }

       
       
        public bool OnNavigationItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            

            if (id == Resource.Id.nav_camera)
            {
                // Handle the camera action

                Toast.MakeText(this, "hola desde camara", ToastLength.Long).Show();

               // StartActivity(typeof(Content));


            }
            else if (id == Resource.Id.nav_gallery)
            {

            }
            else if (id == Resource.Id.nav_slideshow)
            {

            }
           

            DrawerLayout drawer = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            drawer.CloseDrawer(GravityCompat.Start);
            return true;
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}

