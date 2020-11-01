using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFood.forms.formsChild
{
    public partial class frmModifyStaff : Form
    {
        public frmModifyStaff()
        {
            InitializeComponent();
        }

        private void frmModifyStaff_Load(object sender, EventArgs e)
        {
        }
        string connectionstring = @"data source=destiny\\lan;initial catalog=quanlyfastfood;integrated security=true";
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter;
        DataTable dataTable;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbStaffID.Text != "" || tbUserName.Text != "" || tbPassWord.Text != "" || tbFullName.Text != "" || tbSalary.Text != "")
            {
                connection = new SqlConnection(connectionstring);
                connection.Open();
                command = new SqlCommand("Insert into dbo.nhanVien(ID,UserName,PassWord,Ten,ViTri,GioiTinh,NgaySinh,NgayThue,TienLuong) values('" + tbStaffID.Text + "','" + tbUserName.Text + "','" + tbPassWord.Text + "','" + tbFullName.Text + "','" + cbPosition.GetItemText(cbPosition.SelectedItem) + "','" + cbGender.GetItemText(cbGender.SelectedItem) + "','" + dtpDOB.Value.ToString() + "','" + dtpHiredDay.Value.ToString() + "','" + tbSalary.Text + "')", connection);
                command.ExecuteNonQuery();
                connection.Close();
                //connection.Open();
                //SqlDataAdapter adapter = new SqlDataAdapter("SELECT*FROM dbo.nhanVien", connection);
                //command.CommandText = "Insert into dbo.nhanVien(ID,UserName,PassWord,Ten,ViTri,GioiTinh,NgaySinh,NgayThue,TienLuong) values('" + tbStaffID.Text + "','" + tbUserName.Text + "','" + tbPassWord.Text + "','" + tbFullName.Text + "','" + cbPosition.GetItemText(cbPosition.SelectedItem) + "','" + cbGender.GetItemText(cbGender.SelectedItem) + "','" + dtpDOB.Value.ToString() + "','" + dtpHiredDay.Value.ToString() + "','" + tbSalary.Text + "')";
                //command.ExecuteNonQuery();
                //connection.Close();
                MessageBox.Show("Datas saved Successed!~~~");
                Clear();
            }
            else {
                MessageBox.Show("Please Insert your information!~~~");
            }
        }
        private void Clear()
        {
            tbStaffID.Text = "";
            tbUserName.Text = "";
            tbPassWord.Text = "";
            tbFullName.Text = "";
            cbPosition.SelectedIndex = -1;
            cbGender.SelectedIndex = -1;
            dtpDOB.Value = DateTime.Now;
            dtpHiredDay.Value = DateTime.Now;
            tbSalary.Text = "";

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            dataTable = new DataTable();
            connection.Open();
            adapter = new SqlDataAdapter("Select * from dbo.nhanVien", connection);
            adapter.Fill(dataTable);
            StaffDataGridView.DataSource = dataTable;
            connection.Close();
        }
    }
}
