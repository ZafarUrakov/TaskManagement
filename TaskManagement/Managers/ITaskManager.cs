﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Managers
{
    public interface ITaskManager
    {
        public void ViewTasks();
        public void AddTask();
    }
}
