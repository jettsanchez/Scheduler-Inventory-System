namespace MetropolitanTrialCourtSystem
{
    partial class MYSQLConnection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MYSQLConnection));
            this.lblServer = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.lblUsernameID = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.txtUsernameID = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServer.Location = new System.Drawing.Point(84, 125);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(84, 19);
            this.lblServer.TabIndex = 0;
            this.lblServer.Text = "SERVER :";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPort.Location = new System.Drawing.Point(102, 159);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(64, 19);
            this.lblPort.TabIndex = 1;
            this.lblPort.Text = "PORT :";
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatabase.Location = new System.Drawing.Point(62, 193);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(104, 19);
            this.lblDatabase.TabIndex = 2;
            this.lblDatabase.Text = "DATABASE :";
            // 
            // lblUsernameID
            // 
            this.lblUsernameID.AutoSize = true;
            this.lblUsernameID.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameID.Location = new System.Drawing.Point(35, 227);
            this.lblUsernameID.Name = "lblUsernameID";
            this.lblUsernameID.Size = new System.Drawing.Size(135, 19);
            this.lblUsernameID.TabIndex = 3;
            this.lblUsernameID.Text = "USERNAME ID :";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(60, 261);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(111, 19);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "PASSWORD :";
            // 
            // txtServer
            // 
            this.txtServer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServer.Location = new System.Drawing.Point(177, 122);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(194, 26);
            this.txtServer.TabIndex = 5;
            // 
            // txtPort
            // 
            this.txtPort.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.Location = new System.Drawing.Point(177, 156);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(194, 26);
            this.txtPort.TabIndex = 6;
            // 
            // txtDatabase
            // 
            this.txtDatabase.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatabase.Location = new System.Drawing.Point(177, 190);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(194, 26);
            this.txtDatabase.TabIndex = 7;
            // 
            // txtUsernameID
            // 
            this.txtUsernameID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsernameID.Location = new System.Drawing.Point(177, 224);
            this.txtUsernameID.Name = "txtUsernameID";
            this.txtUsernameID.Size = new System.Drawing.Size(194, 26);
            this.txtUsernameID.TabIndex = 8;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(177, 258);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(194, 26);
            this.txtPassword.TabIndex = 9;
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.Color.PaleGreen;
            this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTest.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.Image = ((System.Drawing.Image)(resources.GetObject("btnTest.Image")));
            this.btnTest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTest.Location = new System.Drawing.Point(94, 330);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(209, 63);
            this.btnTest.TabIndex = 10;
            this.btnTest.Text = "TEST CONNECTION";
            this.btnTest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            this.btnTest.MouseLeave += new System.EventHandler(this.btnTest_MouseLeave);
            this.btnTest.MouseHover += new System.EventHandler(this.btnTest_MouseHover);
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.PaleGreen;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApply.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.Image = ((System.Drawing.Image)(resources.GetObject("btnApply.Image")));
            this.btnApply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApply.Location = new System.Drawing.Point(321, 330);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(115, 63);
            this.btnApply.TabIndex = 11;
            this.btnApply.Text = "APPLY";
            this.btnApply.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            this.btnApply.MouseLeave += new System.EventHandler(this.btnApply_MouseLeave);
            this.btnApply.MouseHover += new System.EventHandler(this.btnApply_MouseHover);
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(418, -2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 34);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "x";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 38);
            this.panel1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Archivo Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(4, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 27);
            this.label2.TabIndex = 12;
            this.label2.Text = "CONNECTION SETTINGS";
            // 
            // MYSQLConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(448, 408);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsernameID);
            this.Controls.Add(this.txtDatabase);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsernameID);
            this.Controls.Add(this.lblDatabase);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.lblServer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MYSQLConnection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MYSQLConnection";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.Label lblUsernameID;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.TextBox txtUsernameID;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}