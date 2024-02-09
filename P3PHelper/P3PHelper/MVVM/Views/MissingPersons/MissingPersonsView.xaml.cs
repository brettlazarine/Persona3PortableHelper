using P3PHelper.MVVM.ViewModels;
namespace P3PHelper.MVVM.Views.MissingPersons;

public partial class MissingPersonsView : ContentPage
{
	public MissingPersonsView(MissingPersonsViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = viewModel;
	}
}