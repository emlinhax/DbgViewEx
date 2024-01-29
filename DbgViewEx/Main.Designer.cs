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
            this.TAB_CONTROL = new System.Windows.Forms.TabControl();
            this.TAB_CONTROL__ETW = new System.Windows.Forms.TabPage();
            this.TAB_CONTROL__DBGLOG = new System.Windows.Forms.TabPage();
            this.ETW_RIB_Filter_TT = new System.Windows.Forms.ToolTip(this.components);
            this.ETW_RIB_Filter = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ETW_COL_Summary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TAB_CONTROL.SuspendLayout();
            this.TAB_CONTROL__ETW.SuspendLayout();
            this.SuspendLayout();
            // 
            // ETW_List
            // 
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
            this.ETW_List.Size = new System.Drawing.Size(868, 360);
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
            this.ETW_COL_EventName.Width = 108;
            // 
            // ETW_COL_ProcessID
            // 
            this.ETW_COL_ProcessID.Text = "Process ID";
            this.ETW_COL_ProcessID.Width = 77;
            // 
            // TAB_CONTROL
            // 
            this.TAB_CONTROL.Controls.Add(this.TAB_CONTROL__ETW);
            this.TAB_CONTROL.Controls.Add(this.TAB_CONTROL__DBGLOG);
            this.TAB_CONTROL.Location = new System.Drawing.Point(12, 12);
            this.TAB_CONTROL.Name = "TAB_CONTROL";
            this.TAB_CONTROL.SelectedIndex = 0;
            this.TAB_CONTROL.Size = new System.Drawing.Size(888, 433);
            this.TAB_CONTROL.TabIndex = 2;
            // 
            // TAB_CONTROL__ETW
            // 
            this.TAB_CONTROL__ETW.Controls.Add(this.button1);
            this.TAB_CONTROL__ETW.Controls.Add(this.ETW_RIB_Filter);
            this.TAB_CONTROL__ETW.Controls.Add(this.ETW_List);
            this.TAB_CONTROL__ETW.Location = new System.Drawing.Point(4, 22);
            this.TAB_CONTROL__ETW.Name = "TAB_CONTROL__ETW";
            this.TAB_CONTROL__ETW.Padding = new System.Windows.Forms.Padding(3);
            this.TAB_CONTROL__ETW.Size = new System.Drawing.Size(880, 407);
            this.TAB_CONTROL__ETW.TabIndex = 0;
            this.TAB_CONTROL__ETW.Text = "Event Tracing";
            this.TAB_CONTROL__ETW.UseVisualStyleBackColor = true;
            // 
            // TAB_CONTROL__DBGLOG
            // 
            this.TAB_CONTROL__DBGLOG.Location = new System.Drawing.Point(4, 22);
            this.TAB_CONTROL__DBGLOG.Name = "TAB_CONTROL__DBGLOG";
            this.TAB_CONTROL__DBGLOG.Padding = new System.Windows.Forms.Padding(3);
            this.TAB_CONTROL__DBGLOG.Size = new System.Drawing.Size(880, 407);
            this.TAB_CONTROL__DBGLOG.TabIndex = 1;
            this.TAB_CONTROL__DBGLOG.Text = "Debug Output/Log";
            this.TAB_CONTROL__DBGLOG.UseVisualStyleBackColor = true;
            // 
            // ETW_RIB_Filter
            // 
            this.ETW_RIB_Filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ETW_RIB_Filter.ForeColor = System.Drawing.Color.Gray;
            this.ETW_RIB_Filter.Image = ((System.Drawing.Image)(resources.GetObject("ETW_RIB_Filter.Image")));
            this.ETW_RIB_Filter.Location = new System.Drawing.Point(54, 4);
            this.ETW_RIB_Filter.Margin = new System.Windows.Forms.Padding(0);
            this.ETW_RIB_Filter.Name = "ETW_RIB_Filter";
            this.ETW_RIB_Filter.Size = new System.Drawing.Size(44, 35);
            this.ETW_RIB_Filter.TabIndex = 3;
            this.ETW_RIB_Filter_TT.SetToolTip(this.ETW_RIB_Filter, "Open Filter");
            this.ETW_RIB_Filter.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Gray;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(6, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 35);
            this.button1.TabIndex = 4;
            this.ETW_RIB_Filter_TT.SetToolTip(this.button1, "Open Filter");
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ETW_COL_Summary
            // 
            this.ETW_COL_Summary.Text = "Summary";
            this.ETW_COL_Summary.Width = 598;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 457);
            this.Controls.Add(this.TAB_CONTROL);
            this.Name = "Main";
            this.Text = "DbgViewEx - @emlinhax";
            this.Load += new System.EventHandler(this.Main_Load);
            this.TAB_CONTROL.ResumeLayout(false);
            this.TAB_CONTROL__ETW.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader ETW_COL_Summary;
    }
}

