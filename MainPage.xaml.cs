using Android.Views;

namespace LoginTeste
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

            btnLogout.Text += " - " + Preferences.Default.Get("usuario", "");
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private async void btnLogout_Clicked(object sender, EventArgs e)
        {
            Preferences.Default.Remove("usuario");

            await Shell.Current.GoToAsync("Login");
        }
        protected override bool OnBackButtonPressed() { return true; }

        private async void btnLoja_Clicked(object sender, EventArgs e)
        {
            //await Shell.Current.GoToAsync("Loja");
            Navigation.PushAsync(new Loja());
            //await Navigation.PushAsync(new Loja(nomeProduto, valor));
            //await Shell.Current.GoToAsync("Loja");
        }

        private void btnCadastro_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Cadastro());
        }

        private async void btnMenu_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("Main");
        }
    }

}
