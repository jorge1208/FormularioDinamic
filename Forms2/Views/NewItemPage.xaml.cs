using System;
using System.Collections.Generic;
using System.ComponentModel;
using Forms2.Models;
using Forms2.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Forms2.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}