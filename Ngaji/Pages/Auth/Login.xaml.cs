namespace Ngaji.Pages.Auth;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private async void GotoLupaPassword(object sender, EventArgs e)
    {
        // await Launcher.Default.OpenAsync("https://aka.ms/maui");
        await Navigation.PushAsync(new LupaPassword());
    }

    private async void GotoMainPage(object sender, EventArgs e)
    {
        //Application.Current.MainPage = new NavigationPage(new LandingPage());
        await Navigation.PopAsync();
    }
}