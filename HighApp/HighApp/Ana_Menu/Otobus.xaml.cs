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
    public partial class Otobus : ContentPage
    {
        public Otobus()
        {
            InitializeComponent();
        }

        private async void Halk_Otobus(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Halk_Otobusu());
        }
        private async void Goltur(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Goltur());
        }
    }
}