namespace Ngaji.Pages.Profile;

public partial class UserProfile : ContentPage
{
    public UserProfile()
    {
        InitializeComponent();
    }

    private async void EditProfile(object sender, EventArgs e)
    {
        //await Navigation.PushModalAsync(new EditProfile());
        await Shell.Current.GoToAsync("editprofile");
    }

    private async void GantiPassword(object sender, EventArgs e)
    {
        //await Navigation.PushModalAsync(new GantiPassword());
        await Shell.Current.GoToAsync("gantipassword");
    }
}