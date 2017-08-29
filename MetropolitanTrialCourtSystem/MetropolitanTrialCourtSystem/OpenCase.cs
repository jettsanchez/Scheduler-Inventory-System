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
    public partial class OpenCase : Form
    {
        Point p;
        Responsive res = new Responsive();
        public OpenCase()
        {
            InitializeComponent();
            p.X = (Screen.PrimaryScreen.Bounds.Width / 2) - (this.Size.Width / 2) + 214 / 2;
            p.Y = (Screen.PrimaryScreen.Bounds.Height / 2) - (this.Size.Height / 2) + 88 / 2;
            this.Location = p;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddCriminalCase_Click(object sender, EventArgs e)
        {
            CriminalCase crim = new CriminalCase();
            crim.ShowDialog();
        }

        private void btnSearchCriminalCase_Click(object sender, EventArgs e)
        {
            ViewingofCriminalCase view = new ViewingofCriminalCase();
            view.ShowDialog();
        }

        private void OpenCriminalCase_Load(object sender, EventArgs e)
        {
        }

        private void tsmClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmCriminalCase_Click(object sender, EventArgs e)
        {
            CriminalCase ca = new CriminalCase();
            ca.ShowDialog();
        }

        private void tsmCivilCase_Click(object sender, EventArgs e)
        {
            CivilCase ca = new CivilCase();
            ca.Show();
        }
    }
}
