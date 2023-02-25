using Ngaji.ViewModels;

namespace Ngaji.CustomControls;

public partial class TimePickerView : StackLayout
{
	public TimePickerView()
	{
		InitializeComponent();
        BindingContext = new TimeViewModel();
    }

    void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
    {
        //currentSelectedItemLabel.Text = (args.SelectedItem as Monkey)?.Name;
        TimeSpan ts1 = TimeSpan.FromHours(12.34);
        TimeSpan ts2 = TimeSpan.FromHours(56.78);
        TimeSpan sum = ts1 + ts2;
        Console.WriteLine("Total timespan = {0}hrs which is {1}hrs and {2}mins",
                       sum.TotalHours, sum.Hours, sum.Minutes);

        DateTime d1 = new DateTime(2009, 6, 1, 9, 0, 0);
        DateTime d2 = new DateTime(2009, 6, 1, 12, 0, 0);

        DateTime[] ds = new DateTime[10];

        ds[0] = d1.AddMinutes(30);
        ds[1] = ds[0].AddMinutes(30);


        string str = d1.ToString("H:mm") + '-' + ds[0].ToString("H:mm");
    }
}