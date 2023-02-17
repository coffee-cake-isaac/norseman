using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.Hosting;
using Norseman.Lib.Databases;
using Norseman.Lib.Services.Navigation;
using Norseman.ViewModels;
using Norseman.Views.Onboarding;

namespace Norseman;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			})
			.RegisterViewModels()
			.RegisterViews();

		//builder.Services.AddSingleton<>

        builder.Services.AddSingleton<INavigationService, NorsemanNavigationService>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}

	public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppBuilder)
	{
		mauiAppBuilder.Services.AddSingleton<MainPageViewModel>();
        mauiAppBuilder.Services.AddTransient<LandingPageViewModel>();

        return mauiAppBuilder;
	}

    public static MauiAppBuilder RegisterViews(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.Services.AddSingleton<MainPage>();
        mauiAppBuilder.Services.AddTransient<LandingPageView>();

        return mauiAppBuilder;
    }
}

