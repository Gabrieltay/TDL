using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoListv2.Model;

namespace ToDoListv2.Controller
{
    public static class TaskListSynchronizer
    {
        public static List<Task> SyncLists( List<Task> aNewList, List<Task> aOldList )
        {
            TaskList nSyncList = (TaskList)aNewList;
            foreach ( Task nTask in aOldList )
            {
                if ( ((TaskList)aNewList).Contain( nTask ) )
                    continue;
                else
                    nSyncList.Add( nTask );
            }

            return nSyncList;
        }
    }
}
