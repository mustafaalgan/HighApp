using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HighApp.Yan_Sayfalar
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Highapp : ContentPage
    {
        public Highapp()
        {
            InitializeComponent();
        }

        [Obsolete]
        private void Bize_Ulasin(object sender, EventArgs e)
         {
            if (Device.RuntimePlatform == Device.iOS)
            {
                Device.OpenUri(new Uri("mailto:isem.highapp@gmail.com"));
            }
            else if (Device.RuntimePlatform == Device.Android)
            {
                Device.OpenUri(new Uri("mailto:isem.highapp@gmail.com"));
            }
        }
        async void Instagram(object sender, EventArgs e)
        {
            if (Device.RuntimePlatform == Device.iOS)
            {
                await Launcher.OpenAsync("http://instagram.com/highapponline");
            }
            else if (Device.RuntimePlatform == Device.Android)
            {
                await Launcher.OpenAsync("http://instagram.com/highapponline");
            }
        }
    }
}