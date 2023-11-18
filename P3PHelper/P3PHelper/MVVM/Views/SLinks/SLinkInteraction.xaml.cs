using Microsoft.Maui;
using P3PHelper.Converters;
using P3PHelper.MVVM.Models;
using P3PHelper.MVVM.ViewModels;
using P3PHelper.Repositories;
using System.Diagnostics;

namespace P3PHelper.MVVM.Views.SLinks;
public partial class SLinkInteraction : ContentPage
{
    public InteractionStoryViewModel Vm { get; set; }
	public SLinkInteraction()
	{
		InitializeComponent();
	}

    public SLinkInteraction(string arcanaName)
    {
        InitializeComponent();

        Vm = new InteractionStoryViewModel(arcanaName);

        BindingContext = Vm;
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

        Vm.ArrowRotated = !Vm.ArrowRotated;

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

        arrow.Rotation = Vm.ArrowRotated ? 180 : 0;
    }
    #endregion

    #region Female Arrow Tap Events

    #endregion
}