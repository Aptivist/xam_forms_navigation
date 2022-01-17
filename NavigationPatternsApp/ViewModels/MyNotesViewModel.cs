using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;
using NavigationPatternsApp.Models;
using Xamarin.Forms;

namespace NavigationPatternsApp.ViewModels
{
    public class MyNotesViewModel : INotifyPropertyChanged
    {
        private readonly INavigation _navigation;

        public ObservableCollection<City> Cities { get; private set; }
        public event PropertyChangedEventHandler PropertyChanged;

        private bool _isrefreshing;

        public bool IsRefreshing
        {
            get => _isrefreshing;

            set
            {
                if (_isrefreshing != value)
                {
                    _isrefreshing = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsRefreshing"));
                }
            }
        }

        public ICommand RefreshCommand { get; private set; }
        public ICommand DeleteCommand { get; private set; }
        public ICommand ShowCommand { get; private set; }

        
        public MyNotesViewModel(INavigation navigation)
        {
            _navigation = navigation;

            Cities = new ObservableCollection<City>();
            ShowCommand = new Command<City>(OnShowCommand);
            DeleteCommand = new Command<City>(OnDeleteCommand);
            RefreshCommand = new Command(async() => await OnRefreshCommand());
        }

        private void OnShowCommand(City obj)
        {
            _navigation.PushAsync(new CityDetail(obj));
        }

        private void OnDeleteCommand(City city)
        {
            Cities.Remove(city);
        }

        private async Task OnRefreshCommand()
        {
            IsRefreshing = true;

            //call api
            await Task.Delay(TimeSpan.FromSeconds(2));

            Cities.Add(new City()
            {
                Name = "Cancun",
                Url = "https://elcomercio.pe/resizer/79bdUO7FPcWTQKz2Q26tXy_viTM=/980x0/smart/filters:format(jpeg):quality(75)/cloudfront-us-east-1.images.arcpublishing.com/elcomercio/4REEHFEWSRFQDFRGRTUCJDPRXM.jpg"
            });

            Cities.Add(new City()
            {
                Name = "Paris",
                Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f6/Eiffel_tower_at_dawn_horizontal.jpg/1200px-Eiffel_tower_at_dawn_horizontal.jpg"
            });

            Cities.Add(new City()
            {
                Name = "Tokio",
                Url = "https://media.admagazine.com/photos/618a6025ac089e092dcbfe42/master/w_1600%2Cc_limit/88202.jpg"
            });
            //throw new NotImplementedException();
            IsRefreshing = false;
        }
    }
}
