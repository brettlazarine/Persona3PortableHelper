using P3PHelper.MVVM.ViewModels;
namespace P3PHelper.MVVM.Views.MissingPersons;

public partial class MissingPersonsView : ContentPage
{
	MissingPersonsViewModel viewModel = new();
	public MissingPersonsView()
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}