using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HighApp.Web_View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class E_Belediye : ContentPage
    {
        public E_Belediye()
        {
            InitializeComponent();

            if (Device.RuntimePlatform == Device.iOS)
            {

                Launcher.OpenAsync("https://www.turkiye.gov.tr/golhisar-belediyesi");
            }
            else if (Device.RuntimePlatform == Device.Android)
            {
                // opens the Maps app directly
                Launcher.OpenAsync("https://www.turkiye.gov.tr/golhisar-belediyesi");
            }
        }
    }
}