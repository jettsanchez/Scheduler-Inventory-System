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
    public partial class ViewUser : Form
    {
        DBUtilities db = new DBUtilities();
        private int xPos = 0;
        public ViewUser()
        {
            InitializeComponent();
        }

        private void ViewUser_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = db.SelectQuery("SELECT * FROM tblusers");
            if (dt != null)
            {
                if (dt.Rows.Count != 0)
                {
                    foreach (DataRow r in dt.Rows)
                    {
                        ListViewItem itm = new ListViewItem(r["UserID"].ToString());
                        itm.SubItems.Add(r["Username"].ToString());
                        itm.SubItems.Add(r["Password"].ToString());
                        itm.SubItems.Add(r["Usertype"].ToString());

                        lstAccounts.Items.Add(itm);
                    }
                }
            }
            timer1.Start();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Width == xPos)
            {
                //repeat marquee
                this.lblviewusers.Location = new System.Drawing.Point(0, 6);
                xPos = 0;
            }
            else
            {
                this.lblviewusers.Location = new System.Drawing.Point(xPos, 6);
                xPos++;
            }
        }
    }
}
