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

            #region < 세번째 시도 >
            for (int i = 0; i < input.Length; i++)
            {
                int length = input[i].Length;
                int sum = 2;
                for (int j = 0; j < length; j++)
                {
                    if (length == 4)
                    {
                        sum += 3;
                    }
                    else if (length == 3)
                    {
                        sum += 2;
                    }
                    else if (length == 2)
                    {
                        sum += 1;
                    }

                    
                }
            }

            #endregion

            #region < 두번째 시도 >
            // for문 안에 있는 조건식에 문제가 있음을 파악함
            // 아예 다른 방법이 필요함을 느낌,,
            //for (int i = 0; i < inputNumbers.Length; i++)
            //{
            //    int sum = 2;
            //    int num = 0;
            //    int m = 0;
            //    int h = 0;
            //    int t = 0;
            //    int o = 0;

            //    if (inputNumbers[i] == 0)
            //    {
            //        sum = 0;
            //    }

            //    else if ( inputNumbers[i] / 1000 >= 1)
            //    {
            //        num = inputNumbers[i];
            //        m = num / 1000;
            //        num = num % 1000;
            //        h = num / 100;
            //        num = num % 100;
            //        t = num / 10;
            //        num = num % 10;
            //        o = num / 1;
            //        sum += 3;
            //        Debug.WriteLine(sum.ToString());

            //        if (m != 0 && m != 1 || h != 0 && h != 1 || t != 0 && t != 1 || o != 0 && o != 1)
            //        {
            //            sum += 3;
            //            Debug.WriteLine("o " + sum.ToString());

            //        }

            //        if (m == 1 || h == 1 || t == 1 || o == 1)
            //        {
            //            sum += 2;
            //            Debug.WriteLine("t " + sum.ToString());

            //        }

            //        if (h == 0 || t == 0 || o == 0)
            //        {
            //            sum += 4;
            //            Debug.WriteLine("th " + sum.ToString());

            //        }
            //        Debug.WriteLine(sum.ToString());
            //    }
            //}
            #endregion

            #region < 첫번째 시도 > 
            //for (int i = 0; i < inputNumbers.Length; i++)
            //{
            //    int sum = 2;
            //    int num = 0;
            //    int[] totalnum = new int[4];
            //    int m = 0;
            //    int h = 0;
            //    int t = 0;
            //    int o = 0;

            //    if (inputNumbers[i] == 0)
            //    {
            //        sum = 0;
            //        rtbResult.Text = sum.ToString() + '\n';
            //    }
            //    else if (inputNumbers[i] / 1000 >= 1)
            //    {
            //        Debug.WriteLine(sum.ToString());
            //        num = inputNumbers[i];
            //        m = num / 1000; // 1000의 자리
            //        //Debug.WriteLine(m);
            //        num = num % 1000; // 1000의 자리수에서 100의 자리수로 바뀜
            //        //Debug.WriteLine(num);
            //        h = num / 100; // 
            //        //Debug.WriteLine(h);
            //        num = num % 100;
            //        //Debug.WriteLine(num);
            //        t = num / 10;
            //        //Debug.WriteLine(t);
            //        o = num % 10;
            //        //Debug.WriteLine(o);
            //        sum = sum + 3;
            //        Debug.WriteLine(sum.ToString());



            //    }
            //    else if (inputNumbers[i] / 100 >= 1)
            //    {
            //        num = inputNumbers[i];
            //        h = num / 100;
            //        num = num % 100;
            //        t = num / 10;
            //        o = num % 10;
            //        sum = sum + 2;
            //        if (t == 0 || o == 0)
            //        {
            //            sum = sum + 4;
            //        }
            //        else if (o == 1)
            //        {
            //            sum = sum + 2;
            //        }
            //        else
            //        {
            //            sum = sum + 3;
            //        }
            //        result[i] = sum;

            //    }
            //    else if (inputNumbers[i] / 10 >= 1)
            //    {
            //        num = inputNumbers[i];
            //        t = num / 10;
            //        o = num % 10;
            //        sum = sum + 1;
            //        if (m == 1 || h == 1 || t == 1 || o == 1)
            //        {
            //            sum = sum + 2;
            //        }
            //        else
            //        {
            //            sum = sum + 3;
            //        }
            //        result[i] = sum;
            //    }
            //    Debug.WriteLine(sum.ToString());

            //    for (int j = 0; j < totalnum.Length; i++)
            //    {
            //        totalnum[0] = m;
            //        totalnum[1] = h;
            //        totalnum[2] = t;
            //        totalnum[3] = o;
            //    }

            //    for (int j = 0; j < totalnum.Length; i++)
            //    {
            //        if (totalnum[i] == 0)
            //        {
            //            sum = sum + 4;
            //        }
            //        else if (totalnum[i] == 1)
            //        {
            //            sum = sum + 2;
            //        }
            //        else
            //        {
            //            sum = sum + 3;
            //        }
            //        Debug.WriteLine(sum.ToString());
            //        result[i] = sum;
            //    }

            //    Debug.WriteLine(result[i].ToString());
            //    Debug.WriteLine(sum.ToString());
            //    result[i] = sum;
            //    //rtbResult.Text = sum.ToString()+ '\n';
            //}

            //for (int i = 0; i < result.Length; i++)
            //{
            //    rtbResult.Text = result[i].ToString() + '\n';
            //}
            #endregion
        }

        #region < 나누기, 몫 확인 용 버튼 >
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
        #endregion
    }
}
