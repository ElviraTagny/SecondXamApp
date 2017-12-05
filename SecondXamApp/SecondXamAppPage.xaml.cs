using Xamarin.Forms;

namespace SecondXamApp
{
    public partial class SecondXamAppPage : ContentPage
    {
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            //DisplayAlert("Title", "Congrats !!", "Pff! Exit");
            Navigation.PushModalAsync(new MenuPage());
        }

        public SecondXamAppPage()
        {
            InitializeComponent();
        }
    }
}
