using P3PHelper.MVVM.Models;
using P3PHelper.MVVM.ViewModels;
using P3PHelper.Repositories;
using System.Diagnostics;
using System.Globalization;

namespace P3PHelper.MVVM.Views.SLinks;

public partial class SLinkStory : ContentPage
{
    public SLink Link { get; set; }
    public InteractionStoryViewModel Vm { get; set; }

    public SLinkStory()
	{
		InitializeComponent();
	}

    public SLinkStory(InteractionStoryViewModel vm)
    {
        InitializeComponent();
        Vm = vm;
        BindingContext = Vm;
    }

    public SLinkStory(string arcanaName)
    {
        InitializeComponent();

        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        arcanaName = textInfo.ToTitleCase(arcanaName);

        //Link = App.ProgressRepo.GetSLink(arcanaName);
        BindingContext = Link;
    }

    #region Male Arrow Tap Events
    private void MaleDate_Tapped(object sender, TappedEventArgs e)
    {
        if (sender is not Image arrow)
        {
            Debug.WriteLine("*** Unexpected sender type in MaleDate_Tapped ***");
            return;
        }

        try
        {
            MaleDate.IsVisible = !MaleDate.IsVisible;
            arrow.Rotation = MaleDate.IsVisible ? 180 : 0;
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"*** Error handling MaleDate tap: {ex.Message} ***");

            DisplayAlert("Error", "Error handling MaleDate tap", "OK");
        }
    }

    private void MaleHow_Tapped(object sender, TappedEventArgs e)
    {
        if (sender is not Image arrow)
        {
            Debug.WriteLine("*** Unexpected sender type in MaleHow_Tapped ***");
            return;
        }

        try
        {
            MaleHow.IsVisible = !MaleHow.IsVisible;
            arrow.Rotation = MaleHow.IsVisible ? 180 : 0;
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"*** Error handling MaleHow tap: {ex.Message} ***");

            DisplayAlert("Error", "Error handling MaleHow tap", "OK");
        }
    }

    private void MaleAvailability_Tapped(object sender, TappedEventArgs e)
    {
        if (sender is not Image arrow)
        {
            Debug.WriteLine("*** Unexpected sender type in MaleAvailability_Tapped ***");
            return;
        }

        try
        {
            MaleAvailability.IsVisible = !MaleAvailability.IsVisible;
            arrow.Rotation = MaleAvailability.IsVisible ? 180 : 0;
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"*** Error handling MaleAvailability tap: {ex.Message} ***");

            DisplayAlert("Error", "Error handling MaleAvailability tap", "OK");
        }
    }
    #endregion

    #region Female Arrow Tap Events
    private void FemaleDate_Tapped(object sender, TappedEventArgs e)
    {
        if (sender is not Image arrow)
        {
            Debug.WriteLine("*** Unexpected sender type in FemaleDate_Tapped ***");
            return;
        }

        try
        {
            FemaleDate.IsVisible = !FemaleDate.IsVisible;
            arrow.Rotation = FemaleDate.IsVisible ? 180 : 0;
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"*** Error handling FemaleDate tap: {ex.Message} ***");

            DisplayAlert("Error", "Error handling FemaleDate tap", "OK");
        }
    }
    private void FemaleHow_Tapped(object sender, TappedEventArgs e)
    {
        if (sender is not Image arrow)
        {
            Debug.WriteLine("*** Unexpected sender type in FemaleHow_Tapped ***");
            return;
        }

        try
        {
            FemaleHow.IsVisible = !FemaleHow.IsVisible;
            arrow.Rotation = FemaleHow.IsVisible ? 180 : 0;
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"*** Error handling FemaleHow tap: {ex.Message} ***");

            DisplayAlert("Error", "Error handling FemaleHow tap", "OK");
        }
    }
    private void FemaleAvailability_Tapped(object sender, TappedEventArgs e)
    {
        if (sender is not Image arrow)
        {
            Debug.WriteLine("*** Unexpected sender type in FemaleAvailability_Tapped ***");
            return;
        }

        try
        {
            FemaleAvailability.IsVisible = !FemaleAvailability.IsVisible;
            arrow.Rotation = FemaleAvailability.IsVisible ? 180 : 0;
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"*** Error handling FemaleAvailability tap: {ex.Message} ***");

            DisplayAlert("Error", "Error handling FemaleAvailability tap", "OK");
        }
    }
    #endregion

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

                double bottomY = scrollView.ContentSize.Height - scrollView.Height;

                if (questionResponseStack.IsVisible)
                {
                    var txt = arrowParent.Children
                        .OfType<Label>()
                        .FirstOrDefault(child => child.AutomationId == "RankHolder");

                    var txt2 = txt.Text;

                    var vm = new InteractionStoryViewModel();

                    if (vm.ScrollRanks.Contains(txt2))
                    {
                        await scrollView.ScrollToAsync(0, vm.AdjustY(bottomY), true);
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