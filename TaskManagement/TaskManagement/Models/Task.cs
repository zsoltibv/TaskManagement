using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Models
{
    enum Status
    {
        Created, 
        InProgress,
        Done
    }

    enum Priority
    {
        High,
        Medium, 
        Low
    }

    enum Category
    {
        Home, 
        School,
        Work
    }

    class Task
    {
        public string Name{ get; set; }

        public string Description { get;set;}

        public Status Status { get; set; }

        public Priority Priority { get; set; }

        public DateTime Deadline { get; set; }

        public DateTime EndDate { get; set; }

        public Category Category { get; set; }

        public Task() { }

        public Task(string name, string description, Status status, Priority priority, DateTime deadline, DateTime endDate, Category category)
        {
            Name = name;
            Description = description;
            Status = status;
            Priority = priority;
            Deadline = deadline;
            EndDate = endDate;
            Category = category;
        }
    }
}
