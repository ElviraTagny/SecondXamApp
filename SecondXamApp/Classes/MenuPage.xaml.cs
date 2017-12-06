using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SecondXamApp
{
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();

            // = new MenuPage();
            /*if(Device.OS == TargetPlatform.iOS){
                Padding = new Thickness(10, 20, 10, 0);
            }*/

            /*Padding = Device.OnPlatform(
                iOS: new Thickness(10, 20, 10, 0),
                Android: new Thickness(0, 0, 0, 0),
                WinPhone: new Thickness(10, 10, 10, 0)
            );

            Device.OnPlatform(
                iOS: () => {
                    Padding = new Thickness(10, 20, 10, 0);
                },
                Android: () => {
                    //TODO for Android specific
                }
            );*/

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
            var initialColor = OserBtn.BackgroundColor;
            OserBtn.BackgroundColor = Color.White;
            Device.OpenUri(new System.Uri("http://oserlafrique.com"));
            OserBtn.BackgroundColor = initialColor;
        }

        void BackPressed(object sender, System.EventArgs e)
        {
            BackBtn.TextColor = Color.White;
            Navigation.PopModalAsync();
        }

    }
}
