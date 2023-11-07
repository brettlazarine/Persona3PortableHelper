using P3PHelper.MVVM.Views.SLinks;

namespace P3PHelper.MVVM.Views;

public partial class SocialLinksView : ContentPage
{
	public SocialLinksView()
	{
		InitializeComponent();
	}

    private async void Interaction_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new SLinkInteraction());
    }

    private async void Story_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SLinkStory());
    }
}