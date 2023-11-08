using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3PHelper.MVVM.Models
{
    public class Story
    {
        public string Arcana { get; set; }
        public string FemaleName { get; set; }
        public string MaleName { get; set; }
        public string FemaleUnlockDate { get; set; }
        public string MaleUnlockDate { get; set; }
        public string FemaleHowToUnlock { get; set; }
        public string MaleHowToUnlock { get; set; }
        public string FemaleAvailability { get; set; }
        public string MaleAvailability { get; set; }
        public bool FemaleRequiresPersona { get; set; }
        public bool MaleRequiresPersona { get; set; }
        public ObservableCollection<RankUp> FemaleRankUps { get; set; }
        public ObservableCollection<RankUp> MaleRankUps { get; set; }

        public Story()
        {
            //CHARIOT

            // DEATH
            var death = new Story
            {
                Arcana = "Death",
                MaleRequiresPersona = false,
                // Male
                MaleName = "Pharos",
                MaleUnlockDate = "6/12",
                MaleHowToUnlock = "Story related.",
                MaleAvailability = "Story related.",
                MaleRankUps = new ObservableCollection<RankUp>
                {
                    new RankUp()
                    {
                        RankNumber = 1,
                        RankInteractions = new List<(string, string)>
                        {
                            ("Story related." , "6/12")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 2,
                        RankInteractions = new List<(string, string)>
                        {
                            ("Story related." , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        RankInteractions = new List<(string, string)>
                        {
                            ("Story related." , "7/12")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        RankInteractions = new List<(string, string)>
                        {
                            ("Story related." , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        RankInteractions = new List<(string, string)>
                        {
                            ("Story related." , "8/7")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        RankInteractions = new List<(string, string)>
                        {
                            ("Story related." , "9/12")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        RankInteractions = new List<(string, string)>
                        {
                            ("Story related." , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        RankInteractions = new List<(string, string)>
                        {
                            ("Story related." , "10/6")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        RankInteractions = new List<(string, string)>
                        {
                            ("Story related." , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 10,
                        RankInteractions = new List<(string, string)>
                        {
                            ("Story related." , "11/4")
                        }
                    }
                },
                // Female
                FemaleRequiresPersona = false,
                FemaleName = "Pharos",
                FemaleUnlockDate = "6/12",
                FemaleHowToUnlock = "Story related.",
                FemaleAvailability = "Story related.",
                FemaleRankUps = new ObservableCollection<RankUp>
                {

                    new RankUp()
                    {
                        RankNumber = 1,
                        RankInteractions = new List<(string, string)>
                        {
                            ("Story related." , "6/12")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 2,
                        RankInteractions = new List<(string, string)>
                        {
                            ("Story related." , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        RankInteractions = new List<(string, string)>
                        {
                            ("Story related." , "7/12")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        RankInteractions = new List<(string, string)>
                        {
                            ("Story related." , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        RankInteractions = new List<(string, string)>
                        {
                            ("Story related." , "8/7")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        RankInteractions = new List<(string, string)>
                        {
                            ("Story related." , "9/12")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        RankInteractions = new List<(string, string)>
                        {
                            ("Story related." , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        RankInteractions = new List<(string, string)>
                        {
                            ("Story related." , "10/6")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        RankInteractions = new List<(string, string)>
                        {
                            ("Story related." , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 10,
                        RankInteractions = new List<(string, string)>
                        {
                            ("Story related." , "11/4")
                        }
                    }
                }
            };
        }
    }
}
