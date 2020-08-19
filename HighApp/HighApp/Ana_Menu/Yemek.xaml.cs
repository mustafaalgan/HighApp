using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HighApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Yemek : ContentPage
    {
        public Yemek()
        {
            InitializeComponent();
        }

        private async void Yoresel_Lezzet(object sender, EventArgs e)
        {
           
                await Navigation.PushAsync(new Yoresel_Lezzet());
            
        }
        private async void Fast_Food(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Fast_Food());

        }
        private async void Restoran(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Restoran());

        }
    }
}