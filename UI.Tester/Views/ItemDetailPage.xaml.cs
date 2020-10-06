using System.ComponentModel;
using Xamarin.Forms;
using UI.Tester.ViewModels;

namespace UI.Tester.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}