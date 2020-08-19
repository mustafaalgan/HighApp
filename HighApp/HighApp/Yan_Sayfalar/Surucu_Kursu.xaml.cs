using Plugin.Messaging;
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
    public partial class Surucu_Kursu : ContentPage
    {
        public Surucu_Kursu()
        {
            InitializeComponent();
        }
        private void Seref_Ara(object sender, EventArgs e)
        {
            var arama = CrossMessaging.Current.PhoneDialer;
            if (arama.CanMakePhoneCall)
            {
                arama.MakePhoneCall("02484112057");
            }
        }
        async void Seref_Konum(object sender, EventArgs e)
        {
            if (Device.RuntimePlatform == Device.iOS)
            {
            
                await Launcher.OpenAsync("https://maps.apple.com/place?q=%C3%96zel%20%C5%9Eeref%20S%C3%BCr%C3%BCc%C3%BC%20Kursu&auid=14226678173718639915&address=Cumhuriyet%20Caddesi%20205,%2015400%20G%C3%B6lhisar%20Burdur,%20Turkey&ll=37.143232,29.508288");
            }
            else if (Device.RuntimePlatform == Device.Android)
            {
                // opens the Maps app directly
                await Launcher.OpenAsync("https://www.google.com/maps/place/%C3%96zel+%C5%9Eeref+S%C3%BCr%C3%BCc%C3%BC+Kursu/@37.143118,29.5076398,19z/data=!3m1!4b1!4m13!1m7!3m6!1s0x0:0x0!2zMzfCsDA4JzM1LjMiTiAyOcKwMzAnMjkuNSJF!3b1!8m2!3d37.14313!4d29.50819!3m4!1s0x14c12155ca087901:0x88a5a9ce01ff110e!8m2!3d37.143118!4d29.508187");
            }
        }
        private void Oz_Cinar_Ara(object sender, EventArgs e)
        {
            var arama = CrossMessaging.Current.PhoneDialer;
            if (arama.CanMakePhoneCall)
            {
                arama.MakePhoneCall("05366094241");
            }
        }
        async void Oz_Cinar_Konum(object sender, EventArgs e)
        {
            if (Device.RuntimePlatform == Device.iOS)
            {
                await Launcher.OpenAsync("https://maps.apple.com/place?q=%C3%96zel%20%C3%96z%C3%A7%C4%B1nar%20S%C3%BCr%C3%BCc%C3%BC%20Kursu&auid=16529021647879358423&address=Selvi%20Sokak%202,%2015400%20G%C3%B6lhisar%20Burdur,%20Turkey&ll=37.145521,29.508632");
            }
            else if (Device.RuntimePlatform == Device.Android)
            {
                // opens the Maps app directly
                await Launcher.OpenAsync("https://www.google.com.tr/maps/place/%C3%96z%C3%A7%C4%B1nar+S%C3%BCr%C3%BCc%C3%BC+Kursu+G%C3%B6lhisar/@37.1454746,29.5080421,19z/data=!4m8!1m2!2m1!1s%C5%9Eahan+%C4%B0%C5%9F+Merkezi,+Fatih+Mahallesi+Cumhuriyet+Caddesi,+Selvi+Sk.,+15400+G%C3%B6lhisar%2FBurdur!3m4!1s0x0:0xb1cfc7f0dcb4beb1!8m2!3d37.1454263!4d29.5086864");
            }
        }
    }
}