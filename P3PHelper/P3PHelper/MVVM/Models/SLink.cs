﻿using CommunityToolkit.Mvvm.ComponentModel;
using P3PHelper.Abstractions;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace P3PHelper.MVVM.Models
{
    //[Table("SLinks")]
    public class SLink : ISLinks
    {
        [PrimaryKey]
        public string Arcana { get; set; }
        
        public string MaleName { get; set; }
        
        public string FemaleName { get; set; }
        
        public string MaleUnlockDate { get; set; }
        
        public string FemaleUnlockDate { get; set; }
        
        public string MaleHowToUnlock { get; set; }
        
        public string FemaleHowToUnlock { get; set; }
        
        public string MaleAvailability { get; set; }
        
        public string FemaleAvailability { get; set; }
        public bool MaleRequiresPersona { get; set;}
        public bool FemaleRequiresPersona { get; set; }

        public SLink()
        {
        }
    }
}
