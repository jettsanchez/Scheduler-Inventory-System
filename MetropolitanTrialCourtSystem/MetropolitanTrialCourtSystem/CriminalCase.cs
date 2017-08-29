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
using MetropolitanTrialCourtSystem;

namespace MetropolitanTrialCourtSystem
{
    public partial class CriminalCase : Form
    {
        DBUtilities db = new DBUtilities();
        Point p;
        private int xPos = 0;
        Responsive res = new Responsive();
        public CriminalCase()
        {
            int width = 214 + 910;
            int height = 88 + 542;
            InitializeComponent();
            p.X = (Screen.PrimaryScreen.Bounds.Width / 2) - width /2 + 370;
            p.Y = (Screen.PrimaryScreen.Bounds.Height / 2) - height /2 + 88;
            this.Location = p;

        }
        public static Boolean RefreshAdd = false;
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void CasesSubmitted_Load(object sender, EventArgs e)
        {
            LoadCombo();
            timer1.Start();
        }

        private void btnAddNature_Click(object sender, EventArgs e)
        {
            AddNature add = new AddNature();
            add.ShowDialog();
        }

        private void btnAddJudge_Click(object sender, EventArgs e)
        {
            AddJudge add = new AddJudge();
            add.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Width == xPos)
            {
                //repeat marquee
                this.lblCriminalCase.Location = new System.Drawing.Point(0, 6);
                xPos = 0;
            }
            else if (RefreshAdd == true)
            {
                LoadCombo();
                RefreshAdd = false;
            }
            else
            {
                this.lblCriminalCase.Location = new System.Drawing.Point(xPos, 6);
                xPos++;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCriminalCaseNo.Text != "" || txtNameofAccused.Text != "" || cmbNature.Text != "" || txtDateFiled.Text != "" || cmbJudgeAssigned.Text != "")
            {
                db.InsertQuery("INSERT INTO tblcriminalcase (CaseNo,NameofAccused,Nature,DateFiled,DateRaffled,DatePretrial,DateArraignment,DateInitialtrial,Lasttrial,DateSubmittedDecision,Remarks,JudgeAssigned) VALUES('" + txtCriminalCaseNo.Text + "','" + txtNameofAccused.Text + "','" + cmbNature.Text + "','"
                        + txtDateFiled.Text + "','" + txtDateRaffled.Text + "','" + txtPretrial.Text + "','"
                        + txtDateArraignment.Text + "','" + txtDateInitialtrial.Text + "','" + txtDateLasttrial.Text + "','"
                        + txtDateSubmitted.Text + "','" + txtRemarks.Text + "','" + cmbJudgeAssigned.Text + "');");
                MessageBox.Show("SUCCESSFULLY SAVE", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.None);
                SetAllTextBoxToNull();
            }
            else
                MessageBox.Show("Please Complete Details", "REQUIREMENTS",MessageBoxButtons.OK,MessageBoxIcon.Warning);

        }
    }
}
