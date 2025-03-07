namespace MauiApp10k;

public partial class Banana : ContentPage
{
	public Banana()
	{
		InitializeComponent();
	}
    private void Banana_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("BAnana", "BANANA?", "BANANA!!");
    }
}