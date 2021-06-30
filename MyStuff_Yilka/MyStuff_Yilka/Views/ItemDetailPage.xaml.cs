using MyStuff_Yilka.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MyStuff_Yilka.Views
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