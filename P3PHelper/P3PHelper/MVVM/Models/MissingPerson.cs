using CommunityToolkit.Mvvm.ComponentModel;
using P3PHelper.Abstractions;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace P3PHelper.MVVM.Models
{
    public partial class MissingPerson : ObservableObject, IMissingPerson
    {

        [PrimaryKey, Indexed]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Available { get; set; }
        public string Deadline { get; set; }
        public string Info { get; set; }
        public string Reward { get; set; }
        private int _isCompleted;
        public int IsCompleted
        {
            get { return _isCompleted; }
            set { SetProperty(ref _isCompleted, value); }
        }
    }
}
