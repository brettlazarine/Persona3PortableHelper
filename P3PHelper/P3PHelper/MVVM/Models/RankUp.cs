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
        private bool _isCompleted;

        [PrimaryKey, AutoIncrement]
        public int RankUpId { get; set; }

        [ForeignKey(nameof(SLink))]
        public string SLinkArcana { get; set; }
        

        public bool IsCompleted
        {
            get { return _isCompleted; }
            set { SetProperty(ref _isCompleted, value); }
        }


        public int RankNumber { get; set; }
        [Ignore]
        public List<(string Question, string Answer)> RankInteractions { get; set; }

        public RankUp()
        {
            
        }
    }
}
