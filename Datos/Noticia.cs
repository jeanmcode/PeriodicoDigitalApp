using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PeriodicoDigitalApp.Datos
{
    public class Noticia
    {

        public string Codigo { get; set; }
        public string Titulo { get; set; }
        public string Cuerpo { get; set; }

        public Noticia(string codigo, string titulo, string cuerpo)
        {
            Codigo = codigo;
            Titulo = titulo;
            Cuerpo = cuerpo;
        }

        




    }
}