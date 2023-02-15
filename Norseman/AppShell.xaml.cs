namespace Norseman;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute("LandingPageView", typeof(Views.LandingPageView));
	}
}

