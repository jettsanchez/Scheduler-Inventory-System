namespace MetropolitanTrialCourtSystem
{
    partial class CheckCaseNo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckCaseNo));
            this.btnClose = new System.Windows.Forms.Label();
            this.txtCaseno = new System.Windows.Forms.TextBox();
            this.lblCaseNo = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(462, -2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 34);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "x";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtCaseno
            // 
            this.txtCaseno.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaseno.Location = new System.Drawing.Point(184, 76);
            this.txtCaseno.MaxLength = 200;
            this.txtCaseno.Name = "txtCaseno";
            this.txtCaseno.Size = new System.Drawing.Size(205, 27);
            this.txtCaseno.TabIndex = 10;
            this.txtCaseno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCaseNo
            // 
            this.lblCaseNo.AutoSize = true;
            this.lblCaseNo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaseNo.Location = new System.Drawing.Point(79, 77);
            this.lblCaseNo.Name = "lblCaseNo";
            this.lblCaseNo.Size = new System.Drawing.Size(90, 22);
            this.lblCaseNo.TabIndex = 9;
            this.lblCaseNo.Text = "Case No :";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(221, 130);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(129, 51);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "CHECK";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // CheckCaseNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(494, 195);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCaseno);
            this.Controls.Add(this.lblCaseNo);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CheckCaseNo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CheckCaseNo";
            this.Load += new System.EventHandler(this.CheckCaseNo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btnClose;
        private System.Windows.Forms.TextBox txtCaseno;
        private System.Windows.Forms.Label lblCaseNo;
        private System.Windows.Forms.Button btnSave;
    }
}