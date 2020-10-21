using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            Show_img();
        }

        void Show_img()
        {
            //using (Bitmap bmp = new Bitmap("C:\\Users\\Hamza\\Desktop\\FYP\\keras-frcnn\\results_imgs\\0.png"))
            //{
            //    pictureBox1.Image = bmp;
            //}
            Bitmap bmp = new Bitmap("C:\\Users\\Hamza\\Desktop\\FYP\\keras-frcnn\\results_imgs\\0.png");

            pictureBox1.Image = bmp;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Bitmap bmp = new Bitmap("C:\\Users\\Hamza\\Desktop\\FYP\\keras-frcnn\\results_imgs\\0.png");
            //pictureBox1.Image = bmp;
            //bmp.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //pictureBox1.Dispose();
            //Form1 f1 = new Form1();
            //this.Dispose();
            //GC.Collect();

            //pictureBox1 = null;

            //DirectoryInfo di = new DirectoryInfo(@"C:\Users\Hamza\Desktop\FYP\keras-frcnn\results_imgs");
            //foreach (FileInfo file in di.GetFiles())
            //{
            //    file.Delete();
            //}
            this.Close();
            //f1.Show();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
