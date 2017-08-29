namespace MetropolitanTrialCourtSystem
{
    partial class FORM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tsmCriminalCase = new System.Windows.Forms.ToolStripButton();
            this.tsmLogout = new System.Windows.Forms.ToolStripButton();
            this.tsmInformationForm = new System.Windows.Forms.ToolStripButton();
            this.tsmAccounts = new System.Windows.Forms.ToolStripButton();
            this.tsmADMIN = new System.Windows.Forms.ToolStrip();
            this.tsmSearching = new System.Windows.Forms.ToolStripButton();
            this.tsmDateofHearing = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.tsmADMIN.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(214, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 88);
            this.panel1.TabIndex = 133;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Archivo Black", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(77)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(58, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(998, 52);
            this.label1.TabIndex = 134;
            this.label1.Text = "Metropolitan Trial Court Branch 54 Navotas City";
            // 
            // tsmCriminalCase
            // 
            this.tsmCriminalCase.Font = new System.Drawing.Font("Archivo Black", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmCriminalCase.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tsmCriminalCase.Image = ((System.Drawing.Image)(resources.GetObject("tsmCriminalCase.Image")));
            this.tsmCriminalCase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmCriminalCase.Margin = new System.Windows.Forms.Padding(2, 110, 2, 2);
            this.tsmCriminalCase.Name = "tsmCriminalCase";
            this.tsmCriminalCase.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.tsmCriminalCase.Size = new System.Drawing.Size(209, 57);
            this.tsmCriminalCase.Text = "CASES";
            this.tsmCriminalCase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmCriminalCase.Click += new System.EventHandler(this.tsmCaseSubmitted_Click);
            // 
            // tsmLogout
            // 
            this.tsmLogout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmLogout.BackColor = System.Drawing.Color.Transparent;
            this.tsmLogout.Font = new System.Drawing.Font("Archivo Black", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmLogout.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tsmLogout.Image = ((System.Drawing.Image)(resources.GetObject("tsmLogout.Image")));
            this.tsmLogout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmLogout.Name = "tsmLogout";
            this.tsmLogout.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.tsmLogout.Size = new System.Drawing.Size(213, 57);
            this.tsmLogout.Text = "LOG OUT";
            this.tsmLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmLogout.Click += new System.EventHandler(this.tsmLogout_Click);
            // 
            // tsmInformationForm
            // 
            this.tsmInformationForm.Font = new System.Drawing.Font("Archivo Black", 12.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmInformationForm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tsmInformationForm.Image = ((System.Drawing.Image)(resources.GetObject("tsmInformationForm.Image")));
            this.tsmInformationForm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmInformationForm.Margin = new System.Windows.Forms.Padding(0, 20, 0, 2);
            this.tsmInformationForm.Name = "tsmInformationForm";
            this.tsmInformationForm.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.tsmInformationForm.Size = new System.Drawing.Size(213, 58);
            this.tsmInformationForm.Text = "INFORMATION SHEET";
            this.tsmInformationForm.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsmInformationForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmInformationForm.Click += new System.EventHandler(this.tsmInformationForm_Click);
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
            this.tsmAccounts.Size = new System.Drawing.Size(213, 57);
            this.tsmAccounts.Text = "USER MANAGEMENT";
            this.tsmAccounts.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsmAccounts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmAccounts.Click += new System.EventHandler(this.tsmAccounts_Click);
            // 
            // tsmADMIN
            // 
            this.tsmADMIN.AutoSize = false;
            this.tsmADMIN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tsmADMIN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsmADMIN.Dock = System.Windows.Forms.DockStyle.Left;
            this.tsmADMIN.Font = new System.Drawing.Font("Segoe UI", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.tsmADMIN.GripMargin = new System.Windows.Forms.Padding(0);
            this.tsmADMIN.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsmADMIN.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.tsmADMIN.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCriminalCase,
            this.tsmLogout,
            this.tsmInformationForm,
            this.tsmSearching,
            this.tsmAccounts,
            this.tsmDateofHearing});
            this.tsmADMIN.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.tsmADMIN.Location = new System.Drawing.Point(0, 0);
            this.tsmADMIN.Name = "tsmADMIN";
            this.tsmADMIN.Padding = new System.Windows.Forms.Padding(0);
            this.tsmADMIN.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsmADMIN.Size = new System.Drawing.Size(214, 553);
            this.tsmADMIN.TabIndex = 131;
            // 
            // tsmSearching
            // 
            this.tsmSearching.Font = new System.Drawing.Font("Archivo Black", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmSearching.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tsmSearching.Image = ((System.Drawing.Image)(resources.GetObject("tsmSearching.Image")));
            this.tsmSearching.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmSearching.Margin = new System.Windows.Forms.Padding(0, 20, 0, 2);
            this.tsmSearching.Name = "tsmSearching";
            this.tsmSearching.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.tsmSearching.Size = new System.Drawing.Size(213, 57);
            this.tsmSearching.Text = "SEARCH";
            this.tsmSearching.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsmSearching.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmSearching.Click += new System.EventHandler(this.tsmSearching_Click);
            // 
            // tsmDateofHearing
            // 
            this.tsmDateofHearing.Font = new System.Drawing.Font("Archivo Black", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmDateofHearing.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tsmDateofHearing.Image = ((System.Drawing.Image)(resources.GetObject("tsmDateofHearing.Image")));
            this.tsmDateofHearing.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmDateofHearing.Margin = new System.Windows.Forms.Padding(0, 20, 0, 2);
            this.tsmDateofHearing.Name = "tsmDateofHearing";
            this.tsmDateofHearing.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.tsmDateofHearing.Size = new System.Drawing.Size(232, 57);
            this.tsmDateofHearing.Text = "DATE OF HEARING";
            this.tsmDateofHearing.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsmDateofHearing.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmDateofHearing.Click += new System.EventHandler(this.tsmDateofHearing_Click);
            // 
            // FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(929, 553);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tsmADMIN);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FORM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FORM_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tsmADMIN.ResumeLayout(false);
            this.tsmADMIN.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton tsmCriminalCase;
        private System.Windows.Forms.ToolStripButton tsmLogout;
        private System.Windows.Forms.ToolStripButton tsmInformationForm;
        private System.Windows.Forms.ToolStripButton tsmAccounts;
        private System.Windows.Forms.ToolStrip tsmADMIN;
        private System.Windows.Forms.ToolStripButton tsmSearching;
        private System.Windows.Forms.ToolStripButton tsmDateofHearing;
    }
}