using P3PHelper.MVVM.Models;
using P3PHelper.MVVM.ViewModels;
using P3PHelper.Repositories;
using System.Diagnostics;

namespace P3PHelper.MVVM.Views.Requests;

public partial class SixtyOneToEightyView : ContentPage
{
    public RequestsViewModel Vm = new();
    public SixtyOneToEightyView()
	{
		InitializeComponent();
        Vm.CurrentRequests = Vm.SixtyOneEighty;
        BindingContext = Vm;
	}
}