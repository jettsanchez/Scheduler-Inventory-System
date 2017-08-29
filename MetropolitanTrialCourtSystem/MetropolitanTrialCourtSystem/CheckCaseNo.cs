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
    public partial class CheckCaseNo : Form
    {
        Point p;
        public CheckCaseNo()
        {
            InitializeComponent();
            p.X = (Screen.PrimaryScreen.Bounds.Width / 2) - (this.Size.Width / 2) + 214 / 2;
            p.Y = (Screen.PrimaryScreen.Bounds.Height / 2) - (this.Size.Height / 2) + 88 / 2;
            this.Location = p;
        }

        private void CheckCaseNo_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
