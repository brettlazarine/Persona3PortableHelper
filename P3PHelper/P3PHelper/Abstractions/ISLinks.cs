using P3PHelper.MVVM.Models;

namespace P3PHelper.Abstractions
{
    public interface ISLinks
    {
        string Arcana { get; set; }
        string MaleName { get; set; }
        string FemaleName { get; set; }
        string MaleUnlockDate { get; set; }
        string FemaleUnlockDate { get; set; }
        string MaleHowToUnlock { get; set; }
        string FemaleHowToUnlock { get; set; }
        string MaleAvailability { get; set; }
        string FemaleAvailability { get; set; }
        bool MaleRequiresPersona { get; set; }
        bool FemaleRequiresPersona { get; set; }
    }
}
