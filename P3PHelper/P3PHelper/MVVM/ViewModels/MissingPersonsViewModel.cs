using P3PHelper.Abstractions;
using P3PHelper.MVVM.Models;
using P3PHelper.Repositories;
using System.Diagnostics;
using System.Windows.Input;

namespace P3PHelper.MVVM.ViewModels
{
    public class MissingPersonsViewModel
    {
        IProgressRepository _progressRepositoy;
        public List<MissingPerson> MissingPeople { get; set; } = new();
        public ICommand MissingPersonCheckedCommand { get; }

        public MissingPersonsViewModel(IProgressRepository progressRepository)
        {
            _progressRepositoy = progressRepository;

            foreach (var person in _progressRepositoy.GetMissingPersons())
            {
                // From SQLite, the newlines are escaped, so need to replace them with the actual newline character
                person.Info = person.Info.Replace("\\n", Environment.NewLine);
                MissingPeople.Add(person);
            }

            MissingPersonCheckedCommand = new Command<MissingPerson>(HandleMissingPersonChecked);
        }

        public async void HandleMissingPersonChecked(MissingPerson missingPerson)
        {
            if (missingPerson == null)
            {
                // Null check is required because the event is fired when the view is first loaded 
                return;
            }
            try
            {
                _progressRepositoy.UpdateMissingPerson(missingPerson.Id, missingPerson.IsCompleted);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"*** HandleMIssingPersonChecked {ex.Message} ***");
                await Application.Current.MainPage.DisplayAlert("Error", "An error occurred while updating the missing person", "OK");
            }
        }
    }
}
