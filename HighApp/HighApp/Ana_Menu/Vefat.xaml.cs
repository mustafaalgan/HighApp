using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HighApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Vefat : ContentPage
    {
        public Vefat()
        {
            InitializeComponent();
            var browser = new WebView();

            browser.Source = "https://www.golhisar.bel.tr/vefat-edenler.html";

            Content = browser;
        }
    }
}