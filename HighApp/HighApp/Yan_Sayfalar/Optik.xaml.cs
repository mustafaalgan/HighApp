using Plugin.Messaging;
using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HighApp.Yan_Sayfalar
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Optik : ContentPage
    {
        public Optik()
        {
            InitializeComponent();
        }

        private void Golhisar_Optik_Ara(object sender, EventArgs e)
        {
            var arama = CrossMessaging.Current.PhoneDialer;
            if(arama.CanMakePhoneCall)
            {
                arama.MakePhoneCall("05447214690");
            }
        }

        async void Golhisar_Optik_Konum(object sender, EventArgs e)
        {
            if (Device.RuntimePlatform == Device.iOS)
            {
                await Launcher.OpenAsync("https://maps.apple.com/place?q=G%C3%B6lhisar%20Optik&auid=7247009012475592108&address=Cumhuriyet%20Caddesi%2095B,%2015400%20G%C3%B6lhisar%20Burdur,%20Turkey&ll=37.144095,29.508631");
            }
            else if (Device.RuntimePlatform == Device.Android)
            {
                await Launcher.OpenAsync("https://www.google.com/maps/place/G%C3%B6lhisar+Optik+Ahmet+Atapek/@37.144135,29.5085533,21z/data=!4m13!1m7!3m6!1s0x0:0x0!2zMzfCsDA4JzM4LjMiTiAyOcKwMzAnMzAuNCJF!3b1!8m2!3d37.14398!4d29.50844!3m4!1s0x0:0x7cdfd8c501acd80f!8m2!3d37.1441172!4d29.5085469");
            }
        }

        private void Mesut_Optik_Ara(object sender, EventArgs e)
        {
            var arama = CrossMessaging.Current.PhoneDialer;
            if (arama.CanMakePhoneCall)
            {
                arama.MakePhoneCall("05312433003");
            }
        }
        async void Mesut_Optik_Konum(object sender, EventArgs e)
        {
            if (Device.RuntimePlatform == Device.iOS)
            {
                await Launcher.OpenAsync("https://maps.apple.com/place?q=Mesut%20Optik&auid=4628537352285846531&address=Cumhuriyet%20Caddesi%2084B,%2015400%20G%C3%B6lhisar%20Burdur,%20Turkey&ll=37.143533,29.507904");
            }
            else if (Device.RuntimePlatform == Device.Android)
            {
                await Launcher.OpenAsync("https://www.google.com/maps/place/Mesut+Optik+G%C3%B6lhisar/@37.143609,29.5075238,19z/data=!3m1!4b1!4m13!1m7!3m6!1s0x0:0x0!2zMzfCsDA4JzM3LjAiTiAyOcKwMzAnMjkuMSJF!3b1!8m2!3d37.14362!4d29.50807!3m4!1s0x14c12155b3ab70f9:0xea61240ad47f11bf!8m2!3d37.143609!4d29.508071");
            }
        }

        private void Vizyon_Optik_Ara(object sender, EventArgs e)
        {
            var arama = CrossMessaging.Current.PhoneDialer;
            if (arama.CanMakePhoneCall)
            {
                arama.MakePhoneCall("05439115362");
            }
        }

        async void Vizyon_Optik_Konum(object sender, EventArgs e)
        {
            if (Device.RuntimePlatform == Device.iOS)
            {
                await Launcher.OpenAsync("https://maps.apple.com/place?q=Vizyon%20Optik&auid=16272773177400800029&address=Cumhuriyet%20Caddesi%2089B,%2015400%20G%C3%B6lhisar%20Burdur,%20Turkey&ll=37.144704,29.508846");
            }
            else if (Device.RuntimePlatform == Device.Android)
            {
                await Launcher.OpenAsync("https://www.google.com/maps/place/V%C4%B0ZYON+OPT%C4%B0K/@37.144801,29.5081898,19z/data=!3m1!4b1!4m13!1m7!3m6!1s0x0:0x0!2zMzfCsDA4JzQxLjMiTiAyOcKwMzAnMzEuNSJF!3b1!8m2!3d37.14481!4d29.50874!3m4!1s0x14c121550fd76d3b:0xb15c3edccf69ab8d!8m2!3d37.144801!4d29.508737");
            }
        }
        private void Vural_Optik_Ara(object sender, EventArgs e)
        {
            var arama = CrossMessaging.Current.PhoneDialer;
            if (arama.CanMakePhoneCall)
            {
                arama.MakePhoneCall("05435273132");
            }
        }
        async void Vural_Optik_Konum(object sender, EventArgs e)
        {
            if (Device.RuntimePlatform == Device.iOS)
            {
                await Launcher.OpenAsync("https://maps.apple.com/place?q=Vural%20Optik&auid=4216683430070860192&address=Cumhuriyet%20Caddesi%2088,%2015400%20G%C3%B6lhisar%20Burdur,%20Turkey&ll=37.143351,29.50788");
            }
            else if (Device.RuntimePlatform == Device.Android)
            {
                await Launcher.OpenAsync("https://www.google.com/maps/place/VURAL+OPT%C4%B0K/@37.1434061,29.5074014,19z/data=!3m1!4b1!4m5!3m4!1s0x14c12155b4c10b53:0xc6548c69be450665!8m2!3d37.1434061!4d29.5079486");
            }
        }
        private void Yeni_Gulen_Optik_Ara(object sender, EventArgs e)
        {
            var arama = CrossMessaging.Current.PhoneDialer;
            if (arama.CanMakePhoneCall)
            {
                arama.MakePhoneCall("02484114456");
            }
        }
        async void Yeni_Gulen_Optik_Konum(object sender, EventArgs e)
        {
            if (Device.RuntimePlatform == Device.iOS)
            {
                await Launcher.OpenAsync("https://maps.apple.com/place?q=G%C3%BClem%20Optik&auid=2343062004217043276&address=Cumhuriyet%20Caddesi%2095B,%2015400%20G%C3%B6lhisar%20Burdur,%20Turkey&ll=37.144117,29.508641");
            }
            else if (Device.RuntimePlatform == Device.Android)
            {
                await Launcher.OpenAsync("https://www.google.com/maps/place/G%C3%BClem+Optik/@37.4576145,30.5928604,21z/data=!4m5!3m4!1s0x14c441247a09ab0d:0xca4d3f894b929734!8m2!3d37.4575655!4d30.5929804");
            }
        }
    }
}