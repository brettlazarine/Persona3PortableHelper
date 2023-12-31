﻿using CommunityToolkit.Mvvm.ComponentModel;
using Newtonsoft.Json;
using SQLite;
using System.ComponentModel.DataAnnotations.Schema;

namespace P3PHelper.MVVM.Models
{
    public partial class RankUp : ObservableObject
    {
        [PrimaryKey, Unique, AutoIncrement]
        public int Id { get; set; }

        [ForeignKey(nameof(Arcana)), Indexed]
        public string Arcana { get; set; }

        public int IsMale { get; set; }
        
        private int _isCompleted;
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
            set
            {
                var tempDictList = JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(value);
                RankInteractions = tempDictList
                    .SelectMany(dict => dict)
                    .Select(kvp => (kvp.Key, kvp.Value))
                    .ToList();
            }
        }

        public RankUp()
        {
            //IsMale = 1;
        }
    }
}