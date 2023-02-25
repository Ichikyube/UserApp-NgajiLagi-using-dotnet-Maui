namespace Ngaji.Pages.Auth.Register;

public partial class CodeReferral : ContentPage
{
	public CodeReferral()
	{
		InitializeComponent();
	}

    private async void Goback_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
    }
}