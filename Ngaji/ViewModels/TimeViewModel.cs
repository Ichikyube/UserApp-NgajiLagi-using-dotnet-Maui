using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngaji.ViewModels
{
    class TimeViewModel : INotifyPropertyChanged
    {
        public DateTime Time { get; set; }
        public DateTimeOffset TimeOffset { get; set; }

        //readonly IList<TimePicker> source;
        //TimePicker selectedTime;

        public event PropertyChangedEventHandler PropertyChanged;
    }

    /*public ObservableCollection<TimePicker> Monkeys { get; private set; }

    public TimeViewModel SelectedTime
    {
        get
        {
            return selectedMonkey;
        }
        set
        {
            if (selectedMonkey != value)
            {
                selectedMonkey = value;
            }
        }
    }

    public ICommand DeleteCommand => new Command<Monkey>(RemoveMonkey);
    public ICommand FavoriteCommand => new Command<Monkey>(FavoriteMonkey);

    public MonkeysViewModel()
    {
        source = new List<Monkey>();
        CreateMonkeyCollection();

        SelectedMonkey = Monkeys.Skip(3).FirstOrDefault();
        OnPropertyChanged("SelectedMonkey");

    }

    #region INotifyPropertyChanged
    public event PropertyChangedEventHandler PropertyChanged;

    void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
    #endregion

}}*/

}
