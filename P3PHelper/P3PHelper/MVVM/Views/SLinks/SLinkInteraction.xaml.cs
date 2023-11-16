using P3PHelper.MVVM.ViewModels;
using P3PHelper.Repositories;
using System.Diagnostics;

namespace P3PHelper.MVVM.Views.SLinks;
// propchange branch
public partial class SLinkInteraction : ContentPage
{
    public InteractionStoryViewModel vm { get; set; }
	public SLinkInteraction()
	{
		InitializeComponent();
	}

    public SLinkInteraction(string arcanaName)
    {
        InitializeComponent();

        vm = new InteractionStoryViewModel(arcanaName);

        BindingContext = vm;
    }

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
}