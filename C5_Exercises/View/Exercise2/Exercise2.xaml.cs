using C5_Exercises.ViewModel;
using CommunityToolkit.Maui.Alerts;

namespace C5_Exercises.View.Exercise2;

public partial class Exercise2 : ContentPage
{
	private ExpenseManagerViewModel _viewModel;
	public Exercise2()
	{
		InitializeComponent();
		_viewModel = (ExpenseManagerViewModel)BindingContext;
        _viewModel.ExpenseEventArgsChanged += ViewModel_ExpenseEventArgsChanged;
	}

    private void ViewModel_ExpenseEventArgsChanged(object sender, ExpenseEventArgs e)
    {
        if(!e.IsValid)
		{
			Toast.Make(e.ErrorMessage,CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
		}
    }

    
}