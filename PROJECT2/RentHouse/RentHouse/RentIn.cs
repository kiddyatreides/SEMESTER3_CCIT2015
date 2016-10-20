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
    public partial class RentIn : Form
    {
        DataTable dt;
        DataRow dr;
        string code;

        public RentIn()
        {
            InitializeComponent();
            cb_room();
            cb_customer();
            textBox1.Enabled = false;
        }

        public void cb_room()
        {
            try
            {
                string MyConnection2 = "Data Source=KIDDY\\CCIT;Initial Catalog=rent_house;Persist Security Info=True;User ID=sa;Password=123456";
                //Display query  
                string Query = "select * from tb_room Where status='Available';";
                SqlConnection MyConn2 = new SqlConnection(MyConnection2);
                SqlCommand MyCommand2 = new SqlCommand(Query, MyConn2);
                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                SqlDataAdapter MyAdapter = new SqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                cb_idroom.DataSource = dTable;
                cb_idroom.ValueMember = "id_room";
                cb_idroom.DisplayMember = "id_room";
                // MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void cb_customer()
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
                comboBox1.DataSource = dTable;
                comboBox1.ValueMember = "id_customer";
                comboBox1.DisplayMember = "id_customer";
                
                // MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RentIn_Load(object sender, EventArgs e)
        {
            cb_idroom.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;
            // TODO: This line of code loads data into the 'rent_houseDataSet.tb_rent' table. You can move, or remove it, as needed.
            this.tb_rentTableAdapter.Fill(this.rent_houseDataSet.tb_rent);
            grid();
            tb_idtrans.Enabled = false;

            int ctr, len;
            string codeval;
            dt = rent_houseDataSet.Tables["tb_rent"];
            len = dt.Rows.Count - 1;
            dr = dt.Rows[len];
            code = dr["id_rent"].ToString();
            codeval = code.Substring(1, 3);
            ctr = Convert.ToInt32(codeval);
            if ((ctr >= 1) && (ctr < 9))
            {
                ctr = ctr + 1;
                tb_idtrans.Text = "T00" + ctr;
            }
            else if ((ctr >= 9) && (ctr < 99))
            {
                ctr = ctr + 1;
                tb_idtrans.Text = "T0" + ctr;
            }
            else if (ctr >= 99)
            {
                ctr = ctr + 1;
                tb_idtrans.Text = "T" + ctr;
            }
        }

        public void grid()
        {
            try
            {
                string MyConnection2 = "Data Source=KIDDY\\CCIT;Initial Catalog=rent_house;Persist Security Info=True;User ID=sa;Password=123456";
                //Display query  
                string Query = "select * from tb_room where status = 'Available';";
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

        private int ValidateData()
        {
            int flag = 0;
            if (cb_idroom.Text == "")
            {
                cb_idroom.Focus();
                errorProvider1.SetError(cb_idroom, "Please Fill in The Name");
                flag = 1;
            }
            if (comboBox1.Text == "")
            {
                comboBox1.Focus();
                errorProvider1.SetError(comboBox1, "Please Fill in The Type");
                flag = 1;
            }
            
            return flag;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateData() == 0)
            {
                try
                {
                    //This is my connection string i have assigned the database file address path  
                    string MyConnection2 = "Data Source=KIDDY\\CCIT;Initial Catalog=rent_house;Persist Security Info=True;User ID=sa;Password=123456";
                    //This is my insert query in which i am taking input from the user through windows forms  
                    string Query = "insert into tb_rent (id_rent,id_customer,id_room,date_time) values('" + this.tb_idtrans.Text +"','" + this.comboBox1.Text +"','" + this.cb_idroom.Text +"','" + DateTime.Now +"');";
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
                    grid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please Fix The Error");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //This is my connection string i have assigned the database file address path  
                string MyConnection2 = "Data Source=KIDDY\\CCIT;Initial Catalog=rent_house;Persist Security Info=True;User ID=sa;Password=123456";
                //This is my insert query in which i am taking input from the user through windows forms  
                string Query = "select * from tb_customer where id_customer='" + this.comboBox1.Text + "';";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                SqlConnection MyConn2 = new SqlConnection(MyConnection2);
                //This is command class which will handle the query and connection object.  
                SqlCommand MyCommand2 = new SqlCommand(Query, MyConn2);
                SqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                while (MyReader2.Read())
                {
                    textBox1.Text = (MyReader2["name"].ToString());
                }
                MyConn2.Close();
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
                string Query = "select * from tb_room where status = 'Available' AND id_room like '%" + tb_search.Text + "%' OR  name like '%" + tb_search.Text + "%' OR id_type_room like '%" + tb_search.Text + "%' OR status like '%" + tb_search.Text + "%' OR price like '%" + tb_search.Text + "%' ;";
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
    }
}
