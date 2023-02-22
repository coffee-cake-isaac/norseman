using Norseman.Lib.Databases.Access;
using Norseman.Lib.Services.Navigation;
using System;
using System.Windows.Input;

namespace Norseman.ViewModels
{
	public class MainPageViewModel : ViewModelBase
	{
		public ICommand NavigateToLandingPageView => new Command(NavigateToLandingPageViewCommand);

		/// <summary>
		/// Navigates the user to the Landing Page for the onboarding wizard
		/// </summary>
		/// <param name="obj"></param>
        private async void NavigateToLandingPageViewCommand(object obj)
        {
			await NavigationService.NavigateToAsync("LandingPageView");
		}


		/// <summary>
		/// Default constructor
		/// </summary>
		/// <param name="navigationService">The navigation service used for the application</param>
        public MainPageViewModel(INavigationService navigationService, CarMakeDatabase database) : base(navigationService)
		{

		}
	}
}

