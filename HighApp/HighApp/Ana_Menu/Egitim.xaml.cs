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
    public partial class Egitim : ContentPage
    {
        public Egitim()
        {
            InitializeComponent();
        }
        private async void Maku(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Maku());
        }
        private async void Surucu_Kursu(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Surucu_Kursu());
        }
        
    }
}