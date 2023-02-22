using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.Hosting;
using Norseman.Lib.Databases;
using Norseman.Lib.Databases.Access;
using Norseman.Lib.Models;
using Norseman.Lib.Services.Navigation;
using Norseman.ViewModels;
using Norseman.Views.Onboarding;

namespace Norseman;

public static class MauiProgram
{
    /// <summary>
    /// Main entry point for the MAUI program
    /// </summary>
    /// <returns></returns>
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
            .RegisterDataAccess()
            .RegisterViewModels()
            .RegisterViews();

        //builder.Services.AddSingleton<>

        builder.Services.AddSingleton<INavigationService, NorsemanNavigationService>();

#if DEBUG
        builder.Logging.AddDebug();
#endif
        return builder.Build();
    }

    /// <summary>
    /// Registers the view model with the containers for use throughout the app
    /// </summary>
    /// <param name="mauiAppBuilder">The builder responsible for instantiating instances</param>
    /// <returns>A completed builder with view models</returns>
    public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.Services.AddSingleton<MainPageViewModel>();
        mauiAppBuilder.Services.AddTransient<LandingPageViewModel>();

        return mauiAppBuilder;
    }

    /// <summary>
    /// Registers the view model with the containers for use throughout the app
    /// </summary>
    /// <param name="mauiAppBuilder">The builder responsible for instantiating instances</param>
    /// <returns>A completed builder with views</returns>
    public static MauiAppBuilder RegisterViews(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.Services.AddSingleton<MainPage>();
        mauiAppBuilder.Services.AddTransient<LandingPageView>();

        return mauiAppBuilder;
    }

    public static MauiAppBuilder RegisterDataAccess(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.Services.AddSingleton<CarMakeDatabase>();
        mauiAppBuilder.Services.AddSingleton<CarModelDatabase>();

        using (var service = mauiAppBuilder.Services.BuildServiceProvider())
        {
            var carMakeDatabase = service.GetService<CarMakeDatabase>();
            var carModelDatabase = service.GetService<CarModelDatabase>();
            Task.Run(carMakeDatabase.SeedDefaultData);
        }

        return mauiAppBuilder;
    }
}

