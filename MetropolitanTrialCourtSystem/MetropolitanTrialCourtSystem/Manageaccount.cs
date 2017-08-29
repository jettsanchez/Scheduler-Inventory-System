using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetropolitanTrialCourtSystem
{
    public partial class Manageaccount : Form
    {
        DBUtilities db = new DBUtilities();
        private int xPos = 0;
        public Manageaccount()
        {
            InitializeComponent();
        }

        private void Manageaccount_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" || txtPassword.Text != "" || cmbUsertype.Text != "")
            {
                db.InsertQuery("INSERT INTO tblusers (Username,Password,Usertype) VALUES('" + txtUsername.Text + "','" + txtPassword.Text + "','" + cmbUsertype.Text + "');");
                MessageBox.Show("SUCCESSFULLY SAVE","COMPLETE",MessageBoxButtons.OK,MessageBoxIcon.None);
                txtUsername.Text = null;
                txtPassword.Text = null;
                cmbUsertype.SelectedItem = null;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Width == xPos)
            {
                //repeat marquee
                this.lblCreateAccount.Location = new System.Drawing.Point(0, 6);
                xPos = 0;
            }
            else
            {
                this.lblCreateAccount.Location = new System.Drawing.Point(xPos, 6);
                xPos++;
            }

        }
    }
}
