namespace DEINT_Navigation_Demo.MVVM.Views;

public partial class FinalPage : ContentPage
{
	public FinalPage()
	{
		InitializeComponent();
	}

    private void btnSecondPage_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
        //Navigation.PopModalAsync();
    }

    private void btnInicialPage_Clicked(object sender, EventArgs e)
    {
        Navigation.PopToRootAsync();
    }

    protected override bool OnBackButtonPressed()
    {
        return true;
    }

}