﻿using P3PHelper.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3PHelper.Abstractions
{
    public interface ISLinks
    {
        string Arcana { get; set; }
        string FemaleName { get; set; }
        string MaleName { get; set; }
        string FemaleUnlockDate { get; set; }
        string MaleUnlockDate { get; set; }
        string FemaleHowToUnlock { get; set; }
        string MaleHowToUnlock { get; set; }
        string FemaleAvailability { get; set; }
        string MaleAvailability { get; set; }
        bool FemaleRequiresPersona { get; set; }
        bool MaleRequiresPersona { get; set; }
        ObservableCollection<RankUp> FemaleRankUps { get; set; }
        ObservableCollection<RankUp> MaleRankUps { get; set; }
    }
}
