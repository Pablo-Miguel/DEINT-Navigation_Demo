namespace DEINT_Navigation_Demo.MVVM.Views;

public partial class SecondPage : ContentPage
{
	public SecondPage(string text)
	{
		InitializeComponent();
        txtNameSecondPage.Text = text;
	}

    private void btnInicialPage_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    private void btnFinalPage_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new FinalPage());
        //Navigation.PushModalAsync(new FinalPage());
    }
}