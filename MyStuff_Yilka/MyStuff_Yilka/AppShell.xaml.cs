using MyStuff_Yilka.ViewModels;
using MyStuff_Yilka.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MyStuff_Yilka
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
