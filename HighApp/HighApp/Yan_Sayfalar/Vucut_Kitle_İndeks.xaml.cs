using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HighApp.Yan_Sayfalar
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Vucut_Kitle_İndeks : ContentPage
    {
        int ideal_kiloBay = 0, ideal_kiloBayan = 0;
        public double vki = 0;
        public bool erkekmi = true;
        public double boy_hesap = 0.0;
        public Vucut_Kitle_İndeks()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            Slider kilo = new Slider
            {
                Maximum = 135,
                Value = 55,
                Minimum = 45,
                MinimumTrackColor=Color.Green,
                MaximumTrackColor= Color.Red,
                WidthRequest=40,
                Margin = new Thickness(10, 0)
                
                // Margin = new Thickness(50, 30)
            };

            kilo.ValueChanged += OnSliderValueChanged;


            Content = new StackLayout
            {
                Children =
                    {
                        boy_text,
                        boy,
                        cinsiyet_text,
                        cinsiyet,
                        kilo_text,
                        kilo,
                        kg_yaz,
                        ideal_kilo_text,
                        ideal_kilo,
                        durum,
                        durum_text,
                        png
                    }
            };
        }



        private void Cinsiyet_SelectedItemChanged(object sender, EventArgs e)
        {
            Guncelle();
        }
        void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
        {
            kg_yaz.Text = string.Format("{0:F0}", e.NewValue) ;
            ideal_kiloBayan = (int)(45.5 + 2.3 * ((boy_hesap /2.54) - 60));
            ideal_kiloBay = (int)(50 + 2.3 * (boy_hesap /2.54 - 60));
            vki = e.NewValue / (boy_hesap * boy_hesap / 10000);

            Guncelle();
        }
        void Guncelle()
        {

            if (c_erkek.IsChecked == true)
            {
                ideal_kilo.Text = string.Format("{0:F0}", ideal_kiloBay);

                if (vki <= 20.7)
                {
                    durum_text.Text = "Zayıf Durumdasınız..";
                    durum_text.BackgroundColor = Color.FromHex("#FF7F00");
                }
                else if (20.7 < vki && vki <= 26.4)
                {
                    durum_text.Text = "İdeal Kilodasınız..";

                    durum_text.BackgroundColor = Color.FromHex("#05AF39");
                }
                else if (26.4 < vki && vki <= 27.8)
                {
                    durum_text.Text = "Normalden Fazla Kilodasınız..";

                    durum_text.BackgroundColor = Color.FromHex("#F34C38");
                }
                else if (27.8 < vki && vki <= 31.1)
                {
                    durum_text.Text = "Fazla Kilolu Durumdasınız..";
                    durum_text.BackgroundColor = Color.FromHex("#FF0000");
                }
                else if (31.1 < vki && vki <= 34.9)
                {
                    durum_text.Text = "Obez Durumdasınız..";
                    durum_text.BackgroundColor = Color.FromHex("#B30909");
                }
                else
                {
                    durum_text.Text = "Doktor Tedavisi Gerekiyor..";
                    durum_text.BackgroundColor = Color.FromHex("#000000");
                }

            }
            else
            {
            
                ideal_kilo.Text = string.Format("{0:F0}", ideal_kiloBayan);

                if (vki <= 19.1)
                {
                    durum_text.Text = "Zayıf Durumdasınız..";
                    durum_text.BackgroundColor = Color.FromHex("#FF7F00");

                }
                else if (19.1 < vki && vki <= 25.8)
                {
                    durum_text.Text = "İdeal Kilodasınız..";
                    durum_text.BackgroundColor = Color.FromHex("#05AF39");

                }
                else if (25.8 < vki && vki <= 27.3)
                {
                    durum_text.Text = "Normalden Fazla Kilodasınız..";
                    durum_text.BackgroundColor = Color.FromHex("#F34C38");
                }
                else if (27.3 < vki && vki <= 32.3)
                {
                    durum_text.Text = "Fazla Kilolu Durumdasınız..";
                    durum_text.BackgroundColor = Color.FromHex("#FF0000");

                }
                else if (32.3 < vki && vki <= 34.9)
                {
                    durum_text.Text = "Obez Durumdasınız..";
                    durum_text.BackgroundColor = Color.FromHex("#B30909");
                }
                else
                {
                    durum_text.Text = "Doktor Tedavisi Gerekiyor..";
                    durum_text.BackgroundColor = Color.FromHex("#000000");
                }
            }
        }

        private void Boy_TextChanged(object sender, TextChangedEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(e.NewTextValue))
            {
                boy.Text = string.Empty;
                return;
            }
            else
            {
                boy_hesap = double.Parse(boy.Text);
                Guncelle();
            }
            Guncelle();
        }
    }
}