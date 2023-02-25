using Ngaji.Models.Calendar;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Ngaji.CustomControls;

public partial class CalendarView : StackLayout
{
    #region BindableProperty
    public static readonly BindableProperty SelectedDateProperty = BindableProperty.Create(
		nameof(SelectedDate), typeof(DateTime), 
		declaringType: typeof(CalendarView), 
		defaultBindingMode: BindingMode.TwoWay, 
		defaultValue: DateTime.Now,
		propertyChanged: SelectedDatePropertyChanged
		);

    private static void SelectedDatePropertyChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var controls = (CalendarView)bindable;
		if(newValue!= null)
		{
			var newDate = (DateTime)newValue;
			if(controls._tempDate.Month == newDate.Month && controls._tempDate.Year == newDate.Year)
			{
				var currentDate = controls.Dates.Where(f => f.Date == newDate.Date).FirstOrDefault();
				if(currentDate != null)
				{
					controls.Dates.ToList().ForEach(f => f.IsCurrentDate= false);
					currentDate.IsCurrentDate = true;
				}
			} else
			{
                controls.BindDates(newDate);
            }
				
		}
    }

    public DateTime SelectedDate
	{
		get => (DateTime)GetValue(SelectedDateProperty);
		set => SetValue(SelectedDateProperty, value);
	}
	public static readonly BindableProperty SelectedDateCommandProperty = BindableProperty.Create(
		nameof(SelectedDateCommand), typeof(ICommand), declaringType: typeof(CalendarModel));

	
	public event EventHandler<DateTime> OnDateSelected;
    private DateTime _tempDate;
    
    #endregion
    public ObservableCollection<CalendarModel> Dates { get; set; } = new ObservableCollection<CalendarModel>();
	public CalendarView()
	{
		InitializeComponent();
		BindDates(DateTime.Now);
        Loaded += (s, e) =>
        {
			collectionview.ScrollTo(index: _tempDate.Day);
        }; 
    }

    private void BindDates(DateTime date)
	{
		Dates.Clear();
		int daysCount = DateTime.DaysInMonth(date.Year, date.Month);
		for(int day = 1; day <= daysCount; day++)
		{
			Dates.Add(new CalendarModel
			{
				Date = new DateTime(date.Year, date.Month, day)
			});
		}

		var selectedDate = Dates.Where(f => f.Date.Date == SelectedDate.Date).FirstOrDefault();
		if (selectedDate != null) 
		{
			selectedDate.IsCurrentDate = true;
			_tempDate =  selectedDate.Date;
		}
	}
	#region Commands
	public ICommand CurrentDateCommand => new Command<CalendarModel>((currentDate) =>
	{
		_tempDate = currentDate.Date;
		SelectedDate = currentDate.Date;
		OnDateSelected?.Invoke(null, currentDate.Date);
        SelectedDateCommand?.Execute(currentDate.Date);
        //Dates.ToList().ForEach(f =>  f.IsCurrentDate = false );
        //currentDate.IsCurrentDate = true;
    });

	public ICommand NextMonthCommand => new Command(() =>
	{
		_tempDate = _tempDate.AddMonths(1);
		BindDates(_tempDate);
	});
	public ICommand PreviousMonthCommand => new Command(() =>
	{
		_tempDate = _tempDate.AddMonths(-1);
		BindDates(_tempDate);
	});

    public ICommand SelectedDateCommand 
	{ 
		get => (ICommand)GetValue(SelectedDateCommandProperty); 
		set => SetValue(SelectedDateCommandProperty, value); 
	}
    #endregion
}