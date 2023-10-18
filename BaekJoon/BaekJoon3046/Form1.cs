using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaekJoon3046
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r1 = int.Parse(tbxR1.Text);
            int s = int.Parse(tbxS.Text);

            // s = (r1 + r2)/2
            // s * 2 = r1+ r2 
            int r2 = s * 2 - r1;

            lblResult.Text = r2.ToString();
        }
    }
}
