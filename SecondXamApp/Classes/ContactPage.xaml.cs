using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Plugin.Messaging;

namespace SecondXamApp.Classes
{
    public partial class ContactPage : ContentPage
    {
        public ContactPage()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, true);

            ListeContacts.ItemsSource = new List<ContactTemplate>
            {
                new ContactTemplate(){
                    ContactNum="0000",
                    ContactName = "Toto"
                },
                new ContactTemplate(){
                    ContactNum="1111",
                    ContactName = "Tata"
                },
                new ContactTemplate(){
                    ContactNum="2222",
                    ContactName = "Titi"
                },
                new ContactTemplate(){
                    ContactNum="3333",
                    ContactName = "Tutu"
                }
            };
        }

        async void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var selectedItem = e.Item as ContactTemplate;
            ((ListView)sender).SelectedItem = null;
            var result = await DisplayAlert("Contact " + selectedItem.ContactName, "Number is " + selectedItem.ContactNum, "Cancel", "Launch call");
            if (!result)
            {
                var phoneDialer = CrossMessaging.Current.PhoneDialer;
                if (phoneDialer.CanMakePhoneCall)
                {
                    phoneDialer.MakePhoneCall("+272193343499");
                }
                else
                {
                    await DisplayAlert("Error", "This app cannot query for scheme tel on this device. Try on a real one.", "OK");
                }
                /*if (Device.OS != TargetPlatform.WinPhone)
                {
                    Device.OpenUri(new Uri("tel:0122334455"));
                }*/

                /*var smsSender = CrossMessaging.Current.SmsMessenger;
                if(smsSender.CanSendSmsInBackground){
                    smsSender.SendSmsInBackground(recipient:"0033624033685", message:"Coucou from Xamarin App");
                }
                else {
                    await DisplayAlert("Error", "This app cannot send SMS from this device. Try on a real one.", "OK");
                }*/
            }
        }
    }
}
