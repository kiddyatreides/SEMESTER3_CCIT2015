using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Transactions;
using System.Data.SqlClient;


namespace WindowsFormsApplication3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

      
        private void Form2_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=KIDDY\\CCIT;Initial Catalog=latihan;Persist Security Info=True;User ID=sa;Password=123456";
            SqlConnection cn = new SqlConnection(connectionString);
            cn.Open();
            SqlTransaction trans = cn.BeginTransaction();
            try
            {
                SqlCommand cmd = new SqlCommand("insert into tb_employee values('E004','Wawa','Bogor','Bogor','Indonesia','SUPERVISOR','HRD')", cn, trans);
                cmd.ExecuteNonQuery();
                SqlCommand cmd1 = new SqlCommand("insert into tb_admin values('2','Ojan','1')", cn, trans);
                cmd1.ExecuteNonQuery();
                trans.Commit();
                MessageBox.Show("Transaction Commited");
            }
            catch (SqlException ex)
            {
                trans.Rollback();
                MessageBox.Show("Error - Transaction Rolled Back\n" + ex.Message);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("System Error \n" + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
