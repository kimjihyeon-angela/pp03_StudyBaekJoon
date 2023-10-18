using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaekJoon5575
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string getA = tbxA.Text;
            string[] A = getA.Split(' ');

            int[] timeA = A
                .Select(str => int.Parse(str))
                .ToArray();

            for (int i = 0; i < timeA.Length; i++)
            {
                Debug.WriteLine(timeA[i].ToString());
                int h1 = timeA[0];
                int m1 = timeA[1];
                int s1 = timeA[2];
                int h2 = timeA[3];
                int m2 = timeA[4];
                int s2 = timeA[5];

                int s = 0;
                int m = 0;
                int h = 0;

                if (s2 - s1 <0)
                {
                    s = s2 - s1 + 60;
                    m2 -= 1;
                }

                if (m2 - m1 < 0)
                {
                    m = m2 - m1 + 60;
                    h2 -= 1;
                }

                h = h2 - h1;

                lblA.Text = h.ToString() + ' ' + m.ToString() + ' ' + s.ToString();
            }

            string getB = tbxB.Text;
            string[] B = getB.Split(' ');

            int[] timeB = B
                .Select(str => int.Parse(str))
                .ToArray();

            for (int i = 0; i < timeB.Length; i++)
            {
                Debug.WriteLine(timeB[i].ToString());
                int h1 = timeB[0];
                int m1 = timeB[1];
                int s1 = timeB[2];
                int h2 = timeB[3];
                int m2 = timeB[4];
                int s2 = timeB[5];

                int s = 0;
                int m = 0;
                int h = 0;

                if (s2 - s1 < 0)
                {
                    s = s2 - s1 + 60;
                    m2 -= 1;
                }

                if (m2 - m1 < 0)
                {
                    m = m2 - m1 + 60;
                    h2 -= 1;
                }

                h = h2 - h1;

                lblB.Text = h.ToString() + ' ' + m.ToString() + ' ' + s.ToString();
            }

            string getC = tbxC.Text;
            string[] C = getC.Split(' ');

            int[] timeC = C
                .Select(str => int.Parse(str))
                .ToArray();

            for (int i = 0; i < timeC.Length; i++)
            {
                Debug.WriteLine(timeC[i].ToString());
                int h1 = timeC[0];
                int m1 = timeC[1];
                int s1 = timeC[2];
                int h2 = timeC[3];
                int m2 = timeC[4];
                int s2 = timeC[5];

                int s = 0;
                int m = 0;
                int h = 0;

                if (s2 - s1 < 0)
                {
                    s = s2 - s1 + 60;
                    m2 -= 1;
                }

                if (m2 - m1 < 0)
                {
                    m = m2 - m1 + 60;
                    h2 -= 1;
                }

                h = h2 - h1;

                lblC.Text = h.ToString() + ' ' + m.ToString() + ' ' + s.ToString();
            }
        }
    }
}
