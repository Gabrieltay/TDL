using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using ToDoListv2.Model;
using ToDoListv2.Common;
using BrightIdeasSoftware;

namespace ToDoListv2.Controller
{
    class TaskRenderer : BaseRenderer
    {
        public override void Render( System.Drawing.Graphics g, System.Drawing.Rectangle r )
        {
            Task nTask = (Task)this.RowObject;
            TimeSpan nSpan = DateTime.Today.Subtract( nTask.Deadline );
            Boolean nExpired = (int)nSpan.TotalDays > 0 ? true : false;
            Boolean nCompleted = nTask.Status == Task.STATUS_TYPES.COMPLETED ? true : false;

            if ( (int)nSpan.TotalDays > Constants.EXPIRE_DAYS )
            {
                g.Clear( this.ListView.BackColor );
                StringFormat fmt = this.StringFormatForGdiPlus;
                this.Font = new Font( this.Font.Name, this.Font.Size, FontStyle.Regular );
                g.DrawString( this.GetText(), this.Font, Brushes.Red, r, fmt );
            }
            else if ( (int)nSpan.TotalDays > 0 )
            {
                g.Clear( this.ListView.BackColor );
                StringFormat fmt = this.StringFormatForGdiPlus;
                g.DrawString( this.GetText(), this.Font, Brushes.Brown, r, fmt );
            }
            else if ( (int)nSpan.TotalDays == 0 ) // Today
            {
                g.Clear( this.ListView.BackColor );
                StringFormat fmt = this.StringFormatForGdiPlus;
                this.Font = new Font( this.Font.Name, this.Font.Size, FontStyle.Italic );
                g.DrawString( this.GetText(), this.Font, Brushes.Black, r, fmt );
            }
            else
            {
                g.Clear( this.ListView.BackColor );
                StringFormat fmt = this.StringFormatForGdiPlus;
                g.DrawString( this.GetText(), this.Font, Brushes.DarkSlateBlue, r, fmt );
                //base.Render( g, r );
            }

            if ( nCompleted )
            {
                g.DrawLine( Pens.Red, new Point( r.Left, r.Height / 2 + r.Top ), new Point( r.Right, r.Height / 2 + r.Top ) );
            }
        }
    }
}
