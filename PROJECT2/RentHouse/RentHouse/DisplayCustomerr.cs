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
    public partial class DisplayCustomerr : Form
    {
        public DisplayCustomerr()
        {
            InitializeComponent();
        }

        private void DisplayCustomerr_Load(object sender, EventArgs e)
        {
            loadAll();
        }



        public void loadAll()
        {
            try
            {
                string MyConnection2 = "Data Source=KIDDY\\CCIT;Initial Catalog=rent_house;Persist Security Info=True;User ID=sa;Password=123456";
                //Display query  
                string Query = "select * from tb_customer;";
                SqlConnection MyConn2 = new SqlConnection(MyConnection2);
                SqlCommand MyCommand2 = new SqlCommand(Query, MyConn2);
                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                SqlDataAdapter MyAdapter = new SqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dg_customer.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
                // MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "Data Source=KIDDY\\CCIT;Initial Catalog=rent_house;Persist Security Info=True;User ID=sa;Password=123456";
                //Display query  
                string Query = "select * from tb_customer where name like '%" + tb_search.Text + "%' OR card_type like '%" + tb_search.Text + "%' OR phone like '%" + tb_search.Text + "%' OR address like '%" + tb_search.Text + "%' OR gender like '%" + tb_search.Text + "%' OR id_no like '%" + tb_search.Text + "%' OR birthdate like '%" + tb_search.Text + "%';";
                SqlConnection MyConn2 = new SqlConnection(MyConnection2);
                SqlCommand MyCommand2 = new SqlCommand(Query, MyConn2);
                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                SqlDataAdapter MyAdapter = new SqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dg_customer.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
                //MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadAll();
        }
    }
}
