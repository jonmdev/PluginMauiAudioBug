using Microsoft.Extensions.Logging;
using Plugin.Maui.Audio;

namespace PluginMauiAudioBug {
    public static class MauiProgram {
        public static MauiApp CreateMauiApp() {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts => {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton(AudioManager.Current); //https://learn.microsoft.com/en-us/dotnet/architecture/maui/dependency-injection


            return builder.Build();
        }
    }
}
