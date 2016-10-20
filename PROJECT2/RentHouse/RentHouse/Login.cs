using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RentHouse
{
    public partial class Login : Form
    {
        string MyConnection2 = "Data Source=KIDDY\\CCIT;Initial Catalog=rent_house;Persist Security Info=True;User ID=sa;Password=123456";

        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        public void statusLogin()
        {
            SqlConnection db = new SqlConnection(MyConnection2);
            db.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = db;
            com.CommandType = CommandType.Text;
            SqlCommand dbcmd = db.CreateCommand();
            string sql = "select * from tb_admin where username  = '" + tb_username.Text + "' AND password = '" + tb_password.Text + "';";
            dbcmd.CommandText = sql;
            SqlDataReader reader = dbcmd.ExecuteReader();
            if (reader.Read())
            {
                    this.Hide();
                    MessageBox.Show("Login berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MainMenu fr = new MainMenu();
                    fr.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Username dan Password tidak cocok", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_username.Text = "";
                tb_password.Text = "";
                tb_username.Focus();
            }
            db.Close();
            return;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            statusLogin();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection db = new SqlConnection(MyConnection2);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM tb_admin WHERE username='" + tb_username.Text + "' AND password='" + tb_password.Text + "'", db);
            /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);
            if (dt.Rows[0][5].ToString() == "SuperAdmin")
            {
                /* I have made a new page called home page. If the user is successfully authenticated then the form will be moved to the next form */
                this.Hide();
                new MainMenu().Show();
            }
            else
                MessageBox.Show("Invalid username or password");   
        }
    }
}
