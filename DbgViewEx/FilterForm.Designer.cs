namespace DbgViewEx
{
    partial class FilterForm
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
            this.FILTER_Subject = new System.Windows.Forms.ComboBox();
            this.FILTER_Condition = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FILTER_Action = new System.Windows.Forms.ComboBox();
            this.FILTER_Value = new System.Windows.Forms.TextBox();
            this.FILTER_Savebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FILTER_Subject
            // 
            this.FILTER_Subject.BackColor = System.Drawing.Color.White;
            this.FILTER_Subject.FormattingEnabled = true;
            this.FILTER_Subject.Location = new System.Drawing.Point(12, 12);
            this.FILTER_Subject.Name = "FILTER_Subject";
            this.FILTER_Subject.Size = new System.Drawing.Size(121, 21);
            this.FILTER_Subject.TabIndex = 0;
            // 
            // FILTER_Condition
            // 
            this.FILTER_Condition.BackColor = System.Drawing.Color.White;
            this.FILTER_Condition.FormattingEnabled = true;
            this.FILTER_Condition.Location = new System.Drawing.Point(139, 12);
            this.FILTER_Condition.Name = "FILTER_Condition";
            this.FILTER_Condition.Size = new System.Drawing.Size(82, 21);
            this.FILTER_Condition.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "then";
            // 
            // FILTER_Action
            // 
            this.FILTER_Action.BackColor = System.Drawing.Color.White;
            this.FILTER_Action.FormattingEnabled = true;
            this.FILTER_Action.Location = new System.Drawing.Point(394, 12);
            this.FILTER_Action.Name = "FILTER_Action";
            this.FILTER_Action.Size = new System.Drawing.Size(82, 21);
            this.FILTER_Action.TabIndex = 3;
            // 
            // FILTER_Value
            // 
            this.FILTER_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FILTER_Value.Location = new System.Drawing.Point(227, 12);
            this.FILTER_Value.Name = "FILTER_Value";
            this.FILTER_Value.Size = new System.Drawing.Size(127, 21);
            this.FILTER_Value.TabIndex = 4;
            // 
            // FILTER_Savebutton
            // 
            this.FILTER_Savebutton.Location = new System.Drawing.Point(12, 41);
            this.FILTER_Savebutton.Name = "FILTER_Savebutton";
            this.FILTER_Savebutton.Size = new System.Drawing.Size(463, 23);
            this.FILTER_Savebutton.TabIndex = 5;
            this.FILTER_Savebutton.Text = "Save";
            this.FILTER_Savebutton.UseVisualStyleBackColor = true;
            this.FILTER_Savebutton.Click += new System.EventHandler(this.FILTER_Savebutton_Click);
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 76);
            this.Controls.Add(this.FILTER_Savebutton);
            this.Controls.Add(this.FILTER_Value);
            this.Controls.Add(this.FILTER_Action);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FILTER_Condition);
            this.Controls.Add(this.FILTER_Subject);
            this.Name = "FilterForm";
            this.Text = "FilterForm";
            this.Load += new System.EventHandler(this.FilterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox FILTER_Subject;
        private System.Windows.Forms.ComboBox FILTER_Condition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FILTER_Action;
        private System.Windows.Forms.TextBox FILTER_Value;
        private System.Windows.Forms.Button FILTER_Savebutton;
    }
}