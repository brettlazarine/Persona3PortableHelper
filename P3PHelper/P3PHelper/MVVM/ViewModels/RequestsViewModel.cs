using CommunityToolkit.Mvvm.ComponentModel;
using P3PHelper.MVVM.Models;
using P3PHelper.Repositories;
using System.Diagnostics;
using System.Windows.Input;

namespace P3PHelper.MVVM.ViewModels
{
    public partial class RequestsViewModel: ObservableObject
    {
        ProgressRepository ProgressRepo = new();

        //[ObservableProperty]
        //List<Request> currentRequest;
        public List<Request> OneTwenty { get; set; } = new();
        public List<Request> TwentyOneFourty { get; set; } = new();
        public List<Request> FourtyOneSixty { get; set; } = new();
        public List<Request> SixtyOneEighty { get; set; } = new();

        public List<Request> CurrentRequests { get; set; }

        public ICommand RequestCheckedCommand { get; }

        public RequestsViewModel()
        {
            foreach (var req in ProgressRepo.GetRequests())
            {
                // From SQLite, the newlines are escaped, so need to replace them with the actual newline character
                req.HowToComplete = req.HowToComplete.Replace("\\n", Environment.NewLine);
                req.Reward = req.Reward.Replace("\\n", Environment.NewLine);
                if (req.QuestNumber <= 20)
                {
                    OneTwenty.Add(req);
                }
                else if (req.QuestNumber <= 40)
                {
                    TwentyOneFourty.Add(req);
                }
                else if (req.QuestNumber <= 60)
                {
                    FourtyOneSixty.Add(req);
                }
                else if (req.QuestNumber <= 80)
                {
                    SixtyOneEighty.Add(req);
                }
            }

            CurrentRequests = new();

            RequestCheckedCommand = new Command<Request>(HandleRequestChecked);
        }

        // Avoided this, verify that it is not needed
        public List<Request> SetCurrentRequests(string groupName)
        {
            if (groupName == "One To Twenty View")
            {
                return OneTwenty;
            }
            else if (groupName == "Twenty One Fourty View")
            {
                return TwentyOneFourty;
            }
            else if (groupName == "Fourty One Sixty View")
            {
                return FourtyOneSixty;
            }
            else if (groupName == "Sixty One Eighty View")
            {
                return SixtyOneEighty;
            }
            else
            {
                return null;
            }
        }

        private void HandleRequestChecked(Request request)
        {
            try
            {
                // TRY THIS WITHOUT THE TERNARY
                ProgressRepo.UpdateRequest(request.QuestNumber, request.IsCompleted == 1 ? 1 : 0);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"*** HandleRequestChecked {ex.Message} ***");
            }
        }
    }
}
