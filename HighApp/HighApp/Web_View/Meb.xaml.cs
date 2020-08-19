using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HighApp.Web_View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Meb : ContentPage
    {
        public Meb()
        {
            InitializeComponent();

            var browser = new WebView();

            browser.Source = "https://golhisar.meb.gov.tr/";

            Content = browser;
        }
    }
}