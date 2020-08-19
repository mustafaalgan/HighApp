using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HighApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Namaz : ContentPage
    {
        public Namaz()
        {
            InitializeComponent();
            var browser = new WebView();

            browser.Source = "https://namazvakitleri.diyanet.gov.tr/tr-TR/9330/golhisar-icin-namaz-vakti";

            Content = browser;
        }
    }
}