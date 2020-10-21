using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        Image File;
        public static string Fname = "";
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(@"C:\Users\Osama\Desktop\Final Year Project\keras-frcnn\test_images");
            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            if (open.ShowDialog() == DialogResult.OK)
            {
                File = Image.FromFile(open.FileName);
                Fname = open.SafeFileName;
                // display image in picture box  
                pictureBox1.Image = new Bitmap(open.FileName);
                // image file path  
                textBox1.Text = open.FileName;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DirectoryInfo di = new DirectoryInfo(@"C:\Users\Osama\Desktop\Final Year Project\keras-frcnn\results_imgs");
            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            File.Save("C:\\Users\\Osama\\Desktop\\Final Year Project\\keras-frcnn\\test_images\\" + Fname);
            // Set working directory and create process
            var workingDirectory = Path.GetFullPath(@"C:\Users\Osama\Desktop\Final Year Project\keras-frcnn");
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    //WindowStyle = ProcessWindowStyle.Hidden,
                    RedirectStandardInput = true,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    WorkingDirectory = workingDirectory
                }
            };
            process.Start();

            // Pass multiple commands to cmd.exe
            using (var sw = process.StandardInput)
            {
                if (sw.BaseStream.CanWrite)
                {
                    // Activate your environment
                    sw.WriteLine("conda activate tensorflow");
                    // Any other commands you want to run
                    sw.WriteLine("python test_frcnn.py -p test_images");
                    // run your script. You can also pass in arguments
                    //sw.WriteLine("");
                }
            }
            // read multiple output lines
            while (!process.StandardOutput.EndOfStream)
            {
                var line = process.StandardOutput.ReadLine();
                Console.WriteLine(line);
            }
            //Process.Start(@"C:\Users\Hamza\Desktop\FYP\keras-frcnn\results_imgs\0.png");

            Form9 f9 = new Form9();
            this.Hide();
            f9.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
