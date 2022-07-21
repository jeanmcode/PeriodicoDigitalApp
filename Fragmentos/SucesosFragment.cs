using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using PeriodicoDigitalApp.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PeriodicoDigitalApp.Fragmentos
{
    public class SucesosFragment : BaseFragment
    {
        private ListaNoticias listaNoticias;


        public SucesosFragment()
        {
            //INstanciamos la clase lista noticias
            listaNoticias = new ListaNoticias();


        }


        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here

            if (!noticias.Any())
            {
                listaNoticias.SetNoticias();
                listaNoticias.GetNoticias();


            }


            SetupViews();



        }


        //public override void OnActivityCreated(Bundle savedInstanceState)
        //{
        //    base.OnActivityCreated(savedInstanceState);




        //}
    }
}