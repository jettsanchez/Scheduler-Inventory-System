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
    public partial class OpenSearching : Form
    {
        public OpenSearching()
        {
            InitializeComponent();
        }

        private void tsmClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmSearchCriminalCase_Click(object sender, EventArgs e)
        {
            ViewingofCriminalCase view = new ViewingofCriminalCase();
            view.ShowDialog();
        }

        private void tsmSearchCivilCase_Click(object sender, EventArgs e)
        {
            ViewingofCivilCase view = new ViewingofCivilCase();
            view.ShowDialog();
        }

        private void tsmSearchInformation_Click(object sender, EventArgs e)
        {
            ViewingofInformation info = new ViewingofInformation();
            info.ShowDialog();
        }
    }
}
