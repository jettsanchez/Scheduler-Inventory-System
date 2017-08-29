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
    public partial class InformationSheet : Form
    {
        DBUtilities db = new DBUtilities();
        string successpath = "";
        Point p;
        public InformationSheet()
        {
            InitializeComponent();
            p.X = (Screen.PrimaryScreen.Bounds.Width / 2) - (this.Size.Width / 2) + 214 / 2;
            p.Y = (Screen.PrimaryScreen.Bounds.Height / 2) - (this.Size.Height / 2) + 88 / 2;
            this.Location = p;
        }
        public Image GetImage(string filepath)
        {
            using (Image img = Image.FromFile(filepath))
            {
                Bitmap bit = new Bitmap(img, 139, 116);
                return bit;
            }
        }
        private void InformationSheet_Load(object sender, EventArgs e)
        {

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

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Type of Images(.jpg,.jpeg,.png) | *.jpg;*.jpeg;*.png";
            if (DialogResult.OK == dialog.ShowDialog())
            {
                successpath = dialog.FileName;
                string newpath = "";
                Image img = GetImage(successpath);
                pb_Photo.Image = img;
                string[] path = successpath.Split('\\');
                for (int i = 0; i < path.Length; i++)
                {
                    newpath += path[i] + "\\\\";
                }
                successpath = newpath.Substring(0, newpath.Length - 2);
                lblPath.Text = successpath;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string path = successpath;
            string[] path1 = successpath.ToString().Split('\\');
            string newpath = path1[path1.Length - 1];

            if (txtCaseNo.Text != "" || txtCaseTitle.Text != "" || txtFname.Text != "" || txtLname.Text != "")
            {
                db.InsertQuery("INSERT INTO tblinformation (CaseTitle,CaseNo,Firstname,Lastname,Middlename,NicknameAlias,CityAddress,ProvincialAddress,TelCellno,Age,CivilStatus,Citizenship,Gender,DateBirth,PlaceBirth,Height,Weight,ColorHair,ColorEyes,DistinguishingMarks,Occupation,EducationalAttainment,NameMother,NameFather,NameSpouse,PicturePath) VALUES('" + txtCaseTitle.Text + "','" + txtCaseNo.Text + "','" + txtFname.Text + "','"
                      + txtLname.Text + "','" + txtMname.Text + "','" + txtNickname.Text + "','" + txtCityAddress.Text + "','"
                      + txtProvincialAddress.Text + "','" + txtTelCelNo.Text.ToString() + "','" + txtAge.Text.ToString() + "','"
                      + cmbCivilStatus.Text + "','" + txtCitizenship.Text + "','" + cmbGender.Text + "','"
                      + txtDateofBirth.Text + "','" + txtPlaceofBirth.Text + "','" + txtHeight.Text.ToString() + "','"
                      + txtWeight.Text.ToString() + "','" + txtColorofHair.Text + "','" + txtColorofEyes.Text + "','"
                      + txtDistinguishingMarks.Text + "','" + txtOccupation.Text + "','" + txtEducationalAttainment.Text + "','"
                      + txtNameofMother.Text + "','" + txtNameofFather.Text + "','" + txtNameofSpouse.Text + "','"
                      + newpath + "');");
                MessageBox.Show("YESS SUCCESS !", "SUCCESSFULLY", MessageBoxButtons.OK, MessageBoxIcon.None);
                SetAllTextBoxToNull();
            }
            else
            {
                MessageBox.Show("Please Complete Data .", "REQUIREMENTS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
