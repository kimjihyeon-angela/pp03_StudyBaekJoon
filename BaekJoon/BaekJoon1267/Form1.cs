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

namespace BaekJoon1267
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(rtbInput.Lines[0]);

            Debug.WriteLine(rtbInput.Lines[1]);

            int count = int.Parse(rtbInput.Lines[0]);

            int sumY = 0;
            int sumM = 0;

            string[] input = rtbInput.Lines[1].Split(' ');

            int[] numbers = input
                .Select(str => int.Parse(str))
                .ToArray();

            for (int i = 0; i < count ; i++)
            {
                int moneyY = 10;
                int moneyM = 15;

                if (numbers[i] < 30)
                {
                    moneyY = 10;
                    sumY = sumY + moneyY;
                }
                else if ((numbers[i] / 30) >= 1)
                {
                    moneyY = moneyY + ((numbers[i] / 30) * 10);
                    Debug.WriteLine(moneyY.ToString());
                    sumY = sumY + moneyY;
                    Debug.WriteLine(sumY);
                }

                if (numbers[i] < 60)
                {
                    moneyM = 15;
                    sumM = sumM + moneyM;
                }
                else if ((numbers[i] / 60) >= 1)
                {
                    moneyM = moneyM + ((numbers[i] / 60) * 15);
                    sumM = sumM + moneyM;
                }

            }

            if (sumY < sumM)
            {
                lblResult.Text = "Y " + sumY.ToString();
            }
            else if (sumY == sumM)
            {
                lblResult.Text = "Y M " + sumY.ToString();
            }
            else
            {
                lblResult.Text = "M " + sumM.ToString();
            }

        }
    }
}
