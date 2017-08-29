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
    public partial class ViewingofCivilCase : Form
    {
        DBUtilities db = new DBUtilities();
        public ViewingofCivilCase()
        {
            InitializeComponent();
        }
        public void LoadFromDatabase()
        {
            lvwCivilCase.Items.Clear();
            DataTable dt = db.SelectQuery("SELECT * FROM tblcivilcase");
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
                        itm.SubItems.Add(r["DateInitialtrial"].ToString());
                        itm.SubItems.Add(r["Lasttrial"].ToString());
                        itm.SubItems.Add(r["DateSubmittedDecision"].ToString());
                        itm.SubItems.Add(r["Remarks"].ToString());
                        itm.SubItems.Add(r["JudgeAssigned"].ToString());
                        lvwCivilCase.Items.Add(itm);
                    }
                }
            }
        }
        public void LoadSearch()
        {
            cmbSearchby.Items.Clear();
            DataTable dt = db.SelectQuery("SELECT * FROM tblfilterforcivilcase");
            if (dt != null)
            {
                foreach (DataRow r in dt.Rows)
                {
                    cmbSearchby.Items.Add(r["Topic"].ToString());
                }
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewingofCivilCase_Load(object sender, EventArgs e)
        {
            LoadFromDatabase();
            LoadSearch();
            cmbSearchby.Text = "CaseNo";
            lvwCivilCase.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void Textchanged()
        {
            lvwCivilCase.Items.Clear();
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
                string filter = "SELECT * FROM tblcivilcase WHERE " + SearchBy + " LIKE " + "'%" + SearchTextbox + "%'";
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
                            lvwCivilCase.Items.Add(itm);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Textchanged();
        }
    }
}
