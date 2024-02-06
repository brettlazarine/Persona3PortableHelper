using CommunityToolkit.Mvvm.ComponentModel;
using P3PHelper.MVVM.Models;
using P3PHelper.Repositories;
using System.Diagnostics;

namespace P3PHelper.MVVM.ViewModels
{
    public partial class InteractionStoryViewModel : ObservableObject
    {// THIS TASK AND BOOL ARE NO LONGER IN USE
        private bool _isInitialized = false;
        public async Task EnsureInitializedAsync(string arcanaName)
        {
            if (!_isInitialized)
            {
                await GetSLinkInfo(arcanaName);
                _isInitialized = true;
            }
        }

        public SLink Link { get; set; }
        public List<RankUp> RankUp { get; set; } = new();
        public List<RankUp> MaleInteractions { get; set; } = new();
        public List<RankUp> FemaleInteractions { get; set; } = new();
        // THIS CAN BE REMOVED
        public List<String> ScrollRanks = new()
        {
            "Rank 8", "Rank 9", "Rank 10"
        };

        public InteractionStoryViewModel()
        {
            
        }
        // THIS CTOR IS NO LONGER IN USE
        public InteractionStoryViewModel(string arcanaName)
        {
            
        }

        public async Task GetSLinkInfo(string arcanaName)
        {
            var repo = new ProgressRepository();
            try
            {
                Link = await repo.GetSLinkAsync(arcanaName);
                RankUp = await repo.GetRankUpAsync(arcanaName);

                if (RankUp != null)
                {
                    foreach (var rank in RankUp)
                    {
                        if (rank.IsMale == 1)
                        {
                            MaleInteractions.Add(rank);
                        }
                        else
                        {
                            FemaleInteractions.Add(rank);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"*** Error getting SLink: {ex.Message} ***");
            }
        }
        // ONLY USED FOR UNIT TESTING CURRENTLY, CAN BE REMOVED WHEN TESTS ARE COMPLETELY REMADE
        public double AdjustY(double y)
        {
            return y + 1000;
        }
    }
}
