using P3PHelper.MVVM.Models;
using P3PHelper.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                person.Info = person.Info.Replace("\\n", Environment.NewLine);
                MissingPeople.Add(person);
            }
        }
    }
}
