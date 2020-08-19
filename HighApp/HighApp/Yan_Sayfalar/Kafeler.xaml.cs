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
    public partial class Kafeler : ContentPage
    {
        public Kafeler()
        {
            InitializeComponent();
        }
        private void Cadde_Web(object sender, EventArgs e)
        {
            var browser = new WebView();

            browser.Source = "https://caddekafe15.wixsite.com/caddeyeni";

            Content = browser;
        }
        async void Cadde_Konum(object sender, EventArgs e)
        {
            if (Device.RuntimePlatform == Device.iOS)
            {
                await Launcher.OpenAsync("https://maps.apple.com/?ll=37.142180,29.507810&q=Marked%20Location&_ext=EiYp2YNaDqCSQkAxIyER2ZuBPUA5V1mAasaTQkBBaz38dn6EPUBQBA%3D%3D&t=m");
            }
            else if (Device.RuntimePlatform == Device.Android)
            {
                await Launcher.OpenAsync("https://www.google.com.tr/maps/place/Cadde+Cafe+G%C3%B6lhisar/@37.1490971,29.507969,17z/data=!3m1!4b1!4m5!3m4!1s0x14c127e062c5efc1:0x1ed21b8b753d62a6!8m2!3d37.1490971!4d29.5101577?hl=tr");
            }
        }
        private void BigBaba_Web(object sender, EventArgs e)
        {
            var browser = new WebView();

            browser.Source = "https://bigbaba15.wixsite.com/bigbaba";

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
        private void Memis_Web(object sender, EventArgs e)
        {
            var browser = new WebView();

            browser.Source = "https://memiscorekotu.wixsite.com/memis";

            Content = browser;
        }
        async void Memis_Konum(object sender, EventArgs e)
        {
            if (Device.RuntimePlatform == Device.iOS)
            {
                await Launcher.OpenAsync("https://maps.apple.com/place?q=Memi%C5%9F%27in%20%C3%87%C3%B6rotu%20Gavesi&auid=13199208618022151919&address=Cumhuriyet%20Caddesi%2061,%2015400%20G%C3%B6lhisar%20Burdur,%20Turkey&ll=37.155386,29.514068");
            }
            else if (Device.RuntimePlatform == Device.Android)
            {
                await Launcher.OpenAsync("https://www.google.com/maps/place/Memi%C5%9Fin+%C3%87%C3%B6rotu+Gavesi/@37.1554174,29.5118809,17z/data=!3m1!4b1!4m5!3m4!1s0x14c1241cd11bb123:0xcd2fa5c3e098bf2e!8m2!3d37.1554174!4d29.5140696");
            }
        }
      
    }
}