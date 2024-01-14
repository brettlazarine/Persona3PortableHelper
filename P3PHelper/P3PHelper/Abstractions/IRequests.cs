using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3PHelper.Abstractions
{
    public interface IRequests
    {
        int QuestNumber { get; set; }
        string QuestName { get; set; }
        string Reward { get; set; }
        string Available { get; set; }
        string Deadline { get; set; }
        string HowToComplete { get; set; }
        int IsCompleted { get; set; }
    }
}
