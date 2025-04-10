namespace MauiApp7;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnSignInClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Dashboard());
    }
}