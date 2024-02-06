using P3PHelper.MVVM.Models;
using P3PHelper.MVVM.ViewModels;
using P3PHelper.Repositories;
using System.Diagnostics;

namespace P3PHelper.MVVM.Views.SchoolQuestions;

public partial class SchoolQuestionsView : ContentPage
{
	SchoolQuestionsViewModel _vm;

	public SchoolQuestionsView()
	{
		InitializeComponent();

		_vm= DependencyService.Get<SchoolQuestionsViewModel>();
		_vm.CurrentViewQuestions = _vm.Incomplete;
		BindingContext = _vm;
	}
}