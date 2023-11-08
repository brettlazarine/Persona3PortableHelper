using Microsoft.Maui.Controls.Xaml;
using P3PHelper.MVVM.ViewModels;
using P3PHelper.MVVM.Views.SLinks;
using System.Diagnostics;

namespace P3PHelper.MVVM.Views;

public partial class SocialLinksView : ContentPage
{
    public string ArcanaName { get; set; }
    public List<string> StorySLinks { get; set; } = new()
    {
        "death",
        "fool",
        "judgment"
    };
	public SocialLinksView()
	{
		InitializeComponent();
        BindingContext = new SocialLinksViewModel();
	}

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
        ArcanaName = (sender as ImageButton).AutomationId.ToString().ToLower();
        Debug.WriteLine("*********" + ArcanaName);

        if (StorySLinks.Contains(ArcanaName))
        {
            await Navigation.PushAsync(new SLinkStory());
        }
        else
        {
            await Navigation.PushAsync(new SLinkInteraction());
        }
    }
}