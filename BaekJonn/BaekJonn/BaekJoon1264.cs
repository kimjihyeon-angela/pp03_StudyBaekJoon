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

namespace BaekJonn
{
    public partial class BaekJoon1264 : Form
    {
        public BaekJoon1264()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            string[] stringArray = new string[5] { "a", "e", "i", "o", "u" };
            //Debug.WriteLine(text);
            string text = rtbText.Text;
            text.ToLower();

            while (true)
            {
                for(int i=0; i < text.Length; i++)
                {
                    if (text[i] == '#')
                    {
                        return;
                    }
                    else
                    {
                        for (int j = 0; j < stringArray.Length; j++)
                        {
                            if (text[i].ToString() == stringArray[j].ToString())
                            {
                                Debug.WriteLine(text[i]);
                                count += 1;
                                lalResult.Text = count.ToString();
                            }
                        }
                    }
                }
                
            }

        }
    }
}
