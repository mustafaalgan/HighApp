using HighApp.Web_View;
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
    public partial class Duyuru : ContentPage
    {
        public Duyuru()
        {
            InitializeComponent();
        }
        private async void Belediye(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Belediye());
        }
        private async void Hava_Durumu(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Hava_Durum());
        }
    }
}