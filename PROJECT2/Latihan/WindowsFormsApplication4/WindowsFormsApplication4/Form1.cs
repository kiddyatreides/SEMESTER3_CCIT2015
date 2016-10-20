using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Data.SqlClient;
using System.Xml.Schema;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source=(local)\\CCIT;Initial Catalog=latihan;Persist Security Info=True;User ID=sa;Password=123456";

        public Form1()
        {
            InitializeComponent();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM tb_employee", connection);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset, "tb_employee");
            dataset.WriteXml("D:\\employee.xml");
            MessageBox.Show("XML File Created !");
            connection.Close();
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            XmlTextReader reader = new XmlTextReader("D:\\employee.xml");
            reader.Read();
            doc.Load(reader);
            XmlElement element = doc.CreateElement("tb_employee");
            XmlElement code = doc.CreateElement("code");
            XmlText textCode = doc.CreateTextNode("E002");
            XmlElement name = doc.CreateElement("name");
            XmlText textName = doc.CreateTextNode("Ojan");
            XmlElement address = doc.CreateElement("address");
            XmlText textAddress = doc.CreateTextNode("Kebayoran");
            XmlElement state = doc.CreateElement("state");
            XmlText textState = doc.CreateTextNode("Jakarta");
            XmlElement country = doc.CreateElement("country");
            XmlText textCountry = doc.CreateTextNode("Indonesia");
            XmlElement designation = doc.CreateElement("designation");
            XmlText textDesignation = doc.CreateTextNode("Office Boy");
            XmlElement departement = doc.CreateElement("Departement");
            XmlText textDepartement = doc.CreateTextNode("Office");

            doc.DocumentElement.AppendChild(element);
            doc.DocumentElement.LastChild.AppendChild(code);
            doc.DocumentElement.LastChild.LastChild.AppendChild(textCode);
            doc.DocumentElement.LastChild.AppendChild(name);
            doc.DocumentElement.LastChild.LastChild.AppendChild(textName);
            doc.DocumentElement.LastChild.AppendChild(address);
            doc.DocumentElement.LastChild.LastChild.AppendChild(textAddress);
            doc.DocumentElement.LastChild.AppendChild(state);
            doc.DocumentElement.LastChild.LastChild.AppendChild(textState);
            doc.DocumentElement.LastChild.AppendChild(country);
            doc.DocumentElement.LastChild.LastChild.AppendChild(textCountry);
            doc.DocumentElement.LastChild.AppendChild(designation);
            doc.DocumentElement.LastChild.LastChild.AppendChild(textDesignation);
            doc.DocumentElement.LastChild.AppendChild(departement);
            doc.DocumentElement.LastChild.LastChild.AppendChild(textDepartement);
            doc.Save("D:\\new-employee.xml");
            MessageBox.Show("Details have been stored");


        }  

        private void cmdTotal_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            XmlTextReader reader = new XmlTextReader("D:\\employee.xml");
            reader.Read();
            doc.Load(reader);
            XmlNode root = doc.DocumentElement;
            int count = root.ChildNodes.Count;
            string countStr = count.ToString();
            MessageBox.Show("Total Employee : " + countStr);
        }

         
    }
}
