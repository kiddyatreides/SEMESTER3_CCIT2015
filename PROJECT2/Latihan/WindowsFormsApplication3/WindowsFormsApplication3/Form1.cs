using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        private static string GetConnectionString()
        {
            return "Data Source=KIDDY\\CCIT;Initial Catalog=latihan;Persist Security Info=True;User ID=sa;Password=123456";
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmdBulkCopy_Click(object sender, EventArgs e)
        {
            string connectionString = GetConnectionString();
            using (SqlConnection sourceConnection = new SqlConnection(connectionString))
            {
                sourceConnection.Open();
                SqlCommand commandSourceData = new SqlCommand("SELECT * FROM tb_employee;", sourceConnection);
                SqlDataReader reader = commandSourceData.ExecuteReader();
                using (SqlConnection destinationConnection = new SqlConnection(connectionString))
                {
                    destinationConnection.Open();
                    using (SqlBulkCopy bulkCopy = new SqlBulkCopy(destinationConnection))
                    {
                        bulkCopy.DestinationTableName = "tb_employee";
                        try
                        {
                            bulkCopy.WriteToServer(reader);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            reader.Close();
                        }
                    }
                }
            }
            MessageBox.Show("Data has been successfully coppied");
        }
    }
}
