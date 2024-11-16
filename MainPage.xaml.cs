
namespace MauiApp1agenda11
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

            btn.IsEnabled = false;
            btn.Text = vez;

            vez = vez == "X" ? "O" : "X";

            if (VerificarVencedor())
            {
                DisplayAlert("Parabéns!", $"{btn.Text} ganhou!", "OK");
                Zerar();
            }
        }

        private bool VerificarVencedor()
        {
            // Verifica linhas
            if (btn10.Text == btn11.Text && btn11.Text == btn12.Text && !string.IsNullOrEmpty(btn10.Text))
                return true;
            if (btn20.Text == btn21.Text && btn21.Text == btn22.Text && !string.IsNullOrEmpty(btn20.Text))
                return true;
            if (btn30.Text == btn31.Text && btn31.Text == btn32.Text && !string.IsNullOrEmpty(btn30.Text))
                return true;

            // Verifica colunas
            if (btn10.Text == btn20.Text && btn20.Text == btn30.Text && !string.IsNullOrEmpty(btn10.Text))
                return true;
            if (btn11.Text == btn21.Text && btn21.Text == btn31.Text && !string.IsNullOrEmpty(btn11.Text))
                return true;
            if (btn12.Text == btn22.Text && btn22.Text == btn32.Text && !string.IsNullOrEmpty(btn12.Text))
                return true;

            // Verifica diagonais
            if (btn10.Text == btn21.Text && btn21.Text == btn32.Text && !string.IsNullOrEmpty(btn10.Text))
                return true;
            if (btn12.Text == btn21.Text && btn21.Text == btn30.Text && !string.IsNullOrEmpty(btn12.Text))
                return true;

            return false;
        }

        private void Zerar()
        {
            btn10.Text = btn11.Text = btn12.Text = "";
            btn20.Text = btn21.Text = btn22.Text = "";
            btn30.Text = btn31.Text = btn32.Text = "";

            btn10.IsEnabled = btn11.IsEnabled = btn12.IsEnabled = true;
            btn20.IsEnabled = btn21.IsEnabled = btn22.IsEnabled = true;
            btn30.IsEnabled = btn31.IsEnabled = btn32.IsEnabled = true;

            vez = "X";
        }
    }
    }

