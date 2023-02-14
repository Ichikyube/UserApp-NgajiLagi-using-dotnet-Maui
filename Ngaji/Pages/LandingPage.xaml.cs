namespace Ngaji.Pages;

public partial class LandingPage : ContentPage
{
	public LandingPage()
	{
		InitializeComponent();
	}

    private async void GotoLogin(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Auth.Login());
    }
}