namespace MauiAppJogoDaVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "X";
        int cont = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.IsEnabled = false;
            cont++;

            if (vez == "X")
            {
                btn.Text = "X";
                vez = "O";
            }
            else
            {
                btn.Text = "O";
                vez = "X";
            }

            // Verificando se o X ou O ganhou na 1 linha horizontal

            if (btn10.Text == "X" && btn11.Text == "X" && btn12.Text == "X")
            {
                DisplayAlert("Parabéns", "O X ganhou!", "OK");
                Zerar();
            } else if(btn10.Text == "O" && btn11.Text == "O" && btn12.Text == "O")
            {
                DisplayAlert("Parabéns", "O - ganhou!", "OK");
                Zerar();
            }

            // Verificando se o X ou O ganhou na 2 linha horizontal

            if (btn20.Text == "X" && btn21.Text == "X" && btn22.Text == "X")
            {
                DisplayAlert("Parabéns", "O X ganhou!", "OK");
                Zerar();
            }
            else if (btn20.Text == "O" && btn21.Text == "O" && btn22.Text == "O")
            {
                DisplayAlert("Parabéns", "O - ganhou!", "OK");
                Zerar();
            }

            // Verificando se o X ou O ganhou na 3 linha horizontal

            if (btn30.Text == "X" && btn31.Text == "X" && btn32.Text == "X")
            {
                DisplayAlert("Parabéns", "O X ganhou!", "OK");
                Zerar();
            }
            else if (btn30.Text == "O" && btn31.Text == "O" && btn32.Text == "O")
            {
                DisplayAlert("Parabéns", "O - ganhou!", "OK");
                Zerar();
            }

            // Verificando se o X ou O ganhou na 1 coluna vertical

            if (btn10.Text == "X" && btn20.Text == "X" && btn30.Text == "X")
            {
                DisplayAlert("Parabéns", "O X ganhou!", "OK");
                Zerar();
            }
            else if (btn10.Text == "O" && btn20.Text == "O" && btn30.Text == "O")
            {
                DisplayAlert("Parabéns", "O - ganhou!", "OK");
                Zerar();
            }
            // Verificando se o X ou O ganhou na 2 coluna vertical

            if (btn11.Text == "X" && btn21.Text == "X" && btn31.Text == "X")
            {
                DisplayAlert("Parabéns", "O X ganhou!", "OK");
                Zerar();
            }
            else if (btn11.Text == "O" && btn21.Text == "O" && btn31.Text == "O")
            {
                DisplayAlert("Parabéns", "O - ganhou!", "OK");
                Zerar();
            }
            // Verificando se o X ou O ganhou na 3 coluna vertical

            if (btn12.Text == "X" && btn22.Text == "X" && btn32.Text == "X")
            {
                DisplayAlert("Parabéns", "O X ganhou!", "OK");
                Zerar();
            }
            else if (btn12.Text == "O" && btn22.Text == "O" && btn32.Text == "O")
            {
                DisplayAlert("Parabéns", "O - ganhou!", "OK");
                Zerar();
            }

            //Verificando se o X ou O ganhou na 1 diagonal
            if (btn10.Text == "X" && btn21.Text == "X" && btn32.Text == "X")
            {
                DisplayAlert("Parabéns", "O X ganhou!", "OK");
                Zerar();
            }
            else if (btn10.Text == "O" && btn21.Text == "O" && btn32.Text == "O")
            {
                DisplayAlert("Parabéns", "O - ganhou!", "OK");
                Zerar();
            }
            //Verificando se o X ou O ganhou na 2 diagonal
            if (btn12.Text == "X" && btn21.Text == "X" && btn30.Text == "X")
            {
                DisplayAlert("Parabéns", "O X ganhou!", "OK");
                Zerar();
            }
            else if (btn12.Text == "O" && btn21.Text == "O" && btn30.Text == "O")
            {
                DisplayAlert("Parabéns", "O - ganhou!", "OK");
                Zerar();
            }


            // Se o cont chegar a 9, ninguem ganhou.
            if (cont == 9)
            {
                DisplayAlert("Empate", "Nenhum jogador ganhou", "NOVA PARTIDA");
                Zerar();
            }
        } // Fechamento método Button Clicked

        void Zerar()
        {
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";
            btn20.Text = "";
            btn21.Text = "";
            btn22.Text = "";
            btn30.Text = "";
            btn31.Text = "";
            btn32.Text = "";
            btn10.IsEnabled = true;
            btn11.IsEnabled = true;
            btn12.IsEnabled = true;
            btn20.IsEnabled = true;
            btn21.IsEnabled = true;
            btn22.IsEnabled = true;
            btn30.IsEnabled = true;
            btn31.IsEnabled = true;
            btn32.IsEnabled = true;
            cont = 0;
        }
    } // Fechamento da classe
} // Fechamento namespace
