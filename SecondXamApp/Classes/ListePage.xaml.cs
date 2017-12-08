using System;
using System.Collections.Generic;
using Plugin.Messaging;
using Xamarin.Forms;

namespace SecondXamApp.Classes
{
    public partial class ListePage : ContentPage
    {
        public ListePage()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, true);

            ListeContacts.ItemsSource = new List<ListViewTemplate>
            {
                new ListViewTemplate(){
                    ContactNum="0000",
                    ContactName = "Toto"
                },
                new ListViewTemplate(){
                    ContactNum="1111",
                    ContactName = "Tata"
                },
                new ListViewTemplate(){
                    ContactNum="2222",
                    ContactName = "Titi"
                },
                new ListViewTemplate(){
                    ContactNum="3333",
                    ContactName = "Tutu"
                }
            };

        }

        async void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var selectedItem = e.Item as ListViewTemplate;
            ((ListView)sender).SelectedItem = null;
            var result = await DisplayAlert("Contact " + selectedItem.ContactName, "Number is " + selectedItem.ContactNum, "Cancel", "Launch call");
            if (!result)
            {
                /*if (Device.OS != TargetPlatform.WinPhone)
                {
                    Device.OpenUri(new Uri("tel:0122334455"));
                }*/
                var phoneDialer = CrossMessaging.Current.PhoneDialer;
                if (phoneDialer.CanMakePhoneCall){
                    phoneDialer.MakePhoneCall("+272193343499");
                }
                else {
                    await DisplayAlert("Error", "This app cannot query for scheme tel on this device. Try on a real one.", "OK");
                }
            }
        }
    }
}
