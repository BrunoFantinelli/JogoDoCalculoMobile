using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace JogoDoCalculo
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

        public async void BotaoAdicionar(Object sender, EventArgs args)
        {
            Config.op = 1;
            await App.Current.MainPage.Navigation.PushAsync(new Dificuldade());
        }
        public async void BotaoSubtrair(Object sender, EventArgs args)
        {
            Config.op = 2;
            await App.Current.MainPage.Navigation.PushAsync(new Dificuldade());
        }
        public async void BotaoMultiplicar(Object sender, EventArgs args)
        {
            Config.op = 3;
            await App.Current.MainPage.Navigation.PushAsync(new Dificuldade());
        }
        public async void BotaoDividir(Object sender, EventArgs args)
        {
            Config.op = 4;
            await App.Current.MainPage.Navigation.PushAsync(new Dificuldade());
        }
    }

}
