using C5_Exercises.Enum;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace C5_Exercises.ViewModel
{
    public class PizzasandBurgerViewModel : INotifyPropertyChanged
    {
       

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<FastFood> Foods { get; set; }
        public PizzasandBurgerViewModel()
        {
            Foods = new ObservableCollection<FastFood>()
            {
                new FastFood() { Image = "burger.jpg", Name = " Mc Pork Burger",Price = "$345",FoodType = FoodType.NonVeg},
                new FastFood() { Image = "vegpizza.jpg", Name = "Mc Veg Italian Pizza",Price = "$445",FoodType = FoodType.Veg},
                new FastFood() { Image = "vegpizza1.jpg", Name = "Mc Margreta Pizza",Price = "$355",FoodType = FoodType.Veg},
                new FastFood() { Image = "vegburger.jpg", Name = "Mc Veg Burger",Price = "$310",FoodType = FoodType.Veg},
                new FastFood() { Image = "nonvegburger.jpg", Name = "Mc Saver Pork Burger",Price = "$380",FoodType = FoodType.NonVeg},
                new FastFood() { Image = "veganburger.jpg", Name = "Mc Veg Vegan Burger",Price = "$345",FoodType = FoodType.Veg},
                new FastFood() { Image = "nonvegwrap.jpg", Name = "Mc Saver Pork Wrap",Price = "$200",FoodType = FoodType.NonVeg},
                new FastFood() { Image = "nonvegwrap.jpg", Name = "Mc Saver Pickel Pork Wrap",Price = "$320",FoodType = FoodType.NonVeg},
                new FastFood() { Image = "chessepizza.jpg", Name = " Mc Cheesy 7 Pizza",Price = "$447",FoodType = FoodType.Veg},
                new FastFood() { Image = "vegwrap.jpg", Name = " Mc Veg Wrap",Price = "$150",FoodType = FoodType.Veg},
                new FastFood() { Image = "vegwrap1.jpg", Name = " Mc Veg Cheese Wrap",Price = "$180",FoodType = FoodType.Veg},
                new FastFood() { Image = "nonvegpizza.jpg", Name = " Mc Bacon Cheese Pizza",Price = "$400",FoodType = FoodType.NonVeg},
                new FastFood() { Image = "burger.jpg", Name = " Mc Pork Burger",Price = "$345",FoodType = FoodType.NonVeg},
                new FastFood() { Image = "vegpizza.jpg", Name = "Mc Veg Italian Pizza",Price = "$445",FoodType = FoodType.Veg},
                new FastFood() { Image = "vegpizza1.jpg", Name = "Mc Margreta Pizza",Price = "$355",FoodType = FoodType.Veg},
                new FastFood() { Image = "vegburger.jpg", Name = "Mc Veg Burger",Price = "$310",FoodType = FoodType.Veg},
                new FastFood() { Image = "nonvegburger.jpg", Name = "Mc Saver Pork Burger",Price = "$380",FoodType = FoodType.NonVeg},
                new FastFood() { Image = "veganburger.jpg", Name = "Mc Veg Vegan Burger",Price = "$345",FoodType = FoodType.Veg},
                new FastFood() { Image = "nonvegwrap.jpg", Name = "Mc Saver Pork Wrap",Price = "$200",FoodType = FoodType.NonVeg},
                new FastFood() { Image = "nonvegwrap.jpg", Name = "Mc Saver Pickel Pork Wrap",Price = "$320",FoodType = FoodType.NonVeg},
                new FastFood() { Image = "chessepizza.jpg", Name = " Mc Cheesy 7 Pizza",Price = "$447",FoodType = FoodType.Veg},
                new FastFood() { Image = "vegwrap.jpg", Name = " Mc Veg Wrap",Price = "$150",FoodType = FoodType.Veg},
                new FastFood() { Image = "vegwrap1.jpg", Name = " Mc Veg Cheese Wrap",Price = "$180",FoodType = FoodType.Veg},
                new FastFood() { Image = "nonvegpizza.jpg", Name = " Mc Bacon Cheese Pizza",Price = "$400",FoodType = FoodType.NonVeg},
                new FastFood() { Image = "burger.jpg", Name = " Mc Pork Burger",Price = "$345",FoodType = FoodType.NonVeg},
                new FastFood() { Image = "vegpizza.jpg", Name = "Mc Veg Italian Pizza",Price = "$445",FoodType = FoodType.Veg},
                new FastFood() { Image = "vegpizza1.jpg", Name = "Mc Margreta Pizza",Price = "$355",FoodType = FoodType.Veg},
                new FastFood() { Image = "vegburger.jpg", Name = "Mc Veg Burger",Price = "$310",FoodType = FoodType.Veg},
                new FastFood() { Image = "nonvegburger.jpg", Name = "Mc Saver Pork Burger",Price = "$380",FoodType = FoodType.NonVeg},
                new FastFood() { Image = "veganburger.jpg", Name = "Mc Veg Vegan Burger",Price = "$345",FoodType = FoodType.Veg},
                new FastFood() { Image = "nonvegwrap.jpg", Name = "Mc Saver Pork Wrap",Price = "$200",FoodType = FoodType.NonVeg},
                new FastFood() { Image = "nonvegwrap.jpg", Name = "Mc Saver Pickel Pork Wrap",Price = "$320",FoodType = FoodType.NonVeg},
                new FastFood() { Image = "chessepizza.jpg", Name = " Mc Cheesy 7 Pizza",Price = "$447",FoodType = FoodType.Veg},
                new FastFood() { Image = "vegwrap.jpg", Name = " Mc Veg Wrap",Price = "$150",FoodType = FoodType.Veg},
                new FastFood() { Image = "vegwrap1.jpg", Name = " Mc Veg Cheese Wrap",Price = "$180",FoodType = FoodType.Veg},
                new FastFood() { Image = "nonvegpizza.jpg", Name = " Mc Bacon Cheese Pizza",Price = "$400",FoodType = FoodType.NonVeg},

            };
        }
        public void OnProperyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    public class FastFood
    {
        public ImageSource Image { get; set; }
        public string Name { get; set; }

        public string Price { get; set; }
        public FoodType FoodType { get; set; }
    }
}
