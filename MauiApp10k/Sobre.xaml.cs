namespace MauiApp10k;

public partial class Sobre : ContentPage
{
	public Sobre()
	{
		InitializeComponent();
	}

    private void btnAAlert_Clicked(object sender, EventArgs e)
    {
		DisplayAlert("OI Antony", "meu app funciona", "aaaaa");
    }
}