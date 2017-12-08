using System;
using System.Collections.Generic;
using SecondXamApp.Classes;
using Xamarin.Forms;

namespace SecondXamApp
{
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, true);
            // = new MenuPage();
            /*if(Device.OS == TargetPlatform.iOS){
                Padding = new Thickness(10, 20, 10, 0);
            }*/

            /*Padding = Device.OnPlatform(
                iOS: new Thickness(10, 20, 10, 0),
                Android: new Thickness(0, 0, 0, 0),
                WinPhone: new Thickness(10, 10, 10, 0)
            );*/

            Device.OnPlatform(
                iOS: () => {
                    Padding = new Thickness(10, 10, 10, 0);
                },
                Android: () => {
                    //TODO for Android specific
                }
            );

        }
            
        void AAEClicked(object sender, System.EventArgs e)
        {
            Device.OpenUri(new System.Uri("http://africanarteverywhere.com"));
        }

        void MunabeesBtnClicked(object sender, System.EventArgs e)
        {
            Device.OpenUri(new System.Uri("http://munabees.com"));
        }

        void OserBtnClicked(object sender, System.EventArgs e)
        {
            Device.OpenUri(new System.Uri("http://oserlafrique.com"));
        }

        //void BackPressed(object sender, System.EventArgs e)
        //{
        //    Navigation.PopAsync();
        //}

        async void ListBtnPressed(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ListePage());
        }
    }
}
