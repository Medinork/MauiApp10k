namespace MauiApp10k
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
            {

                CounterBtn.Text = $"Clicked {count} time";
                lblBemVindo.Text = "ERA PRA FREIA EU ACELEREI";

            }
            else if (count == 2)
            {
                CounterBtn.Text = $"Clicked {count} time";
                lblBemVindo.Text = "DAVA PRA DESVIAR MAS EU NEM TENTEI";
            }
            else if (count == 3)
            {
                CounterBtn.Text = $"Clicked {count} time";
                lblBemVindo.Text = "PASSEI POR CIMA DE ¨6!!!!";
            }
            else
            {
                CounterBtn.Text = $"Clicked {count} times";
                lblTeste.Text = "Enfim programando";
            }
            SemanticScreenReader.Announce(CounterBtn.Text);
        }
        private void OnCounterClicked2(object sender, EventArgs e)
        {
            count--;

            if (count == 1)
            {

                CounterBtn.Text = $"Clicked {count} time";
                lblBemVindo.Text = "ERA PRA FREIA EU ACELEREI";

            }
            else if (count == 2)
            {
                CounterBtn.Text = $"Clicked {count} time";
                lblBemVindo.Text = "DAVA PRA DESVIAR MAS EU NEM TENTEI";
            }
            else if (count == 3)
            {
                CounterBtn.Text = $"Clicked {count} time";
                lblBemVindo.Text = "PASSEI POR CIMA DE 6!!!!";
            }
            else
            {
                CounterBtn.Text = $"Clicked {count} times";
                lblTeste.Text = "Enfim programando";
            }
            SemanticScreenReader.Announce(CounterBtn.Text);
        }

    }

}
