using CommunityToolkit.Mvvm.ComponentModel;

namespace P3PHelper.MVVM.ViewModels
{
    public partial class InteractionStoryViewModel : ObservableObject
    {
        public List<String> ScrollRanks = new()
        {
            "Rank 8", "Rank 9", "Rank 10"
        };

        public InteractionStoryViewModel()
        {
            
        }

        public double AdjustY(double y)
        {
            return y + 1000;
        }
    }
}
