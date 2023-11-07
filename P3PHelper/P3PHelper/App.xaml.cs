using P3PHelper.MVVM.Views;

namespace P3PHelper;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new SocialLinksView();
	}
}
