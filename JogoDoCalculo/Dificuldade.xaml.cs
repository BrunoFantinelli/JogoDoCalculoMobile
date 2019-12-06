using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JogoDoCalculo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Dificuldade : ContentPage
    {
        public Dificuldade()
        {
            InitializeComponent();
        }

        public async void BotaoFacil(Object sender, EventArgs args)
        {
            Config.nivel = 1;
            await App.Current.MainPage.Navigation.PushAsync(new Jogo());
        }
        public async void BotaoMedio(Object sender, EventArgs args)
        {
            Config.nivel = 2;
            await App.Current.MainPage.Navigation.PushAsync(new Jogo());
        }
        public async void BotaoDificil(Object sender, EventArgs args)
        {
            Config.nivel = 3;
            await App.Current.MainPage.Navigation.PushAsync(new Jogo());
        }
    }
}