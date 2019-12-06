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
    public partial class Jogo : ContentPage
    {
        
        public Jogo()
        {
            InitializeComponent();
            gerarCalculo();
            atualizarTexto();
        }

        public int gerarCalculo()
        {
            Random randNum = new Random();
            if (Config.nivel == 1)
            {
                Config.valor1 = randNum.Next(1, 10);
                Config.valor2 = randNum.Next(1, 10);
            }else if(Config.nivel == 2)
            {
                Config.valor1 = randNum.Next(10, 100);
                Config.valor2 = randNum.Next(10, 100);
            }else if(Config.nivel == 3)
            {
                Config.valor1 = randNum.Next(100, 1000);
                Config.valor2 = randNum.Next(100, 1000);
            }

            if(Config.op == 1)
            {
                Config.result = Config.valor1 + Config.valor2;
            }else if(Config.op == 2)
            {
                Config.result = Config.valor1 - Config.valor2;
            }else if (Config.op == 3)
            {
                Config.result = Config.valor1 * Config.valor2;
            }else if (Config.op == 4)
            {
                Config.result = Config.valor1 / Config.valor2;
            }
            return 0;
        }

        public async void analisarResposta(Object sender, EventArgs args)
        {
            if(!(resultado.Text == null))
            {
                if (resultado.Text.Equals(Config.result.ToString()))
                {
                    await DisplayAlert("Resultado", "Parabéns, você acertou a resposta!! =)", "Ok");
                    gerarCalculo();
                    atualizarTexto();
                }
                else
                {
                    await DisplayAlert("Resultado", "Resposta errada, mas tente novamente.", "Ok");
                }
            }
            else
            {
                await DisplayAlert("Resultado", "Insira uma resposta. =)", "Ok");
            }

        }

        public void atualizarTexto()
        {
            valor1.Text = Config.valor1.ToString();
            valor2.Text = Config.valor2.ToString();
            if (Config.op == 1)
            {
                op.Text = "+";
            }
            else if (Config.op == 2)
            {
                op.Text = "-";
            }
            else if (Config.op == 3)
            {
                op.Text = "*";
            }
            else if (Config.op == 4)
            {
                op.Text = "\\";
            }
            resultado.Text = "";
        }
    }
}