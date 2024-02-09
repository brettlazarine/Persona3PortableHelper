using Microsoft.Extensions.Logging;
using P3PHelper.Repositories;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using CommunityToolkit.Maui;
using P3PHelper.Abstractions;
using P3PHelper.MVVM.ViewModels;
using P3PHelper.MVVM.Views.SLinks;
using P3PHelper.MVVM.Views.Requests;
using P3PHelper.MVVM.Views.MissingPersons;
using P3PHelper.MVVM.Views.SchoolQuestions;
using P3PHelper.MVVM.Views;

namespace P3PHelper;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
        var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				fonts.AddFont("PTSerif-Regular.ttf", "Regular");
            });

#if DEBUG
		builder.Logging.AddDebug();
#endif
		// Consider Azure Key Vault
        AppCenter.Start("android=72336151-3efa-4251-8590-b1744bec9ddc;" +
                  "windowsdesktop={Your UWP App secret here};" +
                  "ios={Your iOS App secret here};" +
                  "macos={Your macOS App secret here};",
                  typeof(Analytics), typeof(Crashes));

		builder.RegisterServices()
			.RegisterViewModels()
			.RegisterViews();

        return builder.Build();
	}

	public static MauiAppBuilder RegisterServices(this MauiAppBuilder builder)
	{
		builder.Services.AddSingleton<IProgressRepository, ProgressRepository>();

		return builder;
	}
	public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder builder)
	{
		builder.Services.AddSingleton<SchoolQuestionsViewModel>();

		builder.Services.AddTransient<InteractionStoryViewModel>();
		builder.Services.AddTransient<MissingPersonsViewModel>();
		builder.Services.AddTransient<RequestsViewModel>();
		builder.Services.AddTransient<SocialLinksViewModel>();

		return builder;
	}
	public static MauiAppBuilder RegisterViews(this MauiAppBuilder builder)
	{
		// Main
		builder.Services.AddTransient<MainPage>();
		// SLinks
		builder.Services.AddTransient<SocialLinksView>();

		builder.Services.AddTransient<SLinkInteraction>();
		builder.Services.AddTransient<SLinkStory>();
		// Requests
		builder.Services.AddTransient<OneToTwentyView>();
		builder.Services.AddTransient<TwentyOneToFourtyView>();
		builder.Services.AddTransient<FourtyOneToSixtyView>();
		builder.Services.AddTransient<SixtyOneToEightyView>();
		// Missing Persons
		builder.Services.AddTransient<MissingPersonsView>();
		// School Questions
		builder.Services.AddTransient<SchoolQuestionsView>();
		builder.Services.AddTransient<SchoolQuestionsCompletedView>();

		return builder;
	}
}
