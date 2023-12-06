using P3PHelper.MVVM.ViewModels;
using System.Diagnostics;

namespace P3PHelper.MVVM.Views.Requests;

public partial class OneToTwentyView : ContentPage
{
	public RequestsViewModel Vm = new();
	public OneToTwentyView()
	{
		InitializeComponent();
		BindingContext = Vm;
	}

    private async void RequestCheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
		if (sender is not CheckBox checkBox)
		{
			Debug.WriteLine("*** Unexpected sender type in CheckBox_CheckedChanged ***");
			return;
		}

		try
		{
			var parent = checkBox.Parent as Layout;
			//Debug.WriteLine($"Parent id: {parent.AutomationId}");
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
    }
}