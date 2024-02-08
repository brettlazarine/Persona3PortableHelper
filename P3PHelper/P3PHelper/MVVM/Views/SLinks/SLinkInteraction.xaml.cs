using P3PHelper.MVVM.Models;
using P3PHelper.MVVM.ViewModels;
using P3PHelper.Repositories;
using System.Diagnostics;
using System.Globalization;

namespace P3PHelper.MVVM.Views.SLinks;
public partial class SLinkInteraction : ContentPage
{
    public SLink Link { get; set; }
    public InteractionStoryViewModel Vm { get; set; }
    public SLinkInteraction()
	{
		InitializeComponent();
	}

    public SLinkInteraction(InteractionStoryViewModel vm)
    {
        InitializeComponent();
        Vm = vm;
        BindingContext = Vm;
    }
    // REMOVE THIS CTOR
    public SLinkInteraction(string arcanaName)
    {
        InitializeComponent();

        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        arcanaName = textInfo.ToTitleCase(arcanaName);

        BindingContext = Link;
    }
    // MOVE TO VIEWMODEL
    private async void RankStackArrow_Tapped(object sender, EventArgs e)
    {
        if (sender is not Image arrow)
        {
            Debug.WriteLine("*** Unexpected sender type in RankStackArrow_Tapped ***");
            return;
        }

        try
        {
            var arrowParent = arrow.Parent as Layout;
            var container = arrowParent?.Parent as Layout;

            if (container == null)
            {
                Debug.WriteLine("*** Container not found in RankStackArrow_Tapped ***");
                return;
            }

            VerticalStackLayout questionResponseStack = container.Children
                .OfType<VerticalStackLayout>()
                .FirstOrDefault(child => child.AutomationId == "QuestionResponse");

            if (questionResponseStack != null)
            {
                questionResponseStack.IsVisible = !questionResponseStack.IsVisible;
                arrow.Rotation = questionResponseStack.IsVisible ? 180 : 0;

                //double bottomY = scrollView.ContentSize.Height - scrollView.Height;

                if (questionResponseStack.IsVisible)
                {
                    var txt = arrowParent.Children
                        .OfType<Label>()
                        .FirstOrDefault(child => child.AutomationId == "RankHolder");

                    var txt2 = txt.Text;

                    var vm = new InteractionStoryViewModel();

                    if (vm.ScrollRanks.Contains(txt2))
                    {
                        //await scrollView.ScrollToAsync(0, vm.AdjustY(bottomY), true);
                    }
                }
            }
            else
            {
                Debug.WriteLine("*** QuestionResponse stack not found in RankStackArrow_Tapped ***");
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"*** Error handling RankStackArrow tap: {ex.Message} ***");

            await DisplayAlert("Error", "Error handling RankStackArrow tap", "OK");
        }
    }

    // ADJUST TO ASYNC TASK COMMAND, MOVE TO VIEWMODEL
    private void IsCompletedCheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (sender is not CheckBox box)
        {
            Debug.WriteLine("*** Unexpected sender type in IsCompletedCheckBox_CheckedChanged ***");
            return;
        }

        if (box.BindingContext is not RankUp rank)
        {
            Debug.WriteLine("*** Unexpected BindingContext type in IsCompletedCheckBox_CheckedChanged ***");
            return;
        }

        try
        {
            int isCompletedValue = e.Value ? 1 : 0;
            var repo = new ProgressRepository();
            repo.UpdateRankUp(rank.Id, isCompletedValue);
            //App.ProgressRepo.UpdateRankUp(rank.RankUpId, isCompletedValue);
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"*** Error updating RankUp: {ex.Message}   ***");

            DisplayAlert("Error", "Error updating RankUp", "OK");
        }
    }
}