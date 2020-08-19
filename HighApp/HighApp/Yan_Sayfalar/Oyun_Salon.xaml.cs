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
    public partial class Oyun_Salon : ContentPage
    {
        public Oyun_Salon()
        {
            InitializeComponent();
        }
        private void Viyana_Web(object sender, EventArgs e)
        {
            var browser = new WebView();

            browser.Source = "https://uygunfirmalar.com/Firma/viyana-nostalji-cafe.html";

            Content = browser;
        }

        async void Viyana_Konum(object sender, EventArgs e)
        {
            if (Device.RuntimePlatform == Device.iOS)
            {
                await Launcher.OpenAsync("https://maps.apple.com/?ll=37.150530,29.510070&q=Marked%20Location&_ext=EiYp2YNaDqCSQkAxIyER2ZuBPUA5V1mAasaTQkBBaz38dn6EPUBQBA%3D%3D&t=m");
            }
            else if (Device.RuntimePlatform == Device.Android)
            {
                await Launcher.OpenAsync("https://www.google.com/maps/place/Viyananostaljicafe/@37.1506639,29.5097412,21z/data=!4m5!3m4!1s0x14c12765bffae3c9:0x1034dc87c9d8873c!8m2!3d37.150522!4d29.5100699");
            }
        }
    }
}