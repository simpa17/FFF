using FastFood.forms.formsChild;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FastFood.forms
{
    public partial class frmStaff : Form
    {
        public frmStaff()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add();
        }
        private void Add()
        {
            frmModifyStaff frmAdd = new frmModifyStaff();
            if (frmAdd.ShowDialog() != DialogResult.Yes)
            {
                this.Show();
            }
            else
            {
                System.Environment.Exit(1);
            }
        }
        private void Exit()
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to exit","Save DataGridView",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (iExit == DialogResult.Yes) {
                Application.Exit();
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void Delete() {
            foreach (DataGridViewRow item in this.StaffDataGridView.SelectedRows)
            {
                StaffDataGridView.Rows.RemoveAt(item.Index);
            }

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }
        Bitmap bitmap;
        private void printListStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int height = StaffDataGridView.Height;
            StaffDataGridView.Height = StaffDataGridView.RowCount * StaffDataGridView.RowTemplate.Height * 2;
            bitmap = new Bitmap(StaffDataGridView.Width, StaffDataGridView.Height);
            StaffDataGridView.DrawToBitmap(bitmap, new Rectangle(0, 0, StaffDataGridView.Width, StaffDataGridView.Height));
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
            StaffDataGridView.Height = height;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
    }
}
