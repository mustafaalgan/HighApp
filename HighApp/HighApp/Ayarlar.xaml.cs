using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HighApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Ayarlar : ContentPage
    {
        public Ayarlar()
        {
            InitializeComponent();
            //Content = new StackLayout
            //{
            //    Children =
            //        {
            //            RememberStw,
            //            button
            //        }
            //};
        }
    

        //public static Switch RememberStw = new Switch
        //{
        //    HorizontalOptions = LayoutOptions.Center,
        //    VerticalOptions = LayoutOptions.Center
        //};

        //Button button = new Button
        //{
        //    HorizontalOptions = LayoutOptions.Center,
        //    VerticalOptions = LayoutOptions.End
            
        //};


        void Button_Clicked(object sender, EventArgs args)
        {
            Preferences.Set("Remember", RememberStw.IsToggled);

            if (RememberStw.IsToggled == true)
                Preferences.Set("Switch", Switch.SwitchOnVisualState);
        }

        protected override void OnAppearing()
        {
            if ((Preferences.Get("Remember", true) == true))
            {
                RememberStw.IsToggled = true;
            }
        }
    }
}