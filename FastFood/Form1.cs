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
using System.Windows.Markup;
using System.Windows.Media;

namespace FastFood
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void iconShowPass_Click(object sender, EventArgs e)
        {
            if (iconShowPass.IconChar == FontAwesome.Sharp.IconChar.Eye)
            {
                txtPassword.UseSystemPasswordChar = false;
                iconShowPass.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                iconShowPass.IconChar = FontAwesome.Sharp.IconChar.Eye;
            }
        }

        private void iconCloseForm_Click(object sender, EventArgs e)
        {
            frmNotionClose frmClose = new frmNotionClose();
            if (frmClose.ShowDialog() != DialogResult.Yes)
            {
                this.Show();
            }
            else
            {
                System.Environment.Exit(1);
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            {
                if (txtUsername.Text == "" || txtPassword.Text == "")
                {
                    lblWrongPasword.Visible = false;
                    lblEnterPass.Visible = true;
                    panelWrongPass.Visible = true;
                    btnSignIn.Location = new Point(647, 430);

                }
                else
                {
                    string connectionSTR = "Data Source=LAPTOP-AVKCQF6Q\\GIANDON;Initial Catalog=QuanLyFastFood;Integrated Security=True";
                    SqlConnection connection = new SqlConnection(connectionSTR);

                    SqlCommand command = new SqlCommand("SELECT * FROM quanLy WHERE Username=@UUserName and PassWord=@UPassWord", connection);
                    command.Parameters.AddWithValue("@UUserName", txtUsername.Text);
                    command.Parameters.AddWithValue("@UPassWord", txtPassword.Text);

                    connection.Open();
                    SqlDataAdapter adpt = new SqlDataAdapter(command);
                    DataSet dataSet = new DataSet();

                    adpt.Fill(dataSet);
                    connection.Close();

                    int count = dataSet.Tables[0].Rows.Count;
                    if (count == 1)
                    {
                        frmMain main = new frmMain();
                        this.Hide();
                        main.Show();
                    }
                    else
                    {
                        panelWrongPass.Visible = true;
                        lblWrongPasword.Visible = true;
                        lblEnterPass.Visible = false;
                    }
                }
            }
        }

        private void lblWrongPasword_Click(object sender, EventArgs e)
        {

        }
    }
}
