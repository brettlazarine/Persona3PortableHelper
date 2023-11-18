using P3PHelper.Abstractions;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3PHelper.MVVM.Models
{
    [Table("SLinks")]
    public class SLink : ISLinks
    {
        [PrimaryKey]
        public string Arcana { get; set; }
        [Ignore]
        public string MaleName { get; set; }
        [Ignore]
        public string FemaleName { get; set; }
        [Ignore]
        public string MaleUnlockDate { get; set; }
        [Ignore]
        public string FemaleUnlockDate { get; set; }
        [Ignore]
        public string MaleHowToUnlock { get; set; }
        [Ignore]
        public string FemaleHowToUnlock { get; set; }
        [Ignore]
        public string MaleAvailability { get; set; }
        [Ignore]
        public string FemaleAvailability { get; set; }
        [Ignore]
        public bool MaleRequiresPersona { get; set; }
        [Ignore]
        public bool FemaleRequiresPersona { get; set; }
        [Ignore]
        public ObservableCollection<RankUp> MaleRankUps { get; set; }
        [Ignore]
        public ObservableCollection<RankUp> FemaleRankUps { get; set; }

        public SLink()
        {
            MaleRequiresPersona = true;
            FemaleRequiresPersona = true;
        }
    }
}
