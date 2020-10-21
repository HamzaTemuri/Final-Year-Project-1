using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(@"c:\users\osama\Desktop\Final Year Project\keras-frcnn\test_images");
            foreach(FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            try
            {
                Process.Start(@"c:\users\osama\Desktop\Final Year Project\keras-frcnn\test_images");
            }
            catch (Win32Exception win32Exception)
            {
                //The system cannot find the file specified...
                Console.WriteLine(win32Exception.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"c:\users\osama\Desktop\Final Year Project\keras-frcnn\results_imgs");
            }
            catch (Win32Exception win32Exception)
            {
                //The system cannot find the file specified...
                Console.WriteLine(win32Exception.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            this.Hide();
            f6.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
