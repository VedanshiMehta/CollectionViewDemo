using C5_Exercises.Enum;
using CommunityToolkit.Maui.Core.Extensions;
using System;
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
    public class FurnitureViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private FurnitureMainModel _furnitureMainModel;  
        
        private ObservableCollection<FurnitureItemModel> _furnitureItems { get; set; }
        public ObservableCollection<FurnitureMainModel> FurnitureMainList { get; set; }

        public ObservableCollection<FurnitureItemModel> FurnitureItemList { get; set; }

   

        public ObservableCollection<FurnitureItemModel> ShowFurnitureList { get=> _furnitureItems; set { _furnitureItems = value; OnPropertyChanged(); } }

        public ICommand SelectedItemList { get; private set; }

        public FurnitureMainModel SelectedItem 
        {
            get 
            { 
                return _furnitureMainModel; 
            }
            set
            {
                _furnitureMainModel = value;
                OnPropertyChanged();  
            }
        }
        public FurnitureViewModel()
        {
            SelectedItemList = new Command(ShowSelectedList);
            FurnitureItemList = new ObservableCollection<FurnitureItemModel>
            {
                new FurnitureItemModel(){ItemImage = "woodenchair.jpg", ItemName = "Ivonne Chair",ItemPrice="300 Rs", DiscountPrice = string.Empty, OutOfStock = string.Empty, ProductType = ProductType.Chairs},
                new FurnitureItemModel(){ItemImage = "woodenchair.jpg", ItemName = "Arm Chair",ItemPrice="300 Rs", DiscountPrice = "140 Rs", OutOfStock = string.Empty, ProductType = ProductType.Chairs},
                new FurnitureItemModel() {ItemImage = "woodenchair.jpg", ItemName = "Office Chair",ItemPrice="300 Rs", DiscountPrice = "120 Rs", OutOfStock = string.Empty, ProductType = ProductType.Chairs},
                new FurnitureItemModel() {ItemImage = "woodenchair.jpg", ItemName = "Pattern Buckel Chair",ItemPrice="110 Rs", DiscountPrice = "50 Rs", OutOfStock = "Out Of Stock", ProductType = ProductType.Chairs},
                new FurnitureItemModel(){ItemImage = "woodenchair.jpg", ItemName = "Ivonne Chair",ItemPrice="300 Rs", DiscountPrice = string.Empty, OutOfStock = string.Empty, ProductType = ProductType.Chairs},
                new FurnitureItemModel(){ItemImage = "woodenchair.jpg", ItemName = "Arm Chair",ItemPrice="300 Rs", DiscountPrice = "140 Rs", OutOfStock = string.Empty, ProductType = ProductType.Chairs},
                new FurnitureItemModel() {ItemImage = "woodenchair.jpg", ItemName = "Office Chair",ItemPrice="300 Rs", DiscountPrice = "120 Rs", OutOfStock = string.Empty, ProductType = ProductType.Chairs},
                new FurnitureItemModel() {ItemImage = "woodenchair.jpg", ItemName = "Pattern Buckel Chair",ItemPrice="110 Rs", DiscountPrice = "50 Rs", OutOfStock = "Out Of Stock", ProductType = ProductType.Chairs},
                new FurnitureItemModel() {ItemImage = "tabel.jpg", ItemName = "Office Table",ItemPrice="3000 Rs", DiscountPrice = "1000 Rs", OutOfStock = string.Empty, ProductType = ProductType.Tabel},
                new FurnitureItemModel() {ItemImage = "tabel.jpg", ItemName = "Wooden Table",ItemPrice="3200 Rs", DiscountPrice = "1200 Rs", OutOfStock = "Out Of Stock", ProductType = ProductType.Tabel},
                new FurnitureItemModel() {ItemImage = "tabel.jpg", ItemName = "Office Table",ItemPrice="3000 Rs", DiscountPrice = "1000 Rs", OutOfStock = string.Empty, ProductType = ProductType.Tabel},
                new FurnitureItemModel() {ItemImage = "tabel.jpg", ItemName = "Wooden Table",ItemPrice="3200 Rs", DiscountPrice = "1200 Rs", OutOfStock = "Out Of Stock", ProductType = ProductType.Tabel},
                new FurnitureItemModel() {ItemImage = "sofa.jpg", ItemName = "Baxton Studio Milena Sofa",ItemPrice="13000 Rs", DiscountPrice = "3000 Rs", OutOfStock = string.Empty, ProductType = ProductType.Sofa},
                new FurnitureItemModel() {ItemImage = "sofa.jpg", ItemName = "Baxton Studio Milena Sofa",ItemPrice="13000 Rs", DiscountPrice = "3000 Rs", OutOfStock = string.Empty, ProductType = ProductType.Sofa}

            };
            var totalchairs = FurnitureItemList.Where(x => x.ProductType == ProductType.Chairs).ToList().Count().ToString();
            var totaltabel = FurnitureItemList.Where(x => x.ProductType == ProductType.Tabel).ToList().Count().ToString();
            var totalsofa = FurnitureItemList.Where(x => x.ProductType == ProductType.Sofa).ToList().Count().ToString();
            var totalcupboard = FurnitureItemList.Where(x => x.ProductType == ProductType.Cupboard).ToList().Count().ToString();


            FurnitureMainList = new ObservableCollection<FurnitureMainModel>
            {
               new FurnitureMainModel(){ Image = "woodenchair.jpg", ItemName = "Chair",TotalItems =  totalchairs+" items" ,ProductType = ProductType.Chairs},
               new FurnitureMainModel(){ Image = "tabel.jpg", ItemName = "Table",TotalItems = totaltabel+" items",ProductType = ProductType.Tabel},
               new FurnitureMainModel() { Image = "sofa.jpg", ItemName = "Sofa",TotalItems = totalsofa+" items", ProductType = ProductType.Sofa},
               new FurnitureMainModel() { Image = "cupboard.jpg", ItemName = "Cupboard",TotalItems = totalcupboard+" items", ProductType = ProductType.Cupboard},

            };

            _furnitureMainModel = FurnitureMainList.FirstOrDefault();
            SelectedItem = _furnitureMainModel;


            ShowFurnitureList = FurnitureItemList.Where(x => x.ProductType == SelectedItem.ProductType).ToObservableCollection();
          
           

        }


        private void ShowSelectedList()
        {
            ShowFurnitureList.Clear();
            ShowFurnitureList = FurnitureItemList.Where(x => x.ProductType == SelectedItem.ProductType).ToObservableCollection();
        }

        public void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
       
    }
    public class FurnitureMainModel
    {
        public ImageSource Image { get; set; }
        public string ItemName { get; set; }
        public string TotalItems { get; set; }
        public ProductType ProductType { get; set; }
    }

    public class FurnitureItemModel
    {
        public ImageSource ItemImage { get; set; }
        public string ItemName { get; set; }
        public string ItemPrice { get; set; }
        public string DiscountPrice { get; set; }
        public ProductType ProductType { get; set; }
        public string OutOfStock { get; set; }

    }
}
