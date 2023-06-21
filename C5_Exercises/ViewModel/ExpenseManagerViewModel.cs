using Microsoft.Extensions.Options;
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
    public class ExpenseManagerViewModel : INotifyPropertyChanged
    {
        private string _errorMessage;
        private string _message { get; set; }
        private bool _isValid { get; set; }
        private string _enterName;
        private string _enterAmount;
        private string _totalAmount;
        public string EnterName { get => _enterName; set { _enterName = value; OnPropertyChange(); } }
        public string EnterAmount { get => _enterAmount; set { _enterAmount = value; OnPropertyChange(); } }
        public string Message { get => _message; set { _message = value; OnPropertyChange(); } }
        public bool IsValid { get => _isValid; set { _isValid = value; OnPropertyChange(); } }
        public string TotalAmount { get => _totalAmount;set { _totalAmount = value; OnPropertyChange(); } }

        public ObservableCollection<ExpenseManagerModel> ExpenseManager { get; set; }


       
        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler<ExpenseEventArgs> ExpenseEventArgsChanged;
        

        public ICommand AddExpense {  get; set; }
        public ICommand DeleteExpense { get; set; }
        public ExpenseManagerViewModel()
        {
            ExpenseManager = new ObservableCollection<ExpenseManagerModel>();
            AddExpense = new Command(AddNewExpense);
            DeleteExpense = new Command<ExpenseManagerModel>(DeleteExpenses);
          
        }

        private void DeleteExpenses(ExpenseManagerModel expenses)
        {
           
                ExpenseManager.Remove(expenses);
                TotalAmount = ExpenseManager.Sum(x => x.ExpenseAmount).ToString();


        }

        private void AddNewExpense()
        {
           
            
            ValidateDetails();
            ExpenseEventArgsChanged?.Invoke(this, new ExpenseEventArgs() {IsValid = IsValid, ErrorMessage = Message });
            if (!string.IsNullOrEmpty(EnterName) && !string.IsNullOrEmpty(EnterAmount))
            {
                
                GetExpenseDetails();
            }
            EnterName = string.Empty;
            EnterAmount = string.Empty;
        }

        private void GetExpenseDetails()
        {
            var model = new ExpenseManagerModel() 
            {
                ExpenseName = EnterName,
                ExpenseAmount = double.Parse(EnterAmount)
            };
            
            ExpenseManager.Add(model);
            TotalAmount = ExpenseManager.Sum(x => x.ExpenseAmount).ToString();
           
            
        }

        private void ValidateDetails()
        {
            if(IsValidName() && IsValidAmount())
            {
               IsValid = true;
                Message = string.Empty;
            }
            else if(!IsValidName() || !IsValidAmount())
            {
                IsValid = false;
                Message = _errorMessage;
            }
        }

        private bool IsValidAmount()
        {
            
                if (string.IsNullOrEmpty(EnterAmount))
                {
                    _errorMessage = "Enter Amount";
                    return false;
                }
            
            return true;

        }

        private bool IsValidName()
        {
            if (string.IsNullOrEmpty(EnterName))
            {
                _errorMessage = "Enter Expense Name";
                return false;
            }
            return true;
        }

        public void OnPropertyChange([CallerMemberName]string propertyName ="")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    public class ExpenseManagerModel
    {
        
        public string ExpenseName { get; set; }
        public double ExpenseAmount { get; set; }

    }
    public class ExpenseEventArgs : EventArgs
    {
        public string ErrorMessage { get; set; }
        public bool IsValid { get; set; }
    }
}
