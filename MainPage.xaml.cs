namespace Jogo_da_Velha
{
    public partial class MainPage : ContentPage
    {
        string vez = "X";

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if( btn.Text == null ) 
            { 
                if (vez == "X") 
                { 
                    btn.Text = "X";
                    vez = "O";
                } else
                { 
                    btn.Text = "O";
                    vez = "X";
                }
            }
            //linha
            if (btn10.Text == "X" && btn11.Text == "X" && btn12.Text == "X")
            {
                DisplayAlert("Parabéns", "O jogador(a) 'X' ganhou", "ok");
                zerar();
            }
            else if (btn10.Text == "O" && btn11.Text == "O" && btn12.Text == "O")
            {
                DisplayAlert("Parabéns", "O jogador(a) 'O' ganhou", "ok");
                zerar();
            }
            else if (btn20.Text == "X" && btn21.Text == "X" && btn22.Text == "X")
            {
                DisplayAlert("Parabéns", "O jogador(a) 'X' ganhou", "ok");
                zerar();
            }
            else if (btn20.Text == "O" && btn21.Text == "O" && btn22.Text == "O")
            {
                DisplayAlert("Parabéns", "O jogador(a) 'O' ganhou", "ok");
                zerar();
            }
            else if (btn30.Text == "X" && btn31.Text == "X" && btn32.Text == "X")
            {
                DisplayAlert("Parabéns", "O jogador(a) 'X' ganhou", "ok");
                zerar();
            }
            else if (btn30.Text == "O" && btn31.Text == "O" && btn32.Text == "O")
            {
                DisplayAlert("Parabéns", "O jogador(a) 'O' ganhou", "ok");
                zerar();
            }
            else if (btn10.Text == "X" && btn20.Text == "X" && btn30.Text == "X")
            {
                DisplayAlert("Parabéns", "O jogador(a) 'X' ganhou", "ok");
                zerar();
            }

            //coluna
            else if (btn10.Text == "O" && btn20.Text == "O" && btn30.Text == "O")
            {
                DisplayAlert("Parabéns", "O jogador(a) 'O' ganhou", "ok");
                zerar();
            }
            else if (btn11.Text == "X" && btn21.Text == "X" && btn31.Text == "X")
            {
                DisplayAlert("Parabéns", "O jogador(a) 'X' ganhou", "ok");
                zerar();
            }
            else if (btn11.Text == "O" && btn21.Text == "O" && btn31.Text == "O")
            {
                DisplayAlert("Parabéns", "O jogador(a) 'O' ganhou", "ok");
                zerar();
            }
            else if (btn12.Text == "X" && btn22.Text == "X" && btn32.Text == "X")
            {
                DisplayAlert("Parabéns", "O jogador(a) 'X' ganhou", "ok");
                zerar();
            }
            else if (btn12.Text == "O" && btn22.Text == "O" && btn32.Text == "O")
            {
                DisplayAlert("Parabéns", "O jogador(a) 'O' ganhou", "ok");
                zerar();
            }

            //diagonal
            else if (btn10.Text == "X" && btn21.Text == "X" && btn32.Text == "X")
            {
                DisplayAlert("Parabéns", "O jogador(a) 'X' ganhou", "ok");
                zerar();
            }
            else if (btn10.Text == "O" && btn21.Text == "O" && btn32.Text == "O")
            {
                DisplayAlert("Parabéns", "O jogador(a) 'O' ganhou", "ok");
                zerar();
            }
            else if (btn12.Text == "X" && btn21.Text == "X" && btn30.Text == "X")
            {
                DisplayAlert("Parabéns", "O jogador(a) 'X' ganhou", "ok");
                zerar();
            }
            else if (btn12.Text == "O" && btn21.Text == "O" && btn30.Text == "O")
            {
                DisplayAlert("Parabéns", "O jogador(a) 'O' ganhou", "ok");
                zerar();
            }

            //velha
            else if (btn10.Text != null &&
            btn11.Text != null &&
            btn12.Text != null &&
            btn20.Text != null &&
            btn21.Text != null &&
            btn22.Text != null &&
            btn30.Text != null &&
            btn31.Text != null &&
            btn32.Text != null)
            {
                DisplayAlert("Empate", "O jogo deu Velha", "ok");
                zerar();
            }
        }

        void zerar()
        {
            btn10.Text = null;
            btn11.Text = null;
            btn12.Text = null;
            btn20.Text = null;
            btn21.Text = null;
            btn22.Text = null;
            btn30.Text = null;
            btn31.Text = null;
            btn32.Text = null;
        }
    }


}
