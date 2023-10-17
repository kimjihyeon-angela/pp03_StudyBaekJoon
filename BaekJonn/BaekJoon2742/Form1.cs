using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaekJoon2742
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var number = Convert.ToInt32(tbxNumber.Text);

            for (int i = number; i > 0; i--)
            {
                rtbResult.AppendText(i.ToString() + "\n");
                Debug.WriteLine(i.ToString());
            }
        }
    }
}
