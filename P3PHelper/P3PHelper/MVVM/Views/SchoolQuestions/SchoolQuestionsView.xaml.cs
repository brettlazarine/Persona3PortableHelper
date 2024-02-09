using P3PHelper.MVVM.Models;
using P3PHelper.MVVM.ViewModels;
using P3PHelper.Repositories;
using System.Diagnostics;

namespace P3PHelper.MVVM.Views.SchoolQuestions;

public partial class SchoolQuestionsView : ContentPage
{
	public SchoolQuestionsView(SchoolQuestionsViewModel viewModel)
	{
		InitializeComponent();

		viewModel.CurrentViewQuestions = viewModel.Incomplete;
		BindingContext = viewModel;
	}
}