using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoListv2.Model;

namespace ToDoListv2.Controller
{
    public class TaskOrdering : IComparer<Task>
    {
        public int Compare( Task nTask_1, Task nTask_2 )
        {
            int compare = nTask_1.Deadline.CompareTo( nTask_2.Deadline );
            if (compare == 0)
            {
                return nTask_1.TaskName.CompareTo( nTask_2.TaskName );
            }
            return compare;
        }
    }
}
