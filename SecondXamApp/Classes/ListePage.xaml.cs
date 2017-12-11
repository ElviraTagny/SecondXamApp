using System;
using System.Collections.Generic;
using Plugin.Messaging;
using Plugin.Share;
using Plugin.Share.Abstractions;
using Xamarin.Forms;

namespace SecondXamApp.Classes
{
    public partial class ListePage : ContentPage
    {
        public ListePage()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, true);

            Options.ItemsSource = new List<ListViewTemplate>
            {
                new ListViewTemplate(){
                    Id=1,
                    Name="Send SMS",
                    Description = "A tool that helps sending SMS"
                },
                new ListViewTemplate(){
                    Id=2,
                    Name="Send Email",
                    Description = "A tool that helps sending emails"
                },
                new ListViewTemplate(){
                    Id=3,
                    Name="Share message",
                    Description = "A tool that helps sharing files"
                },
                new ListViewTemplate(){
                    Id=4,
                    Name="Open Browser",
                    Description = "A tool that helps opening a browser"
                }
            };

        }
       
        async void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var selectedItem = e.Item as ListViewTemplate;
            ((ListView)sender).SelectedItem = null;

            switch(selectedItem.Id){
                case 1:
                    var smsSender = CrossMessaging.Current.SmsMessenger;
                    if (smsSender.CanSendSmsInBackground)
                    {
                        smsSender.SendSmsInBackground(recipient: "0033624033685", message: "Coucou from Xamarin App");
                    }
                    else
                    {
                        await DisplayAlert("Error", "This app cannot send SMS from this device. Try on a real one.", "OK");
                    }
                    break;
                case 2:
                    /*var emailTask = MessagingPlugin.EmailMessenger;
                    if (emailTask.CanSendEmail)
                    {
                        // Send simple e-mail to single receiver without attachments, CC, or BCC.
                        //emailTask.SendEmail("tagnytest@gmail.com", "Xamarin Messaging Plugin", "Hello from your XamAPp!");

                        // Send a more complex email with the EmailMessageBuilder fluent interface.
                        var email = new EmailMessageBuilder()
                          .To("tagnytest@gmail.com")
                          .Cc("elvira.tagny@soprasteria.com")
                          .Bcc(new[] { "tagny.elvira@gmail.com" })
                          .Subject("Xamarin Messaging Plugin")
                          .Body("Hello from your XamApp!")
                          .Build();

                        emailTask.SendEmail(email);
                    }*/
                    break;
                case 3:
                    ShareMessage message = new ShareMessage();
                    message.Text = "Coucou from Xam App";
                    message.Title = "Sharing";
                    await CrossShare.Current.Share(message);
                    break;
                case 4:
                    await CrossShare.Current.OpenBrowser("http://munabees.com");
                    break;
                default:
                    break;
            }         
        }
    }
}
