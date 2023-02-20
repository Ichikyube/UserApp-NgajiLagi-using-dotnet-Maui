using Ngaji.Models;
using System.Collections.ObjectModel;

namespace Ngaji.CustomControls;

public partial class CalendarView : StackLayout
{
	public ObservableCollection<CalendarModel> Dates { get; set; } = new ObservableCollection<CalendarModel>();
	public CalendarView()
	{
		InitializeComponent();
		BindDates(DateTime.Now);
	}

	private void BindDates(DateTime selectedDate)
	{
		int daysCount = DateTime.DaysInMonth(selectedDate.Year, selectedDate.Month);
		for(int day = 1; day <= daysCount; day++)
		{
			Dates.Add(new CalendarModel
			{
				Date = new DateTime(selectedDate.Year, selectedDate.Month, day)
			});
		}
	}
}