namespace GoogleChromeHistory
{
    partial class frmMain
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
            this.cmdExport = new System.Windows.Forms.Button();
            this.chTime = new System.Windows.Forms.CheckBox();
            this.chTitle = new System.Windows.Forms.CheckBox();
            this.cmdView = new System.Windows.Forms.Button();
            this.lstHistory = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cmdExport
            // 
            this.cmdExport.Location = new System.Drawing.Point(12, 12);
            this.cmdExport.Name = "cmdExport";
            this.cmdExport.Size = new System.Drawing.Size(180, 95);
            this.cmdExport.TabIndex = 0;
            this.cmdExport.Text = "Export to Text file";
            this.cmdExport.UseVisualStyleBackColor = true;
            this.cmdExport.Click += new System.EventHandler(this.cmdExport_Click);
            // 
            // chTime
            // 
            this.chTime.AutoSize = true;
            this.chTime.Location = new System.Drawing.Point(12, 113);
            this.chTime.Name = "chTime";
            this.chTime.Size = new System.Drawing.Size(120, 17);
            this.chTime.TabIndex = 1;
            this.chTime.Text = "Include Time Stamp";
            this.chTime.UseVisualStyleBackColor = true;
            // 
            // chTitle
            // 
            this.chTitle.AutoSize = true;
            this.chTitle.Location = new System.Drawing.Point(12, 146);
            this.chTitle.Name = "chTitle";
            this.chTitle.Size = new System.Drawing.Size(112, 17);
            this.chTitle.TabIndex = 2;
            this.chTitle.Text = "Include Page Title";
            this.chTitle.UseVisualStyleBackColor = true;
            // 
            // cmdView
            // 
            this.cmdView.Location = new System.Drawing.Point(12, 169);
            this.cmdView.Name = "cmdView";
            this.cmdView.Size = new System.Drawing.Size(173, 106);
            this.cmdView.TabIndex = 3;
            this.cmdView.Text = "View/Update History";
            this.cmdView.UseVisualStyleBackColor = true;
            this.cmdView.Click += new System.EventHandler(this.cmdView_Click);
            // 
            // lstHistory
            // 
            this.lstHistory.FormattingEnabled = true;
            this.lstHistory.Location = new System.Drawing.Point(198, 7);
            this.lstHistory.Name = "lstHistory";
            this.lstHistory.Size = new System.Drawing.Size(1002, 602);
            this.lstHistory.TabIndex = 4;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 613);
            this.Controls.Add(this.lstHistory);
            this.Controls.Add(this.cmdView);
            this.Controls.Add(this.chTitle);
            this.Controls.Add(this.chTime);
            this.Controls.Add(this.cmdExport);
            this.Name = "frmMain";
            this.Text = "Google Chrome History viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdExport;
        private System.Windows.Forms.CheckBox chTime;
        private System.Windows.Forms.CheckBox chTitle;
        private System.Windows.Forms.Button cmdView;
        private System.Windows.Forms.ListBox lstHistory;
    }
}

