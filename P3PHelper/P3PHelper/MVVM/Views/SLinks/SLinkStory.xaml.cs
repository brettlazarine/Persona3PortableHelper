using P3PHelper.MVVM.Models;
using P3PHelper.MVVM.ViewModels;
using P3PHelper.Repositories;
using System.Diagnostics;
using System.Globalization;

namespace P3PHelper.MVVM.Views.SLinks;

public partial class SLinkStory : ContentPage
{
    public SLink Link { get; set; }
	public SLinkStory()
	{
		InitializeComponent();
	}

    public SLinkStory(string arcanaName)
    {
        InitializeComponent();

        var sLinkRepo = App.ProgressRepo.GetSLinks();

        //var sLinkRepo = DependencyService.Get<SLinkRepository>();
        //Link = sLinkRepo.GetSLink(arcanaName);
        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        arcanaName = textInfo.ToTitleCase(arcanaName);
        Link = App.ProgressRepo.GetSLink(arcanaName);

        BindingContext = Link;

        //foreach (var rank in Link.MaleRankUps)
        {
        //Debug.WriteLine($"***** {rank.RankInteractions} *****");

        }
    }

    #region Male Arrow Tap Events
    private void MaleDate_Tapped(object sender, TappedEventArgs e)
    {
        var arrow = sender as Image;

        MaleDate.IsVisible = !MaleDate.IsVisible;
        arrow.Rotation = MaleDate.IsVisible ? 180 : 0;
    }
    private void MaleHow_Tapped(object sender, TappedEventArgs e)
    {
        var arrow = sender as Image;

        MaleHow.IsVisible = !MaleHow.IsVisible;
        arrow.Rotation = MaleHow.IsVisible ? 180 : 0;
    }
    private void MaleAvailability_Tapped(object sender, TappedEventArgs e)
    {
        var arrow = sender as Image;

        MaleAvailability.IsVisible = !MaleAvailability.IsVisible;
        arrow.Rotation = MaleAvailability.IsVisible ? 180 : 0;
    }
    private void RankStackArrow_Tapped(object sender, EventArgs e)
    {
        var arrow = sender as Image;

        //Vm.ArrowRotated = !Vm.ArrowRotated;

        var arrowParent = arrow.Parent as Layout;
        var container = arrowParent.Parent as Layout;
        VerticalStackLayout questionResponseStack;

        foreach (var child in container.Children)
        {
            Debug.WriteLine(child.AutomationId);
            if (child.AutomationId == "QuestionResponse")
            {
                questionResponseStack = child as VerticalStackLayout;
                questionResponseStack.IsVisible = !questionResponseStack.IsVisible;
            }
        }

        //arrow.Rotation = Vm.ArrowRotated ? 180 : 0;
    }
    #endregion



    private void IsCompletedCheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        var box = sender as CheckBox;
        var rank = box.BindingContext as RankUp;
        if (rank != null)
        {
            Debug.WriteLine($"*** ID: {rank.RankUpId} ***");
            Debug.WriteLine("**********");
            App.ProgressRepo.UpdateRankUp(rank.RankUpId, e.Value == true ? 1 : 0);
        }

        //var male = Link.MaleRankUps;
        //foreach (var item in male)
        //{
        //    Debug.WriteLine(item.RankUpId);
        //}
    }
}