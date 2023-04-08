namespace DEINT_Navigation_Demo.MVVM.Views;

public partial class InicialPage : ContentPage
{
	public InicialPage()
	{
		InitializeComponent();
	}

    private void btnSecondPage_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new SecondPage(txtNameInicialPage.Text));
    }
}