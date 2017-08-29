namespace MetropolitanTrialCourtSystem
{
    partial class OpenCase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpenCase));
            this.btnClose = new System.Windows.Forms.Label();
            this.tsmADMIN = new System.Windows.Forms.ToolStrip();
            this.tsmCriminalCase = new System.Windows.Forms.ToolStripButton();
            this.tsmCivilCase = new System.Windows.Forms.ToolStripButton();
            this.tsmClose = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tsmADMIN.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClose.Location = new System.Drawing.Point(770, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 34);
            this.btnClose.TabIndex = 97;
            this.btnClose.Text = "x";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.tsmCriminalCase,
            this.tsmCivilCase,
            this.tsmClose});
            this.tsmADMIN.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tsmADMIN.Location = new System.Drawing.Point(0, 0);
            this.tsmADMIN.Name = "tsmADMIN";
            this.tsmADMIN.Padding = new System.Windows.Forms.Padding(0);
            this.tsmADMIN.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsmADMIN.Size = new System.Drawing.Size(910, 145);
            this.tsmADMIN.TabIndex = 133;
            // 
            // tsmCriminalCase
            // 
            this.tsmCriminalCase.Font = new System.Drawing.Font("Coiny", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmCriminalCase.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tsmCriminalCase.Image = ((System.Drawing.Image)(resources.GetObject("tsmCriminalCase.Image")));
            this.tsmCriminalCase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmCriminalCase.Margin = new System.Windows.Forms.Padding(0, 20, 0, 2);
            this.tsmCriminalCase.Name = "tsmCriminalCase";
            this.tsmCriminalCase.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.tsmCriminalCase.Size = new System.Drawing.Size(253, 123);
            this.tsmCriminalCase.Text = "CRIMINAL CASE";
            this.tsmCriminalCase.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsmCriminalCase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmCriminalCase.Click += new System.EventHandler(this.tsmCriminalCase_Click);
            // 
            // tsmCivilCase
            // 
            this.tsmCivilCase.Font = new System.Drawing.Font("Coiny", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmCivilCase.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tsmCivilCase.Image = ((System.Drawing.Image)(resources.GetObject("tsmCivilCase.Image")));
            this.tsmCivilCase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmCivilCase.Margin = new System.Windows.Forms.Padding(0, 20, 0, 2);
            this.tsmCivilCase.Name = "tsmCivilCase";
            this.tsmCivilCase.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.tsmCivilCase.Size = new System.Drawing.Size(203, 123);
            this.tsmCivilCase.Text = "CIVIL CASE";
            this.tsmCivilCase.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsmCivilCase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmCivilCase.Click += new System.EventHandler(this.tsmCivilCase_Click);
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
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 542);
            this.panel1.TabIndex = 134;
            // 
            // OpenCase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(910, 687);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tsmADMIN);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OpenCase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "OpenCriminalCase";
            this.Load += new System.EventHandler(this.OpenCriminalCase_Load);
            this.tsmADMIN.ResumeLayout(false);
            this.tsmADMIN.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label btnClose;
        private System.Windows.Forms.ToolStrip tsmADMIN;
        private System.Windows.Forms.ToolStripButton tsmCriminalCase;
        private System.Windows.Forms.ToolStripButton tsmCivilCase;
        private System.Windows.Forms.ToolStripButton tsmClose;
        private System.Windows.Forms.Panel panel1;
    }
}