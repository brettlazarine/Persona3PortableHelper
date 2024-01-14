using P3PHelper.MVVM.ViewModels;
using P3PHelper.Repositories;

namespace P3PHelper.MVVM.Views.SchoolQuestions;

public partial class SchoolQuestionsView : ContentPage
{
	ProgressRepository ProgressRepo = new();
	SchoolQuestionsViewModel vm = new();

	public SchoolQuestionsView()
	{
		InitializeComponent();

		vm.CurrentViewQuestions = vm.Incomplete;
		BindingContext = vm;
	}

    private void SchoolQuestionCheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {

    }
}