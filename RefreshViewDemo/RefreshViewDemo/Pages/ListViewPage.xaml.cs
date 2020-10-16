using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RefreshViewDemo.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage : ContentPage
    {
        public ListViewPage()
        {
            InitializeComponent();
            Appearing += ListViewPage_Appearing;
        }

        private void ListViewPage_Appearing(object sender, EventArgs e)
        {
            viewModel.RefreshCommand.Execute(null);
        }
    }
}