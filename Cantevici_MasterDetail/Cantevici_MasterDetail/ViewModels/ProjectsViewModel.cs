using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace Cantevici_MasterDetail.ViewModels
{
    public class ProjectsViewModel : BaseViewModel
    {
        public ProjectsViewModel()
        {
            Title = "Projects";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://www.facebook.com/ira.kantsevich")));
        }

        public ICommand OpenWebCommand { get; }
    }
}