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
        public int RankNumber { get; set; }
        public List<(string Question, string Answer)> RankInteractions { get; set; }
    }
}
