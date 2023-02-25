namespace Ngaji.Pages.Booking;

public partial class SelectLevelPage : ContentPage
{
    string active = "";
    Frame selectedFrame = null;
    Label selectedLabel = null;

    void SelectAwal(object sender, EventArgs e)
    {
        OnSelected(fawal, awal, "awal");
    }
    void SelectSedikit(object sender, EventArgs e)
    {
        OnSelected(fsedikit, sedikit, "sedikit");
    }
    void SelectLanjutan(object sender, EventArgs e)
    {
        OnSelected(flanjutan, lanjutan, "lanjutan");
    }

    void OnSelected(Frame frame, Label label, string selected)
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

    void OnActive()
    {
        selectedFrame.BackgroundColor = Color.FromRgba("#88984A");
        selectedLabel.TextColor = Color.FromRgba("#FFF");
        gantiLevel.Background = Color.FromRgba("#FFD53F");
        gantiLevel.TextColor = Color.FromRgba("#000");
    }
    void OnNotActive()
    {
        selectedFrame.BackgroundColor = Color.FromRgba("#FFF");
        selectedLabel.TextColor = Color.FromRgba("#000");
        gantiLevel.Background = Color.FromRgba("#C0C0C0");
        gantiLevel.TextColor = Color.FromRgba("#FFF");
    }
    public SelectLevelPage()
	{
		InitializeComponent();
	}
}