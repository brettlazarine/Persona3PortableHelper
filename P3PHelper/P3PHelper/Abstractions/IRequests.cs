using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3PHelper.Abstractions
{
    public interface IRequests
    {
        public int QuestNumber { get; set; }
        public string QuestName { get; set; }
        public string Reward { get; set; }
        public string Available { get; set; }
        public string Deadline { get; set; }
        public string HowToComplete { get; set; }
        public int IsCompleted { get; set; }
    }
}
