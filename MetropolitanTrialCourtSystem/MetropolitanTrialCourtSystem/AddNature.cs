using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MetropolitanTrialCourtSystem
{
    public partial class AddNature : Form
    {
        DBUtilities db = new DBUtilities();

        public AddNature()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            DataTable dt = db.SelectQuery("SELECT * FROM tblnature");
            if (dt != null)
            {
                if (txtNature.Text != "")
                {
                    db.InsertQuery("INSERT INTO tblnature (Nature) VALUES('" + txtNature.Text + "')");
                    MessageBox.Show("Successfully Save", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.None);
                    CriminalCase.RefreshAdd = true;
                    this.Close();
                }
            }
        }

        private void AddNature_Load(object sender, EventArgs e)
        {

        }
    }
}
