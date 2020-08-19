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
    public partial class Eczane : ContentPage
    {
        public Eczane()
        {
            InitializeComponent();
        }
        private void Asri_Eczane_Ara(object sender, EventArgs e)
        {
            var arama = CrossMessaging.Current.PhoneDialer;
            if (arama.CanMakePhoneCall)
            {
                arama.MakePhoneCall("02484113141");
            }
        }
        async void Asri_Eczane_Konum(object sender, EventArgs e)
        {
            if (Device.RuntimePlatform == Device.iOS)
            {
                await Launcher.OpenAsync("https://maps.apple.com/place?q=Asri%20Eczanesi&auid=10830473836404784249&address=Turgut%20%C3%96zal%20Caddesi%2095,%2015400%20G%C3%B6lhisar%20Burdur,%20Turkey&ll=37.144164,29.508662");
            }
            else if (Device.RuntimePlatform == Device.Android)
            {
                await Launcher.OpenAsync("https://www.google.com/maps/place/Asri+Eczanesi/@37.144206,29.5083403,20.07z/data=!4m5!3m4!1s0x14c42c24311b500d:0x5034b24c79868ff1!8m2!3d37.1442747!4d29.5086364");
            }
        }

        private void Emre_Eczane_Ara(object sender, EventArgs e)
        {
            var arama = CrossMessaging.Current.PhoneDialer;
            if (arama.CanMakePhoneCall)
            {
                arama.MakePhoneCall("02484114544");
            }
        }
        async void Emre_Eczane_Konum(object sender, EventArgs e)
        {
            if (Device.RuntimePlatform == Device.iOS)
            {
                await Launcher.OpenAsync("https://maps.apple.com/?ll=37.145100,29.508860&q=Marked%20Location&_ext=EiYp2YNaDqCSQkAxIyER2ZuBPUA5V1mAasaTQkBBaz38dn6EPUBQBA%3D%3D&t=m");
            }
            else if (Device.RuntimePlatform == Device.Android)
            {
                await Launcher.OpenAsync("https://www.google.com/maps/place/EMRE+ECZANES%C4%B0/@37.1451044,29.5087229,20z/data=!4m12!1m6!3m5!1s0x14c1215511354c1b:0x2fb317ce704bd2a!2sEMRE+ECZANES%C4%B0!8m2!3d37.1450841!4d29.5088635!3m4!1s0x14c1215511354c1b:0x2fb317ce704bd2a!8m2!3d37.1450841!4d29.5088635");
            }
        }


        private void Ercelik_Eczane_Ara(object sender, EventArgs e)
        {
            var arama = CrossMessaging.Current.PhoneDialer;
            if (arama.CanMakePhoneCall)
            {
                arama.MakePhoneCall("02484116160");
            }
        }
        async void Ercelik_Eczane_Konum(object sender, EventArgs e)
        {
            if (Device.RuntimePlatform == Device.iOS)
            {
                await Launcher.OpenAsync("https://maps.apple.com/place?q=Er%C3%A7elik%20Eczanesi&auid=10197940958724438136&address=Cumhuriyet%20Caddesi%20149B,%2015400%20G%C3%B6lhisar%20Burdur,%20Turkey&ll=37.140192,29.507516");
            }
            else if (Device.RuntimePlatform == Device.Android)
            {
                await Launcher.OpenAsync("https://www.google.com/maps/place/Er%C3%A7elik+Eczanesi/@37.1402591,29.5073287,21z/data=!4m12!1m6!3m5!1s0x14c121d614883867:0xd9ffa1c47eeecf0e!2sEr%C3%A7elik+Eczanesi!8m2!3d37.1402394!4d29.5074888!3m4!1s0x14c121d614883867:0xd9ffa1c47eeecf0e!8m2!3d37.1402394!4d29.5074888");
            }
        }


        private void Merkez_Eczane_Ara(object sender, EventArgs e)
        {
            var arama = CrossMessaging.Current.PhoneDialer;
            if (arama.CanMakePhoneCall)
            {
                arama.MakePhoneCall("02484115251");
            }
        }
        async void Merkez_Eczane_Konum(object sender, EventArgs e)
        {
            if (Device.RuntimePlatform == Device.iOS)
            {
                await Launcher.OpenAsync("https://maps.apple.com/place?q=Merkez%20Eczanesi&auid=4847110241349134125&address=Cumhuriyet%20Caddesi%2083B,%2015400%20G%C3%B6lhisar%20Burdur,%20Turkey&ll=37.144922,29.508929");
            }
            else if (Device.RuntimePlatform == Device.Android)
            {
                await Launcher.OpenAsync("https://www.google.com/maps/place/Merkez+Eczanesi/@37.1455096,29.5089058,20z/data=!4m5!3m4!1s0x14c12156fbccf731:0xf7eb5edb45e784bf!8m2!3d37.1455648!4d29.5089838");
            }
        }

        private void Safa_Eczane_Ara(object sender, EventArgs e)
        {
            var arama = CrossMessaging.Current.PhoneDialer;
            if (arama.CanMakePhoneCall)
            {
                arama.MakePhoneCall("02484113883");
            }
        }
        async void Safa_Eczane_Konum(object sender, EventArgs e)
        {
            if (Device.RuntimePlatform == Device.iOS)
            {
                await Launcher.OpenAsync("https://maps.apple.com/?address=Cumhuriyet%20Caddesi%208B,%2015400%20G%C3%B6lhisar%20Burdur,%20T%C3%BCrkiye&auid=16406838111210831786&ll=37.151754,29.511522&lsp=9902&q=Safa%20Eczanesi&_ext=ChkKBQgEENwBCgQIBRADCgQIBhB4CgQIChAAEiYpb9rnfdmSQkAxwZzuyYGBPUA57a8N2v+TQkBBt8E7bGSEPUBQBA%3D%3D");
            }
            else if (Device.RuntimePlatform == Device.Android)
            {
                await Launcher.OpenAsync("https://www.google.com/maps/place/Safa+Eczanesi/@37.1515762,29.5104637,21z/data=!4m5!3m4!1s0x14c12155b115b9d3:0xdf175fd49862ee2a!8m2!3d37.1515752!4d29.5103803");
            }
        }

        private void Sifa_Eczane_Ara(object sender, EventArgs e)
        {
            var arama = CrossMessaging.Current.PhoneDialer;
            if (arama.CanMakePhoneCall)
            {
                arama.MakePhoneCall("02484113421");
            }
        }
        async void Sifa_Eczane_Konum(object sender, EventArgs e)
        {
            if (Device.RuntimePlatform == Device.iOS)
            {
                await Launcher.OpenAsync("https://maps.apple.com/?address=Cumhuriyet%20Caddesi%2093B,%2015400%20G%C3%B6lhisar%20Burdur,%20T%C3%BCrkiye&auid=11041078261932993466&ll=37.144222,29.508686&lsp=9902&q=%C5%9Eifa%20Eczanesi&_ext=ChkKBQgEENwBCgQIBRADCgQIBhB4CgQIChAAEiYpFjw7wOSRQkAxb7E/vcGAPUA5lBFhHAuTQkBBA2PgTKSDPUBQBA%3D%3D");
            }
            else if (Device.RuntimePlatform == Device.Android)
            {
                await Launcher.OpenAsync("https://www.google.com/maps/place/%C5%9Eifa+Eczanesi/@37.1442033,29.50645,17z/data=!3m1!4b1!4m5!3m4!1s0x14c42c24311b500d:0xc123996552970599!8m2!3d37.1442033!4d29.5086387");
            }
        }

        private void Yeni_Eczane_Ara(object sender, EventArgs e)
        {
            var arama = CrossMessaging.Current.PhoneDialer;
            if (arama.CanMakePhoneCall)
            {
                arama.MakePhoneCall("02484113391");
            }
        }
        async void Yeni_Eczane_Konum(object sender, EventArgs e)
        {
            if (Device.RuntimePlatform == Device.iOS)
            {
                await Launcher.OpenAsync("https://maps.apple.com/?address=Cumhuriyet%20Caddesi%2087A,%2015400%20G%C3%B6lhisar%20Burdur,%20T%C3%BCrkiye&auid=5342407742370556860&ll=37.144816,29.508881&lsp=9902&q=Yeni%20Eczanesi&_ext=ChkKBQgEENwBCgQIBRADCgQIBhB4CgQIChAAEiYpYCZA9PWRQkAxEhJeCs+APUA53vtlUByTQkBBQrtOm7GDPUBQBA%3D%3D");
            }
            else if (Device.RuntimePlatform == Device.Android)
            {
                await Launcher.OpenAsync("https://www.google.com/maps/place/Yeni+Eczane/@37.1450019,29.5082002,18.92z/data=!4m5!3m4!1s0x14c1215533fc9c21:0x76797d8e9b8d857f!8m2!3d37.1449076!4d29.508843");
            }
        }
    }
}