using CommunityToolkit.Mvvm.ComponentModel;
using P3PHelper.Abstractions;
using SQLite;

namespace P3PHelper.MVVM.Models
{
    public class Request : ObservableObject , IRequests
    {
        [PrimaryKey, Indexed]
        public int QuestNumber { get; set; }
        public string QuestName { get; set; }
        public string Reward { get; set; }
        public string Available { get; set; }
        public string Deadline { get; set; }
        public string HowToComplete { get; set; }

        private int _isCompleted;
        public int IsCompleted
        {
            get { return _isCompleted; }
            set { SetProperty(ref _isCompleted, value); }
        }

        public Request()
        {
            IsCompleted = 0;
        }
    }
}
