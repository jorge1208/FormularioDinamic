using System.ComponentModel;
using Forms2.ViewModels;
using Xamarin.Forms;

namespace Forms2.Views
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