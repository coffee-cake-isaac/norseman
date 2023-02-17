using Norseman.ViewModels;

namespace Norseman;

public partial class MainPage : ContentPage
{
	public MainPage(MainPageViewModel viewModel)
	{
		BindingContext = viewModel;

		InitializeComponent();
	}
}


