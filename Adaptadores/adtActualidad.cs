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

namespace PeriodicoDigitalApp.Adaptadores
{
    public class adtActualidad : BaseAdapter<Noticia>
    {
        Activity context;
        List<Noticia> noticias = new List<Noticia>();

        public adtActualidad(Activity context, List<Noticia> noticias)
        {
            this.context = context;
            this.noticias = noticias;
        }

        public override Noticia this[int position]
        {

            get { return noticias[position]; }

        }

        public override int Count =>  noticias.Count();


        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {

            var item = noticias[position];

            View view = convertView;

            if (view == null)
                view = context.LayoutInflater.Inflate(Resource.Layout.adtActualidad, null);

            view.FindViewById<TextView>(Resource.Id.txtTituloAdt).Text = item.Titulo;
            view.FindViewById<TextView>(Resource.Id.txtFechaAdt).Text = item.Titulo;
            view.FindViewById<ImageView>(Resource.Id.imgFotoAdt).SetImageResource(Resource.Drawable.logoLogin); 
            return view;
        }
    }
}