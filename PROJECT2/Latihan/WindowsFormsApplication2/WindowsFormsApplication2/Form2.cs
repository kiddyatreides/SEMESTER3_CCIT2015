using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace WindowsFormsApplication2
{
    public partial class Form2 : Form
    {
        Image curImage;
        string curFileName;
        string connectionString = "Data Source=(local)/CCIT;Initial Catalog=latihan;Persist Security Info=True;User ID=sa;Password=123456";
        string savedImageName = "";

        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtFileName.Text != "")
            {
                FileStream file = new FileStream(curFileName, FileMode.OpenOrCreate, FileAccess.Read);
                byte[] rawdata = new byte[file.Length];
                file.Read(rawdata, 0, System.Convert.ToInt32(file.Length));
                file.Close();
                string sql = "SELECT * FROM tb_employee";
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = connectionString;
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);
                DataSet ds = new DataSet("tb_employee");
                adapter.Fill(ds, "tb_employee");
                DataRow row = ds.Tables["tb_employee"].NewRow();
                row["code"] = "E001";
                row["name"] = "Dhana";
                row["address"] = "Jakarta";



            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void cmdBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDlg = new OpenFileDialog();
            if(openDlg.ShowDialog() == DialogResult.OK)
            {
                curFileName = openDlg.FileName;
                txtFileName.Text = curFileName;
            }
        }
    }
}
