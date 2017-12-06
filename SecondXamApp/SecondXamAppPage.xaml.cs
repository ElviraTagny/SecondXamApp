using Xamarin.Forms;

namespace SecondXamApp
{
    public partial class SecondXamAppPage : ContentPage
    {
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            //DisplayAlert("Title", "Congrats !!", "Pff! Exit");
            var menuPage = new NavigationPage(new MenuPage());
            Navigation.PushModalAsync(menuPage);
            //await Application.Current.MainPage.PushAsync(new MenuPage());
        }

        public SecondXamAppPage()
        {
            InitializeComponent();
        }
    }
}
