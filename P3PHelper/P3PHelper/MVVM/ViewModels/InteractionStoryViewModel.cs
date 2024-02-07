using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using P3PHelper.MVVM.Models;
using P3PHelper.Repositories;
using System.Diagnostics;
using System.Windows.Input;

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

        #region Male UI
        public bool _maleDateVisible;
        public bool MaleDateVisible
        {
            get { return _maleDateVisible; }
            set { SetProperty(ref _maleDateVisible, value); }
        }
        public double _maleDateArrowRotation;
        public double MaleDateArrowRotation
        {
            get { return _maleDateArrowRotation; }
            set { SetProperty(ref _maleDateArrowRotation, value); }
        }
        #endregion

        public SLink Link { get; set; }
        public List<RankUp> RankUp { get; set; } = new();
        public List<RankUp> MaleInteractions { get; set; } = new();
        public List<RankUp> FemaleInteractions { get; set; } = new();
        // THIS CAN BE REMOVED
        public List<String> ScrollRanks = new()
        {
            "Rank 8", "Rank 9", "Rank 10"
        };

        public ICommand MaleDateCommand { get; }

        public InteractionStoryViewModel()
        {
            MaleDateCommand = new RelayCommand(MaleDateTapped);
        }

        public void MaleDateTapped()
        {
            try
            {
                MaleDateVisible = !MaleDateVisible;
                MaleDateArrowRotation = MaleDateVisible ? 180 : 0;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"*** Error handling MaleDate tap: {ex.Message} ***");
            }
        }
        // CHECK THE USE OF THIS CTOR, COMMANDS GO HERE
        public InteractionStoryViewModel(string arcanaName)
        {
            MaleDateCommand = new RelayCommand(MaleDateTapped);
        }
        // MAY BE UNNECESSARY
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
