using Microsoft.AppCenter.Crashes;
using Microsoft.Maui.Controls.Xaml;
using P3PHelper.MVVM.ViewModels;
using P3PHelper.MVVM.Views.SLinks;
using System.Diagnostics;

namespace P3PHelper.MVVM.Views;

public partial class SocialLinksView : ContentPage
{
    public string ArcanaName { get; set; }
    public SocialLinksViewModel Vm { get; set; }

	public SocialLinksView()
	{
		InitializeComponent();

        //Crashes.GenerateTestCrash();
        Vm = new SocialLinksViewModel();
        BindingContext = Vm;
	}

    public async void NavigateToSLink(object sender, EventArgs e)
    {
        if (sender is not ImageButton)
        {
            Debug.WriteLine("*** Unexpected sender type in NavigateToSLink ***");
            return;
        }

        try
        {
            ArcanaName = (sender as ImageButton).AutomationId.ToString().ToLower();
            // The hangedman nav causing errors, this will work but is not clean
            // Consider trying source again when refactoring
            if (ArcanaName == "hanged man")
            {
                await Navigation.PushAsync(new SLinkInteraction("hangedman"));
            }
            else if (Vm.StorySLinks.Contains(ArcanaName))
            {
                await Navigation.PushAsync(new SLinkStory(ArcanaName));
            }
            else
            {
                await Navigation.PushAsync(new SLinkInteraction(ArcanaName));
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"*** Error handling SLink navigation: {ex.Message} ***");
            await DisplayAlert("Error", "Error navigating to SLink", "OK");
        }
        
    }
}