using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using PeriodicoDigitalApp.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PeriodicoDigitalApp.Negocio;
using PeriodicoDigitalApp.Adaptadores;

namespace PeriodicoDigitalApp.Fragmentos
{
    public class ActualidadFragment : Fragment
    {

         List<Noticia> noticias= new List<Noticia>();
         ListView listview;
         ListaNoticias listaNoticias= new ListaNoticias(); //Instanciar siempre


        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
           


        }


        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);

            View view = inflater.Inflate(Resource.Layout.ActualidadFragment, container, false);

            listview = view.FindViewById<ListView>(Resource.Id.lstNoticias); //variable view, no la funcion(minuscula)

            listview.Adapter = new adtActualidad(Activity, listaNoticias.GetNoticias());

            return view;

            
        }

    }
}