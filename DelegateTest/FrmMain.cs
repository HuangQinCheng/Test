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
    public partial class FrmMain : Form
    {
        public ChildForm1 childForm1 { get; set; }
        public ChildForm2 childForm2 { get; set; }
        public FrmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            childForm1 = new ChildForm1();
            childForm1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            childForm2 = new ChildForm2();
            childForm1.OnSetText += childForm2.SetText;
           
            childForm2.Show();
        }
    }
}
