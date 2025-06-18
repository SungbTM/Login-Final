namespace LoginTeste;

public partial class Cadastro : ContentPage
{
	public Cadastro()
	{
		InitializeComponent();
	}

    private void btnVoltarCadastro_Clicked(object sender, EventArgs e)
    {
        //Navigation.PushAsync(new Loja());
         Shell.Current.GoToAsync("Main");
    }

    private async void btnFinalizar_Clicked(object sender, EventArgs e)
    {
       

        string nomeProduto = txtCadastro.Text; //pra pegar oque ele digita na aba de cadastro como "Nome"
        string valor = txtPreço.Text; //Pra pegar agora o preço

        
        if (string.IsNullOrEmpty(nomeProduto) || string.IsNullOrEmpty(valor)) //Codigo pra que se ele clicar em cadastrar e os campos tiverem vazio
        {                                                                     //dar erro
            await DisplayAlert("Erro", "Preencha todos os campos !", "Entendido");
            return;
        }

        await Navigation.PushAsync(new Loja(nomeProduto, valor));
    }
}