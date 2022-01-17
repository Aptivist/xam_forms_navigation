using System;
using System.ComponentModel;
using System.Windows.Input;
using NavigationPatternsApp.Models;
using Xamarin.Forms;

namespace NavigationPatternsApp.ViewModels
{
    public class NoteDetailViewModel : INotifyPropertyChanged
    {
        private string _title;
        private string _detail;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Title
        {
            get => _title;
            set
            {
                if (value != _title)
                {
                    _title = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Title"));
                }
            }
        }

        public string Detail
        {
            get => _detail;
            set
            {
                if (value != _detail)
                {
                    _detail = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Detail"));
                }
            }
        }

        public ICommand SaveCommand { get; private set; }

        public NoteDetailViewModel()
        {
            SaveCommand = new Command(OnSaveCommand);
        }

        private void OnSaveCommand(object obj)
        {
            /*
            var myNote = new Note();
            myNote.Title = Title;
            myNote.Detail = Detail;

          */
            var product = new Product();
            product.ProductName = Title;
            product.Description = Detail;
            //TODO: save somewhere
            Console.WriteLine($"product Saved: {product.Description}");
        }
    }
}
