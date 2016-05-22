using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToDoListv2.Model
{
    [Serializable]
    public class Task
    {
        public enum STATUS_TYPES
        {
            PENDING,
            COMPLETED
        }

        public Task()
        {
            this.TaskName = "";
            this.Deadline = DateTime.Today;
            this.Status = STATUS_TYPES.PENDING;
            this.Priority = 0;
            
        }

        public Task( String aTaskName, DateTime aDeadline, STATUS_TYPES aStatus, int aPriority )
        {
            this.TaskName = aTaskName;
            this.Deadline = aDeadline;
            this.Status = aStatus;
            this.Priority = aPriority;
        }

        #region Properties
        public String TaskName
        {
            get;
            set;
        }

        public DateTime Deadline
        {
            get;
            set;
        }

        public STATUS_TYPES Status
        {
            get;
            set;
        }

        public int Priority
        {
            get;
            set;
        }
        #endregion
    }
}
