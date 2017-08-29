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
    public partial class ViewingofCriminalCase : Form
    {
        DBUtilities db = new DBUtilities();

        public ViewingofCriminalCase()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void LoadSearch()
        {
            cmbSearchby.Items.Clear();
            DataTable dt = db.SelectQuery("SELECT * FROM tblfilterforcriminalcase");
            if (dt != null)
            {
                foreach (DataRow r in dt.Rows)
                {
                    cmbSearchby.Items.Add(r["Topic"].ToString());
                }
                //cmbNature.SelectedItem = cmbNature.Items[0];
            }

        }
        public void LoadFromDatabase()
        {
            lvwCriminalCase.Items.Clear();
            DataTable dt = db.SelectQuery("SELECT * FROM tblcriminalcase");
            if (dt != null)
            {
                if (dt.Rows.Count != 0)
                {
                    foreach (DataRow r in dt.Rows)
                    {
                        ListViewItem itm = new ListViewItem(r["ID"].ToString());
                        itm.SubItems.Add(r["CaseNo"].ToString());
                        itm.SubItems.Add(r["NameofAccused"].ToString());
                        itm.SubItems.Add(r["Nature"].ToString());
                        itm.SubItems.Add(r["DateFiled"].ToString());
                        itm.SubItems.Add(r["DateRaffled"].ToString());
                        itm.SubItems.Add(r["DatePretrial"].ToString());
                        itm.SubItems.Add(r["DateArraignment"].ToString());
                        itm.SubItems.Add(r["DateInitialtrial"].ToString());
                        itm.SubItems.Add(r["Lasttrial"].ToString());
                        itm.SubItems.Add(r["DateSubmittedDecision"].ToString());
                        itm.SubItems.Add(r["Remarks"].ToString());
                        itm.SubItems.Add(r["JudgeAssigned"].ToString());
                        lvwCriminalCase.Items.Add(itm);
                    }
                }
            }
        }
        private void Textchanged()
        {
            lvwCriminalCase.Items.Clear();
            string SearchTextbox = txtSearch.Text;
            string comboBox = cmbSearchby.Text;
            string SearchBy = "";
            if (comboBox == "CaseNo")
            {
                SearchBy = "CaseNo";
            }
            else if (comboBox == "Name of Accused")
            {
                SearchBy = "NameofAccused";
            }
            else if (comboBox == "Nature")
            {
                SearchBy = "Nature";
            }
            else if (comboBox == "Date Filed")
            {
                SearchBy = "DateFiled";
            }
            else if (comboBox == "Date Raffled")
            {
                SearchBy = "DateRaffled";
            }
            else if (comboBox == "Date of Pretrial")
            {
                SearchBy = "DateofPretrial";
            }
            else if (comboBox == "Date of InitialTrial")
            {
                SearchBy = "DateofInitialTrial";
            }
            else if (comboBox == "Last Trial")
            {
                SearchBy = "LastTrial";
            }
            else if (comboBox == "Judge Assigned")
            {
                SearchBy = "JudgeAssigned";
            }
            try
            {
                string filter = "SELECT * FROM tblcriminalcase WHERE " + SearchBy + " LIKE " + "'%" + SearchTextbox + "%'";
                DataTable dt = db.SelectQuery(filter);
                if (dt.Rows != null)
                {
                    if (dt.Rows.Count != 0)
                    {
                        foreach (DataRow r in dt.Rows)
                        {
                            ListViewItem itm = new ListViewItem(r["ID"].ToString());
                            itm.SubItems.Add(r["CaseNo"].ToString());
                            itm.SubItems.Add(r["NameofAccused"].ToString());
                            itm.SubItems.Add(r["Nature"].ToString());
                            itm.SubItems.Add(r["DateFiled"].ToString());
                            itm.SubItems.Add(r["DateRaffled"].ToString());
                            itm.SubItems.Add(r["DatePretrial"].ToString());
                            itm.SubItems.Add(r["DateInitialtrial"].ToString());
                            itm.SubItems.Add(r["Lasttrial"].ToString());
                            itm.SubItems.Add(r["DateSubmittedDecision"].ToString());
                            itm.SubItems.Add(r["Remarks"].ToString());
                            itm.SubItems.Add(r["JudgeAssigned"].ToString());
                            lvwCriminalCase.Items.Add(itm);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void ViewingofCasesSubmitted_Load(object sender, EventArgs e)
        {
            LoadSearch();
            LoadFromDatabase();
            cmbSearchby.Text = "CaseNo";
            lvwCriminalCase.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
    }
}
