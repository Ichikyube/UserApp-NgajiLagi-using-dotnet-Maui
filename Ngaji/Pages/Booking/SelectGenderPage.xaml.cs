namespace Ngaji.Pages.Booking;

public partial class SelectGenderPage : ContentPage
{

    // public ICommand pCommand { get; set; }
    // bool isActive = false;
    string active = "";
    Frame selectedFrame = null;
    Label selectedLabel = null;
    public SelectGenderPage()
	{
		InitializeComponent();
        // Create a new Command with a lambda expression
        // pCommand = new Command(() =>
        // {
        //     // Do something when the button is tapped
        //     // For example:
        //     pria.BackgroundColor = Color.FromRgba("#FF00FF");
        //     pria.TextColor = Color.FromRgba("#FF0000");
        //     // DisplayAlert("Button Tapped", "You tapped the button!", "OK");
        // });
    }

    private void SelectPw(object sender, EventArgs e)
    {
        OnSelected(fpria_wanita, pria_wanita, "pria_wanita");
    }
    private void SelectP(object sender, EventArgs e)
    {
        OnSelected(fpria, pria, "pria");
    }
    private void SelectW(object sender, EventArgs e)
    {
        OnSelected(fwanita, wanita, "wanita");
    }

    private void OnSelected(Frame frame, Label label, string selected)
    {
        if (active == "")
        {
            selectedFrame = frame;
            selectedLabel = label;
            OnActive();
            active = selected;
        }
        else if (active != selected)
        {
            OnNotActive();
            selectedFrame = frame;
            selectedLabel = label;
            OnActive();
            active = selected;
        }
        else
        {
            OnNotActive();
            active = "";
        }
    }

    private void OnActive()
    {
        selectedFrame.BackgroundColor = Color.FromRgba("#88984A");
        selectedLabel.TextColor = Color.FromRgba("#FFF");
        pria.TextColor = Color.FromRgba("#FFF00F");
        cariustadz.Background = Color.FromRgba("#FFD53F");
        cariustadz.TextColor = Color.FromRgba("#000");
    }
    private void OnNotActive()
    {
        selectedFrame.BackgroundColor = Color.FromRgba("#FFF");
        selectedLabel.TextColor = Color.FromRgba("#000");
        cariustadz.Background = Color.FromRgba("#C0C0C0");
        cariustadz.TextColor = Color.FromRgba("#FFF");
    }
}