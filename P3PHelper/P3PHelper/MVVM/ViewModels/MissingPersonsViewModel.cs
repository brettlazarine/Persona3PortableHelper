using P3PHelper.MVVM.Models;
using P3PHelper.Repositories;

namespace P3PHelper.MVVM.ViewModels
{
    public class MissingPersonsViewModel
    {
        public List<MissingPerson> MissingPeople { get; set; } = new();
        public ProgressRepository ProgressRepo { get; set; } = new();

        public MissingPersonsViewModel()
        {
            foreach (var person in ProgressRepo.GetMissingPersons())
            {
                // From SQLite, the newlines are escaped, so need to replace them with the actual newline character
                person.Info = person.Info.Replace("\\n", Environment.NewLine);
                MissingPeople.Add(person);
            }
        }
    }
}
