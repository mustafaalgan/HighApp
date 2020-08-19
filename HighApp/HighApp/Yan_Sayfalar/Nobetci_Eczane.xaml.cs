using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HighApp.Yan_Sayfalar
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Nobetci_Eczane : ContentPage
    {
        public Nobetci_Eczane()
        {
            InitializeComponent();
            var browser = new WebView();

            browser.Source = "https://www.eczaneler.gen.tr/nobetci-burdur-golhisar";

            Content = browser;
        }
    }
}