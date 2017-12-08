using Xamarin.Forms;

namespace SecondXamApp
{
    public partial class SecondXamAppPage : ContentPage
    {
        public SecondXamAppPage()
        {
            InitializeComponent();
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            //DisplayAlert("Title", "Congrats !!", "Pff! Exit");
            //var menuPage = new NavigationPage(new MenuPage());
            await Navigation.PushAsync(new MenuPage());
            //await Application.Current.MainPage.PushAsync(new MenuPage());
        }

    }
}
