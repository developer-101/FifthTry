using FifthTry.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace FifthTry.Views
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