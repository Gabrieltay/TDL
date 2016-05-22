using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ToDoListv2.Model;
using ToDoListv2.Common;
using ToDoListv2.Controller;
using BrightIdeasSoftware;

namespace ToDoListv2.View
{
    public partial class ToDoListForm : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute( "user32.dll" )]
        public static extern int SendMessage( IntPtr hWnd,
            int Msg, int wParam, int lParam );

        [DllImportAttribute( "user32.dll" )]
        public static extern bool ReleaseCapture();

        private enum SYNC
        {
            DOWNLOAD,
            UPLOAD
        }

        public ToDoListForm()
        {
            InitializeComponent();
            InitializeColumns();
            InitializeHotItemStyle();
            InitializeSorting();
            InitializeTaskList();
            InitializeTimer();
            displayPriorityToolStripMenuItem.Checked = false;
        }

        #region Initializing
        private void InitializeColumns()
        {
            TypedObjectListView<Task> tlist = new TypedObjectListView<Task>( this.objectListView1 );
            tlist.GenerateAspectGetters();

            // Status Column (Checked Box)
            this.StatusColumn.GroupKeyGetter = delegate( object rowObject )
            {
                Task nTask = (Task)rowObject;
                return nTask.Status;
            };

            this.StatusColumn.GroupKeyToTitleConverter = delegate( object groupKey )
            {
                return ((Task.STATUS_TYPES)groupKey).ToString();
            };
            this.StatusColumn.ImageGetter = delegate( object rowObject )
            {
                Task nTask = (Task)rowObject;
                if ( nTask.Status == Task.STATUS_TYPES.COMPLETED )
                    return "checked";
                else
                    return "unchecked";
            };

            // Task Column (NIL)

            // Deadline Column
            this.DeadlineColumn.AspectToStringConverter = delegate( object aspect )
            {
                if ( Parameters.Deadline_P == Parameters.DEADLINE_DISPLAY.DATE )
                    return ((DateTime)aspect).Date.ToShortDateString();
                else
                {
                    TimeSpan nSpan = ((DateTime)aspect).Date.Subtract( DateTime.Today );
                    return nSpan.TotalDays.ToString() + " Days";
                }
            };

            // Priority Column
            this.PriorityColumn.Renderer = new PriorityColumnRender( "tick", 3, 0, 4 );
        }

        private void InitializeHotItemStyle()
        {
            HotItemStyle hotItemStyle = new HotItemStyle();
            RowBorderDecoration rbd = new RowBorderDecoration();
            rbd.BorderPen = new Pen( Color.CornflowerBlue, 2 );
            rbd.FillBrush = null;
            rbd.CornerRounding = 4.0f;
            hotItemStyle.Decoration = rbd;
            this.objectListView1.HotItemStyle = hotItemStyle;
        }

        private void InitializeTaskList()
        {
            LoadList( Constants.DEFAULT_FILE );
        }

        private void InitializeTimer()
        {
            eventTimer = new Timer();
            eventTimer.Tick += new EventHandler( AutoSaveProcess );
            eventTimer.Interval = Constants.AUTOSAVE_INTERVAL;
            eventTimer.Start();

            shortTimer = new Timer();
            shortTimer.Tick += new EventHandler( AnimationProcess );
            shortTimer.Interval = Constants.ANIMATION_INTERVAL;

            syncTimer = new Timer();
            syncTimer.Tick += new EventHandler( SyncProcess );
            syncTimer.Interval = Constants.SYNC_INTERVAL;
            syncTimer.Start();
        }

        private void InitializeSorting()
        {
            // Sorting
            if ( this.objectListView1.ShowGroups )
            {
                this.objectListView1.PrimarySortColumn = this.StatusColumn;
                this.objectListView1.SecondarySortColumn = this.DeadlineColumn;
                this.objectListView1.PrimarySortOrder = SortOrder.Descending;
                this.objectListView1.SecondarySortOrder = SortOrder.Ascending;
            }
            else
            {
                this.objectListView1.PrimarySortColumn = this.DeadlineColumn;
                this.objectListView1.SecondarySortColumn = this.TaskColumn;
                this.objectListView1.PrimarySortOrder = SortOrder.Ascending;
                this.objectListView1.SecondarySortOrder = SortOrder.Ascending;
            }
        }

        #endregion

        #region Helper Methods

        private bool EnterTask( KeyPressEventArgs e )
        {
            this.taskEntryTxtbox.Visible = true;
            this.taskEntryTxtbox.AppendText( e.KeyChar.ToString() );
            this.taskEntryTxtbox.Focus();
            this.taskEntryTxtbox.SelectionStart = this.taskEntryTxtbox.Text.Length;
            this.KeyPreview = false;
            return true;
        }

        private bool AddTask( Task aTask )
        {
            this.objectListView1.AddObject( aTask );
            this.taskEntryTxtbox.Clear();
            RefreshList();
            return true;
        }

        private bool DeleteTasks()
        {
            if ( this.objectListView1.SelectedObjects.Count > 0 )
            {
                this.objectListView1.RemoveObjects( this.objectListView1.SelectedObjects );
                RefreshList();
                return true;
            }
            return false;
        }

        private bool SaveList( String aFilename )
        {
            try
            {
                List<Task> nList = new List<Task>();
                if ( this.objectListView1.Items.Count > 0 )
                {
                    nList = this.objectListView1.Objects.OfType<Task>().ToList<Task>();
                }

                if ( File.Exists( aFilename ) )
                {
                    List<Task> oldList = DataManager.GetListFromFile<Task>( aFilename );
                    if ( !DataManager.CompareTwoLists<Task>( nList, oldList ) )
                        return DataManager.SaveListToFile<Task>( nList, aFilename );
                    else
                        return false;
                }
                return DataManager.SaveListToFile<Task>( nList, aFilename );
            }
            catch ( IOException )
            {
                return false;
            }
        }

        private void LoadList( String aFilename )
        {
            try
            {
                List<Task> nList = DataManager.GetListFromFile<Task>( aFilename );
                this.objectListView1.AddObjects( nList );
                RefreshList();
            }
            catch ( IOException )
            {
            }
        }

        private void ClearList()
        {
            this.objectListView1.ClearObjects();
        }

        private void RefreshList()
        {
            this.objectListView1.Sort();

            if ( this.CollapsedGroupKeys != null && this.objectListView1.ShowGroups )
            {
                foreach ( OLVGroup nGroup in this.objectListView1.OLVGroups )
                {
                    if ( this.CollapsedGroupKeys.Contains( nGroup.Key.ToString() ) )
                        nGroup.Collapsed = true;
                }
            }
            RedrawListView();
        }

        private void RedrawListView()
        {
            if ( this.objectListView1.Items.Count > 0 )
            {
                int nTotalCount = 1;
                if ( this.objectListView1.ShowGroups )
                    foreach ( OLVGroup nGroup in this.objectListView1.OLVGroups )
                    {
                        ++nTotalCount;
                        if ( !nGroup.Collapsed )
                            nTotalCount += nGroup.Items.Count;
                    }
                else
                    nTotalCount += this.objectListView1.Objects.OfType<Task>().Count();
                int totalHeight = nTotalCount * Constants.LISTVIEWITEM_HEIGHT;
                if ( totalHeight < Constants.LISTVIEW_HEIGHT )
                    this.objectListView1.Height = totalHeight;
                else
                    this.objectListView1.Height = Constants.LISTVIEW_HEIGHT;
            }
            else
            {
                this.objectListView1.Height = 0;
            }
            this.objectListView1.Invalidate();
        }

        private void SyncFile( FileInfo aSrcFile, FileInfo aDesFile, SYNC aSync )
        {
            if ( aSync == SYNC.DOWNLOAD )
            {
                shortTimer.Start();
                this.dropboxButton.ImageKey = "cloud_download";
                ClearList();
                LoadList( Constants.DEFAULT_FILE );
            }
            else
            {
                shortTimer.Start();
                this.dropboxButton.ImageKey = "cloud_upload";
            }
            File.Copy( aSrcFile.FullName, aDesFile.FullName, true );
        }

        private void GoTranslucent( Boolean aEnabled )
        {
            this.Opacity = aEnabled ? Constants.TRANSLUCENT / 2 : Constants.TRANSLUCENT;
        }
        #endregion

        #region Object List Event Handler
        private void objectListView1_CellClick( object sender, BrightIdeasSoftware.CellClickEventArgs e )
        {
            if ( e.ColumnIndex == 0 )
            {
                Task ntask = (Task)this.objectListView1.GetModelObject( e.RowIndex );
                if ( ntask.Status == Task.STATUS_TYPES.PENDING )
                    ntask.Status = Task.STATUS_TYPES.COMPLETED;
                else if ( ntask.Status == Task.STATUS_TYPES.COMPLETED )
                    ntask.Status = Task.STATUS_TYPES.PENDING;
                this.objectListView1.RefreshObject( ntask );
                RefreshList();
            }
        }

        private void objectListView1_DoubleClick( object sender, EventArgs e )
        {
            if ( this.objectListView1.SelectedItems.Count == 1 )
            {
                Task nTask = (Task)this.objectListView1.SelectedObject;
                TaskForm taskForm = new TaskForm( nTask );
                taskForm.StartPosition = FormStartPosition.CenterParent;
                taskForm.ShowDialog( this );
                this.objectListView1.RemoveObject( this.objectListView1.SelectedObject );
                AddTask( nTask );
            }
        }

        private void objectListView1_KeyPress( object sender, KeyPressEventArgs e )
        {
            EnterTask( e );
        }

        private void objectListView1_GroupStateChanged( object sender, GroupStateChangedEventArgs e )
        {
            this.CollapsedGroupKeys = new List<String>();
            foreach ( OLVGroup nGroup in this.objectListView1.OLVGroups )
            {
                if ( nGroup.Collapsed )
                    this.CollapsedGroupKeys.Add( nGroup.Key.ToString() );
            }
            RedrawListView();
        }
        #endregion

        #region Main Form Event Handler

        private void ToDoListForm_FormClosing( object sender, FormClosingEventArgs e )
        {
            SaveList( Constants.DEFAULT_FILE );
        }

        private void ToDoListForm_MouseDown( object sender, MouseEventArgs e )
        {
            if ( e.Button == MouseButtons.Left )
            {
                ReleaseCapture();
                SendMessage( Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0 );
            }
        }

        private void ToDoListForm_KeyPress( object sender, KeyPressEventArgs e )
        {
            EnterTask( e );
        }

        private void taskEntryTxtbox_KeyPress( object sender, KeyPressEventArgs e )
        {
            if ( e.KeyChar == '\r' )
            {
                this.taskEntryTxtbox.Visible = false;
                if ( this.taskEntryTxtbox.Text.Trim().Length > 0 )
                {
                    Task nTask = new Task( taskEntryTxtbox.Text, DateTime.Today,
                        Task.STATUS_TYPES.PENDING, 0 );
                    AddTask( nTask );
                }
                this.KeyPreview = true;
            }
        }

        #endregion

        #region Buttons Event Handler
        private void addButton_Click( object sender, EventArgs e )
        {
            TaskForm taskForm = new TaskForm( new Task( "", DateTime.Today,
                                                Task.STATUS_TYPES.PENDING, 0 ) );
            taskForm.StartPosition = FormStartPosition.CenterParent;
            taskForm.ShowDialog( this );
            if ( taskForm.DialogResult == DialogResult.OK )
            {
                AddTask( taskForm.TaskEntered );
            }
        }

        private void trashButton_Click( object sender, EventArgs e )
        {
            DeleteTasks();
        }

        private void menuButton_MouseDown( object sender, MouseEventArgs e )
        {
            if ( e.Button == MouseButtons.Right )
            {
                menuButton.ContextMenuStrip = null;
            }
            else
            {
                menuButton.ContextMenuStrip = this.contextMenuStrip1;
            }
        }

        private void dropboxButton_Click( object sender, EventArgs e )
        {
            Parameters.DropboxEnabled_P = Parameters.DropboxEnabled_P ? false : true;
            this.dropboxButton.ImageKey = Parameters.DropboxEnabled_P ? "cloud_online" : "cloud_offline";
        }

        private void menuButton_Click( object sender, EventArgs e )
        {
            menuButton.ContextMenuStrip.Show( menuButton, menuButton.Width, 0 );
        }
        #endregion

        #region  Menu Context Strip Event Handler
        private void saveToolStripMenuItem_Click( object sender, EventArgs e )
        {
            DialogResult nResult = this.saveFileDialog.ShowDialog();
            if ( nResult == DialogResult.OK )
            {
                if ( SaveList( this.saveFileDialog.FileName ) )
                    MessageBox.Show( "List Saved" );
            }
        }

        private void loadStripMenuItem_Click( object sender, EventArgs e )
        {
            this.openFileDialog.FileName = Constants.DEFAULT_FILE;
            DialogResult nResult = this.openFileDialog.ShowDialog();
            if ( nResult == DialogResult.OK )
            {
                LoadList( this.openFileDialog.FileName );
            }
        }

        private void exitStripMenuItem_Click( object sender, EventArgs e )
        {
            this.Close();
        }
        #endregion

        #region Clear Context Strip Event Handler
        private void clearAllToolStripMenuItem_Click( object sender, EventArgs e )
        {
            this.objectListView1.ClearObjects();
            RefreshList();
        }

        private void clearCompletedToolStripMenuItem_Click( object sender, EventArgs e )
        {
            if ( this.objectListView1.Items.Count > 0 )
            {
                List<Task> nList = this.objectListView1.Objects.OfType<Task>().ToList<Task>();
                foreach ( Task nTask in nList )
                {
                    if ( nTask.Status == Task.STATUS_TYPES.COMPLETED )
                        this.objectListView1.RemoveObject( nTask );
                }
                RefreshList();
            }
        }

        private void expiredToolStripMenuItem_Click( object sender, EventArgs e )
        {
            if ( this.objectListView1.Items.Count > 0 )
            {
                List<Task> nList = this.objectListView1.Objects.OfType<Task>().ToList<Task>();
                foreach ( Task nTask in nList )
                {
                    TimeSpan span = DateTime.Today.Subtract( nTask.Deadline );
                    if ( (int)span.TotalDays > Constants.EXPIRE_DAYS )
                        this.objectListView1.RemoveObject( nTask );
                }
                RefreshList();
            }
        }

        private void ClearBothItem_Click( object sender, EventArgs e )
        {
            if ( this.objectListView1.Items.Count > 0 )
            {
                List<Task> nList = this.objectListView1.Objects.OfType<Task>().ToList<Task>();
                foreach ( Task nTask in nList )
                {
                    TimeSpan span = DateTime.Today.Subtract( nTask.Deadline );
                    if ( (int)span.TotalDays > Constants.EXPIRE_DAYS )
                        if ( nTask.Status == Task.STATUS_TYPES.COMPLETED )
                            this.objectListView1.RemoveObject( nTask );
                }
                RefreshList();
            }
        }
        #endregion

        #region LV Context Strip Event Handler
        private void displayPriorityToolStripMenuItem_CheckedChanged( object sender, EventArgs e )
        {
            if ( displayPriorityToolStripMenuItem.Checked )
            {
                Parameters.Display_Prior_P = true;
                this.PriorityColumn.Width = Constants.PRIORITY_COLUMN_WIDTH;
                this.Width += Constants.PRIORITY_COLUMN_WIDTH;
            }
            else
            {
                Parameters.Display_Prior_P = false;
                this.PriorityColumn.Width = 0;
                this.Width -= Constants.PRIORITY_COLUMN_WIDTH;
            }
        }

        private void displayGroupiToolStripMenuItem_CheckedChanged( object sender, EventArgs e )
        {
            this.objectListView1.ShowGroups = this.displayGroupiToolStripMenuItem.Checked;
            InitializeSorting();
            RefreshList();
        }

        private void deleteToolStripMenuItem_Click( object sender, EventArgs e )
        {
            DeleteTasks();
        }
        #endregion

        #region Opacity Control Events Handler
        private void ToDoListForm_MouseMove( object sender, MouseEventArgs e )
        {
            GoTranslucent( false );
        }

        private void label1_MouseMove( object sender, MouseEventArgs e )
        {
            GoTranslucent( false );
        }

        private void objectListView1_MouseMove( object sender, MouseEventArgs e )
        {
            GoTranslucent( false );
        }

        private void taskEntryTxtbox_MouseMove( object sender, MouseEventArgs e )
        {
            GoTranslucent( false );
        }

        private void addButton_MouseMove( object sender, MouseEventArgs e )
        {
            GoTranslucent( false );
        }

        private void trashButton_MouseMove( object sender, MouseEventArgs e )
        {
            GoTranslucent( false );
        }

        private void menuButton_MouseMove( object sender, MouseEventArgs e )
        {
            GoTranslucent( false );
        }

        private void dropboxButton_MouseEnter( object sender, EventArgs e )
        {
            GoTranslucent( false );
        }

        private void ToDoListForm_MouseLeave( object sender, EventArgs e )
        {
            GoTranslucent( true );
        }

        private void listviewContext_MouseEnter( object sender, EventArgs e )
        {
            GoTranslucent( false );
        }
        #endregion

        #region Timer Processes
        private void AutoSaveProcess( object sender, EventArgs e )
        {
            SaveList( Constants.DEFAULT_FILE );
        }

        private void SyncProcess( object sender, EventArgs e )
        {
            if ( Parameters.DropboxEnabled_P )
            {
                if ( Directory.Exists( Parameters.DropboxDir_P ) )
                {
                    FileInfo nSyncFile = new FileInfo( Parameters.DropboxDir_P + Constants.DEFAULT_FILE );
                    FileInfo nCurFile = new FileInfo( Constants.DEFAULT_FILE );
                    if ( File.Exists( Parameters.DropboxDir_P + Constants.DEFAULT_FILE ) )
                    {
                        if ( nCurFile.LastWriteTime.ToFileTime() > nSyncFile.LastWriteTime.ToFileTime() )
                        {
                            SyncFile( nCurFile, nSyncFile, SYNC.UPLOAD );
                        }
                        else if ( nCurFile.LastWriteTime.ToFileTime() < nSyncFile.LastWriteTime.ToFileTime() )
                        {
                            DialogResult r = MessageBox.Show( " Remote File is Newer, Update Current?", "Warning", MessageBoxButtons.YesNo );
                            if ( r == DialogResult.Yes )
                            {
                                SyncFile( nSyncFile, nCurFile, SYNC.DOWNLOAD );

                            }
                            else
                                SyncFile( nCurFile, nSyncFile, SYNC.UPLOAD );
                        }
                    }
                    else
                    {
                        SyncFile( nCurFile, nSyncFile, SYNC.UPLOAD );
                    }
                }
            }
        }

        private void AnimationProcess( object sender, EventArgs e )
        {
            this.dropboxButton.ImageKey = Parameters.DropboxEnabled_P ? "cloud_online" : "cloud_offline";
            shortTimer.Stop();
        }
        #endregion

        #region Properties
        private List<String> CollapsedGroupKeys
        {
            get;
            set;
        }
        #endregion

        private void objectListView1_GroupExpandingCollapsing( object sender, GroupExpandingCollapsingEventArgs e )
        {

        }


    }

}
