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

        private async void HandleRequestChecked(Request request)
        {
            if (request is null)
            {
                // Null check is required because the event is fired when the view is first loaded
                return;
            }
            try
            {
                ProgressRepo.UpdateRequest(request.QuestNumber, request.IsCompleted);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"*** HandleRequestChecked {ex.Message} ***");
                await App.Current.MainPage.DisplayAlert("Error", "An error occurred while updating the request", "OK");
            }
        }
    }
}
