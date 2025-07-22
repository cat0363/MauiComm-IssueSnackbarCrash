namespace MauiComm_IssueSnackbarCrash;

public partial class Page1 : ContentPage
{
	public Page1()
	{
		InitializeComponent();
	}

    private void btnNext_Clicked(object sender, EventArgs e)
    {
        Shell.Current.Navigation.PushAsync(new Page2(), false);
    }
}