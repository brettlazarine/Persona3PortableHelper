using CommunityToolkit.Mvvm.ComponentModel;
using P3PHelper.MVVM.Models;
using P3PHelper.Repositories;
using System.Diagnostics;

namespace P3PHelper.MVVM.ViewModels
{
    public partial class InteractionStoryViewModel : ObservableObject
    {
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

        //public List<(int rankNumber, int isCompleted, List<(string question, string answer>)>)> 

        public List<String> ScrollRanks = new()
        {
            "Rank 8", "Rank 9", "Rank 10"
        };

        public InteractionStoryViewModel()
        {
            
        }

        public InteractionStoryViewModel(string arcanaName)
        {
            //Debug.WriteLine("*** BEFORE GETSLINK ***");
            //try
            //{
            //    var repo = new ProgressRepository();
            //    //Link = await repo.GetSLinkAsync(arcanaName);
            //    Debug.WriteLine($"*** Link: {Link.Arcana} ***");
            //}
            //catch (Exception ex)
            //{
            //    Debug.WriteLine($"*** Error getting SLink: {ex.Message} ***");
            //}
            //Debug.WriteLine("*** BEFORE GETRANKUP ***");
            //try
            //{
            //    var repo = new ProgressRepository();
            //    RankUp = repo.GetRankUp(arcanaName);
            //    Debug.WriteLine($"*** RankUps: {RankUp.Count} ***");
            //}
            //catch (Exception ex)
            //{
            //    Debug.WriteLine($"*** Error getting RankUps: {ex.Message} ***");
            //}

            //if (RankUp != null)
            //{
            //    foreach (var rank in RankUp)
            //    {
            //        if (rank.IsMale == 1)
            //        {
            //            MaleInteractions.Add(rank);
            //        }
            //        else
            //        {
            //            FemaleInteractions.Add(rank);
            //        }
            //    }
            //}

            //GetSLinkInfo(arcanaName);
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

        public double AdjustY(double y)
        {
            return y + 1000;
        }
    }
}
