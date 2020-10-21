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
    public partial class Form4 : Form
    {
        OleDbConnection connection = new OleDbConnection();
        public Form4()
        {
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\osama\Documents\Database1.accdb;Persist Security Info=False;";
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "insert into Table1 ([Firstname],[Lastname], [Username], [Password]) values('"+txt_fname.Text+ "','"+txt_lname.Text+ "','"+txt_uname.Text+ "','"+txt_password.Text+"')";
                MessageBox.Show("Created");

                Form2 f2 = new Form2();
                this.Hide();
                f2.Show();

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
