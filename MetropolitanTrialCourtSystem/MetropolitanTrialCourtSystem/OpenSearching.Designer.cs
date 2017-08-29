namespace MetropolitanTrialCourtSystem
{
    partial class OpenSearching
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpenSearching));
            this.tsmADMIN = new System.Windows.Forms.ToolStrip();
            this.tsmSearchCriminalCase = new System.Windows.Forms.ToolStripButton();
            this.tsmSearchCivilCase = new System.Windows.Forms.ToolStripButton();
            this.tsmClose = new System.Windows.Forms.ToolStripButton();
            this.tsmSearchInformation = new System.Windows.Forms.ToolStripButton();
            this.tsmADMIN.SuspendLayout();
            this.SuspendLayout();
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
            this.tsmSearchCriminalCase,
            this.tsmSearchCivilCase,
            this.tsmClose,
            this.tsmSearchInformation});
            this.tsmADMIN.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tsmADMIN.Location = new System.Drawing.Point(0, 0);
            this.tsmADMIN.Name = "tsmADMIN";
            this.tsmADMIN.Padding = new System.Windows.Forms.Padding(0);
            this.tsmADMIN.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsmADMIN.Size = new System.Drawing.Size(827, 145);
            this.tsmADMIN.TabIndex = 135;
            // 
            // tsmSearchCriminalCase
            // 
            this.tsmSearchCriminalCase.Font = new System.Drawing.Font("Coiny", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmSearchCriminalCase.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tsmSearchCriminalCase.Image = ((System.Drawing.Image)(resources.GetObject("tsmSearchCriminalCase.Image")));
            this.tsmSearchCriminalCase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmSearchCriminalCase.Margin = new System.Windows.Forms.Padding(0, 20, 0, 2);
            this.tsmSearchCriminalCase.Name = "tsmSearchCriminalCase";
            this.tsmSearchCriminalCase.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.tsmSearchCriminalCase.Size = new System.Drawing.Size(253, 123);
            this.tsmSearchCriminalCase.Text = "CRIMINAL CASE";
            this.tsmSearchCriminalCase.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsmSearchCriminalCase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmSearchCriminalCase.Click += new System.EventHandler(this.tsmSearchCriminalCase_Click);
            // 
            // tsmSearchCivilCase
            // 
            this.tsmSearchCivilCase.Font = new System.Drawing.Font("Coiny", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmSearchCivilCase.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tsmSearchCivilCase.Image = ((System.Drawing.Image)(resources.GetObject("tsmSearchCivilCase.Image")));
            this.tsmSearchCivilCase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmSearchCivilCase.Margin = new System.Windows.Forms.Padding(0, 20, 0, 2);
            this.tsmSearchCivilCase.Name = "tsmSearchCivilCase";
            this.tsmSearchCivilCase.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.tsmSearchCivilCase.Size = new System.Drawing.Size(203, 123);
            this.tsmSearchCivilCase.Text = "CIVIL CASE";
            this.tsmSearchCivilCase.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsmSearchCivilCase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmSearchCivilCase.Click += new System.EventHandler(this.tsmSearchCivilCase_Click);
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
            // tsmSearchInformation
            // 
            this.tsmSearchInformation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tsmSearchInformation.Font = new System.Drawing.Font("Coiny", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmSearchInformation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tsmSearchInformation.Image = ((System.Drawing.Image)(resources.GetObject("tsmSearchInformation.Image")));
            this.tsmSearchInformation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmSearchInformation.Margin = new System.Windows.Forms.Padding(0, 20, 0, 2);
            this.tsmSearchInformation.Name = "tsmSearchInformation";
            this.tsmSearchInformation.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.tsmSearchInformation.Size = new System.Drawing.Size(236, 73);
            this.tsmSearchInformation.Text = "INFORMATION";
            this.tsmSearchInformation.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsmSearchInformation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmSearchInformation.Click += new System.EventHandler(this.tsmSearchInformation_Click);
            // 
            // OpenSearching
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(827, 561);
            this.Controls.Add(this.tsmADMIN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OpenSearching";
            this.Text = "OpenSearching";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tsmADMIN.ResumeLayout(false);
            this.tsmADMIN.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsmADMIN;
        private System.Windows.Forms.ToolStripButton tsmSearchCriminalCase;
        private System.Windows.Forms.ToolStripButton tsmSearchCivilCase;
        private System.Windows.Forms.ToolStripButton tsmClose;
        private System.Windows.Forms.ToolStripButton tsmSearchInformation;
    }
}