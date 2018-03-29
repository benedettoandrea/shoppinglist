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
    [Activity(Label = "Lista corrente")]
    public class Activity3 : Activity
    {
        ListView visualizza;
        IList<string> listavisualizza;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Activity3);
            visualizza = FindViewById<ListView>(Resource.Id.listacreata);

            listavisualizza = new List<string>();
            listavisualizza = Intent.GetStringArrayListExtra("lista");
            
            visualizza.Adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SelectDialogMultiChoice, listavisualizza);
            visualizza.ChoiceMode = ChoiceMode.Multiple;
        }
    }
}