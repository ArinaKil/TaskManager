using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager_Kilunina.Models;
using TaskManager_Kilunina.Context;
using TaskManager_Kilunina.Classes;
using System.Collections.ObjectModel;

namespace TaskManager_Kilunina.ViewModels
{
    public class VM_Tasks : Notification
    {
        public ObservableCollection<Tasks> Tasks { get; set; }
        public TasksContext tasksContext;

        public VM_Tasks() =>
            Tasks = new ObservableCollection<Tasks>(tasksContext.Tasks.OrderBy(x => x.Done));
        public RealyCommand OnAddTask
        {
            get
            {
                return new RealyCommand(obj =>
                {
                    Tasks newTask = new Tasks()
                    {
                        DateExecute = DateTime.Now
                    };
                    Tasks.Add(newTask);
                    tasksContext.Tasks.Add(newTask);
                    tasksContext.SaveChanges();
                });
            }
        }
    }
}
