using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3PHelper.MVVM.Models
{
    public partial class RankUp : ObservableObject
    {
        [ObservableProperty]
        public bool _isCompleted;
        [ObservableProperty]
        public bool _isVisible = false;
        public int RankNumber { get; set; }
        [ObservableProperty]
        public List<(string Question, string Answer)> _rankInteractions;

        public RankUp()
        {
            
        }
    }
}
