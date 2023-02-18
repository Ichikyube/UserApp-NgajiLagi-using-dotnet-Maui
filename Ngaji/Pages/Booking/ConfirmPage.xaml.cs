namespace Ngaji.Pages.Booking;

public partial class ConfirmPage : ContentPage
{
	public ConfirmPage()
	{
		InitializeComponent();
	}

    private async void Discount(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new DiscountPage());
    }
}