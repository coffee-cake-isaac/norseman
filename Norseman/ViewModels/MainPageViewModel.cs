using System;
using System.Windows.Input;

namespace Norseman.ViewModels
{
	public class MainPageViewModel : ViewModelBase
	{
		public ICommand NavigateToLandingPageView => new Command(NavigateToLandingPageViewCommand);

        private async void NavigateToLandingPageViewCommand(object obj)
        {
			await Shell.Current.GoToAsync("LandingPageView");
		}

        public MainPageViewModel()
		{
		}
	}
}

