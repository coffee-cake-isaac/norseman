using Norseman.ViewModels;

namespace Norseman.Views.Onboarding;

public partial class LandingPageView : ContentPage
{
	public LandingPageView(LandingPageViewModel viewModel)
	{
		BindingContext = viewModel;

		InitializeComponent();
	}
}