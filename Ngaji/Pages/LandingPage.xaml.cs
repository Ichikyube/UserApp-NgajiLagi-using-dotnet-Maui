using Ngaji.ViewModels;

namespace Ngaji.Pages;

public partial class LandingPage : ContentPage
{
    
    public LandingPage()
	{
		InitializeComponent();
        BindingContext = new UstadzsViewModel();
        var loggedin = false;
        if (!loggedin)
        {
            authtitle.IsVisible = false;
            guesttitle.IsVisible = true;
        }
        else
        {
            authtitle.IsVisible = true;
            guesttitle.IsVisible = false;
        }
    }

    private async void GotoLogin(object sender, EventArgs e)
    {
        //await Navigation.PushAsync(new Auth.Login());
        await Shell.Current.GoToAsync("login");

    }

    private async void OnTapGestureRecognizerTapped(object sender, EventArgs e)
    {
        // Position relative to an Image
        //Point? relativeToImagePosition = e.GetPosition(image);

        // Position relative to the container view
        //Point? relativeToContainerPosition = e.GetPosition((View)sender);
        await Shell.Current.GoToAsync("login");
    }

}