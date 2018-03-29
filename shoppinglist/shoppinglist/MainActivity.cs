using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace shoppinglist
{
    [Activity(Label = "shoppinglist", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);
            Button crea = FindViewById<Button>(Resource.Id.crea);
            Button recupera = FindViewById<Button>(Resource.Id.recupera);
            Intent avvia;
            crea.Click += delegate
            {
                avvia = new Intent(this, typeof(Activity2));
                StartActivity(avvia);
            };
            recupera.Click += delegate
            {
                Toast.MakeText(this, "questa funzionalità è attualmente non disponibile", ToastLength.Long).Show();
            };
        }
    }
}

