using static System.Net.Mime.MediaTypeNames;

namespace LoginTeste;

public partial class Loja : ContentPage
{
	public Loja(string nomeProduto, string valor)
	{
        

		InitializeComponent();

       lblNomeProduto.Text = "Produto: " + nomeProduto;
       lblValor.Text = "Valor: " + valor;
    }

    private void btnCadastro_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Cadastro());
    }

    private void btnVoltarLoja_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
}