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
    public partial class Belediye : ContentPage
    {
        public Belediye()
        {
            InitializeComponent();

            var browser = new WebView();

            browser.Source = "https://www.golhisar.bel.tr/";

            Content = browser;
        }
    }
}