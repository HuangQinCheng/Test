using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerTest
{
    public partial class Form1 : Form
    {
        int iNumber;
        int iCurrentNumber;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                comboBox1.Items.Add(i);
            }
            label3.Text = "0秒";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            iNumber = Convert.ToInt32(comboBox1.Text);
            label3.Text = iNumber + "秒";
            iCurrentNumber = 0;
            progressBar1.Maximum = iNumber;
            timer1.Start();
 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            iCurrentNumber++;
            
            progressBar1.Value = iCurrentNumber;
            label3.Text = (iNumber - iCurrentNumber) + "秒";
            if (iCurrentNumber == iNumber)
            {
                timer1.Stop();
                System.Media.SystemSounds.Asterisk.Play();
                MessageBox.Show("倒计时结束", "提示");
            }
        }
    }
}
