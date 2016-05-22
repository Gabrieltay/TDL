namespace ToDoListv2.View
{
    partial class ToDoListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( ToDoListForm ) );
            this.listviewContext = new System.Windows.Forms.ContextMenuStrip( this.components );
            this.displayPriorityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayGroupiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList( this.components );
            this.menuButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip( this.components );
            this.loadStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonImageList = new System.Windows.Forms.ImageList( this.components );
            this.trashButton = new System.Windows.Forms.Button();
            this.purgeContextMenuStrip = new System.Windows.Forms.ContextMenuStrip( this.components );
            this.expiredToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearCompletedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearBothItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.taskEntryTxtbox = new System.Windows.Forms.TextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.eventTimer = new System.Windows.Forms.Timer( this.components );
            this.dropboxButton = new System.Windows.Forms.Button();
            this.shortTimer = new System.Windows.Forms.Timer( this.components );
            this.syncTimer = new System.Windows.Forms.Timer( this.components );
            this.objectListView1 = new ToDoListv2.View.MyObjectListView();
            this.StatusColumn = new BrightIdeasSoftware.OLVColumn();
            this.checkColumnRenderer = new ToDoListv2.Controller.CheckColumnRender();
            this.TaskColumn = new BrightIdeasSoftware.OLVColumn();
            this.strikeRenderer = new ToDoListv2.Controller.TaskRenderer();
            this.DeadlineColumn = new BrightIdeasSoftware.OLVColumn();
            this.PriorityColumn = new BrightIdeasSoftware.OLVColumn();
            this.priorityColumnRenderer = new ToDoListv2.Controller.PriorityColumnRender();
            this.listviewContext.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.purgeContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).BeginInit();
            this.SuspendLayout();
            // 
            // listviewContext
            // 
            this.listviewContext.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.displayPriorityToolStripMenuItem,
            this.displayGroupiToolStripMenuItem,
            this.toolStripSeparator3,
            this.deleteToolStripMenuItem} );
            this.listviewContext.Name = "listviewContext";
            this.listviewContext.Size = new System.Drawing.Size( 154, 76 );
            this.listviewContext.MouseEnter += new System.EventHandler( this.listviewContext_MouseEnter );
            // 
            // displayPriorityToolStripMenuItem
            // 
            this.displayPriorityToolStripMenuItem.Checked = true;
            this.displayPriorityToolStripMenuItem.CheckOnClick = true;
            this.displayPriorityToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.displayPriorityToolStripMenuItem.Name = "displayPriorityToolStripMenuItem";
            this.displayPriorityToolStripMenuItem.Size = new System.Drawing.Size( 153, 22 );
            this.displayPriorityToolStripMenuItem.Text = "Display Priority";
            this.displayPriorityToolStripMenuItem.CheckedChanged += new System.EventHandler( this.displayPriorityToolStripMenuItem_CheckedChanged );
            // 
            // displayGroupiToolStripMenuItem
            // 
            this.displayGroupiToolStripMenuItem.Checked = true;
            this.displayGroupiToolStripMenuItem.CheckOnClick = true;
            this.displayGroupiToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.displayGroupiToolStripMenuItem.Name = "displayGroupiToolStripMenuItem";
            this.displayGroupiToolStripMenuItem.Size = new System.Drawing.Size( 153, 22 );
            this.displayGroupiToolStripMenuItem.Text = "Display Groups";
            this.displayGroupiToolStripMenuItem.CheckedChanged += new System.EventHandler( this.displayGroupiToolStripMenuItem_CheckedChanged );
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size( 150, 6 );
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size( 153, 22 );
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler( this.deleteToolStripMenuItem_Click );
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject( "imageList1.ImageStream" )));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName( 0, "checked" );
            this.imageList1.Images.SetKeyName( 1, "unchecked" );
            this.imageList1.Images.SetKeyName( 2, "tick" );
            this.imageList1.Images.SetKeyName( 3, "untick" );
            // 
            // menuButton
            // 
            this.menuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.menuButton.BackColor = System.Drawing.Color.Transparent;
            this.menuButton.ContextMenuStrip = this.contextMenuStrip1;
            this.menuButton.FlatAppearance.BorderSize = 0;
            this.menuButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.menuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.ImageKey = "more";
            this.menuButton.ImageList = this.buttonImageList;
            this.menuButton.Location = new System.Drawing.Point( 437, 496 );
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size( 23, 23 );
            this.menuButton.TabIndex = 1;
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.MouseMove += new System.Windows.Forms.MouseEventHandler( this.menuButton_MouseMove );
            this.menuButton.Click += new System.EventHandler( this.menuButton_Click );
            this.menuButton.MouseDown += new System.Windows.Forms.MouseEventHandler( this.menuButton_MouseDown );
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.contextMenuStrip1.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.loadStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitStripMenuItem} );
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size( 115, 76 );
            // 
            // loadStripMenuItem
            // 
            this.loadStripMenuItem.Name = "loadStripMenuItem";
            this.loadStripMenuItem.Size = new System.Drawing.Size( 114, 22 );
            this.loadStripMenuItem.Text = "Load";
            this.loadStripMenuItem.Click += new System.EventHandler( this.loadStripMenuItem_Click );
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size( 114, 22 );
            this.saveToolStripMenuItem.Text = "Save As";
            this.saveToolStripMenuItem.Click += new System.EventHandler( this.saveToolStripMenuItem_Click );
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size( 111, 6 );
            // 
            // exitStripMenuItem
            // 
            this.exitStripMenuItem.Name = "exitStripMenuItem";
            this.exitStripMenuItem.Size = new System.Drawing.Size( 114, 22 );
            this.exitStripMenuItem.Text = "Exit";
            this.exitStripMenuItem.Click += new System.EventHandler( this.exitStripMenuItem_Click );
            // 
            // buttonImageList
            // 
            this.buttonImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject( "buttonImageList.ImageStream" )));
            this.buttonImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.buttonImageList.Images.SetKeyName( 0, "more" );
            this.buttonImageList.Images.SetKeyName( 1, "bin" );
            this.buttonImageList.Images.SetKeyName( 2, "add" );
            this.buttonImageList.Images.SetKeyName( 3, "offline" );
            this.buttonImageList.Images.SetKeyName( 4, "online" );
            this.buttonImageList.Images.SetKeyName( 5, "cloud_download" );
            this.buttonImageList.Images.SetKeyName( 6, "cloud_upload" );
            this.buttonImageList.Images.SetKeyName( 7, "cloud_offline" );
            this.buttonImageList.Images.SetKeyName( 8, "cloud_cross.png" );
            this.buttonImageList.Images.SetKeyName( 9, "cloud_down.png" );
            this.buttonImageList.Images.SetKeyName( 10, "cloud_online" );
            this.buttonImageList.Images.SetKeyName( 11, "cloud_up.png" );
            // 
            // trashButton
            // 
            this.trashButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.trashButton.BackColor = System.Drawing.Color.Transparent;
            this.trashButton.ContextMenuStrip = this.purgeContextMenuStrip;
            this.trashButton.FlatAppearance.BorderSize = 0;
            this.trashButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.trashButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.trashButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trashButton.ImageKey = "bin";
            this.trashButton.ImageList = this.buttonImageList;
            this.trashButton.Location = new System.Drawing.Point( 407, 496 );
            this.trashButton.Name = "trashButton";
            this.trashButton.Size = new System.Drawing.Size( 23, 23 );
            this.trashButton.TabIndex = 2;
            this.trashButton.UseVisualStyleBackColor = false;
            this.trashButton.MouseMove += new System.Windows.Forms.MouseEventHandler( this.trashButton_MouseMove );
            this.trashButton.Click += new System.EventHandler( this.trashButton_Click );
            // 
            // purgeContextMenuStrip
            // 
            this.purgeContextMenuStrip.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.expiredToolStripMenuItem,
            this.clearCompletedToolStripMenuItem,
            this.ClearBothItem,
            this.toolStripSeparator1,
            this.clearAllToolStripMenuItem} );
            this.purgeContextMenuStrip.Name = "purgeContextMenuStrip";
            this.purgeContextMenuStrip.Size = new System.Drawing.Size( 228, 98 );
            // 
            // expiredToolStripMenuItem
            // 
            this.expiredToolStripMenuItem.Name = "expiredToolStripMenuItem";
            this.expiredToolStripMenuItem.Size = new System.Drawing.Size( 227, 22 );
            this.expiredToolStripMenuItem.Text = "Clear Expired";
            this.expiredToolStripMenuItem.Click += new System.EventHandler( this.expiredToolStripMenuItem_Click );
            // 
            // clearCompletedToolStripMenuItem
            // 
            this.clearCompletedToolStripMenuItem.Name = "clearCompletedToolStripMenuItem";
            this.clearCompletedToolStripMenuItem.Size = new System.Drawing.Size( 227, 22 );
            this.clearCompletedToolStripMenuItem.Text = "Clear Completed";
            this.clearCompletedToolStripMenuItem.Click += new System.EventHandler( this.clearCompletedToolStripMenuItem_Click );
            // 
            // ClearBothItem
            // 
            this.ClearBothItem.Name = "ClearBothItem";
            this.ClearBothItem.Size = new System.Drawing.Size( 227, 22 );
            this.ClearBothItem.Text = "Clear Expired and Completed";
            this.ClearBothItem.Click += new System.EventHandler( this.ClearBothItem_Click );
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size( 224, 6 );
            // 
            // clearAllToolStripMenuItem
            // 
            this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            this.clearAllToolStripMenuItem.Size = new System.Drawing.Size( 227, 22 );
            this.clearAllToolStripMenuItem.Text = "Clear All";
            this.clearAllToolStripMenuItem.Click += new System.EventHandler( this.clearAllToolStripMenuItem_Click );
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.BackColor = System.Drawing.Color.Transparent;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.addButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.ImageKey = "add";
            this.addButton.ImageList = this.buttonImageList;
            this.addButton.Location = new System.Drawing.Point( 377, 496 );
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size( 23, 23 );
            this.addButton.TabIndex = 3;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.MouseMove += new System.Windows.Forms.MouseEventHandler( this.addButton_MouseMove );
            this.addButton.Click += new System.EventHandler( this.addButton_Click );
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font( "Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)) );
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point( 13, 8 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 190, 22 );
            this.label1.TabIndex = 4;
            this.label1.Text = "MY TASK LIST v1.10";
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler( this.label1_MouseMove );
            // 
            // taskEntryTxtbox
            // 
            this.taskEntryTxtbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.taskEntryTxtbox.BackColor = System.Drawing.Color.FromArgb( ((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))) );
            this.taskEntryTxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.taskEntryTxtbox.Font = new System.Drawing.Font( "Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)) );
            this.taskEntryTxtbox.Location = new System.Drawing.Point( 13, 498 );
            this.taskEntryTxtbox.Name = "taskEntryTxtbox";
            this.taskEntryTxtbox.Size = new System.Drawing.Size( 358, 15 );
            this.taskEntryTxtbox.TabIndex = 5;
            this.taskEntryTxtbox.Visible = false;
            this.taskEntryTxtbox.MouseMove += new System.Windows.Forms.MouseEventHandler( this.taskEntryTxtbox_MouseMove );
            this.taskEntryTxtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler( this.taskEntryTxtbox_KeyPress );
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "tdl";
            this.saveFileDialog.Filter = "\"tdl files (*.tdl)|*.tdl|All files (*.*)|*.*\"";
            this.saveFileDialog.RestoreDirectory = true;
            // 
            // dropboxButton
            // 
            this.dropboxButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dropboxButton.BackColor = System.Drawing.Color.Transparent;
            this.dropboxButton.ContextMenuStrip = this.purgeContextMenuStrip;
            this.dropboxButton.FlatAppearance.BorderSize = 0;
            this.dropboxButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.dropboxButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.dropboxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropboxButton.ImageKey = "cloud_offline";
            this.dropboxButton.ImageList = this.buttonImageList;
            this.dropboxButton.Location = new System.Drawing.Point( 433, 5 );
            this.dropboxButton.Name = "dropboxButton";
            this.dropboxButton.Size = new System.Drawing.Size( 23, 23 );
            this.dropboxButton.TabIndex = 6;
            this.dropboxButton.UseVisualStyleBackColor = false;
            this.dropboxButton.Click += new System.EventHandler( this.dropboxButton_Click );
            this.dropboxButton.MouseEnter += new System.EventHandler( this.dropboxButton_MouseEnter );
            // 
            // objectListView1
            // 
            this.objectListView1.AllColumns.Add( this.StatusColumn );
            this.objectListView1.AllColumns.Add( this.TaskColumn );
            this.objectListView1.AllColumns.Add( this.DeadlineColumn );
            this.objectListView1.AllColumns.Add( this.PriorityColumn );
            this.objectListView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.objectListView1.BackColor = System.Drawing.Color.White;
            this.objectListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.objectListView1.CheckedAspectName = "IsActive";
            this.objectListView1.Columns.AddRange( new System.Windows.Forms.ColumnHeader[] {
            this.StatusColumn,
            this.TaskColumn,
            this.DeadlineColumn,
            this.PriorityColumn} );
            this.objectListView1.ContextMenuStrip = this.listviewContext;
            this.objectListView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView1.Font = new System.Drawing.Font( "Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)) );
            this.objectListView1.FullRowSelect = true;
            this.objectListView1.GroupWithItemCountFormat = "";
            this.objectListView1.GroupWithItemCountSingularFormat = "";
            this.objectListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.objectListView1.Location = new System.Drawing.Point( 13, 35 );
            this.objectListView1.Name = "objectListView1";
            this.objectListView1.OwnerDraw = true;
            this.objectListView1.ShowItemCountOnGroups = true;
            this.objectListView1.ShowItemToolTips = true;
            this.objectListView1.Size = new System.Drawing.Size( 441, 455 );
            this.objectListView1.SmallImageList = this.imageList1;
            this.objectListView1.TabIndex = 0;
            this.objectListView1.Text = "MyObjectListView";
            this.objectListView1.UseCompatibleStateImageBehavior = false;
            this.objectListView1.UseHotItem = true;
            this.objectListView1.UseTranslucentSelection = true;
            this.objectListView1.View = System.Windows.Forms.View.Details;
            this.objectListView1.MouseMove += new System.Windows.Forms.MouseEventHandler( this.objectListView1_MouseMove );
            this.objectListView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler( this.objectListView1_KeyPress );
            this.objectListView1.CellClick += new System.EventHandler<BrightIdeasSoftware.CellClickEventArgs>( this.objectListView1_CellClick );
            this.objectListView1.DoubleClick += new System.EventHandler( this.objectListView1_DoubleClick );
            this.objectListView1.GroupStateChanged += new System.EventHandler<BrightIdeasSoftware.GroupStateChangedEventArgs>( this.objectListView1_GroupStateChanged );
            // 
            // StatusColumn
            // 
            this.StatusColumn.AspectName = "";
            this.StatusColumn.CellPadding = null;
            this.StatusColumn.GroupWithItemCountFormat = "{0} ({1} Tasks)";
            this.StatusColumn.GroupWithItemCountSingularFormat = "{0} (Only {1} Task)";
            this.StatusColumn.IsEditable = false;
            this.StatusColumn.Renderer = this.checkColumnRenderer;
            this.StatusColumn.Text = "";
            this.StatusColumn.Width = 25;
            // 
            // TaskColumn
            // 
            this.TaskColumn.AspectName = "TaskName";
            this.TaskColumn.CellPadding = null;
            this.TaskColumn.Renderer = this.strikeRenderer;
            this.TaskColumn.Text = "Task";
            this.TaskColumn.Width = 250;
            // 
            // DeadlineColumn
            // 
            this.DeadlineColumn.AspectName = "Deadline";
            this.DeadlineColumn.CellPadding = null;
            this.DeadlineColumn.Renderer = this.strikeRenderer;
            this.DeadlineColumn.Text = "Deadline";
            this.DeadlineColumn.Width = 100;
            // 
            // PriorityColumn
            // 
            this.PriorityColumn.AspectName = "Priority";
            this.PriorityColumn.CellPadding = null;
            this.PriorityColumn.Renderer = this.priorityColumnRenderer;
            this.PriorityColumn.Text = "Priority";
            // 
            // ToDoListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size( 466, 525 );
            this.ContextMenuStrip = this.listviewContext;
            this.Controls.Add( this.taskEntryTxtbox );
            this.Controls.Add( this.label1 );
            this.Controls.Add( this.dropboxButton );
            this.Controls.Add( this.addButton );
            this.Controls.Add( this.trashButton );
            this.Controls.Add( this.menuButton );
            this.Controls.Add( this.objectListView1 );
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "ToDoListForm";
            this.Opacity = 0.8;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToDoListForm";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Violet;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler( this.ToDoListForm_MouseDown );
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler( this.ToDoListForm_KeyPress );
            this.MouseLeave += new System.EventHandler( this.ToDoListForm_MouseLeave );
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler( this.ToDoListForm_FormClosing );
            this.MouseMove += new System.Windows.Forms.MouseEventHandler( this.ToDoListForm_MouseMove );
            this.listviewContext.ResumeLayout( false );
            this.contextMenuStrip1.ResumeLayout( false );
            this.purgeContextMenuStrip.ResumeLayout( false );
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).EndInit();
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private MyObjectListView objectListView1;
        private BrightIdeasSoftware.OLVColumn TaskColumn;
        private System.Windows.Forms.ImageList imageList1;
        private BrightIdeasSoftware.OLVColumn StatusColumn;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Button trashButton;
        private System.Windows.Forms.Button addButton;
        private BrightIdeasSoftware.OLVColumn DeadlineColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitStripMenuItem;
        private System.Windows.Forms.ImageList buttonImageList;
        private System.Windows.Forms.TextBox taskEntryTxtbox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem loadStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ContextMenuStrip purgeContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem expiredToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearCompletedToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClearBothItem;
        private ToDoListv2.Controller.TaskRenderer strikeRenderer;
        private ToDoListv2.Controller.CheckColumnRender checkColumnRenderer;
        private BrightIdeasSoftware.OLVColumn PriorityColumn;
        private ToDoListv2.Controller.PriorityColumnRender priorityColumnRenderer;
        private System.Windows.Forms.Timer eventTimer;
        private System.Windows.Forms.Button dropboxButton;
        private System.Windows.Forms.Timer shortTimer;
        private System.Windows.Forms.Timer syncTimer;
        private System.Windows.Forms.ContextMenuStrip listviewContext;
        private System.Windows.Forms.ToolStripMenuItem displayPriorityToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayGroupiToolStripMenuItem;
    }
}