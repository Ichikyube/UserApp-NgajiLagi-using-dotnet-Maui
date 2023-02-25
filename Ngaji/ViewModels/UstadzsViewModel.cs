using Ngaji.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Ngaji.ViewModels
{
    public enum StatusData
    {
        Success,
        Failed,
        Loading
    }
    public class UstadzsViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Ustadz> _ustadzs;

        private bool _isRefreshing = false;
        public bool IsRefreshing
        {
            get => _isRefreshing;
            set
            {
                if (_isRefreshing == value)
                    return;

                _isRefreshing = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsRefreshing)));
            }
        }

        private bool _isBusy = false;
        public bool IsBusy
        {
            get => _isBusy;
            set
            {
                if (_isBusy == value)
                    return;

                _isBusy = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsBusy)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public UstadzsViewModel()
        {
            _ustadzs = new ObservableCollection<Ustadz>();
            LoadDataCommand = new Command(async () => await LoadData());

            Task.Run(LoadData);
        }

        public ObservableCollection<Ustadz> Ustadzs { get => _ustadzs; }

        public ICommand LoadDataCommand { get; private set; }

        public async Task LoadData()
        {
            if (IsBusy)
                return;

            try
            {
                IsRefreshing = true;
                IsBusy = true;

                var ustadzsCollection = await UstadzManager.GetAll();

                MainThread.BeginInvokeOnMainThread(() =>
                {
                    Ustadzs.Clear();

                    foreach (Ustadz part in ustadzsCollection)
                    {
                        if(part != null)
                        {
                            Ustadzs.Add(part);
                        }
                    }
                });
            }
            finally
            {
                IsRefreshing = false;
                IsBusy = false;
            }
        }

    }
}
