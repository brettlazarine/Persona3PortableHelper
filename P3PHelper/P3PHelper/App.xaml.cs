using P3PHelper.MVVM.Views;
using P3PHelper.MVVM.Views.Requests;
using P3PHelper.MVVM.Views.SLinks;
using P3PHelper.Repositories;
using System.Diagnostics;

namespace P3PHelper;

public partial class App : Application
{
	public static ProgressRepository ProgressRepo { get; private set; }
	public App()
	{
		InitializeComponent();
		//ProgressRepo = repo;

		//Constants.InitializeDatabaseAsync().ConfigureAwait(false);
		//CheckDatabaseFile();




        //SLinkRepository sLinkRepository = new SLinkRepository();
        //DependencyService.RegisterSingleton(sLinkRepository);

		//RequestRepository requestRepository = new RequestRepository();
		//DependencyService.RegisterSingleton(requestRepository);

        MainPage = new AppShell();
	}

	private void RegisterRoutes()
	{
		Routing.RegisterRoute("socialLinks", typeof(SocialLinksView));
		Routing.RegisterRoute("slinkInteraction", typeof(SLinkInteraction));
		Routing.RegisterRoute("slinkStory", typeof(SLinkStory));
		Routing.RegisterRoute("oneTwenty", typeof(OneToTwentyView));
		Routing.RegisterRoute("twentyoneForty", typeof(TwentyOneToFourtyView));
		Routing.RegisterRoute("fourtyoneSixty", typeof(FourtyOneToSixtyView));
		Routing.RegisterRoute("sixtyoneEighty", typeof(SixtyOneToEightyView));
    }

    public static void CheckDatabaseFile()
    {
        var dbPath = Constants.DatabasePath;
        if (File.Exists(dbPath))
        {
            Debug.WriteLine("*** Database file exists. ***");
        }
        else
        {
            Debug.WriteLine("*** Database file does not exist. ***");
        }
    }

}
