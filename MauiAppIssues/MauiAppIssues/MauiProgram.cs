#if ANDROID
using MauiAppIssues.Platforms.Android;
#elif IOS
using MauiAppIssues.Platforms.iOS;
#endif
using MauiAppIssues.Services;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.Hosting;

namespace MauiAppIssues
{
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
                });
#if ANDROID
            builder.Services.AddSingleton<IChangeIconService, ChangeIconService>();

#elif IOS
            builder.Services.AddSingleton<IChangeIconService, ChangeIconService>();

#endif
            builder.Services.AddSingleton<IAppEnvironmentService, AppEnvironmentService>(
                serviceProvider =>
                {                    
                    var aes =
                        new AppEnvironmentService(                             
                              new ChangeIconService()); 
                    return aes;
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
