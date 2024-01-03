using CommunityToolkit.Mvvm.ComponentModel;
using Newtonsoft.Json;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3PHelper.MVVM.Models
{
    public class ArcanaRankUp
    {
        public string Arcana { get; set; }
        [Ignore]
        public Dictionary<string, RankInteractionDetails> RankUps { get; set; }
        [Column("RankUps")]
        public string SerializedRankUps
        {
            get => JsonConvert.SerializeObject(RankUps);
            set => RankUps = JsonConvert.DeserializeObject<Dictionary<string, RankInteractionDetails>>(value);
        }
    }
    public class RankInteractionDetails
    {
        public RankInteraction Male { get; set; }
        public RankInteraction Female { get; set; }
    }
    public class RankInteraction : ObservableObject
    {
        private int _isCompleted;
        public int IsCompleted
        {
            get { return _isCompleted; }
            set { SetProperty(ref _isCompleted, value); }
        }
        [Ignore]
        public List<QuestionAnswerPair> RankInteractions { get; set; }
        public string SerializedRankInteractions
        {
            get => JsonConvert.SerializeObject(RankInteractions);
            set => RankInteractions = JsonConvert.DeserializeObject<List<QuestionAnswerPair>>(value);
        }

        // Method to deserialize the SerializedRankInteractions
        public List<QuestionAnswerPair> GetRankInteractions()
        {
            return JsonConvert.DeserializeObject<List<QuestionAnswerPair>>(SerializedRankInteractions);
        }
    }
    public class QuestionAnswerPair
    {
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}
