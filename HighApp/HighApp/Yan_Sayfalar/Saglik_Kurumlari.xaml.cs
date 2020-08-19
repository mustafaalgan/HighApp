using HighApp.Yan_Sayfalar;
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
    public partial class Saglik_Kurumlari : ContentPage
    {
        public Saglik_Kurumlari()
        {
            InitializeComponent();
        }
        private async void Hastane(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Hastane());

        }
        async void Hastane_Konum(object sender, EventArgs e)
        {
            if (Device.RuntimePlatform == Device.iOS)
            {
                await Launcher.OpenAsync("https://maps.apple.com/?address=Cumhuriyet%20Caddesi%2074,%2015400%20G%C3%B6lhisar%20Burdur,%20T%C3%BCrkiye&auid=1574428339400754233&ll=37.144732,29.507770&lsp=9902&q=G%C3%B6lhisar%20Devlet%20Hastanesi&_ext=ChkKBQgEENwBCgQIBRADCgQIBhAKCgQIChAAEiYpXZDjLhOSQkAx7Z5wGdOAPUA522UJizmTQkBBPyCcrLWDPUBQBA%3D%3D");
            }
            else if (Device.RuntimePlatform == Device.Android)
            {
                await Launcher.OpenAsync("https://www.google.com/maps/place/Fatih,+G%C3%B6lhisar+Devlet+Hst.,+15400+G%C3%B6lhisar%2FBurdur/@37.1443683,29.5057145,17z/data=!4m5!3m4!1s0x14c1215500d074ff:0x78d9b3b47a1b976a!8m2!3d37.1443683!4d29.5079032");
            }
        }
    }
}