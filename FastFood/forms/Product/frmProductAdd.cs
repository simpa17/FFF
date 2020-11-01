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
using System.Security.Policy;

namespace FastFood.forms.Product
{
    public partial class frmProductAdd : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=LAPTOP-AVKCQF6Q\GIANDON;Initial Catalog=QuanLyFastFood;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from sanPham";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvProductModify.DataSource = table;
        }
        public frmProductAdd()
        {
            InitializeComponent();
         

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void tbxProductStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
       

        private void frmProductAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyFastFoodDataSet3.sanPham' table. You can move, or remove it, as needed.
            this.sanPhamTableAdapter1.Fill(this.quanLyFastFoodDataSet3.sanPham);
            // TODO: This line of code loads data into the 'quanLyFastFoodDataSet1.sanPham' table. You can move, or remove it, as needed.
            this.sanPhamTableAdapter.Fill(this.quanLyFastFoodDataSet1.sanPham);
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
            connection.Close();
        }

        private void tbxIngridient_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void dgvProductModify_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            connection.Open();
            command = new SqlCommand("insert into sanPham values ('" + tbxProductName.Text + "','" + tbxProductStatus.Text + "','" + tbxPrice.Text + "','" + tbxProductCategory.Text + "','" + tbxIngridient.Text + "')", connection);
            command.ExecuteNonQuery();
            MessageBox.Show("Your data has been stored");
            connection.Close();
            

        }

        
    }
}
