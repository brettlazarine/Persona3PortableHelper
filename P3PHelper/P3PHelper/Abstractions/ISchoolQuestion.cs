using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3PHelper.Abstractions
{
    public class ISchoolQuestion
    {
        int Id { get; set; }
        string Date { get; set; }
        string Question { get; set; }
        string Answer { get; set; }
        int IsCompleted { get; set; }
    }
}
