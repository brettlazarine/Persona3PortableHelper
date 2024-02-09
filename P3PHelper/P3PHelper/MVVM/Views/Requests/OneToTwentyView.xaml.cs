using P3PHelper.MVVM.Models;
using P3PHelper.MVVM.ViewModels;
using P3PHelper.Repositories;
using P3PHelper.Utilities;
using System.Diagnostics;

namespace P3PHelper.MVVM.Views.Requests;

public partial class OneToTwentyView : ContentPage
{
	public OneToTwentyView(RequestsViewModel viewModel)
	{
		InitializeComponent();

		viewModel.CurrentRequests = viewModel.OneTwenty;
		BindingContext = viewModel;
    }
}