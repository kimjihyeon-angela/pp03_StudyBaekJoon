using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaekJoon5532
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vacation = int.Parse(tbxVacation.Text);
            int homework1 = int.Parse(tbxHomeWork1.Text);
            int maxhomework1 = int.Parse(tbxMaxHomeWork1.Text);
            int math = int.Parse(tbxMath.Text);
            int maxmath = int.Parse(tbxMaxMath.Text);

            int homework1date = 0;
            int mathdate = 0;
            int totaldate = 0;
            
            int datehomework = homework1 % maxhomework1;
            int datemath = math % maxmath;



            if (datehomework >= 1 )
            {
                homework1date = (homework1 / maxhomework1) + 1;
            }
            else
            {
                homework1date = (homework1 / maxhomework1);
            }

            if ( datemath >= 1)
            {
                mathdate = (math / maxmath) + 1;
            }
            else
            {
                mathdate = (math / maxmath);
            }

            if (homework1date >= mathdate)
            {
                totaldate = homework1date;
            }
            else
            {
                totaldate = mathdate;
            }

            lblResult.Text = (vacation - totaldate).ToString() + "일";
        }
    }
}
