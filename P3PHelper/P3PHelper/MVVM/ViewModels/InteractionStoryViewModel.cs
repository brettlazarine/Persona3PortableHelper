using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.VisualBasic;
using P3PHelper.MVVM.Models;
using P3PHelper.Repositories;
using System.Diagnostics;
using System.Windows.Input;

namespace P3PHelper.MVVM.ViewModels
{
    public partial class InteractionStoryViewModel : ObservableObject
    {
        ProgressRepository ProgressRepo = new();
        // CONSIDER A SIMPLER IMPLEMENTATION, THEN TEST RELEASE SPEED
        private bool _isInitialized = false;
        public async Task EnsureInitializedAsync(string arcanaName)
        {
            if (!_isInitialized)
            {
                await GetSLinkInfo(arcanaName);
                _isInitialized = true;
            }
        }

        #region Binding Properties
        public SLink Link { get; set; }
        public List<RankUp> RankUp { get; set; } = new();
        public List<RankUp> MaleInteractions { get; set; } = new();
        public List<RankUp> FemaleInteractions { get; set; } = new();
        #endregion
        // THIS CAN BE REMOVED
        public List<String> ScrollRanks = new()
        {
            "Rank 8", "Rank 9", "Rank 10"
        };

        #region Male UI
        // Male Date
        bool _maleDateVisible;
        public bool MaleDateVisible
        {
            get { return _maleDateVisible; }
            set { SetProperty(ref _maleDateVisible, value); }
        }
        double _maleDateArrowRotation;
        public double MaleDateArrowRotation
        {
            get { return _maleDateArrowRotation; }
            set { SetProperty(ref _maleDateArrowRotation, value); }
        }

        // Male How
        bool _maleHowVisible;
        public bool MaleHowVisible
        {
            get { return _maleHowVisible; }
            set { SetProperty(ref _maleHowVisible, value); }
        }
        double _maleHowArrowRotation;
        public double MaleHowArrowRotation
        {
            get { return _maleHowArrowRotation; }
            set { SetProperty(ref _maleHowArrowRotation, value); }
        }

        // Male Availability
        bool _maleAvailabilityVisible;
        public bool MaleAvailabilityVisible
        {
            get { return _maleAvailabilityVisible; }
            set { SetProperty(ref _maleAvailabilityVisible, value); }
        }
        double _maleAvailabilityArrowRotation;
        public double MaleAvailabilityArrowRotation
        {
            get { return _maleAvailabilityArrowRotation; }
            set { SetProperty(ref _maleAvailabilityArrowRotation, value); }
        }
        #endregion

        #region Female UI
        // Female Date
        bool _femaleDateVisible;
        public bool FemaleDateVisible
        {
            get { return _femaleDateVisible; }
            set { SetProperty(ref _femaleDateVisible, value); }
        }
        double _femaleDateArrowRotation;
        public double FemaleDateArrowRotation
        {
            get { return _femaleDateArrowRotation; }
            set { SetProperty(ref _femaleDateArrowRotation, value); }
        }

        // Female How
        bool _femaleHowVisible;
        public bool FemaleHowVisible
        {
            get { return _femaleHowVisible; }
            set { SetProperty(ref _femaleHowVisible, value); }
        }
        double _femaleHowArrowRotation;
        public double FemaleHowArrowRotation
        {
            get { return _femaleHowArrowRotation; }
            set { SetProperty(ref _femaleHowArrowRotation, value); }
        }

        // Female Availability
        bool _femaleAvailabilityVisible;
        public bool FemaleAvailabilityVisible
        {
            get { return _femaleAvailabilityVisible; }
            set { SetProperty(ref _femaleAvailabilityVisible, value); }
        }
        double _femaleAvailabilityArrowRotation;
        public double FemaleAvailabilityArrowRotation
        {
            get { return _femaleAvailabilityArrowRotation; }
            set { SetProperty(ref _femaleAvailabilityArrowRotation, value); }
        }
        #endregion

        #region Commands
        // Male
        public ICommand MaleDateCommand { get; }
        public ICommand MaleHowCommand { get; }
        public ICommand MaleAvailabilityCommand { get; }

        // Female
        public ICommand FemaleDateCommand { get; }
        public ICommand FemaleHowCommand { get; }
        public ICommand FemaleAvailabilityCommand { get; }

        // RankUp
        public ICommand RankCheckedCommand { get; }
        #endregion

        public InteractionStoryViewModel(string arcanaName)
        {
            MaleDateCommand = new RelayCommand(MaleDateTapped);
            MaleHowCommand = new RelayCommand(MaleHowTapped);
            MaleAvailabilityCommand = new RelayCommand(MaleAvailabilityTapped);

            FemaleDateCommand = new RelayCommand(FemaleDateTapped);
            FemaleHowCommand = new RelayCommand(FemaleHowTapped);
            FemaleAvailabilityCommand = new RelayCommand(FemaleAvailabilityTapped);

            RankCheckedCommand = new Command<RankUp>(HandleRankChecked);
        }
        // SHOULD BE CLEAR AFTER MOVING FROM CB TO VM, WILL NEED TO ADJUST TESTS FOR PARAMETERIZED CTOR
        public InteractionStoryViewModel()
        {
            MaleDateCommand = new RelayCommand(MaleDateTapped);
        }

        #region Male Events
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

        public void MaleHowTapped()
        {
            try
            {
                MaleHowVisible = !MaleHowVisible;
                MaleHowArrowRotation = MaleHowVisible ? 180 : 0;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"*** Error handling MaleHow tap: {ex.Message} ***");
            }
        }

        public void MaleAvailabilityTapped()
        {
            try
            {
                MaleAvailabilityVisible = !MaleAvailabilityVisible;
                MaleAvailabilityArrowRotation = MaleAvailabilityVisible ? 180 : 0;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"*** Error handling MaleAvailability tap: {ex.Message} ***");
            }
        }
        #endregion

        #region Female Events
        public void FemaleDateTapped()
        {
            try
            {
                FemaleDateVisible = !FemaleDateVisible;
                FemaleDateArrowRotation = FemaleDateVisible ? 180 : 0;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"*** Error handling FemaleDate tap: {ex.Message} ***");
            }
        }

        public void FemaleHowTapped()
        {
            try
            {
                FemaleHowVisible = !FemaleHowVisible;
                FemaleHowArrowRotation = FemaleHowVisible ? 180 : 0;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"*** Error handling FemaleHow tap: {ex.Message} ***");
            }
        }

        public void FemaleAvailabilityTapped()
        {
            try
            {
                FemaleAvailabilityVisible = !FemaleAvailabilityVisible;
                FemaleAvailabilityArrowRotation = FemaleAvailabilityVisible ? 180 : 0;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"*** Error handling FemaleAvailability tap: {ex.Message} ***");
            }
        }
        #endregion

        public void HandleRankChecked(RankUp rank)
        {
            if (rank is null)
            {
                // Null check because the event fires when the page is loaded
                return;
            }
            try
            {
                ProgressRepo.UpdateRankUp(rank.Id, rank.IsCompleted);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"*** HandleRankChecked {ex.Message} ***");
            }
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
