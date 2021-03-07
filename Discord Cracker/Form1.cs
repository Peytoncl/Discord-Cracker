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

namespace Discord_Rat_V1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "";

            if (richTextBox1.Text == "") { richTextBox2.Text = "PLEASE ENTER A TOKEN"; return; } 

            string filetext = File.ReadAllText(Application.StartupPath + "/token_login.txt");
            richTextBox2.Text = filetext + richTextBox1.Text + "')";

            System.Diagnostics.Process.Start(Application.StartupPath + "/rungoogle.bat");

            await Task.Delay(700);
            this.TopMost = true;
            await Task.Delay(500);
            this.TopMost = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + "/opengithub.bat");
        }
    }
}
