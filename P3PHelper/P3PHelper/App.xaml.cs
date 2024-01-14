using P3PHelper.MVVM.ViewModels;
using P3PHelper.MVVM.Views;
using P3PHelper.MVVM.Views.MissingPersons;
using P3PHelper.MVVM.Views.Requests;
using P3PHelper.MVVM.Views.SchoolQuestions;
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

		ProgressRepository.InitializeDatabase();
		//ProgressRepo = repo;

		//Constants.InitializeDatabaseAsync().ConfigureAwait(false);
		//CheckDatabaseFile();




        //SLinkRepository sLinkRepository = new SLinkRepository();
        //DependencyService.RegisterSingleton(sLinkRepository);

		//RequestRepository requestRepository = new RequestRepository();
		//DependencyService.RegisterSingleton(requestRepository);

		DependencyService.RegisterSingleton<SchoolQuestionsViewModel>(new SchoolQuestionsViewModel());

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
		Routing.RegisterRoute("missingPersons", typeof(MissingPersonsView));
		Routing.RegisterRoute("schoolQuestions", typeof(SchoolQuestionsView));
		Routing.RegisterRoute("schoolQuestionsCompleted", typeof(SchoolQuestionsCompletedView));
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
