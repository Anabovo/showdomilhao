namespace showdomilhao;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

     private void ButtonIniciar(object sender, EventArgs e)
        {
            if (Application.Current != null) 
            Application.Current.MainPage = new TelaPergunta();
        }

}

