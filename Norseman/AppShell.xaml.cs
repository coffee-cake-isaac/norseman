using Norseman.Lib.Services.Navigation;

namespace Norseman;

public partial class AppShell : Shell
{
	private readonly INavigationService _navigationService;

	public AppShell(INavigationService navigationService)
	{
		_navigationService = navigationService;

        InitializeRoutes();

        InitializeComponent();
	}

    public AppShell()
    {
    }

    protected override async void OnHandlerChanged()
    {
        base.OnHandlerChanged();

        if (Handler is not null)
        {
            await _navigationService.InitializeAsync();
        }
    }

    private static void InitializeRoutes()
	{
        Routing.RegisterRoute("LandingPageView", typeof(Views.Onboarding.LandingPageView));
    }
}

