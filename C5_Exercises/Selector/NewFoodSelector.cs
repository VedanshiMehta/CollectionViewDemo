using C5_Exercises.ViewModel;
using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5_Exercises.Selector
{
    public class NewFoodSelector : DataTemplateSelector
    {
        public DataTemplate NewFood { get; set; }
        public DataTemplate Food { get; set; }
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var newItem = (FoodModel)item;
            if(newItem.New.Contains("NEW"))
            {
                return NewFood;
            }
            else
            {
                return Food;
            }
        }
    }
}
