using DEINT_Navigation_Demo.MVVM.Views;

namespace DEINT_Navigation_Demo;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new InicialPage());
	}
}
