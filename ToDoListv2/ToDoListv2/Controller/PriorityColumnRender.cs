using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using BrightIdeasSoftware;
using ToDoListv2.Model;

namespace ToDoListv2.Controller
{
    class PriorityColumnRender : MultiImageRenderer
    {
        public PriorityColumnRender()
        { }

        public PriorityColumnRender( object imageSelector, int maxImages, int minValue, int maxValue )
        {
            base.ImageSelector = imageSelector;
            base.MaxNumberImages = maxImages;
            base.MinimumValue = minValue;
            base.MaximumValue = maxValue;
        }

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
