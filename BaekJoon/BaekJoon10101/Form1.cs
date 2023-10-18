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

namespace BaekJoon10101
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = rtbInput.Lines.Length;
            int b = 0;
            int c = 0;
            int d = 0;

            for (int i = 0; i < a; i++)
            {
                b = int.Parse(rtbInput.Lines[0]);
                c = int.Parse(rtbInput.Lines[1]);
                d = int.Parse(rtbInput.Lines[2]);
            }

            if (b == 60 && c == 60 && d == 60 )
            {
                lblResult.Text = "Equilateral";
            }
            else if (b + c + d == 180 && (b == c || c == d))
            {
                lblResult.Text = "Isosceles";
            }
            else if (b + c + d == 180)
            {
                lblResult.Text = "Scalene";
            }
            else
            {
                lblResult.Text = "Error";
            }
        }
    }
}
