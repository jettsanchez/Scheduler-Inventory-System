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
    public partial class FORM : Form
    {
        Responsive res = new Responsive();
        Point p;
        public FORM()
        {
            InitializeComponent();
            res.generateresponsive(this);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            
        }
        private void tsmLogout_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure to logout ?", "WARNING !", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.Hide();
                this.Show();
                Useraccount vote = new Useraccount();
                this.Close();
                vote.Show();
            }
        }

        private void tsmCaseSubmitted_Click(object sender, EventArgs e)
        {
           
            OpenCase frm = new OpenCase();
            frm.ShowDialog();
        }
        private void tsmInformationForm_Click(object sender, EventArgs e)
        {
            InformationSheet sheet = new InformationSheet();
            sheet.ShowDialog();
        }
        private void tsmAccounts_Click(object sender, EventArgs e)
        {
            UserInfo acc = new UserInfo();
            acc.ShowDialog();
        }

        private void tsmSearchInformation_Click(object sender, EventArgs e)
        {
            ViewingofInformation view = new ViewingofInformation();
            view.ShowDialog();
        }

        private void tsmCivilCase_Click(object sender, EventArgs e)
        {
        }
        private void tsmAddaccount_Click(object sender, EventArgs e)
        {
            Manageaccount acc = new Manageaccount();
            acc.ShowDialog();
        }

        private void FORM_Load(object sender, EventArgs e)
        {
           
        }

        private void tsmSearching_Click(object sender, EventArgs e)
        {
            OpenSearching search = new OpenSearching();
            search.Show();
        }

        private void tsmDateofHearing_Click(object sender, EventArgs e)
        {
            CheckCaseNo no = new CheckCaseNo();
            no.ShowDialog();
        }
    }
}
