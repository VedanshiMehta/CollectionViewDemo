using C5_Exercises.Enum;
using CommunityToolkit.Maui.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace C5_Exercises.ViewModel
{
    public class ShoppingViewModel : INotifyPropertyChanged
    {
       
        private MainCategory _category;
        private string _emptyView { get; set; }
        private bool _isfavPressed;
        private CategoryType _itemcategory;
        private ObservableCollection<Category> _showSelectedCategoryList { get;set; }
        public ObservableCollection<MainCategory> MainCategoryList { get; set; }

        public ObservableCollection<Category> Categories { get; set; }
        public MainCategory MainCategory { get { return _category; } set { _category = value; OnpropertyChanged(); } }



        public ObservableCollection<Category> ShowSelectedCategoryList { get => _showSelectedCategoryList; set { _showSelectedCategoryList = value; OnpropertyChanged(); } }

        public ObservableCollection<Category> FavCategories { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand SelectedMainCategory { get; private set; }
        public ICommand FavouriteItem { get; private set; }
        public string EmptyView { get => _emptyView; set { _emptyView = value; OnpropertyChanged(); } }
        public ShoppingViewModel()
        {
            FavCategories = new ObservableCollection<Category>();   
            SelectedMainCategory = new Command(SelectMainCategories);

            FavouriteItem = new Command<Category>(AddFavouriteItems);

            MainCategoryList = new ObservableCollection<MainCategory>()
            {
                new MainCategory(){ Name = "All",CategoryType = CategoryType.All},
                new MainCategory(){ Name = "Winter",CategoryType = CategoryType.Winter},
                new MainCategory(){ Name = "Men",CategoryType = CategoryType.Men},
                new MainCategory(){ Name = "Women",CategoryType = CategoryType.Women},
                new MainCategory(){ Name = "Sports",CategoryType = CategoryType.Sports},
            };


            Categories = new ObservableCollection<Category>()
            {
                new Category(){ ImageSource = "menclothes1.jpg",ItemName="Roadster",Amount= "$ 14.99", FavouriteImage = "fillheart", CategoryTypeAll= CategoryType.All,CategoryTypeWinter = CategoryType.Winter,CategoryTypeMen = CategoryType.Men,CategoryTypeWomen = CategoryType.None ,CategoryTypeSports = CategoryType.None},
                new Category(){ ImageSource = "menclothes2.jpg",ItemName="Raymond",Amount="$ 12.67", FavouriteImage = "fillheart",CategoryTypeAll = CategoryType.All,CategoryTypeWinter = CategoryType.None,CategoryTypeMen = CategoryType.Men,CategoryTypeWomen = CategoryType.None ,CategoryTypeSports = CategoryType.None},
                new Category(){ ImageSource = "menclothes3.jpg",ItemName="Siyaram",Amount= "$ 15.19", FavouriteImage = "fillheart",CategoryTypeAll = CategoryType.All,CategoryTypeWinter = CategoryType.None,CategoryTypeMen = CategoryType.Men,CategoryTypeWomen = CategoryType.None ,CategoryTypeSports = CategoryType.None},
                new Category(){ ImageSource = "menclothes4.jpg",ItemName="Arrow",Amount= "$ 18.78", FavouriteImage = "fillheart",CategoryTypeAll = CategoryType.All,CategoryTypeWinter = CategoryType.None,CategoryTypeMen = CategoryType.Men,CategoryTypeWomen = CategoryType.None ,CategoryTypeSports = CategoryType.None},
                new Category(){ ImageSource = "menclothes5.jpg",ItemName="Allen Solly",Amount= "$ 15.39", FavouriteImage = "fillheart",CategoryTypeAll = CategoryType.All,CategoryTypeWinter = CategoryType.Winter,CategoryTypeMen = CategoryType.Men,CategoryTypeWomen = CategoryType.None ,CategoryTypeSports = CategoryType.None},
                new Category(){ ImageSource = "menclothes6.jpg",ItemName="Allen Solly",Amount= "$ 13.50", FavouriteImage = "fillheart",CategoryTypeAll = CategoryType.All,CategoryTypeWinter = CategoryType.Winter,CategoryTypeMen = CategoryType.Men,CategoryTypeWomen = CategoryType.None ,CategoryTypeSports = CategoryType.None},

                new Category(){ ImageSource = "womenclothes2.jpg",ItemName="Green Coordset",Amount= "$ 20.99", FavouriteImage = "fillheart",CategoryTypeAll = CategoryType.All,CategoryTypeWinter = CategoryType.Winter,CategoryTypeMen = CategoryType.None,CategoryTypeWomen = CategoryType.Women ,CategoryTypeSports = CategoryType.None},
                new Category(){ ImageSource = "womensclothes3.jpg",ItemName="Nike Tshirt",Amount= "$ 15.78", FavouriteImage = "fillheart",CategoryTypeAll = CategoryType.All,CategoryTypeWinter = CategoryType.None,CategoryTypeMen = CategoryType.None,CategoryTypeWomen = CategoryType.Women ,CategoryTypeSports = CategoryType.None},
                new Category(){ ImageSource = "womensclothes4.jpg",ItemName="Libas Blue Cotton Kurta", FavouriteImage = "fillheart",Amount= "$ 12.99",CategoryTypeAll = CategoryType.All,CategoryTypeWinter = CategoryType.None,CategoryTypeMen = CategoryType.None,CategoryTypeWomen = CategoryType.Women ,CategoryTypeSports = CategoryType.None},
                new Category(){ ImageSource = "womensclothes5.jpg",ItemName="H&M Dress",Amount= "$ 20.09", FavouriteImage = "fillheart",CategoryTypeAll = CategoryType.All,CategoryTypeWinter = CategoryType.None,CategoryTypeMen = CategoryType.None,CategoryTypeWomen = CategoryType.Women ,CategoryTypeSports = CategoryType.None},
                new Category(){ ImageSource = "womensclothes6.jpg",ItemName="H&M Dress",Amount= "$ 16.89", FavouriteImage = "fillheart",CategoryTypeAll = CategoryType.All,CategoryTypeWinter = CategoryType.None,CategoryTypeMen = CategoryType.None,CategoryTypeWomen = CategoryType.Women ,CategoryTypeSports = CategoryType.None},
                new Category(){ ImageSource = "womensclothes7.jpg",ItemName="Levis Jeans",Amount= "$ 18.60", FavouriteImage = "fillheart",CategoryTypeAll = CategoryType.All,CategoryTypeWinter = CategoryType.None,CategoryTypeMen = CategoryType.None,CategoryTypeWomen = CategoryType.Women ,CategoryTypeSports = CategoryType.None},
                new Category(){ ImageSource = "womensclothes8.jpg",ItemName="Zara Dress",Amount= "$ 19.99", FavouriteImage = "fillheart",CategoryTypeAll = CategoryType.All,CategoryTypeWinter = CategoryType.None,CategoryTypeMen = CategoryType.None,CategoryTypeWomen = CategoryType.Women ,CategoryTypeSports = CategoryType.None},
                new Category(){ ImageSource = "womenclothes9.jpg",ItemName="Rodster",Amount= "$ 15.29",FavouriteImage = "fillheart", CategoryTypeAll = CategoryType.All,CategoryTypeWinter = CategoryType.Winter,CategoryTypeMen = CategoryType.None,CategoryTypeWomen = CategoryType.Women ,CategoryTypeSports = CategoryType.None},
                new Category(){ ImageSource = "womenclothes10.jpg",ItemName="Street9",Amount= "$ 14.99" , FavouriteImage = "fillheart",CategoryTypeAll = CategoryType.All,CategoryTypeWinter = CategoryType.Winter,CategoryTypeMen = CategoryType.None,CategoryTypeWomen = CategoryType.Women ,CategoryTypeSports = CategoryType.None},




            };

            _category = MainCategoryList.FirstOrDefault();
            MainCategory = _category;


            _itemcategory = MainCategory.CategoryType;

            switch (_itemcategory)
            {

                case CategoryType.All:
                    ShowSelectedCategoryList = Categories.Where(x => x.CategoryTypeAll == MainCategory.CategoryType).ToObservableCollection();
                    break;
                case CategoryType.Winter:
                    ShowSelectedCategoryList = Categories.Where(x => x.CategoryTypeWinter == MainCategory.CategoryType).ToObservableCollection();
                    break;
                case CategoryType.Men:
                    ShowSelectedCategoryList = Categories.Where(x => x.CategoryTypeMen == MainCategory.CategoryType).ToObservableCollection();
                    break;
                case CategoryType.Women:
                    ShowSelectedCategoryList = Categories.Where(x => x.CategoryTypeWomen == MainCategory.CategoryType).ToObservableCollection();
                    break;
                case CategoryType.Sports:
                    ShowSelectedCategoryList = Categories.Where(x => x.CategoryTypeSports == MainCategory.CategoryType).ToObservableCollection();
                   
                    break;
              
            }
            EmptyView = (ShowSelectedCategoryList.Count == 0) ? "No data available for " + MainCategory.CategoryType.ToString() : string.Empty;
            
        }

        private void AddFavouriteItems(Category category)
        {
            var index = ShowSelectedCategoryList.IndexOf(category);
           
            if (ShowSelectedCategoryList[index].FavouriteImage.Equals("fillheart"))
            {
                FavCategories.Add(category);
                ShowSelectedCategoryList[index].FavouriteImage = "redheart";

                ShowSelectedCategoryList.RemoveAt(index);
                ShowSelectedCategoryList.Insert(index, category);
            }
            else
            {
                FavCategories.Remove(category);
                ShowSelectedCategoryList[index].FavouriteImage = "fillheart";
                ShowSelectedCategoryList.RemoveAt(index);
                ShowSelectedCategoryList.Insert(index, category);
            }
                
        }

        private void SelectMainCategories()
        {
            _itemcategory = MainCategory.CategoryType;

            switch (_itemcategory)
            {

                case CategoryType.All:
                    ShowSelectedCategoryList = Categories.Where(x => x.CategoryTypeAll == MainCategory.CategoryType).ToObservableCollection();
                    break;
                case CategoryType.Winter:
                    ShowSelectedCategoryList = Categories.Where(x => x.CategoryTypeWinter == MainCategory.CategoryType).ToObservableCollection();
                    break;
                case CategoryType.Men:
                    ShowSelectedCategoryList = Categories.Where(x => x.CategoryTypeMen == MainCategory.CategoryType).ToObservableCollection();
                    break;
                case CategoryType.Women:
                    ShowSelectedCategoryList = Categories.Where(x => x.CategoryTypeWomen == MainCategory.CategoryType).ToObservableCollection();
                    break;
                case CategoryType.Sports:
                    ShowSelectedCategoryList = Categories.Where(x => x.CategoryTypeSports == MainCategory.CategoryType).ToObservableCollection();
                    break;

            }
            
            EmptyView = (ShowSelectedCategoryList.Count == 0)? "No data available for " + MainCategory.CategoryType.ToString() : string.Empty;


        }

        public void OnpropertyChanged([CallerMemberName]string propertyName ="")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    public class MainCategory
    {
        public string Name { get; set; }
        public CategoryType CategoryType { get; set; }
    }
    public class Category
    {
        public ImageSource ImageSource { get; set; }
        public string ItemName { get; set; }
        public string Amount { get; set; }
        public string FavouriteImage { get;set; }
        public CategoryType CategoryTypeAll { get; set; }
        public CategoryType CategoryTypeWinter { get; set; }
        public CategoryType CategoryTypeMen { get; set; }
        public CategoryType CategoryTypeWomen { get; set; }
        public CategoryType CategoryTypeSports { get; set; }
    }
}
