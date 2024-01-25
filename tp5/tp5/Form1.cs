using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp5
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            FVoiture f = new FVoiture();
            f.MdiParent = this;
            f.Show();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            FLocation f = new FLocation();
            f.MdiParent = this;
            f.Show();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            FRetLoc f = new FRetLoc();
            f.MdiParent = this;
            f.Show();
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            FClient f = new FClient();
            f.MdiParent = this;
            f.Show();

        }
    }
}
