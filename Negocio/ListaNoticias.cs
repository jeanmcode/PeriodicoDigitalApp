using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using PeriodicoDigitalApp.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PeriodicoDigitalApp.Negocio
{
    public class ListaNoticias
    {

       private static List<Noticia> noticias = new List<Noticia>(); 

       public void SetNoticias()
        {

            noticias.Add(new Noticia("001", "Primera noticia", "kkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkk"));
            noticias.Add(new Noticia("002", "Segunda noticia", "llllllllllllllllllllllllllllllllllllllllll"));
            noticias.Add(new Noticia("003", "Tercer noticia", "oooooooooooooooooooooooooooooooooooooooooooo"));

        }


        public List<Noticia> GetNoticias()
        {


            return noticias;
        }



    }
}