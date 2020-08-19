using HighApp.Yan_Sayfalar;
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
    public partial class Eglence : ContentPage
    {
        public Eglence()
        {
            InitializeComponent();
        }
        private async void Canli_Muzik(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Canli_Muzik());

        }
        private async void Kafeler(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Kafeler());

        }
        private async void Oyun_Salon(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Oyun_Salon());

        }
    }
}