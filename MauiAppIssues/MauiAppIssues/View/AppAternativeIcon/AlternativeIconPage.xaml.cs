using MauiAppIssues.Model;
using MauiAppIssues.ViewModel;

namespace MauiAppIssues.View.AppAternativeIcon;

public partial class AlternativeIconPage : ContentPage
{
	public AlternativeIconPage()
	{
		InitializeComponent();
		BindingContext= new ChangeAppIconViewModel();
	}

    private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
		try
		{
			if (e.SelectedItem != null)
			{
				var restClub = e.SelectedItem as ConnectionModel;
				if (restClub != null)
                {// Change the app icon
                    var newIcon = ImageSource.FromFile("demo.png");
                    Application.Current.Resources["MauiControlsAppIcon"] = newIcon;

                    // Change the app name
                    //Application.Current.Properties["AppName"] = "New App Name";

                    //this is For change the App Icon 
                    App._appEnvironmentService?.ChangeIconService?.ChangeIcon(restClub.ClubId);
                }
            }
		}
		catch (Exception ex)
		{

		}
    }
}