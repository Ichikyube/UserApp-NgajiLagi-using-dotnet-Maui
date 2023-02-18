namespace Ngaji.Pages;

public partial class LandingPage : ContentPage
{
	public LandingPage()
	{
		InitializeComponent();
	}

    private async void GotoLogin(object sender, EventArgs e)
    {
        //await Navigation.PushAsync(new Auth.Login());
        await Shell.Current.GoToAsync("login");

    }

    private void OnTapGestureRecognizerTapped(object sender, EventArgs e)
    {
        // Position relative to an Image
        //Point? relativeToImagePosition = e.GetPosition(image);

        // Position relative to the container view
        //Point? relativeToContainerPosition = e.GetPosition((View)sender);
        Navigation.PushAsync(new Auth.Login());
    }
}