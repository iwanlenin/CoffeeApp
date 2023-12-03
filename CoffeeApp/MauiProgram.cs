using CoffeeApp.View;
using CoffeeApp.ViewModel;
using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using PanCardView;

namespace CoffeeApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                // Initialize the .NET MAUI Community Toolkit by adding the below line of code
                .UseMauiCommunityToolkit()
                .UseCardsView()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Rubik-Regular.ttf", "RubikRegular");
                    fonts.AddFont("fontello.ttf", "IconsFont");
                    fonts.AddFont("Nexa-Heavy.ttf", "NexaHeavy");
                    fonts.AddFont("Nexa-ExtraLight.ttf", "NexaLight");

                });

            // Pages
            builder.Services.AddTransient<CoffeeUI>();
            builder.Services.AddSingleton<MainPage>();
            //View models
            builder.Services.AddSingleton<CoffeeUIViewModel>();
            //builder.Services.AddTransient<MonkeyDetailPage>();
#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}