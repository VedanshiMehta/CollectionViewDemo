using C5_Exercises.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5_Exercises.Selector
{
    public class FurnitureSelector : DataTemplateSelector
    {
        public DataTemplate NormalTemplate { get; set; }    
        public DataTemplate DiscountPriceTemplate { get; set; }

        public DataTemplate OutOfStockTemplate { get; set; }
       
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var furniture = (FurnitureItemModel)item;

            if(furniture.OutOfStock.Contains("Out Of Stock"))
            {
                return OutOfStockTemplate;
                
            }
            else if (!string.IsNullOrEmpty(furniture.DiscountPrice))
            {
                return DiscountPriceTemplate;
            }
            else
            { 
                return NormalTemplate; 
            }
        }
    }
}
