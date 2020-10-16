using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RefreshViewDemo.ViewModels
{
    public class RefreshVM : BaseVM
    {
        public RefreshVM()
        {
            RefreshCommand = new Command(OnRefresh);
            logMessages = new ObservableCollection<string>();
        }

        #region IsLoading
        private bool isLoading;
        public bool IsLoading
        {
            get => isLoading;
            set => SetProperty(ref isLoading, value);
        }
        #endregion

        #region LogMessages
        private ObservableCollection<string> logMessages;
        public ObservableCollection<string> LogMessages
        {
            get => logMessages;
            set => SetProperty(ref logMessages, value);
        }
        #endregion

        public ICommand RefreshCommand { get; }

        private async void OnRefresh(object obj)
        {
            // The spinner should be running when navigating to the page.
            // Hence why we're setting the property here
            // However this triggers the RefreshCommand twice,
            // First because the method is being called ofc,
            // Next because the IsLoading property is set.
            IsLoading = true;
            LogMessages.Add("Start refresh");

            await Task.Delay(2000);
            IsLoading = false;

            LogMessages.Add("End refresh");
        }
    }
}
