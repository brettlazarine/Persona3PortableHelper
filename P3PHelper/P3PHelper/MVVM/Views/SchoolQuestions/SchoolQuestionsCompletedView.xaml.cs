using P3PHelper.MVVM.ViewModels;
using P3PHelper.Repositories;

namespace P3PHelper.MVVM.Views.SchoolQuestions;

public partial class SchoolQuestionsCompletedView : ContentPage
{
    public SchoolQuestionsCompletedView(SchoolQuestionsViewModel viewModel)
	{
		InitializeComponent();

        viewModel.CurrentViewQuestions = viewModel.Complete;
        BindingContext = viewModel;
	}
}