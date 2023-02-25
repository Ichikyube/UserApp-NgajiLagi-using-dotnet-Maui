using Microsoft.Maui.Controls;

namespace Ngaji.Pages.Booking;

public partial class BookingPage : ContentPage
{
    public BookingPage()
    {
        InitializeComponent();
        cal.SelectedDate = DateTime.Now.AddDays(1);
        //TimePicker arrivalTimePicker = new TimePicker();
    }

    private void cal_onDateSelected(object sender, DateTime e)
    {

    }
}