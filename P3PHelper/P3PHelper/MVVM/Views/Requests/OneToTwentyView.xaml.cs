using P3PHelper.MVVM.ViewModels;

namespace P3PHelper.MVVM.Views.Requests;

public partial class OneToTwentyView : ContentPage
{
	public RequestsViewModel Vm = new();
	public OneToTwentyView()
	{
		InitializeComponent();
		BindingContext = Vm;
	}

    private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {

    }
}