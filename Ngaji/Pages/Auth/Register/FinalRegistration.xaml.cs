namespace Ngaji.Pages.Auth.Register;

public partial class FinalRegistration : ContentPage
{
	public FinalRegistration()
	{
		InitializeComponent();
	}

    private async void MulaiBelajarNgaji_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new Login());
        // Navigation.RemovePage(Navigation.NavigationStack[Navigation.NavigationStack.Count - 7]);
    }
}