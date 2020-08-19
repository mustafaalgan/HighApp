using Plugin.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HighApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Fast_Food : ContentPage
    {
        public Fast_Food()
        {
            InitializeComponent();
        }
        private void Yayla_Ara(object sender, EventArgs e)
        {
            var arama = CrossMessaging.Current.PhoneDialer;
            if (arama.CanMakePhoneCall)
            {
                arama.MakePhoneCall("05325727052");
            }
        }
        async void Yayla_Konum(object sender, EventArgs e)
        {
            if (Device.RuntimePlatform == Device.iOS)
            {
                await Launcher.OpenAsync("https://maps.apple.com/?ll=37.145610,29.509010&q=Marked%20Location&_ext=EiYp2YNaDqCSQkAxIyER2ZuBPUA5V1mAasaTQkBBaz38dn6EPUBQBA%3D%3D&t=m");
            }
            else if (Device.RuntimePlatform == Device.Android)
            {
                await Launcher.OpenAsync("https://www.google.com/maps/place/Yayla+Kahvalti+Tost/@37.1454536,29.5085046,19z/data=!3m1!4b1!4m5!3m4!1s0x14c121553e42baa7:0xe7176d9c4432b82d!8m2!3d37.1454525!4d29.5090518");
            }
        }
        private void Komage_Ara(object sender, EventArgs e)
        {
            var arama = CrossMessaging.Current.PhoneDialer;
            if (arama.CanMakePhoneCall)
            {
                arama.MakePhoneCall("05443463264");
            }
        }
        async void Komagene_Konum(object sender, EventArgs e)
        {
            if (Device.RuntimePlatform == Device.iOS)
            {
                await Launcher.OpenAsync("https://maps.apple.com/?ll=37.142690,29.507680&q=Marked%20Location&_ext=EiYp2YNaDqCSQkAxIyER2ZuBPUA5V1mAasaTQkBBaz38dn6EPUBQBA%3D%3D&t=m");
            }
            else if (Device.RuntimePlatform == Device.Android)
            {
                await Launcher.OpenAsync("https://www.google.com/maps/place/Komagene+%C3%87i%C4%9F+K%C3%B6fte/@37.1454536,29.5085046,19z/data=!4m5!3m4!1s0x14c12154323ed553:0xeb78394ba3f653eb!8m2!3d37.1427724!4d29.5075872");
            }
        }
        private void Evim_Ara(object sender, EventArgs e)
        {
            var arama = CrossMessaging.Current.PhoneDialer;
            if (arama.CanMakePhoneCall)
            {
                arama.MakePhoneCall("05424826961");
            }
        }
        async void Evim_Konum(object sender, EventArgs e)
        {
            if (Device.RuntimePlatform == Device.iOS)
            {
                await Launcher.OpenAsync("https://maps.apple.com/place?q=Evim%20%C3%87ay%20Ve%20Tost%20Salonu&auid=15431748089829097375&address=Cumhuriyet%20Caddesi%20117A,%2015400%20G%C3%B6lhisar%20Burdur,%20Turkey&ll=37.142149,29.507974");
            }
            else if (Device.RuntimePlatform == Device.Android)
            {
                await Launcher.OpenAsync("https://www.google.com/maps/place/Evim+%C3%87ay+Tost+Salonu/@37.1421892,29.5072905,19z/data=!4m5!3m4!1s0x14c121542abf04ff:0x9bdc3aae2fede4c6!8m2!3d37.1420768!4d29.5077934");
            }
        }
        async void Vitamin_Bar_Konum(object sender, EventArgs e)
        {
            if (Device.RuntimePlatform == Device.iOS)
            {
                await Launcher.OpenAsync("https://maps.apple.com/?ll=37.145280,29.508860&q=Marked%20Location&_ext=EiYp2YNaDqCSQkAxIyER2ZuBPUA5V1mAasaTQkBBaz38dn6EPUBQBA%3D%3D&t=m");
            }
            else if (Device.RuntimePlatform == Device.Android)
            {
                await Launcher.OpenAsync("https://www.google.com/maps/place/Vitamin+bar/@37.1452317,29.5086466,20z/data=!4m5!3m4!1s0x14c121945033d747:0x121e0030bec99896!8m2!3d37.1452643!4d29.5088628");
            }
        }
        async void Hanimeli_Konum(object sender, EventArgs e)
        {
            if (Device.RuntimePlatform == Device.iOS)
            {
                await Launcher.OpenAsync("https://maps.apple.com/?ll=37.145210,29.508850&q=Marked%20Location&_ext=EiYp2YNaDqCSQkAxIyER2ZuBPUA5V1mAasaTQkBBaz38dn6EPUBQBA%3D%3D&t=m");
            }
            else if (Device.RuntimePlatform == Device.Android)
            {
                await Launcher.OpenAsync("https://www.google.com.tr/maps/place/BURUKS+B%C4%B0STRO/@37.1449479,29.5064338,17z/data=!3m1!4b1!4m5!3m4!1s0x14c121163d875fa1:0xf7f6947620786ae8!8m2!3d37.1449479!4d29.5086225?hl=tr");
            }
        }
    }
}