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
    public partial class Hakkimizda : ContentPage
    {
        public Hakkimizda()
        {
            InitializeComponent();
        }
        private async void Tesekkurler(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Tesekkurler());

        }
        private async void Highapp(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Highapp());

        }
        
    }
}