namespace Ngaji.Pages.Auth.Register;

using Pages.Auth.Register;

public partial class ChooseTarget : ContentPage
{
	public ChooseTarget()
	{
		InitializeComponent();
	}

    private async void Next_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ChooseLevel());
        // await Shell.Current.GoToAsync("//auth/chooselevel");
    }

    private async void Goback_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}