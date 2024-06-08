using AplicativoMAUI;
using AplicativoMAUI.Views;
using Microsoft.Extensions.Logging;

namespace AplicativoMAUI
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
      //      builder.Services.AddSingleton<HomePage>();
            builder.Services.AddSingleton<LoginPage>();
         //   builder.Services.AddSingleton<LoginPageViewModel>();
            builder.Services.AddSingleton<AlunoView>();
         //   builder.Services.AddSingleton<ContactPage>();
#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
