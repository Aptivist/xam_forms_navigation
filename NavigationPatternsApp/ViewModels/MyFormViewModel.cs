using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace NavigationPatternsApp.ViewModels
{
    public class MyFormViewModel : INotifyPropertyChanged
    {
        private int _result;
        private string _title;
        private string _colorName;

        public string ColorName
        {
            get => _colorName;

            set
            {
                if (_colorName != value)
                {
                    _colorName = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ColorName"));
                }
            }
        }

        public int Results
        {
            get => _result;

            set
            {
                if (_result != value)
                {
                    _result = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Results"));
                }
            }
        }

        public string Title
        {
            get => _title;

            set
            {
                if (_title != value)
                {
                    _title = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Title)));
                }
            }
        }

        public ICommand ChangeCommand { get; private set; }
        public ICommand ShowDataCommand { get; private set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public MyFormViewModel()
        {
            ChangeCommand = new Command(OnChangeCommand);
            ShowDataCommand = new Command(OnShowDataCommand);
        }

        private void OnShowDataCommand(object obj)
        {
            Console.WriteLine($"Data in view model for Results: {Results}");

            Console.WriteLine($"Data in view model for Title: {Title}");
        }

        private void OnChangeCommand(object obj)
        {
            Results = 30;
            Title = $"My Title {Results}";
        }


    }
}
