using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaekJoon5554
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int htos = int.Parse(tbxhtos.Text);
            int stop = int.Parse(tbxstop.Text);
            int ptoa = int.Parse(tbxptoa.Text);
            int atoh = int.Parse(tbxatoh.Text);

            int totalSec = htos + stop + ptoa + atoh;
            int Min = totalSec / 60;
            int Sec = totalSec - (Min * 60);

            lblMin.Text = Min.ToString() + "분";
            lblSec.Text = Sec.ToString() + "초";
        }
    }
}
