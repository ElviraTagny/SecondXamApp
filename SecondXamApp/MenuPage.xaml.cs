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
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Device.OpenUri(new System.Uri("http://www.google.com"));
        }

        void MunabeesBtnClicked(object sender, System.EventArgs e)
        {
            Device.OpenUri(new System.Uri("http://www.munabees.com"));
        }

        void OserBtnClicked(object sender, System.EventArgs e)
        {
            Device.OpenUri(new System.Uri("http://www.oserlafrique.com"));
        }

    }
}
