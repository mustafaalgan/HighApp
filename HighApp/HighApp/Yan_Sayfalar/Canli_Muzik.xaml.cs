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
    public partial class Canli_Muzik : ContentPage
    {
        public Canli_Muzik()
        {
            InitializeComponent();
        }

        private void Ardic_Web(object sender, EventArgs e)
        {
            var browser = new WebView();

            browser.Source = "https://ardicafe15.wixsite.com/ardic";

            Content = browser;
        }
        async void Ardic_Konum(object sender, EventArgs e)
        {
            if (Device.RuntimePlatform == Device.iOS)
            {
                await Launcher.OpenAsync("https://maps.apple.com/place?q=Ard%C4%B1%C3%A7%20Cafe&auid=18048189572136510357&address=Cumhuriyet%20Meydan%C4%B1%202,%2015400%20G%C3%B6lhisar%20Burdur,%20Turkey&ll=37.150829,29.511213");
            }
            else if (Device.RuntimePlatform == Device.Android)
            {
                await Launcher.OpenAsync("https://www.google.com/maps/place/Ard%C4%B1%C3%A7+Cafe+Bistro/@37.150831,29.5089603,17z/data=!3m1!4b1!4m5!3m4!1s0x14c12401f8b46a03:0x1abaca5179e26499!8m2!3d37.150831!4d29.511149");
            }
        }
        private void BigBaba_Web(object sender, EventArgs e)
        {
            var browser = new WebView();

            browser.Source = "https://ardicafe15.wixsite.com/ardic";

            Content = browser;
        }

        async void BigBaba_Konum(object sender, EventArgs e)
        {
            if (Device.RuntimePlatform == Device.iOS)
            {
                await Launcher.OpenAsync("https://maps.apple.com/?ll=37.141000,29.511640&q=Marked%20Location&_ext=EiYp2YNaDqCSQkAxIyER2ZuBPUA5V1mAasaTQkBBaz38dn6EPUBQBA%3D%3D&t=m");
            }
            else if (Device.RuntimePlatform == Device.Android)
            {
                await Launcher.OpenAsync("https://www.google.com/maps/place/Bigbaba+f%C4%B1r%C4%B1n+%26+cafe/@37.1409839,29.50945,17z/data=!3m1!4b1!4m5!3m4!1s0x14c123f14572fe6b:0xa1dc9ebacea2859d!8m2!3d37.1409839!4d29.5116387");
            }
        }
    }
}