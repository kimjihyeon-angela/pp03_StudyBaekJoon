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

namespace BaekJoon2752
{
    public partial class BaekJoon2752 : Form
    {

        public BaekJoon2752()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            int[] array = new int[3];
            rtbOriginal.Text = "정렬 전 : \n";
            rtbSort.Text = "정렬 후 : \n";

            for ( int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 10);
                Debug.WriteLine("정렬 전 : " + array[i].ToString());
                
                rtbOriginal.AppendText(array[i].ToString() + "\n");
            }

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)  
                {
                    if (array[i] > array[j])       
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp; 
                    }
                }
                Debug.WriteLine("정렬 후 : " + array[i].ToString());

                
                rtbSort.AppendText(array[i].ToString() + "\n");
            }

        }
    }
}
