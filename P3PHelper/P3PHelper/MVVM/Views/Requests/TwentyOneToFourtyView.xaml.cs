using P3PHelper.MVVM.Models;
using P3PHelper.MVVM.ViewModels;
using P3PHelper.Repositories;
using System.Diagnostics;

namespace P3PHelper.MVVM.Views.Requests;

public partial class TwentyOneToFourtyView : ContentPage
{
    public TwentyOneToFourtyView(RequestsViewModel viewModel)
	{
		InitializeComponent();

        viewModel.CurrentRequests = viewModel.TwentyOneFourty;
        BindingContext = viewModel;
	}
}