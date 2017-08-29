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
    public partial class CivilCase : Form
    {
        DBUtilities db = new DBUtilities();
        public static Boolean RefreshAdd = false;
        private int xPos = 0;
        Point p;
        public CivilCase()
        {
            int width = 214 + 910;
            int height = 88 + 542;
            InitializeComponent();
            p.X = (Screen.PrimaryScreen.Bounds.Width / 2) - width / 2 + 370;
            p.Y = (Screen.PrimaryScreen.Bounds.Height / 2) - height / 2 + 88;
            this.Location = p;
        }
        public void SetAllTextBoxToNull()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                    c.Text = "";
                if (c is ComboBox)
                    (c as ComboBox).SelectedItem = null;
            }
        }
        public void LoadCombo()
        {

            cmbNature.Items.Clear();
            DataTable dt = db.SelectQuery("SELECT * FROM tblnature");
            if (dt != null)
            {
                foreach (DataRow r in dt.Rows)
                {
                    cmbNature.Items.Add(r["Nature"].ToString());
                }
                //cmbNature.SelectedItem = cmbNature.Items[0];
            }

            cmbJudgeAssigned.Items.Clear();
            DataTable dt1 = db.SelectQuery("SELECT * FROM tbljudge");
            if (dt1 != null)
            {
                foreach (DataRow r in dt1.Rows)
                {
                    cmbJudgeAssigned.Items.Add(r["Judge"].ToString());
                }
                //cmbNature.SelectedItem = cmbNature.Items[0];
            }
        }
        private void CivilCase_Load(object sender, EventArgs e)
        {
            LoadCombo();
            timer1.Start();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCriminalCaseNo.Text != "" || txtNameofAccused.Text != "" || cmbNature.Text != "" || txtDateFiled.Text != "" || cmbJudgeAssigned.Text != "")
            {
                db.InsertQuery("INSERT INTO tblcivilcase (CaseNo,NameofAccused,Nature,DateFiled,DateRaffled,DatePretrial,DateInitialtrial,Lasttrial,DateSubmittedDecision,Remarks,JudgeAssigned) VALUES('" + txtCriminalCaseNo.Text + "','" + txtNameofAccused.Text + "','" + cmbNature.Text + "','"
                        + txtDateFiled.Text + "','" + txtDateRaffled.Text + "','" + txtPretrial.Text + "','"
                        + txtDateInitialtrial.Text + "','" + txtDateLasttrial.Text + "','"
                        + txtDateSubmitted.Text + "','" + txtRemarks.Text + "','" + cmbJudgeAssigned.Text + "');");
                MessageBox.Show("SUCCESSFULLY SAVE", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.None);
                SetAllTextBoxToNull();
            }
            else
                MessageBox.Show("Please Complete Details", "REQUIREMENTS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                this.lblCivilcase.Location = new System.Drawing.Point(0, 6);
                xPos = 0;
            }
            else if (RefreshAdd == true)
            {
                LoadCombo();
                RefreshAdd = false;
            }
            else
            {
                this.lblCivilcase.Location = new System.Drawing.Point(xPos, 6);
                xPos++;
            }


        }
    }
}
