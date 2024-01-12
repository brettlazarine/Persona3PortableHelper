using Microsoft.Extensions.Logging;
using P3PHelper.Repositories;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace P3PHelper;

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
				fonts.AddFont("PTSerif-Regular.ttf", "Regular");
            });

#if DEBUG
		builder.Logging.AddDebug();
#endif
		//builder.Services.AddSingleton<ProgressRepository>();
		//builder.Services.AddSingleton<SLinkRepository>();
		//builder.Services.AddSingleton<RequestRepository>();
		// Consider Azure Key Vault
        AppCenter.Start("android=72336151-3efa-4251-8590-b1744bec9ddc;" +
                  "windowsdesktop={Your UWP App secret here};" +
                  "ios={Your iOS App secret here};" +
                  "macos={Your macOS App secret here};",
                  typeof(Analytics), typeof(Crashes));

        return builder.Build();
	}
}
