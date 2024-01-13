using P3PHelper.MVVM.Models;
using P3PHelper.MVVM.ViewModels;
using P3PHelper.Repositories;
using System.Diagnostics;

namespace P3PHelper.MVVM.Views.MissingPersons;

public partial class MissingPersonsView : ContentPage
{
	MissingPersonsViewModel viewModel = new();
    ProgressRepository ProgressRepo = new();
	public MissingPersonsView()
	{
		InitializeComponent();
		BindingContext = viewModel;
	}

    private void MissingPersonCheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (sender is not CheckBox checkBox)
        {
            Debug.WriteLine("*** Unexpected sender type in CheckBox_CheckedChanged ***");
            return;
        }
        if (checkBox.BindingContext is not MissingPerson missingPerson)
        {
            Debug.WriteLine("*** Unexpected BindingContext type in RequestCheckBox_CheckedChanged ***");
            return;
        }
        // Toggle the IsVisible property of the MissingPersonInfo Grid
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
                .FirstOrDefault(x => x.AutomationId == "MissingPersonInfo");
            if (hider != null)
            {
                hider.IsVisible = !hider.IsVisible;
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine("*** " + ex.Message + " ***");
            DisplayAlert("Error", "Error handling CheckBox tap", "OK");
        }
        // Update the MissingPerson in the database
        try
        {
            int isCompleted = checkBox.IsChecked ? 1 : 0;
            ProgressRepo.UpdateMissingPerson(missingPerson.Id, isCompleted);
        }
        catch (Exception ex)
        {
            Debug.WriteLine("*** " + ex.Message + " ***");
            DisplayAlert("Error", "Error updating Missing Person", "OK");
        }
    }
}