﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SecondXamApp.Classes
{
    public partial class ListePage : ContentPage
    {
        public ListePage()
        {
            InitializeComponent();
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

        void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var selectedItem = e.Item as ListViewTemplate;
            DisplayAlert("Contact "+ selectedItem.ContactName, "Number is " + selectedItem.ContactNum, "Launch call");
            ((ListView)sender).SelectedItem = null;
        }
    }
}