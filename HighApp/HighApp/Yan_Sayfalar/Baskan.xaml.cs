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
    public partial class Baskan : ContentPage
    {
        public Baskan()
        {
            InitializeComponent();
        }
        async void Baskan_Face(object sender, EventArgs e)
        {
            if (Device.RuntimePlatform == Device.iOS)
            {
                await Launcher.OpenAsync("https://www.facebook.com/ibrahim.sertbas.94");
            }
            else if (Device.RuntimePlatform == Device.Android)
            {
                await Launcher.OpenAsync("https://www.facebook.com/ibrahim.sertbas.94");
            }
        }
        async void Baskan_WP(object sender, EventArgs e)
        {
            string mobile = "905424353580";
            if (Device.RuntimePlatform == Device.iOS)
            {
                await Launcher.OpenAsync("https://api.whatsapp.com/send?phone=" + mobile);
            }
            else if (Device.RuntimePlatform == Device.Android)
            {
                await Launcher.OpenAsync("https://api.whatsapp.com/send?phone=" + mobile);
            }
        }
        async void Baskan_Instagram(object sender, EventArgs e)
        {
            if (Device.RuntimePlatform == Device.iOS)
            {
                await Launcher.OpenAsync("http://instagram.com/sertbas_ibrahim");
            }
            else if (Device.RuntimePlatform == Device.Android)
            {
                await Launcher.OpenAsync("http://instagram.com/sertbas_ibrahim");
            }
        }
    }
}