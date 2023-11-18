using P3PHelper.Abstractions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3PHelper.MVVM.Models
{
    public class SLink : ISLinks
    {
        public string Arcana { get; set; }
        public string MaleName { get; set; }
        public string FemaleName { get; set; }
        public string MaleUnlockDate { get; set; }
        public string FemaleUnlockDate { get; set; }
        public string MaleHowToUnlock { get; set; }
        public string FemaleHowToUnlock { get; set; }
        public string MaleAvailability { get; set; }
        public string FemaleAvailability { get; set; }
        public bool MaleRequiresPersona { get; set; }
        public bool FemaleRequiresPersona { get; set; }
        public ObservableCollection<RankUp> MaleRankUps { get; set; }
        public ObservableCollection<RankUp> FemaleRankUps { get; set; }

        public SLink()
        {
            MaleRequiresPersona = true;
            FemaleRequiresPersona = true;
        }
    }
}
