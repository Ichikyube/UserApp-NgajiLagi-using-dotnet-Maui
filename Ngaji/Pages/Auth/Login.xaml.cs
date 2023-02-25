using Ngaji.Services;
using Ngaji.ViewModel;

namespace Ngaji.Pages.Auth;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        //var loggedin = true;
        //if(loggedin)
        await Shell.Current.GoToAsync($"//{nameof(LandingPage)}");
    }

    private async void GotoLupaPassword(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("lupapassword");
    }

    private async void GotoBooking(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("book-appointment");
    }

    private void password_Focused(object sender, FocusEventArgs e)
    {

    }
    private readonly ILoginRepo _loginRepository = new LoginService();
    private async void Login_Clicked(object sender, EventArgs e)
    {
        string email = txtemail.Text;
        string password = txtpassword.Text;

        if (email == null || password == null)
        {
            await DisplayAlert("Warning", "Please Input Username & Password", "Ok");
            return;
        }

        var userData = await _loginRepository.Login(email, password);

        if (userData != null)
        {
            await Shell.Current.GoToAsync("//LandingPage");
        }
        else
        {
            await DisplayAlert("Warning", "Username or Password is incorrect", "Ok");
        }
    }
}