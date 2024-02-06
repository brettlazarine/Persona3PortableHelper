
namespace P3PHelper.Abstractions
{
    public interface ISchoolQuestion
    {
        int Id { get; set; }
        string Date { get; set; }
        string Question { get; set; }
        string Answer { get; set; }
        int IsCompleted { get; set; }
    }
}
