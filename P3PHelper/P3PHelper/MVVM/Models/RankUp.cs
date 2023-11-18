using CommunityToolkit.Mvvm.ComponentModel;
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3PHelper.MVVM.Models
{
    public partial class RankUp : ObservableObject
    {
        private bool _isCompletedMale;
        private bool _isCompletedFemale;

        [PrimaryKey, AutoIncrement]
        public int RankUpId { get; set; }

        [ForeignKey(nameof(SLink))]
        public string SLinkArcana { get; set; }
        

        public bool IsCompletedMale
        {
            get { return _isCompletedMale; }
            set { SetProperty(ref _isCompletedMale, value); }
        }
        public bool IsCompletedFemale
        {
            get { return _isCompletedFemale; }
            set { SetProperty(ref _isCompletedFemale, value); }
        }

        public int RankNumber { get; set; }
        [Ignore]
        public List<(string Question, string Answer)> RankInteractions { get; set; }

        public RankUp()
        {
            
        }
    }
}
