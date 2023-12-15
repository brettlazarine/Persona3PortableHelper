using CommunityToolkit.Mvvm.ComponentModel;
using P3PHelper.MVVM.Models;

namespace P3PHelper.MVVM.ViewModels
{
    public partial class InteractionStoryViewModel : ObservableObject
    {
        public SLink Link { get; set; }
        public List<String> ScrollRanks = new()
        {
            "Rank 8", "Rank 9", "Rank 10"
        };

        public InteractionStoryViewModel()
        {
            
        }

        public InteractionStoryViewModel(string arcanaName)
        {
            Link = App.ProgressRepo.GetSLink(arcanaName);
        }

        public double AdjustY(double y)
        {
            return y + 1000;
        }
    }
}
