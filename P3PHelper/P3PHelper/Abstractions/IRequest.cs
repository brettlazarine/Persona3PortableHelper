
namespace P3PHelper.Abstractions
{
    public interface IRequest
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
