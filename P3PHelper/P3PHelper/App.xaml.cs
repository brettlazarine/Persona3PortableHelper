using P3PHelper.MVVM.Views;
using P3PHelper.MVVM.Views.SLinks;
using P3PHelper.Repositories;

namespace P3PHelper;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
        DependencyService.RegisterSingleton<SLinkRepository>(new SLinkRepository());

        MainPage = new AppShell();
	}

	private void RegisterRoutes()
	{
		Routing.RegisterRoute("socialLinks", typeof(SocialLinksView));
		Routing.RegisterRoute("slinkInteraction", typeof(SLinkInteraction));
    }
}
