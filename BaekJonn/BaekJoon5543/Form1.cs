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

namespace BaekJoon5543
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int burger1 = int.Parse(tbxBurger1.Text);
            int burger2 = int.Parse(tbxBurger2.Text);
            int burger3 = int.Parse(tbxBurger3.Text);
            int coke = int.Parse(tbxCoke.Text);
            int sprite = int.Parse(tbxSprite.Text);

            int[] burger = new int[3] { burger1, burger2, burger3 };
            int[] beverage = new int[2] { coke, sprite };

            int total = burger1 + coke - 50;
            //int total = 0;

            for (int i = 0; i < burger.Length; i++)
            {
                for(int j = 0; j < beverage.Length; j++)
                {
                    int price = burger[i] + beverage[j] - 50;

                    Debug.WriteLine(price.ToString());
                    
                    if (total > price)
                    {
                        int temp = total;
                        total = price;
                        price = temp;
                    }

                    lblResult.Text = total.ToString();
                }
                
            }
        }
    }
}
