using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RefreshViewDemo.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void BtnListViewClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListViewPage());
        }

        private async void BtnRefreshViewClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RefreshViewPage());
        }
    }
}
