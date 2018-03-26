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
    [Activity(Label = "Activity2")]
    public class Activity2 : Activity
    {
        List<string> Spesa; // lista che contiene tutti gli elementi selezionabili 
        List<string> SpesaConfermata; // lista che contiene gli elementi selezionati
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Activity2);
            Button conferma = FindViewById<Button>(Resource.Id.conferma);
            ListView selezione = FindViewById<ListView>(Resource.Id.listadacreare);
            
            // init e aggiunta elementi
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

            SpesaConfermata = new List<string>();

            ArrayAdapter arrayAdapter = new ArrayAdapter<String>(this, Android.Resource.Layout.SelectDialogMultiChoice, Spesa);
            selezione.Adapter = arrayAdapter;
            selezione.ChoiceMode = ChoiceMode.Multiple;
            Intent avvia;
            conferma.Click += delegate
            {
                SpesaConfermata.Clear();
                for (int i = 0; i < Spesa.Count; i++)
                {
                    if (selezione.IsItemChecked(i))
                    {
                        SpesaConfermata.Append(Spesa[i]);
                    }
                }
                if (SpesaConfermata.Count == 0)
                {

                }
                else
                {
                    avvia = new Intent(this, typeof(Activity3));
                    avvia.PutStringArrayListExtra("lista", SpesaConfermata);
                    StartActivity(avvia);
                    SpesaConfermata.Clear();
                }
            };
        }
    }
}