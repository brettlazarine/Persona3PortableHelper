using CommunityToolkit.Mvvm.ComponentModel;
using P3PHelper.Abstractions;
using SQLite;

namespace P3PHelper.MVVM.Models
{
    public class SchoolQuestion : ObservableObject
    {
        [PrimaryKey, Indexed]
        public int Id { get; set; }
        public string Date { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        private int _isCompleted;
        public int IsCompleted
        {
            get { return _isCompleted; }
            set { SetProperty(ref _isCompleted, value); }
        }
    }
}
