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
    public partial class UserInfo : Form
    {
        DBUtilities db = new DBUtilities();
        Point p;
        public UserInfo()
        {
            InitializeComponent();
            p.X = (Screen.PrimaryScreen.Bounds.Width / 2) - (this.Size.Width / 2) + 214 / 2;
            p.Y = (Screen.PrimaryScreen.Bounds.Height / 2) - (this.Size.Height / 2) + 88 / 2;
            this.Location = p;
        }
        private void Viewaccount_Load(object sender, EventArgs e)
        {
           
        }

        private void tsmClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmAccounts_Click(object sender, EventArgs e)
        {
            ViewUser frm = new ViewUser();
            frm.TopLevel = false;
            frm.Show();
        }

        private void tsmAddaccount_Click(object sender, EventArgs e)
        {
            Manageaccount frm = new Manageaccount();
            frm.TopLevel = false;
            frm.Show();
        }
    }
}
