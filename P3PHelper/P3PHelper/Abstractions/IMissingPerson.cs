﻿
namespace P3PHelper.Abstractions
{
    public interface IMissingPerson
    {
        int Id { get; set; }
        string Name { get; set; }
        string Available { get; set; }
        string Deadline { get; set; }
        string Info { get; set; }
        string Reward { get; set; }
        int IsCompleted { get; set; }
    }
}
