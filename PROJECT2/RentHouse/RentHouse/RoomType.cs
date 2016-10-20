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
    public partial class RoomType : Form
    {

        DataTable dt;
        DataRow dr;
        string code;

        public RoomType()
        {
            InitializeComponent();
            loadAll();
        }

        private void RoomType_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rent_houseDataSet.tb_type_room' table. You can move, or remove it, as needed.
            this.tb_type_roomTableAdapter.Fill(this.rent_houseDataSet.tb_type_room);
            tb_idcust.Enabled = false;
        }

        public void loadAll()
        {
            try
            {
                string MyConnection2 = "Data Source=KIDDY\\CCIT;Initial Catalog=rent_house;Persist Security Info=True;User ID=sa;Password=123456";
                //Display query  
                string Query = "select * from tb_type_room;";
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

        private void btn_add_Click(object sender, EventArgs e)
        {
            tb_idcust.Text = "";
            tb_name.Text = "";
            textBox1.Text = "";

            int ctr, len;
            string codeval;
            dt = rent_houseDataSet.Tables["tb_type_room"];
            len = dt.Rows.Count - 1;
            dr = dt.Rows[len];
            code = dr["id_type_room"].ToString();
            codeval = code.Substring(1, 3);
            ctr = Convert.ToInt32(codeval);
            if ((ctr >= 1) && (ctr < 9))
            {
                ctr = ctr + 1;
                tb_idcust.Text = "T00" + ctr;
            }
            else if ((ctr >= 9) && (ctr < 99))
            {
                ctr = ctr + 1;
                tb_idcust.Text = "T0" + ctr;
            }
            else if (ctr >= 99)
            {
                ctr = ctr + 1;
                tb_idcust.Text = "T" + ctr;
            }
        }

        private int ValidateData()
        {
            int flag = 0;
            if (tb_idcust.Text == "")
            {
                tb_idcust.Focus();
                errorProvider1.SetError(tb_idcust, "Please Fill in The ID");
                flag = 1;
            }
            if (tb_name.Text == "")
            {
                tb_name.Focus();
                errorProvider1.SetError(tb_name, "Please Fill in The Name");
                flag = 1;
            }
            if (textBox1.Text == "")
            {
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "Please Fill The Description");
                flag = 1;
            }
            return flag;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (ValidateData() == 0)
            {
                try
                {
                    //This is my connection string i have assigned the database file address path  
                    string MyConnection2 = "Data Source=KIDDY\\CCIT;Initial Catalog=rent_house;Persist Security Info=True;User ID=sa;Password=123456";
                    //This is my insert query in which i am taking input from the user through windows forms  
                    string Query = "insert into tb_type_room values('" + this.tb_idcust.Text + "','" + this.tb_name.Text + "','" + this.textBox1.Text + "');";
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
                    clear();
                    loadAll();
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

        public void clear()
        {
            tb_name.Text = "";
            textBox1.Text = "";
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (ValidateData() == 0)
            {
                try
                {
                    //This is my connection string i have assigned the database file address path  
                    string MyConnection2 = "Data Source=KIDDY\\CCIT;Initial Catalog=rent_house;Persist Security Info=True;User ID=sa;Password=123456";
                    //This is my insert query in which i am taking input from the user through windows forms  
                    string Query = "update tb_type_room set name='" + this.tb_name.Text + "', description='" + this.textBox1.Text + "' where id_type_room='" + this.tb_idcust.Text+"';";
                    //This is  MySqlConnection here i have created the object and pass my connection string.  
                    SqlConnection MyConn2 = new SqlConnection(MyConnection2);
                    //This is command class which will handle the query and connection object.  
                    SqlCommand MyCommand2 = new SqlCommand(Query, MyConn2);
                    SqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                    MessageBox.Show("Data Has Been Updated");
                    while (MyReader2.Read())
                    {

                    }
                    MyConn2.Close();
                    clear();
                    loadAll();
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
    }
}
