using C5_Exercises.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5_Exercises.Selector
{
    public class MonkeyDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate AmericanMonkey {  get; set; }  
        public DataTemplate OtherMonkey { get;set; }
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var monkey = (Monkey)item;
            if (monkey.Location.Contains("America"))
            {
                return AmericanMonkey;
            }
            else
            {
                return OtherMonkey;
            }
        }
    }
}
