using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using PeriodicoDigitalApp.Adaptadores;
using PeriodicoDigitalApp.Datos;
using PeriodicoDigitalApp.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PeriodicoDigitalApp.Fragmentos
{
    public class BaseFragment : Fragment
    {
       
        public List<Noticia> noticias;
        private ListView listview;
        private ListaNoticias listaNoticias;

        public BaseFragment()
        {
            
            //Instanciamos la lista de noticias
            noticias = new List<Noticia>();
        }


        


        public  void SetupFragment()
        {

            SetupViews();
            SetupEvents();

            listview.Adapter = new adtActualidad(Activity, listaNoticias.GetNoticias());

        }

        public void SetupViews()
        {

            //traemos el id del listview que esta en el layou
            listview = View.FindViewById<ListView>(Resource.Id.lstNoticias);

        }


        public void SetupEvents()
        {


            listview.ItemClick += Listview_ItemClick;
        }

        private void Listview_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {


            Intent intent = new Intent(Activity, typeof(ActualidadActivity));

            var Id = (int)e.Id;

            intent.PutExtra("Id", Id);

            StartActivity(intent);

        }


        //public override void OnCreate(Bundle savedInstanceState)
        //{
        //    base.OnCreate(savedInstanceState);

        //    // Create your fragment here




        //}

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);


            return inflater.Inflate(Resource.Layout.content_main, container, false);
        }
    }
}