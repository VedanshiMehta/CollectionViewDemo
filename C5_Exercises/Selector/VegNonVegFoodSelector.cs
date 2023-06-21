using C5_Exercises.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5_Exercises.Selector
{
    public class VegNonVegFoodSelector : DataTemplateSelector
    {
        public DataTemplate NonVegDataTemplate { get; set; }
        public DataTemplate VegDataTemplate { get; set; }
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var foodselector = (FastFood)item;
            return (foodselector.FoodType == Enum.FoodType.NonVeg)? NonVegDataTemplate : VegDataTemplate;
           
        }
    }
}
