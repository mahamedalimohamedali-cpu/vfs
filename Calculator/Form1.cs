using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        char Opration = default(char);





        float Calc() 
        {
            float result = default(float);

            string FullText = textBox1.Text;

            string[] Split = FullText.Split('+','-','%','X','/');

            int[] Numbers = new int[Split.Length];

            for (int i = 0; i < Split.Length; i++)
            {
                Numbers[i] = Convert.ToInt32(Split[i]);
            }

            result = Numbers[0];

            List<char> C = new List<char>();

            foreach (char c in FullText) 
            {
                if (c == '+' || c == '-' || c == '%'||c=='X'||c=='/') 
                {
                    C.Add(c);
                }
            }


            for (int i = 0; i <C.Count; i++)
            {
                char c = C[i];
                int Number = Numbers[i + 1];
                  switch (c)
                    {
                        case '+':
                            result += Number;
                            break;

                        case '-':
                            result -= Number;
                            break;

                        case '%':
                            if (Number != 0)
                                result %= Number;
                            break;


                    case 'X':
                        result *= Number;
                        break;

                    case '/':
                        result /= (float)Number;
                        break;
                }
                
            }

            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += button2.Text;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += button3.Text;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += button6.Text;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += button7.Text;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += button9.Text;

        }

        private void button10_Click(object sender, EventArgs e)
        {

            float result = Calc();

            string FinalResult = Convert.ToString(result);

            textBox1.Text += '=';
            textBox1.Text += FinalResult;
        }

        private void button11_Click(object sender, EventArgs e)
        { 
            Opration = '+';
            textBox1.Text += Opration;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Opration = '-';
            textBox1.Text += Opration;
       
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Opration = '%';
            textBox1.Text += Opration;

        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += '(';
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += ')';
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = button17.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals(""))
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.TextLength - 1);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Opration = 'X';
            textBox1.Text += Opration;
        }

        private void button20_Click(object sender, EventArgs e)
        {

            Opration = '/';
            textBox1.Text += Opration;
        }

      
    }
}
