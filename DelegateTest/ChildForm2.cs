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
    public partial class ChildForm2 : Form
    {
        public ChildForm2()
        {
            InitializeComponent();
        }

        private void ChildForm2_Load(object sender, EventArgs e)
        {

        }

        public void SetText(string text)
        {
            textBox1.Text = text;
        }
    }
}
