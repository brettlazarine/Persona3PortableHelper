using P3PHelper.MVVM.ViewModels;
using P3PHelper.Repositories;

namespace P3PHelper.MVVM.Views.SchoolQuestions;

public partial class SchoolQuestionsCompletedView : ContentPage
{
    ProgressRepository ProgressRepo = new();
    SchoolQuestionsViewModel vm = new();

    public SchoolQuestionsCompletedView()
	{
		InitializeComponent();

        vm.CurrentViewQuestions = vm.Complete;
        BindingContext = vm;
	}

    private void SchoolQuestionCheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {

    }
}