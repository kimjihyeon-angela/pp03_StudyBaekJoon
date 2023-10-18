using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaekJoon5596
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string getMinScore = tbxMinScore.Text;
            string getManScore = tbxManScore.Text;

            int minTotalScore = 0;
            int manTotalScore = 0;

            string[] MinScore = getMinScore.Split(' ');

            int[] MinScoreNumber = MinScore
                .Select(str => int.Parse(str))
                .ToArray();

            string[] ManScore = getManScore.Split(' ');

            int[] ManScoreNumber = ManScore
                .Select(str => int.Parse(str))
                .ToArray();

            for (int i = 0; i < 4; i++)
            {
                minTotalScore = minTotalScore + MinScoreNumber[i];
                manTotalScore = manTotalScore + ManScoreNumber[i];
            }

            if (manTotalScore > minTotalScore)
            {
                lblResult.Text = manTotalScore.ToString();
            }
            else
            {
                lblResult.Text = minTotalScore.ToString();
            }

        }
    }
}
