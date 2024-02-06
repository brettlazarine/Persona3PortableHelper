
namespace P3PHelper.Abstractions
{
    public interface IRankUp
    {
        int Id { get; set; }
        string Arcana { get; set; }
        int IsMale { get; set; }
        int IsCompleted { get; set; }
        int RankNumber { get; set; }
        List<(string Question, string Answer)> RankInteractions { get; set; }
    }
}
