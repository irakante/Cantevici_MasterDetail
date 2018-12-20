using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace Cantevici_MasterDetail.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://www.facebook.com/ira.kantsevich")));
        }

        public ICommand OpenWebCommand { get; }
    }
}