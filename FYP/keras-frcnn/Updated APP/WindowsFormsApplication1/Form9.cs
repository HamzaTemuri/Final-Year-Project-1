using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            Bitmap bmp = new Bitmap("C:\\Users\\Osama\\Desktop\\Final Year Project\\keras-frcnn\\results_imgs\\0.png");

            pictureBox1.Image = bmp;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap("C:\\Users\\Osama\\Desktop\\Final Year Project\\keras-frcnn\\results_imgs\\0.png");

            pictureBox1.Image = bmp;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }
    }
}
