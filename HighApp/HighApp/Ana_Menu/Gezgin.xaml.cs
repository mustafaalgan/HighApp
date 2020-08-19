using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HighApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Gezgin : ContentPage
    {
        public Gezgin()
        {
            InitializeComponent();
        }
        private async void Kibyra_Ac(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Kibyra_Ac());
        }
        async void Kibyra_Konum(object sender, EventArgs e)
        {
            if (Device.RuntimePlatform == Device.iOS)
            {
                await Launcher.OpenAsync("https://maps.apple.com/place?q=Kibyra%20Antik%20Kenti&auid=276578367721899226&address=15400%20G%C3%B6lhisar%20Burdur,%20Turkey&ll=37.15826443979121,29.496445655822754");
            }
            else if (Device.RuntimePlatform == Device.Android)
            {
                await Launcher.OpenAsync("https://www.google.com/maps/place/Kibyra+Ancient+City/@37.156843,29.4974933,17z/data=!3m1!4b1!4m5!3m4!1s0x14c126afd17310a9:0xe3237dba047cc568!8m2!3d37.156843!4d29.499682");
            }
        }

        private async void Golhisar_Ac(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Golhisar_Ac());
        }
        async void Golhisar_Konum(object sender, EventArgs e)
        {
            if (Device.RuntimePlatform == Device.iOS)
            {
                await Launcher.OpenAsync("https://maps.apple.com/place?q=G%C3%B6lhisar%20Belediyesi&auid=2309188084468907668&address=Cumhuriyet%20Caddesi%2093,%2015400%20G%C3%B6lhisar%20Burdur,%20Turkey&ll=37.144296,29.508711");
            }
            else if (Device.RuntimePlatform == Device.Android)
            {
                await Launcher.OpenAsync("https://www.google.com/maps/place/Pazar,+G%C3%B6lhisar+Belediyesi,+15400+G%C3%B6lhisar%2FBurdur/@37.1441888,29.5064522,17z/data=!3m1!4b1!4m5!3m4!1s0x14c12155a7e95721:0x50989692b80cac5d!8m2!3d37.1441888!4d29.5086409");
            }
        }


        private async void Yayla_Ac(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Yayla_Ac());
        }
        async void Yaylalar_Konum(object sender, EventArgs e)
        {
            if (Device.RuntimePlatform == Device.iOS)
            {
                await Launcher.OpenAsync("https://maps.apple.com/?ll=37.163180,29.464590&q=Marked%20Location&_ext=EiYp2YNaDqCSQkAxIyER2ZuBPUA5V1mAasaTQkBBaz38dn6EPUBQBA%3D%3D&t=m");
            }
            else if (Device.RuntimePlatform == Device.Android)
            {
                await Launcher.OpenAsync("https://www.google.com/maps/place/G%C3%B6lhisar+B%C3%B6%C4%9Fr%C3%BCdelik+yaylas%C4%B1/@37.1630858,29.4624022,17z/data=!3m1!4b1!4m5!3m4!1s0x14c127dd560eb281:0x4f3205594b36787c!8m2!3d37.1630858!4d29.4645909");
            }
        }



        private async void Gol_Ac(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Gol_Ac());
        }
        async void Gol_Konum(object sender, EventArgs e)
        {
            if (Device.RuntimePlatform == Device.iOS)
            {
                await Launcher.OpenAsync("https://maps.apple.com/?ll=37.156860,29.499680&q=Marked%20Location&_ext=EiYp2YNaDqCSQkAxIyER2ZuBPUA5V1mAasaTQkBBaz38dn6EPUBQBA%3D%3D&t=m");
            }
            else if (Device.RuntimePlatform == Device.Android)
            {
                await Launcher.OpenAsync("https://www.google.com/maps/place/G%C3%B6lhisar+Lake/@37.1173342,29.5923702,15z/data=!3m1!4b1!4m5!3m4!1s0x14c123549eae68df:0x325f5b12c8ea54bb!8m2!3d37.1142198!4d29.6006511");
            }
        }
    }
}