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
    public partial class Form6 : Form
    {
        bool flag = false;
        public Form6()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //var workingDirectory = Path.GetFullPath(@"C:\Users\Hamza\Desktop\FYP\keras-frcnn");
            //var process = new Process
            //{
            //    StartInfo = new ProcessStartInfo
            //    {
            //        FileName = "cmd.exe",
            //        //WindowStyle = ProcessWindowStyle.Hidden,
            //        RedirectStandardInput = true,
            //        UseShellExecute = false,
            //        RedirectStandardOutput = true,
            //        WorkingDirectory = workingDirectory
            //    }
            //};
            //process.Start();

            //// Pass multiple commands to cmd.exe
            //using (var sw = process.StandardInput)
            //{
            //    if (sw.BaseStream.CanWrite)
            //    {
            //        // Vital to activate Anaconda
            //        //sw.WriteLine("C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\anaconda3\\Scripts\\activate.bat");
            //        // Activate your environment
            //        sw.WriteLine("conda activate tensorflow");
            //        // Any other commands you want to run
            //        sw.WriteLine("python test_frcnn.py -p test_images");
            //        // run your script. You can also pass in arguments
            //        //sw.WriteLine("");
            //    }
            //}
            //// read multiple output lines
            //while (!process.StandardOutput.EndOfStream)
            //{
            //    var line = process.StandardOutput.ReadLine();
            //    Console.WriteLine(line);
            //}
            //Console.ReadKey();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                Form7 f7 = new Form7();
                this.Hide();
                f7.Show();
            }
            else
            {
                MessageBox.Show("Press Test First");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Set working directory and create process
            var workingDirectory = Path.GetFullPath(@"C:\Users\Hamza\Desktop\FYP\keras-frcnn");
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
                    // Vital to activate Anaconda
                    //sw.WriteLine("C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\anaconda3\\Scripts\\activate.bat");
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
            flag = true;
            //Console.ReadKey();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
