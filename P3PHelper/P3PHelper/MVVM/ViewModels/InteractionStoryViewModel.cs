using CommunityToolkit.Mvvm.ComponentModel;
using P3PHelper.MVVM.Models;
using P3PHelper.Repositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3PHelper.MVVM.ViewModels
{
    public partial class InteractionStoryViewModel : ObservableObject
    {
        [ObservableProperty]
        public SLink _sLinkBC;
        [ObservableProperty]
        public bool _arrowRotated;
        public InteractionStoryViewModel()
        {
            
        }
        public InteractionStoryViewModel(string arcanaName)
        {
            var sLinkRepo = DependencyService.Get<SLinkRepository>();
            SLinkBC = sLinkRepo.GetSLink(arcanaName);
        }

        public double AdjustY(string rankNumber, double y)
        {
            switch (rankNumber)
            {
                case "Rank 1":
                case "Rank 2":
                case "Rank 3":
                case "Rank 4":
                    return y - 10;
                case "Rank 5":
                case "Rank 6":
                case "Rank 7":
                case "Rank 8":
                case "Rank 9":
                case "Rank 10":
                    return y + 100;
                default:
                    return 0;
            }
        }
    }
}
