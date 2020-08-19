using HighApp.Web_View;
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
    public partial class Kurumsal : ContentPage
    {
        public Kurumsal()
        {
            InitializeComponent();
        }
        private async void Baskan(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Baskan());

        }

        private async void E_Belediye(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new E_Belediye());

        }
        private async void Kaymakamlik(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Kaymakamlik());

        }
        private async void MEB(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Meb());

        }

    }
}