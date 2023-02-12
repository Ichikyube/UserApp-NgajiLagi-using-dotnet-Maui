namespace Ngaji;

public partial class MainPage : ContentPage
{
    Image image = new Image
    {
        Source = ImageSource.FromResource("Images.avatar.png")
    };
    public MainPage()
	{
		InitializeComponent();
	}

}

