using Microsoft.AppCenter.Crashes;
using Microsoft.Maui.Controls.Xaml;
using P3PHelper.MVVM.ViewModels;
using P3PHelper.MVVM.Views.SLinks;
using System.Diagnostics;
using System.Globalization;

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
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            ArcanaName = textInfo.ToTitleCase(ArcanaName);
            var vm = new InteractionStoryViewModel(ArcanaName);
            await vm.EnsureInitializedAsync(ArcanaName);
            // The hangedman nav causing errors, this will work but is not clean
            // Consider trying source again when refactoring
            if (ArcanaName.ToLower() == "hanged man")
            {
                await Navigation.PushAsync(new SLinkInteraction(vm));
            }
            else if (Vm.StorySLinks.Contains(ArcanaName.ToLower()))
            {
                await Navigation.PushAsync(new SLinkStory(vm));
            }
            else
            {
                await Navigation.PushAsync(new SLinkInteraction(vm));
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"*** Error handling SLink navigation: {ex.Message} ***");
            await DisplayAlert("Error", "Error navigating to SLink", "OK");
        }
        
    }
}