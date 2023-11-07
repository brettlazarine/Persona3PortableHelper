using P3PHelper.MVVM.Views;
using P3PHelper.MVVM.Views.SLinks;

namespace P3PHelper;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}

	private void RegisterRoutes()
	{
		Routing.RegisterRoute("socialLinks", typeof(SocialLinksView));
		Routing.RegisterRoute("slinkInteraction", typeof(SLinkInteraction));
    }
}
