using CommunityToolkit.Mvvm.ComponentModel;
using Newtonsoft.Json;
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
        private int _isCompleted;

        [PrimaryKey, Unique, AutoIncrement]
        public int RankUpId { get; set; }

        [ForeignKey(nameof(Arcana)), Indexed]
        public string Arcana { get; set; }

        public bool IsMale;
        
        public int IsCompleted
        {
            get { return _isCompleted; }
            set { SetProperty(ref _isCompleted, value); }
        }

        public int RankNumber { get; set; }

        [Ignore]
        public List<(string Question, string Answer)> RankInteractions { get; set; }

        // Serialized property for storing in the database
        public string SerializedRankInteractions
        {
            get => JsonConvert.SerializeObject(RankInteractions);
            set => RankInteractions = JsonConvert.DeserializeObject<List<(string, string)>>(value);
        }

        //[Ignore]
        //public List<(string Question, string Answer)> FemaleRankInteractions { get; set; }
        //public string FemaleSerializedRankInteractions
        //{
        //    get => JsonConvert.SerializeObject(RankInteractions);
        //    set => RankInteractions = JsonConvert.DeserializeObject<List<(string, string)>>(value);
        //}

        public RankUp()
        {
            IsMale = true;
        }
    }
}
