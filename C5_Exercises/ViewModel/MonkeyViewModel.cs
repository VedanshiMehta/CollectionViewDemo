using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace C5_Exercises.ViewModel
{
    public class MonkeyViewModel :INotifyPropertyChanged
    {

        private bool _isRefreshing;
        public ObservableCollection<Monkey> Monkeys { get; set; }
        public bool IsRefreshing { get => _isRefreshing; set { _isRefreshing = value; OnPropertyChanged(); } }
        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand StopResfreshing { get;  private set; }
        public MonkeyViewModel() {


            LoadMonkeyDetails();
            StopResfreshing = new Command(LoadData);
            

        }

        private void LoadMonkeyDetails()
        {
            Monkeys = new ObservableCollection<Monkey>
            {
                new Monkey(){Name = "Baboon", Location="America"},
                new Monkey(){Name = "Blue", Location="Other"},
                new Monkey(){Name = "Squirrel", Location = "America"},
                new Monkey(){Name = "Howler", Location = "Other"},
                new Monkey(){Name = "Baboon", Location="America"},
                new Monkey(){Name = "Blue", Location="Other"},
                new Monkey(){Name = "Squirrel", Location = "America"},
                new Monkey(){Name = "Howler", Location = "Other"},
                new Monkey(){Name = "Baboon", Location="America"},
                new Monkey(){Name = "Blue", Location="Other"},
                new Monkey(){Name = "Squirrel", Location = "America"},
                new Monkey(){Name = "Howler", Location = "Other"},
                new Monkey(){Name = "Baboon", Location="America"},
                new Monkey(){Name = "Blue", Location="Other"},
                new Monkey(){Name = "Squirrel", Location = "America"},
                new Monkey(){Name = "Howler", Location = "Other"},
                new Monkey(){Name = "Baboon", Location="America"},
                new Monkey(){Name = "Blue", Location="Other"},
                new Monkey(){Name = "Squirrel", Location = "America"},
                new Monkey(){Name = "Howler", Location = "Other"},
            };
        }

        private async void LoadData()
        {
            
           IsRefreshing = true;
            LoadMonkeyDetails();
            await Task.Delay(2000);
            IsRefreshing = false;
        }

        public void OnPropertyChanged([CallerMemberName]string propertyName ="")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    
    }
    public class Monkey
    {
        public string Name { get; set; }
        public string Location { get;set; }
    }
 

      
}
