using Plugin.Messaging;
using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HighApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Restoran : ContentPage
    {
        public Restoran()
        {
            InitializeComponent();
        }
        private void Kosk_Restoran_Web(object sender, EventArgs e)
        {
            var browser = new WebView();

            browser.Source = "https://koskrestaurant15.wixsite.com/koskrestaurant15";

            Content = browser;
        }
        private void Kosk_Restoran_Ara(object sender, EventArgs e)
        {

            var arama = CrossMessaging.Current.PhoneDialer;
            if (arama.CanMakePhoneCall)
            {
                arama.MakePhoneCall("02484112220");
            }
        }
        async void Kosk_Restoran_Konum(object sender, EventArgs e)
        {
            if (Device.RuntimePlatform == Device.iOS)
            {

                await Launcher.OpenAsync("https://maps.apple.com/place?q=K%C3%B6%C5%9Fk%20Restoran&auid=16682977221937197536&address=130.%20Sokak%206A,%2015400%20G%C3%B6lhisar%20Burdur,%20Turkey&ll=37.142661,29.507025");
            }
            else if (Device.RuntimePlatform == Device.Android)
            {
                await Launcher.OpenAsync("https://www.google.com/maps/place/K%C3%96%C8%98K+RESTAURANT/@37.1426201,29.5065602,19z/data=!3m1!4b1!4m13!1m7!3m6!1s0x0:0x0!2zMzfCsDA4JzMzLjUiTiAyOcKwMzAnMjUuNiJF!3b1!8m2!3d37.14263!4d29.50711!3m4!1s0x14c12154285c42cb:0xe35c892bed38df06!8m2!3d37.1426201!4d29.5071074");            }
        }




        private void İkincibahar_Restoran_Web(object sender, EventArgs e)
        {
          
            var browser = new WebView();

            browser.Source = "https://ikincibahar1515.wixsite.com/ikincibahar";

            Content = browser;
        }
        private void İkincibahar_Restoran_Ara(object sender, EventArgs e)
        {
           
            var arama = CrossMessaging.Current.PhoneDialer;
            if (arama.CanMakePhoneCall)
            {
                arama.MakePhoneCall("02484112545");
            }
        }
        async void İkincibahar_Restoran_Konum(object sender, EventArgs e)
        {
            if (Device.RuntimePlatform == Device.iOS)
            {

                await Launcher.OpenAsync("https://maps.apple.com/place?q=%C4%B0kinci%20Bahar%20Aile%20Lokantas%C4%B1&auid=8163742198335515480&address=Hal%20Sokak%207,%2015400%20G%C3%B6lhisar%20Burdur,%20Turkey&ll=37.150298,29.512516");
            }
            else if (Device.RuntimePlatform == Device.Android)
            {
                // opens the Maps app directly
                await Launcher.OpenAsync("https://www.google.com/maps/place/%C4%B0kinci+Bahar+Aile+restoran/@37.150279,29.5119868,19z/data=!3m1!4b1!4m13!1m7!3m6!1s0x0:0x0!2zMzfCsDA5JzAxLjAiTiAyOcKwMzAnNDUuMSJF!3b1!8m2!3d37.15029!4d29.51253!3m4!1s0x14c124018be86f53:0xbc7be797a038de00!8m2!3d37.150279!4d29.512534");
            }
        }

        

        private void Kavurmaci_Osman_Web(object sender, EventArgs e)
        {
            var browser = new WebView();

            browser.Source = "https://kavurmaciosman15.wixsite.com/kavurmaciosman";

            Content = browser;
        }
        async void Kavurmaci_Osman_Konum(object sender, EventArgs e)
        {
            if (Device.RuntimePlatform == Device.iOS)
            {

                await Launcher.OpenAsync("https://maps.apple.com/?ll=37.150350,29.511800&q=Marked%20Location&_ext=EiYp2YNaDqCSQkAxIyER2ZuBPUA5V1mAasaTQkBBaz38dn6EPUBQBA%3D%3D&t=m");
            }
            else if (Device.RuntimePlatform == Device.Android)
            {
                await Launcher.OpenAsync("https://www.google.com/maps/place/Kavurmaci+osman+kaya/@37.15028,29.5120092,21z/data=!4m5!3m4!1s0x14c125fe76809d45:0xf7f61ac9852d3bf3!8m2!3d37.1503788!4d29.511812");
            }

        }
    }
}