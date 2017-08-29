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
    public partial class AddJudge : Form
    {
        DBUtilities db = new DBUtilities();

        public AddJudge()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataTable dt = db.SelectQuery("SELECT * FROM tblstatus");
            if (dt != null)
            {
                if (txtJudge.Text != "")
                {
                    db.InsertQuery("INSERT INTO tblstatus (Status) VALUES('" + txtJudge.Text + "')");
                    MessageBox.Show("Successfully Save", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Close();
                }
            }
        }
    }
}
