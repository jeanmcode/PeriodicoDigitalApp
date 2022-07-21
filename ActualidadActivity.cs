using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using PeriodicoDigitalApp.Adaptadores;
using PeriodicoDigitalApp.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PeriodicoDigitalApp
{
    [Activity(Label = "ActualidadActivity")]
    public class ActualidadActivity : Activity
    {

        ListaNoticias negocios = new ListaNoticias();
        ListView lstNoticias;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState); 
            SetContentView(Resource.Layout.ActualidadFragment);



            //lstNoticias = (ListView)FindViewById(Resource.Id.lstNoticias);


            //lstNoticias.Adapter = new adtActualidad(this, negocios.GetNoticias());




        }
    }
}