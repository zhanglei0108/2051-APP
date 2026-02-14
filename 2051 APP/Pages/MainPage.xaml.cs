using _2051_APP.Models;
using _2051_APP.PageModels;

namespace _2051_APP.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}