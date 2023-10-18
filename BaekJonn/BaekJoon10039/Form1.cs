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

namespace BaekJoon10039
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = rtbScore.Text.Count();
            int b = rtbScore.Lines.Length; // richtextbox의 줄 수 찾아냄
            int sum = 0;
            int avg = 0;

            Debug.WriteLine(a.ToString()); // a = 숫자, 공백 모두 출력됨 ex) 1 \n 2 => 3
            Debug.WriteLine(b.ToString()); // ex) 1\ 2 => 2

            for (int i = 0; i < b; i++)
            {
                Debug.WriteLine(rtbScore.Lines[i]);
                int score = int.Parse(rtbScore.Lines[i]);
                if (score < 40)
                {
                    score = 40;
                }
                sum = sum + score;
            }
            avg = sum / 5;
            Debug.WriteLine("sum :  " + sum.ToString());
            lblResult.Text = avg.ToString();
        }
    }
}
