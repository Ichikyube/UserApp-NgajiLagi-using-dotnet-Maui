namespace Ngaji.Pages.Auth.Register;

public partial class CreateProfile : ContentPage
{
	public CreateProfile()
	{
		InitializeComponent();
	}

    private async void RegisterNow_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FinalRegistration());
        var existingPages = Navigation.NavigationStack.ToList();
        foreach (var page in existingPages)
        {
            if (page != null)
            {
                Navigation.RemovePage(page);
            }
        }
        // Navigation.RemovePage(Navigation.NavigationStack[Navigation.NavigationStack.Count - 5]);
        // await Shell.Current.GoToAsync("//auth/finalregistration");
    }

    private async void CodeReferral_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CodeReferral());
        // await Shell.Current.GoToAsync("//auth/codereferral");
    }
     
    private async void Goback_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}