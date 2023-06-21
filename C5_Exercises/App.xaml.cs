
using C5_Exercises.View.Exercise2;
using C5_Exercises.View.Exercise3;
using C5_Exercises.View.Exercise4;
using C5_Exercises.View.Exercise6;

namespace C5_Exercises;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new Exercise4())
		{
			BarBackgroundColor = Color.Parse("#ffffff"),
		};
	}
}
