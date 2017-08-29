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
    public partial class ViewingofInformation : Form
    {
        DBUtilities db = new DBUtilities();

        public ViewingofInformation()
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
            DataTable dt = db.SelectQuery("SELECT * FROM tblfilterforinformation");
            if (dt != null)
            {
                foreach (DataRow r in dt.Rows)
                {
                    cmbSearchby.Items.Add(r["Topic"].ToString());
                }
            }
        }
        private void Textchanged()
        {
            lvwInformation.Items.Clear();
            string SearchTextbox = txtSearch.Text;
            string comboBox = cmbSearchby.Text;
            string SearchBy = "";
            if (comboBox == "CaseTitle")
            {
                SearchBy = "CaseTitle";
            }
            else if (comboBox == "CaseNo")
            {
                SearchBy = "CaseNo";
            }
            else if (comboBox == "Firstname")
            {
                SearchBy = "Firstname";
            }
            else if (comboBox == "Lastname")
            {
                SearchBy = "Lastname";
            }
            else if (comboBox == "Middlename")
            {
                SearchBy = "Middlename";
            }
            else if (comboBox == "Nickname/alias")
            {
                SearchBy = "Nickname/alias";
            }
            else if (comboBox == "Age")
            {
                SearchBy = "Age";
            }
            else if (comboBox == "CivilStatus")
            {
                SearchBy = "CivilStatus";
            }
            else if (comboBox == "Gender")
            {
                SearchBy = "Gender";
            }
            try
            {
                string filter = "SELECT * FROM tblinformation WHERE " + SearchBy + " LIKE " + "'%" + SearchTextbox + "%'";
                DataTable dt = db.SelectQuery(filter);
                if (dt.Rows != null)
                {
                    if (dt.Rows.Count != 0)
                    {
                        foreach (DataRow r in dt.Rows)
                        {
                            ListViewItem itm = new ListViewItem(r["ID"].ToString());
                            itm.SubItems.Add(r["CaseTitle"].ToString());
                            itm.SubItems.Add(r["CaseNo"].ToString());
                            itm.SubItems.Add(r["Firstname"].ToString());
                            itm.SubItems.Add(r["Lastname"].ToString());
                            itm.SubItems.Add(r["Middlename"].ToString());
                            itm.SubItems.Add(r["Nicknamealias"].ToString());
                            itm.SubItems.Add(r["CityAddress"].ToString());
                            itm.SubItems.Add(r["ProvincialAddress"].ToString());
                            itm.SubItems.Add(r["TellCellno"].ToString());
                            itm.SubItems.Add(r["Age"].ToString());
                            itm.SubItems.Add(r["CivilStatus"].ToString());
                            itm.SubItems.Add(r["Citizenship"].ToString());
                            itm.SubItems.Add(r["Gender"].ToString());
                            itm.SubItems.Add(r["DateBirth"].ToString());
                            itm.SubItems.Add(r["PlaceBirth"].ToString());
                            itm.SubItems.Add(r["Height"].ToString());
                            itm.SubItems.Add(r["Weight"].ToString());
                            itm.SubItems.Add(r["ColorHair"].ToString());
                            itm.SubItems.Add(r["ColorEyes"].ToString());
                            itm.SubItems.Add(r["DistinguishingMarks"].ToString());
                            itm.SubItems.Add(r["Occupation"].ToString());
                            itm.SubItems.Add(r["Citizenship"].ToString());
                            itm.SubItems.Add(r["EducationalAttainment"].ToString());
                            itm.SubItems.Add(r["NameMother"].ToString());
                            itm.SubItems.Add(r["NameFather"].ToString());
                            itm.SubItems.Add(r["NameSpouse"].ToString());
                            itm.SubItems.Add(r["PicturePath"].ToString());
                            lvwInformation.Items.Add(itm);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void LoadFromDatabase()
        {
            lvwInformation.Items.Clear();
            DataTable dt = db.SelectQuery("SELECT * FROM tblinformation");
            if (dt != null)
            {
                if (dt.Rows.Count != 0)
                {
                    foreach (DataRow r in dt.Rows)
                    {
                        ListViewItem itm = new ListViewItem(r["ID"].ToString());
                        itm.SubItems.Add(r["CaseTitle"].ToString());
                        itm.SubItems.Add(r["CaseNo"].ToString());
                        itm.SubItems.Add(r["Firstname"].ToString());
                        itm.SubItems.Add(r["Lastname"].ToString());
                        itm.SubItems.Add(r["Middlename"].ToString());
                        itm.SubItems.Add(r["Nicknamealias"].ToString());
                        itm.SubItems.Add(r["CityAddress"].ToString());
                        itm.SubItems.Add(r["ProvincialAddress"].ToString());
                        itm.SubItems.Add(r["TellCellno"].ToString());
                        itm.SubItems.Add(r["Age"].ToString());
                        itm.SubItems.Add(r["CivilStatus"].ToString());
                        itm.SubItems.Add(r["Citizenship"].ToString());
                        itm.SubItems.Add(r["Gender"].ToString());
                        itm.SubItems.Add(r["DateBirth"].ToString());
                        itm.SubItems.Add(r["PlaceBirth"].ToString());
                        itm.SubItems.Add(r["Height"].ToString());
                        itm.SubItems.Add(r["Weight"].ToString());
                        itm.SubItems.Add(r["ColorHair"].ToString());
                        itm.SubItems.Add(r["ColorEyes"].ToString());
                        itm.SubItems.Add(r["DistinguishingMarks"].ToString());
                        itm.SubItems.Add(r["Occupation"].ToString());
                        itm.SubItems.Add(r["Citizenship"].ToString());
                        itm.SubItems.Add(r["EducationalAttainment"].ToString());
                        itm.SubItems.Add(r["NameMother"].ToString());
                        itm.SubItems.Add(r["NameFather"].ToString());
                        itm.SubItems.Add(r["NameSpouse"].ToString());
                        itm.SubItems.Add(r["PicturePath"].ToString());
                        lvwInformation.Items.Add(itm);
                    }
                }
            }
        }
        private void ViewingofInformation_Load(object sender, EventArgs e)
        {
            LoadSearch();
            LoadFromDatabase();
            cmbSearchby.Text = "CaseTitle";
            lvwInformation.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Textchanged();
        }
    }
}
