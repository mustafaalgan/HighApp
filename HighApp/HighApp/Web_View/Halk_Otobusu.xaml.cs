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
    public partial class Halk_Otobusu : ContentPage
    {
        public Halk_Otobusu()
        {
            InitializeComponent();
            var browser = new WebView();

            browser.Source = "https://websitehighapp.wixsite.com/halkotobus";

            Content = browser;
        }
    }
}