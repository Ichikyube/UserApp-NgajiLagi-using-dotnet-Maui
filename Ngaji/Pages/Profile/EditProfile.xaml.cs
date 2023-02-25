namespace Ngaji.Pages.Profile;

public partial class EditProfile : ContentPage
{
    public EditProfile()
    {
        InitializeComponent();
    }

    void OnScroll(Object sender, ScrolledEventArgs e)
    {
        ScrollView scroll = new ScrollView();
        scroll.Scrolled += OnScroll;
    }

    private async void BackImage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}