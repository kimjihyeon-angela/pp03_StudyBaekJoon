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

namespace BaekJoon1284
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = rtbInput.Lines.Length;
            string[] input = rtbInput.Text.Split('\n');
            int[] inputNumbers = input
                .Select(str => int.Parse(str))
                .ToArray();
            int[] result = new int[count];

            for(int i = 0; i < count; i++)
            {
                int sum = 2;
                int num = 0;
                int[] totalnum = new int[4];
                int m = 0;
                int h = 0;
                int t = 0;
                int o = 0;

                if (inputNumbers[i] == 0)
                {
                    sum = 0;
                    rtbResult.Text = sum.ToString() + '\n';
                }
                else if (inputNumbers[i] / 1000 >= 1)
                {
                    Debug.WriteLine(sum.ToString());
                    num = inputNumbers[i];
                    m = num / 1000;
                    //Debug.WriteLine(m);
                    num = num % 1000;
                    //Debug.WriteLine(num);
                    h = num / 100;
                    //Debug.WriteLine(h);
                    num = num % 100;
                    //Debug.WriteLine(num);
                    t = num / 10;
                    //Debug.WriteLine(t);
                    o = num % 10;
                    //Debug.WriteLine(o);
                    sum = sum + 3;
                    Debug.WriteLine(sum.ToString());

                    for (int j = 0; j < totalnum.Length; i++)
                    {
                        totalnum[0] = m;
                        totalnum[1] = h;
                        totalnum[2] = t;
                        totalnum[3] = o;
                    }

                    for (int j = 0; j < totalnum.Length; i++)
                    {
                        if (totalnum[i] == 0)
                        {
                            sum = sum + 4;
                        }
                        else if (totalnum[i] == 1)
                        {
                            sum = sum + 2;
                        }
                        else
                        {
                            sum = sum + 3;
                        }
                        Debug.WriteLine(sum.ToString());
                        result[i] = sum;
                    }

                    Debug.WriteLine(result[i].ToString());
                    Debug.WriteLine(sum.ToString());
                    result[i] = sum;

                }
                else if (inputNumbers[i] / 100 >= 1)
                {
                    num = inputNumbers[i];
                    h = num / 100;
                    num = num % 100;
                    t = num / 10;
                    o = num % 10;
                    sum = sum + 2;
                    if (t == 0 || o == 0)
                    {
                        sum = sum + 4;
                    }
                    else if (o == 1)
                    {
                        sum = sum + 2;
                    }
                    else
                    {
                        sum = sum + 3;
                    }
                    result[i] = sum;

                }
                else if (inputNumbers[i] / 10 >= 1)
                {
                    num = inputNumbers[i];
                    t = num / 10;
                    o = num % 10;
                    sum = sum + 1;
                    if (m == 1 || h == 1 || t == 1 || o == 1)
                    {
                        sum = sum + 2;
                    }
                    else
                    {
                        sum = sum + 3;
                    }
                    result[i] = sum;
                }
                Debug.WriteLine(sum.ToString());

                //rtbResult.Text = sum.ToString()+ '\n';
            }

            for (int i = 0; i < result.Length; i++)
            {
                rtbResult.Text = result[i].ToString() + '\n';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = 1234;
            int b = 1234 / 1000;
            int c = 1234 % 1000;
            int d = c / 100;
            int f = c % 100;
            int g = f / 10;
            int h = f % 10;
                
            Debug.WriteLine(a.ToString());
            Debug.WriteLine(b.ToString());
            Debug.WriteLine(c.ToString());
            Debug.WriteLine(d.ToString());
            Debug.WriteLine(f.ToString());
            Debug.WriteLine(g.ToString());
            Debug.WriteLine(h.ToString());
        }
    }
}
