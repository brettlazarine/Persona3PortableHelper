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
        public Story _sLinkBC;
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
    }
}
