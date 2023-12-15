using CommunityToolkit.Mvvm.ComponentModel;
using P3PHelper.MVVM.Models;
using P3PHelper.Repositories;
using System.Diagnostics;

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
            Debug.WriteLine("*** BEFORE GETSLINK ***");
            try
            {
                var repo = new ProgressRepository();
                Link = repo.GetSLink(arcanaName);
                Debug.WriteLine($"*** Link: {Link.Arcana} ***");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"*** Error getting SLink: {ex.Message} ***");
            }
        }

        public double AdjustY(double y)
        {
            return y + 1000;
        }
    }
}
