using CommunityToolkit.Maui.Alerts;

namespace MauiComm_IssueSnackbarCrash
{
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void btnShow_Clicked(object sender, EventArgs e)
        {
            Snackbar.Make("This is test message.", null, string.Empty, new TimeSpan(0, 0, 0, 0, 3000), new CommunityToolkit.Maui.Core.SnackbarOptions() { BackgroundColor = Colors.Green, TextColor = Colors.White }, gdSnackBarAnchor).Show();
        }

        private void btnBack_Clicked(object sender, EventArgs e)
        {
            Shell.Current.Navigation.PopAsync(false);
        }
    }
}
