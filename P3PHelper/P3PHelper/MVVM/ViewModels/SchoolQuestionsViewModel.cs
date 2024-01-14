using P3PHelper.MVVM.Models;
using P3PHelper.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3PHelper.MVVM.ViewModels
{
    public class SchoolQuestionsViewModel
    {
        public List<SchoolQuestion> Incomplete { get; set; }
        public List<SchoolQuestion> Complete { get; set; }

        public List<SchoolQuestion> CurrentViewQuestions { get; set; } = new();

        public SchoolQuestionsViewModel()
        {
            var repo = new ProgressRepository();
            var questions = repo.GetSchoolQuestions();
            Incomplete = questions.Where(x => x.IsCompleted == 0).ToList();
            Complete = questions.Where(x => x.IsCompleted == 1).ToList();
        }
    }
}
