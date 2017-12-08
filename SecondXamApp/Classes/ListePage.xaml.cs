﻿using System;
using System.Collections.Generic;
using Plugin.Messaging;
using Plugin.Share;
using Plugin.Share.Abstractions;
using Xamarin.Forms;

namespace SecondXamApp.Classes
{
    public partial class ListePage : ContentPage, IEmailMessage
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

        public string Message => throw new NotImplementedException();

        public List<IEmailAttachment> Attachments => throw new NotImplementedException();

        public List<string> Recipients => throw new NotImplementedException();

        public List<string> RecipientsBcc => throw new NotImplementedException();

        public List<string> RecipientsCc => throw new NotImplementedException();

        public string Subject => throw new NotImplementedException();

        async void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var selectedItem = e.Item as ListViewTemplate;
            ((ListView)sender).SelectedItem = null;
            var result = await DisplayAlert("Contact " + selectedItem.ContactName, "Number is " + selectedItem.ContactNum, "Cancel", "Send Email");
            if (!result)
            {
                /*if (Device.OS != TargetPlatform.WinPhone)
                {
                    Device.OpenUri(new Uri("tel:0122334455"));
                }*/
                /*var phoneDialer = CrossMessaging.Current.PhoneDialer;
                if (phoneDialer.CanMakePhoneCall){
                    phoneDialer.MakePhoneCall("+272193343499");
                }
                else {
                    await DisplayAlert("Error", "This app cannot query for scheme tel on this device. Try on a real one.", "OK");
                }*/

                /*var smsSender = CrossMessaging.Current.SmsMessenger;
                if(smsSender.CanSendSmsInBackground){
                    smsSender.SendSmsInBackground(recipient:"0033624033685", message:"Coucou from Xamarin App");
                }
                else {
                    await DisplayAlert("Error", "This app cannot send SMS from this device. Try on a real one.", "OK");
                }*/

                /*var emailSender = CrossMessaging.Current.EmailMessenger;
                if(emailSender.CanSendEmail){
                    emailSender.SendEmail(this);
                }*/

                ShareMessage message = new ShareMessage();
                message.Text = "COucou from Xam App";
                message.Title = "Sharing";
                //await CrossShare.Current.Share(message);
                await CrossShare.Current.OpenBrowser("http://munabees.com");
            }
        }
    }
}
