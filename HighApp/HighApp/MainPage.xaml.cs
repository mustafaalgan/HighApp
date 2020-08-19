using Plugin.SimpleAudioPlayer;
using System;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace HighApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }
      
        Stream GetStreamFromFile(string filename)
        {
            var assembly = typeof(App).GetTypeInfo().Assembly;
            var stream = assembly.GetManifestResourceStream("HighApp." + filename);

            return stream;
        }
        async void Ayarlar(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Ayarlar());
        }
        async void Duyuru(object sender, EventArgs e)
        {
            var player = CrossSimpleAudioPlayer.Current;
            var folder = "raw";
            player.Load(GetStreamFromFile($"Audio.{folder}.ses_duyurular.wav"));
            //if(Preferences.Set("Revember",true) == true)
            //{
            //    player.Play();

            //}
            player.Play();
            await Navigation.PushAsync(new Duyuru());
        }
        async void Kurumsal(object sender, EventArgs e)
        {
            var player = CrossSimpleAudioPlayer.Current;
            var folder = "raw";
            player.Load(GetStreamFromFile($"Audio.{folder}.ses_kurumsal.mp3"));
            player.Play();
            await Navigation.PushAsync(new Kurumsal());
        }
        async void Vefat(object sender, EventArgs e)
        {
            var player = CrossSimpleAudioPlayer.Current;
            var folder = "raw";
            player.Load(GetStreamFromFile($"Audio.{folder}.ses_konaklama.wav"));
            player.Play();
            await Navigation.PushAsync(new Vefat());
        }
        async void Saglik(object sender, EventArgs e)
        {
            var player = CrossSimpleAudioPlayer.Current;
            var folder = "raw";
            player.Load(GetStreamFromFile($"Audio.{folder}.ses_saglik.mp3"));
            player.Play();
            await Navigation.PushAsync(new Saglik());
        }
        async void Eglence(object sender, EventArgs e)
        {
            var player = CrossSimpleAudioPlayer.Current;
            var folder = "raw";
            player.Load(GetStreamFromFile($"Audio.{folder}.ses_eglence.wav"));
            player.Play();
            await Navigation.PushAsync(new Eglence());
        }
        async void Seyhat(object sender, EventArgs e)
        {
            var player = CrossSimpleAudioPlayer.Current;
            var folder = "raw";
            player.Load(GetStreamFromFile($"Audio.{folder}.ses_otobus.wav"));
            player.Play();
            await Navigation.PushAsync(new Otobus());
        }
        async void Yemek(object sender, EventArgs e)
        {
            var player = CrossSimpleAudioPlayer.Current;
            var folder = "raw";
            player.Load(GetStreamFromFile($"Audio.{folder}.ses_yemek.wav"));
            player.Play();
            await Navigation.PushAsync(new Yemek());
        }
        async void Haber(object sender, EventArgs e)
        {
            var player = CrossSimpleAudioPlayer.Current;
            var folder = "raw";
            player.Load(GetStreamFromFile($"Audio.{folder}.ses_haber.wav"));
            player.Play();
            await Navigation.PushAsync(new Haber());
        }
        async void Gezgin(object sender, EventArgs e)
        {
            var player = CrossSimpleAudioPlayer.Current;
            var folder = "raw";
            player.Load(GetStreamFromFile($"Audio.{folder}.ses_gezi.wav"));
            player.Play();
            await Navigation.PushAsync(new Gezgin());
        }
        async void Namaz(object sender, EventArgs e)
        {
            var player = CrossSimpleAudioPlayer.Current;
            var folder = "raw";
            player.Load(GetStreamFromFile($"Audio.{folder}.ses_namazvakit.mp3"));
            player.Play();
            await Navigation.PushAsync(new Namaz());
        }
        async void Egitim(object sender, EventArgs e)
        {
            var player = CrossSimpleAudioPlayer.Current;
            var folder = "raw";
            player.Load(GetStreamFromFile($"Audio.{folder}.ses_egitim.wav"));
            player.Play();
            await Navigation.PushAsync(new Egitim());
        }
        async void Hakkimizda(object sender, EventArgs e)
        {
            var player = CrossSimpleAudioPlayer.Current;
            var folder = "raw";
            player.Load(GetStreamFromFile($"Audio.{folder}.ses_geribildirim.mp3"));
            player.Play();
            await Navigation.PushAsync(new Hakkimizda());
        }
    }
}
