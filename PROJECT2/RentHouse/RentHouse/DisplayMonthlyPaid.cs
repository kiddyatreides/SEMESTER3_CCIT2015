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
    public partial class DisplayMonthlyPaid : Form
    {
        public DisplayMonthlyPaid()
        {
            InitializeComponent();
            tb_total.Enabled = false;
            tb_idtrans.Enabled = false;
            tb_idroom.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void DisplayMonthlyPaid_Load(object sender, EventArgs e)
        {
            loadAll();
            loadAllTransaction();
        }

        public void loadAllTransaction()
        {
            try
            {
                string MyConnection2 = "Data Source=KIDDY\\CCIT;Initial Catalog=rent_house;Persist Security Info=True;User ID=sa;Password=123456";
                //Display query  
                string Query = "SELECT A.date_time,A.id_rent,D.name,B.id_room,C.price,A.description from tb_monthly_paid A, tb_rent B, tb_room C,tb_customer D WHERE A.id_rent = B.id_rent AND B.id_room = C.id_room AND B.id_customer = D.id_customer order by date_time DESC;";
                SqlConnection MyConn2 = new SqlConnection(MyConnection2);
                SqlCommand MyCommand2 = new SqlCommand(Query, MyConn2);
                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                SqlDataAdapter MyAdapter = new SqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
                // MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void loadAll()
        {
            try
            {
                string MyConnection2 = "Data Source=KIDDY\\CCIT;Initial Catalog=rent_house;Persist Security Info=True;User ID=sa;Password=123456";
                //Display query  
                string Query = "SELECT A.id_rent,A.date_time,B.name,A.id_room,C.price from tb_rent A, tb_customer B, tb_room C WHERE A.id_room = C.id_room AND A.id_customer = B.id_customer AND A.date_out IS NULL;";
                SqlConnection MyConn2 = new SqlConnection(MyConnection2);
                SqlCommand MyCommand2 = new SqlCommand(Query, MyConn2);
                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                SqlDataAdapter MyAdapter = new SqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dg_monthly.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
                // MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dg_monthly_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dg_monthly.Rows[e.RowIndex];
            tb_idtrans.Text = row.Cells[0].Value.ToString();
            tb_idroom.Text = row.Cells[3].Value.ToString();
            tb_total.Text = row.Cells[4].Value.ToString();

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "Data Source=KIDDY\\CCIT;Initial Catalog=rent_house;Persist Security Info=True;User ID=sa;Password=123456";
                //Display query  
                string Query = "SELECT A.id_rent,A.date_time,B.name,A.id_room,C.price from tb_rent A, tb_customer B, tb_room C where B.name like '%" + tb_search.Text + "%' AND A.id_room = C.id_room AND A.id_customer = B.id_customer AND A.date_out IS NULL;";
                SqlConnection MyConn2 = new SqlConnection(MyConnection2);
                SqlCommand MyCommand2 = new SqlCommand(Query, MyConn2);
                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                SqlDataAdapter MyAdapter = new SqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dg_monthly.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
                //MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "Data Source=KIDDY\\CCIT;Initial Catalog=rent_house;Persist Security Info=True;User ID=sa;Password=123456";
                //Display query  
                string Query = "SELECT A.date_time,A.id_rent,D.name,B.id_room,C.price from tb_monthly_paid A, tb_rent B, tb_room C,tb_customer D WHERE D.name like '%" + textBox1.Text + "%' AND A.id_rent = B.id_rent AND B.id_room = C.id_room AND B.id_customer = D.id_customer order by date_time DESC;";
                SqlConnection MyConn2 = new SqlConnection(MyConnection2);
                SqlCommand MyCommand2 = new SqlCommand(Query, MyConn2);
                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                SqlDataAdapter MyAdapter = new SqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
                //MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int ValidateData()
        {
            int flag = 0;
            if (tb_idroom.Text == "")
            {
                tb_idroom.Focus();
                errorProvider1.SetError(tb_idroom, "Please Fill in The ID Room");
                flag = 1;
            }
            if (tb_idtrans.Text == "")
            {
                tb_idtrans.Focus();
                errorProvider1.SetError(tb_idtrans, "Please Fill in The ID Transaction");
                flag = 1;
            }
            if (tb_total.Text == "")
            {
                tb_total.Focus();
                errorProvider1.SetError(tb_total, "Please Fill The Total Price");
                flag = 1;
            }
            if (textBox2.Text == "")
            {
                textBox2.Focus();
                errorProvider1.SetError(textBox2, "Please Fill The Description");
                flag = 1;
            }
            return flag;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (ValidateData() == 0)
            {
                try
                {
                    //This is my connection string i have assigned the database file address path  
                    string MyConnection2 = "Data Source=KIDDY\\CCIT;Initial Catalog=rent_house;Persist Security Info=True;User ID=sa;Password=123456";
                    //This is my insert query in which i am taking input from the user through windows forms  
                    string Query = "insert into tb_monthly_paid (id_rent,date_time,total,description) values('" + this.tb_idtrans.Text + "','" + DateTime.Today + "','" + this.tb_total.Text + "','" + this.textBox2.Text + "');";
                    //This is  MySqlConnection here i have created the object and pass my connection string.  
                    SqlConnection MyConn2 = new SqlConnection(MyConnection2);
                    //This is command class which will handle the query and connection object.  
                    SqlCommand MyCommand2 = new SqlCommand(Query, MyConn2);
                    SqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                    MessageBox.Show("Data Has Been Added");
                    while (MyReader2.Read())
                    {
                    }
                    MyConn2.Close();
                    loadAllTransaction();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}

