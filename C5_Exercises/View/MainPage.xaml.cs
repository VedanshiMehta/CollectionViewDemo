using C5_Exercises.ViewModel;
using CommunityToolkit.Maui.Alerts;

namespace C5_Exercises;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
		string name = (e.CurrentSelection.FirstOrDefault() as Monkey)?.Name;
		Toast.Make(name,CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
    }
}

