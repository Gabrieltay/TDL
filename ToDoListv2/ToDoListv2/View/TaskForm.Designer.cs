namespace ToDoListv2.View
{
    partial class TaskForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( TaskForm ) );
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.TaskImageList = new System.Windows.Forms.ImageList( this.components );
            this.calPicBox = new System.Windows.Forms.PictureBox();
            this.deadlineLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.calPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font( "Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)) );
            this.label1.Location = new System.Drawing.Point( 6, 16 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 52, 13 );
            this.label1.TabIndex = 1;
            this.label1.Text = "Task:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font( "Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)) );
            this.textBox1.Location = new System.Drawing.Point( 9, 33 );
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size( 292, 19 );
            this.textBox1.TabIndex = 2;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler( this.textBox1_KeyDown );
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler( this.textBox1_KeyPress );
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ImageKey = "gtk_close.png";
            this.closeButton.ImageList = this.TaskImageList;
            this.closeButton.Location = new System.Drawing.Point( 287, 7 );
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size( 15, 15 );
            this.closeButton.TabIndex = 3;
            this.closeButton.UseVisualStyleBackColor = false;
            // 
            // TaskImageList
            // 
            this.TaskImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject( "TaskImageList.ImageStream" )));
            this.TaskImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.TaskImageList.Images.SetKeyName( 0, "gtk_close.png" );
            this.TaskImageList.Images.SetKeyName( 1, "calendar_1.png" );
            this.TaskImageList.Images.SetKeyName( 2, "tick" );
            this.TaskImageList.Images.SetKeyName( 3, "untick" );
            // 
            // calPicBox
            // 
            this.calPicBox.Image = ((System.Drawing.Image)(resources.GetObject( "calPicBox.Image" )));
            this.calPicBox.Location = new System.Drawing.Point( 9, 59 );
            this.calPicBox.Name = "calPicBox";
            this.calPicBox.Size = new System.Drawing.Size( 26, 26 );
            this.calPicBox.TabIndex = 4;
            this.calPicBox.TabStop = false;
            this.calPicBox.Click += new System.EventHandler( this.calPicBox_Click );
            // 
            // deadlineLabel
            // 
            this.deadlineLabel.AutoSize = true;
            this.deadlineLabel.Font = new System.Drawing.Font( "Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)) );
            this.deadlineLabel.Location = new System.Drawing.Point( 48, 67 );
            this.deadlineLabel.Name = "deadlineLabel";
            this.deadlineLabel.Size = new System.Drawing.Size( 71, 13 );
            this.deadlineLabel.TabIndex = 6;
            this.deadlineLabel.Text = "Deadline";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ImageKey = "tick";
            this.button1.ImageList = this.TaskImageList;
            this.button1.Location = new System.Drawing.Point( 60, 7 );
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size( 27, 23 );
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler( this.button1_Click );
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ImageKey = "tick";
            this.button2.ImageList = this.TaskImageList;
            this.button2.Location = new System.Drawing.Point( 90, 7 );
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size( 27, 23 );
            this.button2.TabIndex = 9;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler( this.button2_Click );
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ImageKey = "tick";
            this.button3.ImageList = this.TaskImageList;
            this.button3.Location = new System.Drawing.Point( 120, 7 );
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size( 27, 23 );
            this.button3.TabIndex = 10;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler( this.button3_Click );
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size( 310, 103 );
            this.Controls.Add( this.button3 );
            this.Controls.Add( this.button2 );
            this.Controls.Add( this.button1 );
            this.Controls.Add( this.deadlineLabel );
            this.Controls.Add( this.calPicBox );
            this.Controls.Add( this.closeButton );
            this.Controls.Add( this.textBox1 );
            this.Controls.Add( this.label1 );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TaskForm";
            this.Text = "Task";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler( this.TaskForm_MouseDown );
            ((System.ComponentModel.ISupportInitialize)(this.calPicBox)).EndInit();
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ImageList TaskImageList;
        private System.Windows.Forms.PictureBox calPicBox;
        private System.Windows.Forms.Label deadlineLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}