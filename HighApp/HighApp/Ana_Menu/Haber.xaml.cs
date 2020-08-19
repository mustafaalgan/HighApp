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
    public partial class Haber : ContentPage
    {
        public Haber()
        {
            InitializeComponent();
            var browser = new WebView();

            browser.Source = "https://yerelhaber15.com";

            Content = browser;
        }
    }
}