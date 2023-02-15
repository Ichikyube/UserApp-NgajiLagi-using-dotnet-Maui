namespace MauiApp1.View.Ustadz;

public partial class Konsultasi : ContentPage
{
	public Konsultasi()
	{
		InitializeComponent();
	}

    private async void Diskon(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new Diskon());
    }
}