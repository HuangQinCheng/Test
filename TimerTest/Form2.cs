using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerTest
{
    public delegate void SetTextDelegate(int a,int b);
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetTextDelegate delsetText = new SetTextDelegate(AddNum);
            delsetText(1, 2);
        }

        private void AddNum(int x,int y)
        {
            Console.WriteLine(x + y);
        }
    }
}
