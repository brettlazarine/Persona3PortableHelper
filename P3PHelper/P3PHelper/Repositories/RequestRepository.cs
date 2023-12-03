using P3PHelper.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3PHelper.Repositories
{
    public class RequestRepository
    {
        public List<Request> AllRequests { get; set; } = new();

        public RequestRepository()
        {
            AllRequests = new List<Request>()
            {
                #region 1-10
                new Request()
                {
                   QuestNumber = 1,
                   QuestName = "Retrieve 1 Beetle Shell",
                   Reward = "¥12,000",
                   Available = "4/30",
                   Deadline = "5/7",
                   HowToComplete = "Dropped by Grave Beetle on Floors 6 - 15"
                },
                new Request()
                {
                   QuestNumber = 2,
                   QuestName = "Retrieve the first old document",
                   Reward = "Bead Chain",
                   Available = "4/30",
                   Deadline = "5/7",
                   HowToComplete = "Reach the top of Thebel Block before the Full Moon"
                },
                new Request()
                {
                   QuestNumber = 3,
                   QuestName = "I'd like to sip a Muscle Drink",
                   Reward = "Dark Jacket (male) \n---\n Angora Sweater (female)",
                   Available = "4/30",
                   Deadline = "None",
                   HowToComplete = "Can be found in chests in Tartarus or bought from Pharmacy"
                },
                new Request()
                {
                   QuestNumber = 4,
                   QuestName = "Retrieve 3 Old Lanterns",
                   Reward = "Umugi Water x2",
                   Available = "5/10",
                   Deadline = "6/6",
                   HowToComplete = "Dropped by Phantom Mage on Floors 17 - 24"
                },
                new Request()
                {
                   QuestNumber = 5,
                   QuestName = "Retrieve the second old document",
                   Reward = "Recarm Card",
                   Available = "5/10",
                   Deadline = "6/6",
                   HowToComplete = "Reach the 40th Floor of Tartarus before the Full Moon"
                },
                new Request()
                {
                   QuestNumber = 6,
                   QuestName = "Create Jack Frost with Dia",
                   Reward = "Battle Panties",
                   Available = "5/10",
                   Deadline = "None",
                   HowToComplete = "Fuse Pixie and Unicorn"
                },
                new Request()
                {
                   QuestNumber = 7,
                   QuestName = "Retrieve 1 Lead Medal",
                   Reward = "Toy Bow",
                   Available = "5/10",
                   Deadline = "None",
                   HowToComplete = "Dropped by Gold Shadows in Thebel Block"
                },
                new Request()
                {
                   QuestNumber = 8,
                   QuestName = "Create Valkyrie with Tarukaja",
                   Reward = "Torn Black Cloth",
                   Available = "After Completing #6",
                   Deadline = "None",
                   HowToComplete = "Fuse Forneus and Yomotsu Shikome"
                },
                new Request()
                {
                   QuestNumber = 9,
                   QuestName = "Retrieve 5 Bronze Figurines",
                   Reward = "Sigma Drive",
                   Available = "6/13",
                   Deadline = "7/5",
                   HowToComplete = "Dropped by Bronze Dice on Floors 41 - 46"
                },
                new Request()
                {
                   QuestNumber = 10,
                   QuestName = "Retrieve 3 Snake Scale",
                   Reward = "¥46,000",
                   Available = "6/13",
                   Deadline = "7/5",
                   HowToComplete = "Dropped by Lustful Snakes (Red Shadows) on Floors 41-63"
                },
                #endregion
                #region 11-20
                new Request()
                {
                   QuestNumber = 11,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 12,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 13,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 14,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 15,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 16,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 17,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 18,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 19,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 20,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                #endregion
                #region 21-30
                new Request()
                {
                   QuestNumber = 21,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 22,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 23,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 24,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 25,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 26,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 27,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 28,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 29,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 30,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                #endregion
                #region 31-40
                new Request()
                {
                   QuestNumber = 31,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 32,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 33,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 34,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 35,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 36,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 37,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 38,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 39,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 40,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                #endregion
                #region 41-50
                new Request()
                {
                   QuestNumber = 41,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 42,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 43,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 44,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 45,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 46,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 47,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 48,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 49,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 50,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                #endregion
                #region 51-60
                new Request()
                {
                   QuestNumber = 51,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 52,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 53,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 54,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 55,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 56,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 57,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 58,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 59,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 60,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                #endregion
                #region 61-70
                new Request()
                {
                   QuestNumber = 61,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 62,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 63,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 64,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 65,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 66,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 67,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 68,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 69,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 70,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                #endregion
                #region 71-80
                new Request()
                {
                   QuestNumber = 1,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 2,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 3,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 4,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 5,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 6,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 7,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 8,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 9,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                new Request()
                {
                   QuestNumber = 10,
                   QuestName = "",
                   Reward = "",
                   Available = "",
                   Deadline = "",
                   HowToComplete = ""
                },
                #endregion
            };

            if (App.ProgressRepo.GetRequests().Count >= 0)
            {
                LoadRequestDb(AllRequests);
            }
        }

        public void LoadRequestDb(List<Request> requests)
        {
            try
            {
                if (App.ProgressRepo.GetRequests().Count == 0)
                {
                    foreach (var request in requests)
                    {
                        App.ProgressRepo.InsertRequest(request);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("*** LoadRequestDb: " + ex.Message + " ***");
                return;
            }
        }
    }
}
