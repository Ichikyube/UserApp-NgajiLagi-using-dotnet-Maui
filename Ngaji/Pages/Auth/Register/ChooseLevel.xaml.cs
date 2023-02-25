namespace Ngaji.Pages.Auth.Register;

using Pages.Auth.Register;

public partial class ChooseLevel : ContentPage
{
	public ChooseLevel()
	{
		InitializeComponent();
    }

    private async void Next_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CreateAccount());
    }

    private async void GoBack_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}