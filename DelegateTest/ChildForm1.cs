using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateTest
{
    public delegate void SetTextDel(string text);
    public partial class ChildForm1 : Form
    {
        public event SetTextDel OnSetText;
        public ChildForm1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OnSetText(textBox1.Text);
        }
    }
}
