using CoffeeApp.View;
using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;

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
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("fontello.ttf", "IconsFont");
                    fonts.AddFont("Rubik-Regular.ttf", "RubikRegular");
                    fonts.AddFont("Rubik-Light.ttf", "RubikLight");
                });

            // Pages
            builder.Services.AddSingleton<CoffeeUI>();
            builder.Services.AddSingleton<MainPage>();
            //builder.Services.AddTransient<MonkeyDetailPage>();
#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}