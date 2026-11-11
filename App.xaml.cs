using MauiAppEventos.Views;

namespace MauiAppEventos;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        // NavigationPage permite usar Navigation.PushAsync entre as telas
        MainPage = new NavigationPage(new CadastroEvento());
    }
}
