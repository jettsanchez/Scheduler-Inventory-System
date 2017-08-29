namespace MetropolitanTrialCourtSystem
{
    partial class UserInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInfo));
            this.tsmAccounts = new System.Windows.Forms.ToolStripButton();
            this.tsmAddaccount = new System.Windows.Forms.ToolStripButton();
            this.tsmADMIN = new System.Windows.Forms.ToolStrip();
            this.tsmClose = new System.Windows.Forms.ToolStripButton();
            this.tsmADMIN.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsmAccounts
            // 
            this.tsmAccounts.Font = new System.Drawing.Font("Archivo Black", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmAccounts.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tsmAccounts.Image = ((System.Drawing.Image)(resources.GetObject("tsmAccounts.Image")));
            this.tsmAccounts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmAccounts.Margin = new System.Windows.Forms.Padding(0, 20, 0, 2);
            this.tsmAccounts.Name = "tsmAccounts";
            this.tsmAccounts.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.tsmAccounts.Size = new System.Drawing.Size(199, 123);
            this.tsmAccounts.Text = "User Accounts";
            this.tsmAccounts.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsmAccounts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmAccounts.Click += new System.EventHandler(this.tsmAccounts_Click);
            // 
            // tsmAddaccount
            // 
            this.tsmAddaccount.Font = new System.Drawing.Font("Archivo Black", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmAddaccount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tsmAddaccount.Image = ((System.Drawing.Image)(resources.GetObject("tsmAddaccount.Image")));
            this.tsmAddaccount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmAddaccount.Margin = new System.Windows.Forms.Padding(0, 20, 0, 2);
            this.tsmAddaccount.Name = "tsmAddaccount";
            this.tsmAddaccount.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.tsmAddaccount.Size = new System.Drawing.Size(192, 123);
            this.tsmAddaccount.Text = "Add Accounts";
            this.tsmAddaccount.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsmAddaccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmAddaccount.Click += new System.EventHandler(this.tsmAddaccount_Click);
            // 
            // tsmADMIN
            // 
            this.tsmADMIN.AutoSize = false;
            this.tsmADMIN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tsmADMIN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsmADMIN.Font = new System.Drawing.Font("Segoe UI", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.tsmADMIN.GripMargin = new System.Windows.Forms.Padding(0);
            this.tsmADMIN.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsmADMIN.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.tsmADMIN.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAccounts,
            this.tsmAddaccount,
            this.tsmClose});
            this.tsmADMIN.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tsmADMIN.Location = new System.Drawing.Point(0, 0);
            this.tsmADMIN.Name = "tsmADMIN";
            this.tsmADMIN.Padding = new System.Windows.Forms.Padding(0);
            this.tsmADMIN.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsmADMIN.Size = new System.Drawing.Size(859, 145);
            this.tsmADMIN.TabIndex = 132;
            // 
            // tsmClose
            // 
            this.tsmClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmClose.Font = new System.Drawing.Font("Archivo Black", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tsmClose.Image = ((System.Drawing.Image)(resources.GetObject("tsmClose.Image")));
            this.tsmClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmClose.Margin = new System.Windows.Forms.Padding(0, 20, 0, 2);
            this.tsmClose.Name = "tsmClose";
            this.tsmClose.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.tsmClose.Size = new System.Drawing.Size(129, 123);
            this.tsmClose.Text = "CLOSE";
            this.tsmClose.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsmClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmClose.Click += new System.EventHandler(this.tsmClose_Click);
            // 
            // UserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(859, 653);
            this.Controls.Add(this.tsmADMIN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.Viewaccount_Load);
            this.tsmADMIN.ResumeLayout(false);
            this.tsmADMIN.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripButton tsmAccounts;
        private System.Windows.Forms.ToolStripButton tsmAddaccount;
        private System.Windows.Forms.ToolStrip tsmADMIN;
        private System.Windows.Forms.ToolStripButton tsmClose;
    }
}