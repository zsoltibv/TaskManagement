using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Models
{
    public class Enums
    {
        public enum Status
        {
            Created,
            InProgress,
            Done
        }

        public enum Priority
        {
            Low,
            Medium,
            High
        }

        public enum Category
        {
            Home,
            School,
            Work
        }
    }
}
