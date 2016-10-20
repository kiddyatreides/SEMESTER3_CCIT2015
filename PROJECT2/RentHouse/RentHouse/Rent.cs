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
    public partial class Rent : Form
    {

        DataTable dt;
        DataRow dr;
        string code;


        public Rent()
        {
            InitializeComponent();
            cb_trans();
        }

        private void cb_idroom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void cb_trans()
        {
            try
            {
                string MyConnection2 = "Data Source=KIDDY\\CCIT;Initial Catalog=rent_house;Persist Security Info=True;User ID=sa;Password=123456";
                //Display query  
                string Query = "select * from tb_rent Where date_out IS NULL;";
                SqlConnection MyConn2 = new SqlConnection(MyConnection2);
                SqlCommand MyCommand2 = new SqlCommand(Query, MyConn2);
                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                SqlDataAdapter MyAdapter = new SqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                cb_idtrans.DataSource = dTable;
                cb_idtrans.ValueMember = "id_rent";
                cb_idtrans.DisplayMember = "id_rent";
                // MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }

        private void Rent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rent_houseDataSet1.tb_rent' table. You can move, or remove it, as needed.
            this.tb_rentTableAdapter.Fill(this.rent_houseDataSet1.tb_rent);
            // TODO: This line of code loads data into the 'rent_houseDataSet.tb_rent' table. You can move, or remove it, as needed.
            this.tb_rentTableAdapter.Fill(this.rent_houseDataSet.tb_rent);

            
            

            try
            {
                string MyConnection2 = "Data Source=KIDDY\\CCIT;Initial Catalog=rent_house;Persist Security Info=True;User ID=sa;Password=123456";
                //Display query  
                string Query = "select * from tb_rent where date_out IS NULL;";
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

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tb_rentTableAdapter.FillBy(this.rent_houseDataSet.tb_rent);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.tb_rentTableAdapter.FillBy(this.rent_houseDataSet.tb_rent);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tb_rentTableAdapter.FillBy1(this.rent_houseDataSet.tb_rent);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tb_rentTableAdapter.FillBy2(this.rent_houseDataSet.tb_rent);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            
        }

        private void availableToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tb_roomTableAdapter.available(this.rent_houseDataSet1.tb_room);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private int ValidateData()
        {
            int flag = 0;
            if (cb_idtrans.Text == "")
            {
                cb_idtrans.Focus();
                errorProvider1.SetError(cb_idtrans, "Please Fill in The DateOut");
                flag = 1;
            }
            return flag;
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
                    string Query = "update tb_rent set date_out='" + DateTime.Today + "' where id_rent ='" + this.cb_idtrans.Text + "';";
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

        private void fillBy3ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tb_rentTableAdapter.FillBy3(this.rent_houseDataSet.tb_rent);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cb_idtrans_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
