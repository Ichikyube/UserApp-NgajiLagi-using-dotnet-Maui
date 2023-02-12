namespace Ngaji.Pages;

public partial class LandingPage : ContentPage
{
	public LandingPage()
	{
		InitializeComponent();
	}

    private void OnScrollViewLogin(object sender, ScrolledEventArgs e)
    {
        ScrollView Scroll = new ScrollView();
        Scroll.Scrolled += OnScrollViewLogin;
    }
}