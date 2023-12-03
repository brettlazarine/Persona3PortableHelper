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
                   QuestName = "Name",
                   Reward = "Reward",
                   Available = "Available",
                   Deadline = "Deadline",
                   HowToComplete = "How to complete"
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
