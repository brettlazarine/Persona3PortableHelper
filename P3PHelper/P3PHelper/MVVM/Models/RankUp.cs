using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3PHelper.MVVM.Models
{
    public class RankUp
    {
        public bool IsCompleted { get; set; }
        public int RankNumber { get; set; }
        public List<(string Question, string Answer)> RankInteractions { get; set; }
    }
}
