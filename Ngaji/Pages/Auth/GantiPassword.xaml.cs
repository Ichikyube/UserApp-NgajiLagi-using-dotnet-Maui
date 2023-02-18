namespace Ngaji.Pages.Auth;

public partial class GantiPassword : ContentPage
{
    public GantiPassword()
    {
        InitializeComponent();
    }

    private async void BackImage(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new UserProfile());
    }

    void PasswordConfirm_TextChange(object sender, TextChangedEventArgs e)
    {
        if (password.Text == "")
        {
            button.IsEnabled = false;
            button.BackgroundColor = Color.FromHex("#C0C0C0");
            button.TextColor = Color.FromHex("#FFFFFF");
        }
        else
        {
            button.IsEnabled = true;
            button.BackgroundColor = Color.FromHex("#FFD53F");
            button.TextColor = Color.FromHex("#313131");
        }
    }

    void scrollview(object sender, ScrolledEventArgs e)
    {
        ScrollView scroll = new ScrollView();
        scroll.Scrolled += scrollview;
    }
}