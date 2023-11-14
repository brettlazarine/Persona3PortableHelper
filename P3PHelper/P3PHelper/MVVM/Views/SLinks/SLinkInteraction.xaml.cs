using P3PHelper.Repositories;
using System.Diagnostics;

namespace P3PHelper.MVVM.Views.SLinks;

public partial class SLinkInteraction : ContentPage
{
	public SLinkInteraction()
	{
		InitializeComponent();
	}

    public SLinkInteraction(string arcanaName)
    {
        InitializeComponent();

        var sLinkRepo = DependencyService.Get<SLinkRepository>();
        var sLink = sLinkRepo.GetSLink(arcanaName);

        var rankUp = sLink.MaleRankUps[0];
        Debug.WriteLine("***** " + rankUp.RankInteractions[0].Question);

        BindingContext = sLink;
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