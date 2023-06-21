using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace C5_Exercises.ViewModel
{
     public class FoodViewModel  : INotifyPropertyChanged
    {

        private bool _isRefreshing;
        public bool IsRefreshing { get => _isRefreshing; set { _isRefreshing = value; OnPropertyChanged(); } }
        public ObservableCollection<FoodModel> Foods { get; set; }
       
        public ICommand RefreshIt { get; private set; }
        public event PropertyChangedEventHandler PropertyChanged;
        public FoodViewModel()
        {
            GetFoodDetails();
            RefreshIt = new Command(RefreshData);
        }

        private async void RefreshData()
        {
            IsRefreshing = true;
            GetFoodDetails();
            await Task.Delay(1000);
            IsRefreshing = false;
        }

        private void GetFoodDetails()
        {
            Foods = new ObservableCollection<FoodModel>
            {
                new FoodModel(){Image = ImageSource.FromFile("pizza.jpg"), FoodName = "Cheese Pizza",Rating="4.8",Calories="160 KCal" , Time = "25:00",New ="NEW"},
                new FoodModel(){Image = ImageSource.FromFile("pancake.jpg"), FoodName = "Blueberry Pan Cake",Rating="4.4",Calories="120 KCal" , Time = "15:00",New = string.Empty},
                new FoodModel(){Image = ImageSource.FromFile("icecream.jpg"), FoodName = "Cream N Cookies Ice Cream",Rating="4.9",Calories="100 KCal" , Time = "20:00",New ="NEW"},
                new FoodModel(){Image = ImageSource.FromFile("vadapav.jpg"), FoodName = "Grilled Vada Paav",Rating="5",Calories="260 KCal" , Time = "30:00",New = string.Empty},
                new FoodModel(){Image = ImageSource.FromFile("pizza.jpg"), FoodName = "Cheese Pizza",Rating="4.8",Calories="160 KCal" , Time = "25:00",New ="NEW"},
                new FoodModel(){Image = ImageSource.FromFile("pancake.jpg"), FoodName = "Blueberry Pan Cake",Rating="4.4",Calories="120 KCal" , Time = "15:00",New = string.Empty},
                new FoodModel(){Image = ImageSource.FromFile("icecream.jpg"), FoodName = "Cream N Cookies Ice Cream",Rating="4.9",Calories="100 KCal" , Time = "20:00",New ="NEW"},
                new FoodModel(){Image = ImageSource.FromFile("vadapav.jpg"), FoodName = "Grilled Vada Paav",Rating="5",Calories="260 KCal" , Time = "30:00",New = string.Empty},
                new FoodModel(){Image = ImageSource.FromFile("pizza.jpg"), FoodName = "Cheese Pizza",Rating="4.8",Calories="160 KCal" , Time = "25:00",New ="NEW"},
                new FoodModel(){Image = ImageSource.FromFile("pancake.jpg"), FoodName = "Blueberry Pan Cake",Rating="4.4",Calories="120 KCal" , Time = "15:00",New = string.Empty},
                new FoodModel(){Image = ImageSource.FromFile("icecream.jpg"), FoodName = "Cream N Cookies Ice Cream",Rating="4.9",Calories="100 KCal" , Time = "20:00",New ="NEW"},
                new FoodModel(){Image = ImageSource.FromFile("vadapav.jpg"), FoodName = "Grilled Vada Paav",Rating="5",Calories="260 KCal" , Time = "30:00",New = string.Empty},
                new FoodModel(){Image = ImageSource.FromFile("pizza.jpg"), FoodName = "Cheese Pizza",Rating="4.8",Calories="160 KCal" , Time = "25:00",New ="NEW"},
                new FoodModel(){Image = ImageSource.FromFile("pancake.jpg"), FoodName = "Blueberry Pan Cake",Rating="4.4",Calories="120 KCal" , Time = "15:00",New = string.Empty},
                new FoodModel(){Image = ImageSource.FromFile("icecream.jpg"), FoodName = "Cream N Cookies Ice Cream",Rating="4.9",Calories="100 KCal" , Time = "20:00",New ="NEW"},
                new FoodModel(){Image = ImageSource.FromFile("vadapav.jpg"), FoodName = "Grilled Vada Paav",Rating="5",Calories="260 KCal" , Time = "30:00",New = string.Empty},
                new FoodModel(){Image = ImageSource.FromFile("pizza.jpg"), FoodName = "Cheese Pizza",Rating="4.8",Calories="160 KCal" , Time = "25:00",New ="NEW"},
                new FoodModel(){Image = ImageSource.FromFile("pancake.jpg"), FoodName = "Blueberry Pan Cake",Rating="4.4",Calories="120 KCal" , Time = "15:00",New = string.Empty},
                new FoodModel(){Image = ImageSource.FromFile("icecream.jpg"), FoodName = "Cream N Cookies Ice Cream",Rating="4.9",Calories="100 KCal" , Time = "20:00",New ="NEW"},
                new FoodModel(){Image = ImageSource.FromFile("vadapav.jpg"), FoodName = "Grilled Vada Paav",Rating="5",Calories="260 KCal" , Time = "30:00",New = string.Empty},
                new FoodModel(){Image = ImageSource.FromFile("pizza.jpg"), FoodName = "Cheese Pizza",Rating="4.8",Calories="160 KCal" , Time = "25:00",New ="NEW"},
                new FoodModel(){Image = ImageSource.FromFile("pancake.jpg"), FoodName = "Blueberry Pan Cake",Rating="4.4",Calories="120 KCal" , Time = "15:00",New = string.Empty},
                new FoodModel(){Image = ImageSource.FromFile("icecream.jpg"), FoodName = "Cream N Cookies Ice Cream",Rating="4.9",Calories="100 KCal" , Time = "20:00",New ="NEW"},
                new FoodModel(){Image = ImageSource.FromFile("vadapav.jpg"), FoodName = "Grilled Vada Paav",Rating="5",Calories="260 KCal" , Time = "30:00",New = string.Empty},
                new FoodModel(){Image = ImageSource.FromFile("pizza.jpg"), FoodName = "Cheese Pizza",Rating="4.8",Calories="160 KCal" , Time = "25:00",New ="NEW"},
                new FoodModel(){Image = ImageSource.FromFile("pancake.jpg"), FoodName = "Blueberry Pan Cake",Rating="4.4",Calories="120 KCal" , Time = "15:00",New = string.Empty},
                new FoodModel(){Image = ImageSource.FromFile("icecream.jpg"), FoodName = "Cream N Cookies Ice Cream",Rating="4.9",Calories="100 KCal" , Time = "20:00",New ="NEW"},
                new FoodModel(){Image = ImageSource.FromFile("vadapav.jpg"), FoodName = "Grilled Vada Paav",Rating="5",Calories="260 KCal" , Time = "30:00",New = string.Empty},
            };
        }

        public void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    public class FoodModel
    {
        public ImageSource Image { get; set; }
        public string FoodName { get; set; }
        public string Rating { get; set; }
        public string Calories { get; set; }

        public string Time { get; set; }

        public string New { get; set; }
    }
}
