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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            
        }
        int step = 0;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            switch(step)
            {
                case 0:
                    label1.Text = "Loading.";
                    break;
                case 1:
                    label1.Text = "Loading..";
                    break;
                case 2:
                    label1.Text = "Loading...";
                    break;
                case 3:
                    label1.Text = "Initializing Modules...100%";
                    break;
                case 4:
                    label1.Text = "Initializing UI...100%";
                    break;
                case 5:
                    label1.Text = "Initializing Plugins...100%";
                    break;
                case 6:
                    label1.Text = "Starting System...";
                    break;
                case 7:
                    UseWaitCursor = false;
                    this.Hide();
                    Form1 f1 = new Form1();
                    f1.Show();
                    break;
            }
            step++;
        }
    }
}
