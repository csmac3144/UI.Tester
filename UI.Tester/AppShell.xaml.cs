using System;
using System.Collections.Generic;
using UI.Tester.ViewModels;
using UI.Tester.Views;
using Xamarin.Forms;

namespace UI.Tester
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
