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
    public partial class Hava_Durum : ContentPage
    {
        public Hava_Durum()
        {
            InitializeComponent();
            var browser = new WebView();

            browser.Source = "https://www.mgm.gov.tr/?il=Burdur&ilce=G%C3%B6lhisar";

            Content = browser;
        }
    }
}