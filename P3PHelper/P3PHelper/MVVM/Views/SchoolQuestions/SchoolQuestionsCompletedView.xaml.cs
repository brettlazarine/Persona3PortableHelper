using P3PHelper.MVVM.ViewModels;
using P3PHelper.Repositories;

namespace P3PHelper.MVVM.Views.SchoolQuestions;

public partial class SchoolQuestionsCompletedView : ContentPage
{
    SchoolQuestionsViewModel _vm;

    public SchoolQuestionsCompletedView()
	{
		InitializeComponent();

        _vm = DependencyService.Get<SchoolQuestionsViewModel>();
        _vm.CurrentViewQuestions = _vm.Complete;
        BindingContext = _vm;
	}
}