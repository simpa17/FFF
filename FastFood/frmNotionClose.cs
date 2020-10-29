using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFood
{
    public partial class frmNotionClose : Form
    {
        public frmNotionClose()
        {
            InitializeComponent();
        }

        private void btnYesClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

        private void btnNoClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }
    }
}
