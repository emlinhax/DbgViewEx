namespace DbgViewEx
{
    partial class EventDetails
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
            this.ED_RawJson = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ED_RawJson
            // 
            this.ED_RawJson.Location = new System.Drawing.Point(12, 12);
            this.ED_RawJson.Name = "ED_RawJson";
            this.ED_RawJson.Size = new System.Drawing.Size(451, 354);
            this.ED_RawJson.TabIndex = 0;
            this.ED_RawJson.Text = "";
            // 
            // EventDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 378);
            this.Controls.Add(this.ED_RawJson);
            this.Name = "EventDetails";
            this.Text = "Details";
            this.Load += new System.EventHandler(this.EventDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox ED_RawJson;
    }
}