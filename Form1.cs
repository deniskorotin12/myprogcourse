using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая
{
    public partial class Form1 : Form
    {
        string activeStr;
        bool point = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        // interesting for git
        //it's real

        private void button1_Click(object sender, EventArgs e)
        {
            string myindex="";
            if (sender == button1)
            {
                myindex = "1";
            }
            else if (sender == button2)
            {
                myindex = "2";
            }
            else if (sender == button3)
            {
                myindex = "3";
            }
            else if (sender == button4)
            {
                myindex = "4";
            }
            else if (sender == button5)
            {
                myindex = "5";
            }
            else if (sender == button6)
            {
                myindex = "6";
            }
            else if (sender == button7)
            {
                myindex = "7";
            }
            else if (sender == button8)
            {
                myindex = "8";
            }
            else if (sender == button9)
            {
                myindex = "9";
            }
            else if (sender == button10)
            {
                myindex = "0";
            }
            else if (sender == button11 && point !=true)
            { 
            textBox2.Text += ".";
            activeStr += ".";
            point = true;
            }
            textBox2.Text += myindex;
            activeStr += myindex;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Close();
        }  

        private void button17_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            point = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length != 0)
            {
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1, 1);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text + "+";
            textBox2.Text = "";
            point = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += ""+ textBox2.Text + Environment.NewLine;
            textBox1.Text += Result(textBox2.Text); 
            textBox2.Text = "";
        }
        private string Result (string str)
        {
            int index =0 ;
            string answer = "";
            string [] word;
            if ((index = str.IndexOf("+")) >= 0)
            {
                    word = str.Split(new char[] { '+', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i=word[0].Length > word[0+1].Length?word[0].Length:word[0+1].Length;i>0;i--)
                {
                    int F = Convert.ToInt32(word[0]) + Convert.ToInt32(word[0 + 1]) + (F>10?1:0);
                    answer += Convert.ToString(F % 10);
                }
            }
            for (int i = 0; i < answer.Length / 2;i++ )
            {
                int k;
                k = answer[i];
                answer[i] = answer[answer.Length - i];
                answer[answer.Length - i] = k;
            }
                return System.Array.Reverse(answer);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text + "/";
            textBox2.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text + "*";
            textBox2.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text + "-";
            textBox2.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e) // ( )
        {
            textBox1.Text += "()";
            textBox1.SelectedText += "fssfs";
        }
    }
}



