using P3PHelper.MVVM.ViewModels;

namespace P3PHelper.MVVM.Views.Requests;

public partial class OneToTwentyView : ContentPage
{
	public RequestsViewModel Vm = new RequestsViewModel();
	public OneToTwentyView()
	{
		InitializeComponent();
		BindingContext = Vm;
	}
}