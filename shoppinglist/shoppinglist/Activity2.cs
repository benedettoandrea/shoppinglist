using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace shoppinglist
{
    class Activity2 : Activity
    {
        private List<string> Spesa; //lista che contiene tutti gli elementi selezionabili 

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);
            //init e aggiunta elementi
            Spesa = new List<String>();
            Spesa.Add("pane");
            Spesa.Add("burro");
            Spesa.Add("latte");
            Spesa.Add("acqua");
            Spesa.Add("biscotti");
            Spesa.Add("vino");
            Spesa.Add("birra");
            Spesa.Add("yogurt");
            Spesa.Add("formaggio");
            Spesa.Add("carne");
            Spesa.Add("insalata");
            Spesa.Add("torta");
        }
}