using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Models;

namespace TaskManagement.ViewModels
{
    public class StatsVM
    {
        public Stats Stats { get; set; }
        public StatsVM()
        {
            Stats = new Stats();
        }
    }
}
