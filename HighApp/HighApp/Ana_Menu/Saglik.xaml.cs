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
    public partial class Saglik : ContentPage
    {
        public Saglik()
        {
            InitializeComponent();
        }
        private async void Saglik_Kurumlari(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Saglik_Kurumlari());

        }
        private async void Eczane(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Eczane());

        }
        private async void Nobetci_Eczane(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Nobetci_Eczane());

        }
        private async void Optik(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Optik());

        }
        private async void Vucut_Kitle_İndeks(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Vucut_Kitle_İndeks());

        }
    }
}