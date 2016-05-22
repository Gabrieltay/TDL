using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToDoListv2.Model
{
    class TaskList : List<Task>
    {
        public Boolean Contain( Task aTask )
        {
            foreach ( Task nTask in this )
            {
                if ( nTask.TaskName.Equals( aTask.TaskName ) )
                {
                    if ( nTask.Deadline.Equals( aTask.Deadline ) )
                        return true;
                }
            }
            return false;
        }

        public void SyncLists( List<Task> aList )
        {
            TaskList nSyncList = this;
            foreach ( Task nTask in aList )
            {
                if ( this.Contain( nTask ) )
                    continue;
                else
                    nSyncList.Add( nTask );
            }

            this.Clear();
            this.AddRange( nSyncList );
        }
    }
}
