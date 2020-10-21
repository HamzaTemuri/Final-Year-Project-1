using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        OleDbConnection connection = new OleDbConnection();
        public Form2()
        {
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\osama\Documents\Database1.accdb;Persist Security Info=False;";
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "select * from Table1 where Username = '"+txt_username.Text+"' and Password = '"+txt_password.Text+"'";
            OleDbDataReader reader =  command.ExecuteReader();
            int count = 0;
            while(reader.Read())
            {
                count++;
            }
            if(count == 1)
            {
                //MessageBox.Show("Username and Password is correct");
                Form5 f5 = new Form5();
                this.Hide();
                f5.Show();
            }
            else
            {
                MessageBox.Show("Incorrect username or password");
            }
            connection.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 f4 = new Form4();
            this.Hide();
            f4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
