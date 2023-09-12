using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Managers.Interfaces
{
    public interface ITaskManager
    {
        void ViewTasks();
        void AddTask();
        void DeleteTask();
        void UpdateTask();
    }
}
