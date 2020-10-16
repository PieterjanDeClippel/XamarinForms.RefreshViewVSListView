using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RefreshViewDemo.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RefreshViewPage : ContentPage
    {
        public RefreshViewPage()
        {
            InitializeComponent();
            Appearing += RefreshViewPage_Appearing;
        }

        private void RefreshViewPage_Appearing(object sender, EventArgs e)
        {
            viewModel.RefreshCommand.Execute(null);
        }
    }
}