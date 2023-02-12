namespace Ngaji.Pages.Auth;

public partial class LupaPassword : ContentPage
{
	public LupaPassword()
	{
		InitializeComponent();
	}

    async private void Back(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}