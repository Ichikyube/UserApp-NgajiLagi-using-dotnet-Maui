namespace Ngaji.Pages.Auth.Register;

public partial class CreateAccount : ContentPage
{
	public CreateAccount()
	{
		InitializeComponent();
	}

    private async void Goback_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
		// await Shell.Current.GoToAsync("//..");
    }

    private async void Next_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CreateProfile());
        // await Shell.Current.GoToAsync("//auth/createprofile");
    }
}