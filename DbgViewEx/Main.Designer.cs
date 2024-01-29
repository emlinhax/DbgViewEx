namespace DbgViewEx
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ETW_List = new System.Windows.Forms.ListView();
            this.ETW_COL_EventIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ETW_COL_EventName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ETW_COL_ProcessID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ETW_COL_Summary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TAB_CONTROL = new System.Windows.Forms.TabControl();
            this.TAB_CONTROL__ETW = new System.Windows.Forms.TabPage();
            this.ETW_RIB_Start = new System.Windows.Forms.Button();
            this.ETW_RIB_Filter = new System.Windows.Forms.Button();
            this.TAB_CONTROL__DBGLOG = new System.Windows.Forms.TabPage();
            this.ETW_RIB_Filter_TT = new System.Windows.Forms.ToolTip(this.components);
            this.ETW_ProcessTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TOOLBAR_Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.TOOLBAR_Settings_Refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.TOOLBAR_Settings_Refresh_0_5 = new System.Windows.Forms.ToolStripMenuItem();
            this.TOOLBAR_Settings_Refresh_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TOOLBAR_Settings_Refresh_5 = new System.Windows.Forms.ToolStripMenuItem();
            this.ETW_RIB_Stop = new System.Windows.Forms.Button();
            this.TAB_CONTROL.SuspendLayout();
            this.TAB_CONTROL__ETW.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ETW_List
            // 
            this.ETW_List.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ETW_List.AutoArrange = false;
            this.ETW_List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ETW_COL_EventIndex,
            this.ETW_COL_EventName,
            this.ETW_COL_ProcessID,
            this.ETW_COL_Summary});
            this.ETW_List.FullRowSelect = true;
            this.ETW_List.GridLines = true;
            this.ETW_List.HideSelection = false;
            this.ETW_List.Location = new System.Drawing.Point(6, 44);
            this.ETW_List.Name = "ETW_List";
            this.ETW_List.Size = new System.Drawing.Size(868, 345);
            this.ETW_List.TabIndex = 1;
            this.ETW_List.UseCompatibleStateImageBehavior = false;
            this.ETW_List.View = System.Windows.Forms.View.Details;
            // 
            // ETW_COL_EventIndex
            // 
            this.ETW_COL_EventIndex.Text = "ID";
            this.ETW_COL_EventIndex.Width = 72;
            // 
            // ETW_COL_EventName
            // 
            this.ETW_COL_EventName.Text = "Event";
            this.ETW_COL_EventName.Width = 300;
            // 
            // ETW_COL_ProcessID
            // 
            this.ETW_COL_ProcessID.Text = "Process ID";
            this.ETW_COL_ProcessID.Width = 77;
            // 
            // ETW_COL_Summary
            // 
            this.ETW_COL_Summary.Text = "Summary";
            this.ETW_COL_Summary.Width = 598;
            // 
            // TAB_CONTROL
            // 
            this.TAB_CONTROL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TAB_CONTROL.Controls.Add(this.TAB_CONTROL__ETW);
            this.TAB_CONTROL.Controls.Add(this.TAB_CONTROL__DBGLOG);
            this.TAB_CONTROL.Location = new System.Drawing.Point(12, 27);
            this.TAB_CONTROL.Name = "TAB_CONTROL";
            this.TAB_CONTROL.SelectedIndex = 0;
            this.TAB_CONTROL.Size = new System.Drawing.Size(888, 418);
            this.TAB_CONTROL.TabIndex = 2;
            // 
            // TAB_CONTROL__ETW
            // 
            this.TAB_CONTROL__ETW.Controls.Add(this.ETW_RIB_Stop);
            this.TAB_CONTROL__ETW.Controls.Add(this.ETW_RIB_Start);
            this.TAB_CONTROL__ETW.Controls.Add(this.ETW_RIB_Filter);
            this.TAB_CONTROL__ETW.Controls.Add(this.ETW_List);
            this.TAB_CONTROL__ETW.Location = new System.Drawing.Point(4, 22);
            this.TAB_CONTROL__ETW.Name = "TAB_CONTROL__ETW";
            this.TAB_CONTROL__ETW.Padding = new System.Windows.Forms.Padding(3);
            this.TAB_CONTROL__ETW.Size = new System.Drawing.Size(880, 392);
            this.TAB_CONTROL__ETW.TabIndex = 0;
            this.TAB_CONTROL__ETW.Text = "Event Tracing";
            this.TAB_CONTROL__ETW.UseVisualStyleBackColor = true;
            // 
            // ETW_RIB_Start
            // 
            this.ETW_RIB_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ETW_RIB_Start.ForeColor = System.Drawing.Color.Gray;
            this.ETW_RIB_Start.Image = ((System.Drawing.Image)(resources.GetObject("ETW_RIB_Start.Image")));
            this.ETW_RIB_Start.Location = new System.Drawing.Point(6, 5);
            this.ETW_RIB_Start.Margin = new System.Windows.Forms.Padding(0);
            this.ETW_RIB_Start.Name = "ETW_RIB_Start";
            this.ETW_RIB_Start.Size = new System.Drawing.Size(44, 35);
            this.ETW_RIB_Start.TabIndex = 4;
            this.ETW_RIB_Filter_TT.SetToolTip(this.ETW_RIB_Start, "Open Filter");
            this.ETW_RIB_Start.UseVisualStyleBackColor = true;
            this.ETW_RIB_Start.Click += new System.EventHandler(this.ETW_RIB_Start_Click);
            // 
            // ETW_RIB_Filter
            // 
            this.ETW_RIB_Filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ETW_RIB_Filter.ForeColor = System.Drawing.Color.Gray;
            this.ETW_RIB_Filter.Image = ((System.Drawing.Image)(resources.GetObject("ETW_RIB_Filter.Image")));
            this.ETW_RIB_Filter.Location = new System.Drawing.Point(102, 5);
            this.ETW_RIB_Filter.Margin = new System.Windows.Forms.Padding(0);
            this.ETW_RIB_Filter.Name = "ETW_RIB_Filter";
            this.ETW_RIB_Filter.Size = new System.Drawing.Size(44, 35);
            this.ETW_RIB_Filter.TabIndex = 3;
            this.ETW_RIB_Filter_TT.SetToolTip(this.ETW_RIB_Filter, "Open Filter");
            this.ETW_RIB_Filter.UseVisualStyleBackColor = true;
            this.ETW_RIB_Filter.Click += new System.EventHandler(this.ETW_RIB_Filter_Click);
            // 
            // TAB_CONTROL__DBGLOG
            // 
            this.TAB_CONTROL__DBGLOG.Location = new System.Drawing.Point(4, 22);
            this.TAB_CONTROL__DBGLOG.Name = "TAB_CONTROL__DBGLOG";
            this.TAB_CONTROL__DBGLOG.Padding = new System.Windows.Forms.Padding(3);
            this.TAB_CONTROL__DBGLOG.Size = new System.Drawing.Size(880, 392);
            this.TAB_CONTROL__DBGLOG.TabIndex = 1;
            this.TAB_CONTROL__DBGLOG.Text = "Debug Output/Log";
            this.TAB_CONTROL__DBGLOG.UseVisualStyleBackColor = true;
            // 
            // ETW_ProcessTimer
            // 
            this.ETW_ProcessTimer.Interval = 1000;
            this.ETW_ProcessTimer.Tick += new System.EventHandler(this.ETW_ProcessTimer_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.TOOLBAR_Settings});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(912, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // TOOLBAR_Settings
            // 
            this.TOOLBAR_Settings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TOOLBAR_Settings_Refresh});
            this.TOOLBAR_Settings.Name = "TOOLBAR_Settings";
            this.TOOLBAR_Settings.Size = new System.Drawing.Size(61, 20);
            this.TOOLBAR_Settings.Text = "Settings";
            // 
            // TOOLBAR_Settings_Refresh
            // 
            this.TOOLBAR_Settings_Refresh.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TOOLBAR_Settings_Refresh_0_5,
            this.TOOLBAR_Settings_Refresh_1,
            this.TOOLBAR_Settings_Refresh_5});
            this.TOOLBAR_Settings_Refresh.Name = "TOOLBAR_Settings_Refresh";
            this.TOOLBAR_Settings_Refresh.Size = new System.Drawing.Size(155, 22);
            this.TOOLBAR_Settings_Refresh.Text = "Refresh Interval";
            this.TOOLBAR_Settings_Refresh.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.TOOLBAR_Settings_Refresh_DropDownItemClicked);
            // 
            // TOOLBAR_Settings_Refresh_0_5
            // 
            this.TOOLBAR_Settings_Refresh_0_5.Checked = true;
            this.TOOLBAR_Settings_Refresh_0_5.CheckOnClick = true;
            this.TOOLBAR_Settings_Refresh_0_5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TOOLBAR_Settings_Refresh_0_5.Name = "TOOLBAR_Settings_Refresh_0_5";
            this.TOOLBAR_Settings_Refresh_0_5.Size = new System.Drawing.Size(94, 22);
            this.TOOLBAR_Settings_Refresh_0_5.Text = "0.5s";
            // 
            // TOOLBAR_Settings_Refresh_1
            // 
            this.TOOLBAR_Settings_Refresh_1.CheckOnClick = true;
            this.TOOLBAR_Settings_Refresh_1.Name = "TOOLBAR_Settings_Refresh_1";
            this.TOOLBAR_Settings_Refresh_1.Size = new System.Drawing.Size(94, 22);
            this.TOOLBAR_Settings_Refresh_1.Text = "1s";
            // 
            // TOOLBAR_Settings_Refresh_5
            // 
            this.TOOLBAR_Settings_Refresh_5.CheckOnClick = true;
            this.TOOLBAR_Settings_Refresh_5.Name = "TOOLBAR_Settings_Refresh_5";
            this.TOOLBAR_Settings_Refresh_5.Size = new System.Drawing.Size(94, 22);
            this.TOOLBAR_Settings_Refresh_5.Text = "5s";
            // 
            // ETW_RIB_Stop
            // 
            this.ETW_RIB_Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ETW_RIB_Stop.ForeColor = System.Drawing.Color.Gray;
            this.ETW_RIB_Stop.Image = ((System.Drawing.Image)(resources.GetObject("ETW_RIB_Stop.Image")));
            this.ETW_RIB_Stop.Location = new System.Drawing.Point(54, 5);
            this.ETW_RIB_Stop.Margin = new System.Windows.Forms.Padding(0);
            this.ETW_RIB_Stop.Name = "ETW_RIB_Stop";
            this.ETW_RIB_Stop.Size = new System.Drawing.Size(44, 35);
            this.ETW_RIB_Stop.TabIndex = 5;
            this.ETW_RIB_Filter_TT.SetToolTip(this.ETW_RIB_Stop, "Open Filter");
            this.ETW_RIB_Stop.UseVisualStyleBackColor = true;
            this.ETW_RIB_Stop.Click += new System.EventHandler(this.ETW_RIB_Stop_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 457);
            this.Controls.Add(this.TAB_CONTROL);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "DbgViewEx - @emlinhax";
            this.Load += new System.EventHandler(this.Main_Load);
            this.TAB_CONTROL.ResumeLayout(false);
            this.TAB_CONTROL__ETW.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ETW_List;
        private System.Windows.Forms.ColumnHeader ETW_COL_EventName;
        private System.Windows.Forms.ColumnHeader ETW_COL_EventIndex;
        private System.Windows.Forms.ColumnHeader ETW_COL_ProcessID;
        private System.Windows.Forms.TabControl TAB_CONTROL;
        private System.Windows.Forms.TabPage TAB_CONTROL__ETW;
        private System.Windows.Forms.Button ETW_RIB_Filter;
        private System.Windows.Forms.TabPage TAB_CONTROL__DBGLOG;
        private System.Windows.Forms.ToolTip ETW_RIB_Filter_TT;
        private System.Windows.Forms.Button ETW_RIB_Start;
        private System.Windows.Forms.ColumnHeader ETW_COL_Summary;
        private System.Windows.Forms.Timer ETW_ProcessTimer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TOOLBAR_Settings;
        private System.Windows.Forms.ToolStripMenuItem TOOLBAR_Settings_Refresh;
        private System.Windows.Forms.ToolStripMenuItem TOOLBAR_Settings_Refresh_0_5;
        private System.Windows.Forms.ToolStripMenuItem TOOLBAR_Settings_Refresh_1;
        private System.Windows.Forms.ToolStripMenuItem TOOLBAR_Settings_Refresh_5;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button ETW_RIB_Stop;
    }
}

