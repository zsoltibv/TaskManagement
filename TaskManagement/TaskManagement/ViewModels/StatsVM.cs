using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using TaskManagement.Models;
using TaskManagement.Services;

namespace TaskManagement.ViewModels
{
    public class StatsVM
    {
        ObservableCollection<TreeViewElement> list;
        StatsHelper stats;
        public Stats Stats { get; set; }
        public StatsVM(ObservableCollection<TreeViewElement> element)
        {
            this.list = element;
            Stats = new Stats();
            stats = new StatsHelper(element);
        }

        public void Reset()
        {
            Stats.TasksDue = 0;
            Stats.TasksDueTomorrow = 0;
            Stats.TasksToBeDone = 0;
            Stats.TasksDone = 0;
            Stats.TasksOverdue = 0;
        }

        public void UpdateStats()
        {
            Reset();
            foreach (var stats in list)
            {
                if (stats.SubCollectionTask != null)
                {
                    foreach (TaskElement element in stats.SubCollectionTask)
                    {
                        var dateDiff = (element.Deadline - DateTime.Today).TotalDays;
                        if (element.Status == Enums.Status.Done)
                        {
                            Stats.TasksDone++;
                        }
                        else
                        {
                            Stats.TasksToBeDone++;
                        }
                        if (dateDiff == 1)
                        {
                            Stats.TasksDueTomorrow++;
                        }
                        if (dateDiff < 0)
                        {
                            Stats.TasksOverdue++;
                        }
                        if (dateDiff == 0)
                        {
                            Stats.TasksDue++;
                        }
                    }
                }
            }
        }
    }
}
