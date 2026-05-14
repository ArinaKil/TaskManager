using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager_Kilunina.Models;
using TaskManager_Kilunina.Context;

namespace TaskManager_Kilunina.ViewModels
{
    public class VM_Tasks
    {
        public TasksContext tasksContext;
        public List<Tasks> Tasks = new List<Tasks>();
    }
}
