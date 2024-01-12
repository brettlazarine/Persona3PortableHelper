using P3PHelper.MVVM.Models;
using P3PHelper.MVVM.ViewModels;
using P3PHelper.Repositories;
using System.Diagnostics;

namespace P3PHelper.MVVM.Views.Requests;

public partial class FourtyOneToSixtyView : ContentPage
{
    public RequestsViewModel Vm = new();
    ProgressRepository ProgressRepo = new();
    public FourtyOneToSixtyView()
	{
		InitializeComponent();
        BindingContext = Vm.FourtyOneSixty;
	}

    private async void RequestCheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (sender is not CheckBox checkBox)
        {
            Debug.WriteLine("*** Unexpected sender type in CheckBox_CheckedChanged ***");
            return;
        }
        if (checkBox.BindingContext is not Request request)
        {
            Debug.WriteLine("*** Unexpected BindingContext type in RequestCheckBox_CheckedChanged ***");
            return;
        }
        // Toggle the IsVisible property of the RequestDetails Grid
        try
        {
            var parent = checkBox.Parent as Layout;
            if (parent == null)
            {
                Debug.WriteLine("*** Parent is null in RequestCheckBox_CheckedChanged ***");
                return;
            }

            var hider = parent.Children
                .OfType<Grid>()
                .FirstOrDefault(x => x.AutomationId == "RequestDetails");
            if (hider != null)
            {
                hider.IsVisible = !hider.IsVisible;
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"*** Error handling CheckBox tapped: {ex.Message} ***");

            await DisplayAlert("Error", "Error handling CheckBox tap", "OK");
        }
        // Update the Request in the database
        try
        {
            int isCompleted = checkBox.IsChecked ? 1 : 0;
            //App.ProgressRepo.UpdateRequest(request.QuestNumber, isCompleted);
            ProgressRepo.UpdateRequest(request.QuestNumber, isCompleted);
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"*** Error updating Request: {ex.Message}   ***");

            await DisplayAlert("Error", "Error updating Request", "OK");
        }
    }
}