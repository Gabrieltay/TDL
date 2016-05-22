using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ToDoListv2.View
{
    public partial class CalendarForm : Form
    {
        public CalendarForm( DateTime aDate )
        {
            InitializeComponent();
            this.monthCalendar1.SetDate( aDate );
        }

        public DateTime GetSelectedDate()
        {
            return this.monthCalendar1.SelectionStart;
        }

        private void monthCalendar1_DateSelected( object sender, DateRangeEventArgs e )
        {
            this.Close();
        }
    }
}
