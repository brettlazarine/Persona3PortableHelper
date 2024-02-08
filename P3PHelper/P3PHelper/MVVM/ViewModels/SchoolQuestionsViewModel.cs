using CommunityToolkit.Mvvm.ComponentModel;
using P3PHelper.MVVM.Models;
using P3PHelper.Repositories;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;

namespace P3PHelper.MVVM.ViewModels
{
    public class SchoolQuestionsViewModel : ObservableObject
    {
        public ObservableCollection<SchoolQuestion> Incomplete { get; set; }
        public ObservableCollection<SchoolQuestion> Complete { get; set; }

        public ObservableCollection<SchoolQuestion> CurrentViewQuestions { get; set; } = new();

        ProgressRepository ProgressRepo = new();
        public ICommand SchoolQuestionCheckedCommand { get; }


        public SchoolQuestionsViewModel()
        {
            var questions = ProgressRepo.GetSchoolQuestions();
            Incomplete = new ObservableCollection<SchoolQuestion>(questions.Where(x => x.IsCompleted == 0));
            Complete = new ObservableCollection<SchoolQuestion>(questions.Where(x => x.IsCompleted == 1));

            SchoolQuestionCheckedCommand = new Command<SchoolQuestion>(HandleSchoolQuestionChecked);
        }
        
        private async void HandleSchoolQuestionChecked(SchoolQuestion schoolQuestion)
        {
            // Null check is required because the event is fired when the view is first loaded
            if (schoolQuestion is null)
            {
                return;
            }

            try
            {
                ProgressRepo.UpdateSchoolQuestion(schoolQuestion.Id, schoolQuestion.IsCompleted);

                // Logic to arrange question collections
                CurrentViewQuestions.Remove(schoolQuestion);

                if (schoolQuestion.IsCompleted is 1)
                {
                    Incomplete.Remove(schoolQuestion);
                    if (!Complete.Contains(schoolQuestion))
                    {
                        AddQuestionAtIndex(schoolQuestion, Complete);
                    }
                }
                else
                {
                    Complete.Remove(schoolQuestion);
                    if (!Incomplete.Contains(schoolQuestion))
                    {
                        AddQuestionAtIndex(schoolQuestion, Incomplete);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"*** HandleSchoolQuestionChecked error: {ex.Message} ***");
                await App.Current.MainPage.DisplayAlert("Error", "An error occurred while updating the school question", "OK");
            }
            
        }

        public async void AddQuestionAtIndex(SchoolQuestion entry, ObservableCollection<SchoolQuestion> collection)
        {
            try
            {
                if (collection.Count == 0)
                {
                    collection.Add(entry);
                    return;
                }

                for (int i = 0; i < collection.Count; i++)
                {
                    if (entry.Index < collection[i].Index)
                    {
                        collection.Insert(i, entry);
                        return;
                    }
                }
                collection.Add(entry);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"*** AddQuestionAtIndex error: {ex.Message} ***");
                await App.Current.MainPage.DisplayAlert("Error", "An error occurred while indexing the school question", "OK");
            }
        }
    }
}
