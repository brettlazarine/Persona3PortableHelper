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

        App.ProgressRepo.GetRankUps();

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

    private void IsCompletedMaleCheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        var it = (CheckBox)sender;
        var rankUp = it.BindingContext as RankUp;
        Debug.WriteLine($"RankUpId: {rankUp.RankUpId}");

        //var data = App.ProgressRepo.GetRankUps();
        //foreach (var item in  data)
        //{
        //    Debug.WriteLine($"Arcana: {item.Arcana}, ID: {item.RankUpId}, #: {item.RankNumber}, Bool: {item.IsCompleted}");
        //}

        //if (sender is CheckBox checkBox)
        //{
        //    if (checkBox.BindingContext is InteractionStoryViewModel vModel)
        //    {
        //        Debug.WriteLine($"*** BC is viewmodel ***");
        //    }
        //    if (checkBox.BindingContext is RankUp rankUp)
        //    {
        //        Debug.WriteLine($"*** BC is rankup ***");
        //        Debug.WriteLine($"*** RankUpId: {rankUp.RankUpId} ***");
        //        Debug.WriteLine($"*** Arcana: {rankUp.Arcana} ***");
        //    }
        //}


        //var bc = Vm.SLinkBC.MaleRankUps;
        //var checkbox = sender as CheckBox;
        //if (bc != null && bc.Any())
        //{

        //    App.ProgressRepo.UpdateRankUp(bc.FirstOrDefault().RankUpId, checkbox.IsChecked, true);
        //}
        //else
        //{
        //    Debug.WriteLine("BindingContext is null");
        //}
    }
}