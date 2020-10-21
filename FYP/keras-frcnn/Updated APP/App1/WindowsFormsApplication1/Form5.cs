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
        bool flag = false;
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(@"c:\users\Hamza\Desktop\FYP\keras-frcnn\test_images");
            foreach(FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            try
            {
                Process.Start(@"c:\users\Hamza\Desktop\FYP\keras-frcnn\test_images");
                //flag = true;
            }
            catch (Win32Exception win32Exception)
            {
                //The system cannot find the file specified...
                Console.WriteLine(win32Exception.Message);
            }
            foreach (FileInfo file in di.GetFiles())
            {
                flag = file.Exists;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    Process.Start(@"c:\users\Hamza\Desktop\FYP\keras-frcnn\results_imgs");
            //}
            //catch (Win32Exception win32Exception)
            //{
            //    //The system cannot find the file specified...
            //    Console.WriteLine(win32Exception.Message);
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(@"c:\users\Hamza\Desktop\FYP\keras-frcnn\test_images");
            foreach (FileInfo file in di.GetFiles())
            {
                flag = file.Exists;
            }
            if (flag)
            {
                Form6 f6 = new Form6();
                this.Hide();
                f6.Show();
            }
            else
            {
                MessageBox.Show("Upload Imges First");
            }
            //Form6 f6 = new Form6();
            //this.Hide();
            //f6.Show();
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

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
