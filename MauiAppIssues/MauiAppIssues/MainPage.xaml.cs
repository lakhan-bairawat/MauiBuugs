using MauiAppIssues.View.AppAternativeIcon;
using Microsoft.Maui.Handlers;

namespace MauiAppIssues
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

        }

        #region TO NAVIGATE THE iCON iSSUE PAGE
        private void OnCounterClicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new AlternativeIconPage());
            }
            catch (Exception EX)
            {

            }
        }
        #endregion

        #region Picker not focus in android but working properly in ios
        private void OpenPicker_Tapped(object sender, TappedEventArgs e)
        {
            try
            {
            
                picker.Focus();//it should be focus the picker like ios
                // it's working perfect also in xamarin

            }
            catch (Exception ex)
            {

            }
        }
        #endregion
    }

}
