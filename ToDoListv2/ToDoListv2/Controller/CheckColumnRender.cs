using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using ToDoListv2.Model;
using BrightIdeasSoftware;

namespace ToDoListv2.Controller
{
    class CheckColumnRender : BaseRenderer
    {
        public override void Render( System.Drawing.Graphics g, System.Drawing.Rectangle r )
        {
            base.Render( g, r );
            Task nTask = (Task)this.RowObject;
            TimeSpan nSpan = DateTime.Today.Subtract( nTask.Deadline );
            Boolean nCompleted = nTask.Status == Task.STATUS_TYPES.COMPLETED ? true : false;
            if ( nTask.Status == Task.STATUS_TYPES.COMPLETED )
            {
                g.DrawLine( Pens.Red, new Point( r.Left, r.Height / 2 + r.Top ), new Point( r.Right, r.Height / 2 + r.Top ) );
            }
        }
    }
}
