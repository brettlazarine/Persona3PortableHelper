using P3PHelper.MVVM.Models;
using P3PHelper.MVVM.ViewModels;
using P3PHelper.Repositories;
using System.Diagnostics;

namespace P3PHelper.MVVM.Views.Requests;

public partial class TwentyOneToFourtyView : ContentPage
{
    public RequestsViewModel Vm = new();
    public TwentyOneToFourtyView()
	{
		InitializeComponent();

        Vm.CurrentRequests = Vm.TwentyOneFourty;
        BindingContext = Vm;
	}
}