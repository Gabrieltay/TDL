using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ToDoListv2.Model;

namespace ToDoListv2.View
{
    public partial class TaskForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute( "user32.dll" )]
        public static extern int SendMessage( IntPtr hWnd,
            int Msg, int wParam, int lParam );

        [DllImportAttribute( "user32.dll" )]
        public static extern bool ReleaseCapture();

        public TaskForm()
        {
            InitializeComponent();
            this.TaskEntered = new Task();
            this.textBox1.Text = this.TaskEntered.TaskName;
            this.deadlineLabel.Text = this.TaskEntered.Deadline.ToLongDateString();
            SetPriority( this.TaskEntered.Priority );
        }

        public TaskForm( Task aTask )
        {
            InitializeComponent();
            this.TaskEntered = aTask;
            this.textBox1.Text = this.TaskEntered.TaskName;
            this.deadlineLabel.Text = this.TaskEntered.Deadline.ToLongDateString();
            SetPriority( this.TaskEntered.Priority );
        }

        private void SetPriority( int aSel )
        {
            if ( aSel == 0 )
            {
                button1.ImageKey = "untick";
                button2.ImageKey = "untick";
                button3.ImageKey = "untick";
            }

            if ( aSel == 1 )
            {
                button1.ImageKey = "tick";
                button2.ImageKey = "untick";
                button3.ImageKey = "untick";
            }

            if ( aSel == 2 )
            {
                button1.ImageKey = "tick";
                button2.ImageKey = "tick";
                button3.ImageKey = "untick";
            }

            if ( aSel == 3 )
            {
                button1.ImageKey = "tick";
                button2.ImageKey = "tick";
                button3.ImageKey = "tick";
            }
            this.textBox1.Focus();
            this.textBox1.SelectionStart = this.textBox1.Text.Length;
        }

        private int GetPriority()
        {
            if ( button3.ImageKey == "tick" )
                return 3;
            if ( button2.ImageKey == "tick" )
                return 2;
            if ( button1.ImageKey == "tick" )
                return 1;
            return 0;
        }  

        #region Properties
        public Task TaskEntered
        {
            get;
            set;
        }
        #endregion

        #region UI Event Handlers
        private void button1_Click( object sender, EventArgs e )
        {
            if ( GetPriority() == 1 )
            {
                SetPriority( 0 );
            }
            else
            {
                SetPriority( 1 );
            }
        }

        private void button2_Click( object sender, EventArgs e )
        {
            SetPriority( 2 );
        }

        private void button3_Click( object sender, EventArgs e )
        {
            SetPriority( 3 );
        }

        private void textBox1_KeyDown( object sender, KeyEventArgs e )
        {
            if ( e.Alt & (e.KeyValue >= '0' && e.KeyValue <= '3') )
            {
                SetPriority( Int16.Parse( ((char)(e.KeyValue)).ToString() ) );
            }
        }

        private void textBox1_KeyPress( object sender, KeyPressEventArgs e )
        {
            if ( e.KeyChar == '\r' )
            {
                if ( this.textBox1.Text.Trim().Length > 0 )
                {
                    TaskEntered.TaskName = this.textBox1.Text;
                    TaskEntered.Deadline = DateTime.Parse( this.deadlineLabel.Text );
                    TaskEntered.Priority = GetPriority();
                    this.DialogResult = DialogResult.OK;
                }
                else
                    this.DialogResult = DialogResult.Cancel;
            }
            else if ( e.KeyChar == 27 )
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void calPicBox_Click( object sender, EventArgs e )
        {
            CalendarForm cal = new CalendarForm( DateTime.Today );
            cal.StartPosition = FormStartPosition.Manual;
            cal.Location = Cursor.Position;
            cal.ShowDialog( this );
            this.deadlineLabel.Text = cal.GetSelectedDate().ToLongDateString();
        }

        private void TaskForm_MouseDown( object sender, MouseEventArgs e )
        {
            if ( e.Button == MouseButtons.Left )
            {
                ReleaseCapture();
                SendMessage( Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0 );
            }
        }
    
        #endregion

         

    }
}
