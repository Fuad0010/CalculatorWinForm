using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWinForm
{
    public partial class Form1 : Form
    {

        double num1 = 0;
        double num2 = 0;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxOutput(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox_Output_Result.Text = textBox_Output_Result.Text + 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox_Output_Result.Text = textBox_Output_Result.Text + 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox_Output_Result.Text = textBox_Output_Result.Text + 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox_Output_Result.Text = textBox_Output_Result.Text + 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox_Output_Result.Text = textBox_Output_Result.Text + 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox_Output_Result.Text = textBox_Output_Result.Text + 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox_Output_Result.Text = textBox_Output_Result.Text + 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox_Output_Result.Text = textBox_Output_Result.Text + 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox_Output_Result.Text = textBox_Output_Result.Text + 9;
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            textBox_Output_Result.Text = textBox_Output_Result.Text + 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox_Output_Result.Clear();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string[] arr = textBox_Output_Result.Text.Split(" ");

            if (textBox_Output_Result.Text != "")
            {

                if (num1 == 0 && arr.Length <= 2)
                {
                    num1 = Convert.ToDouble(textBox_Output_Result.Text);
                    textBox_Output_Result.Text = textBox_Output_Result.Text;
                }
                if (num1 == 0 && arr[2] != "")
                {
                    num1 = Convert.ToDouble(arr[0]);
                }
            }

            if (arr.Length == 3)
            {
                if (arr[2] != "" && textBox_Output_Result.Text.Contains(" + ") ||
                    arr[2] != "" && textBox_Output_Result.Text.Contains(" - ") ||
                    arr[2] != "" && textBox_Output_Result.Text.Contains(" * ") ||
                    arr[2] != "" && textBox_Output_Result.Text.Contains(" / "))
                {
                    num2 = Convert.ToDouble(arr[2]);
                    if (arr[1] == "-")
                    {
                        num2 = num1 - num2;
                    }
                    else if (arr[1] == "+")
                    {
                        num2 += num1;
                    }
                    else if (arr[1] == "*")
                    {
                        num2 *= num1;
                    }
                    else if (arr[1] == "/")
                    {
                        num2 = num1 / num2;
                    }

                    textBox_Output_Result.Clear();
                    textBox_Output_Result.Text = textBox_Output_Result.Text + num2;
                    num1 = 0;
                }
                else
                {
                    if (num1 == 0)
                    {
                        textBox_Output_Result.Clear();
                        textBox_Output_Result.Text = textBox_Output_Result.Text + num2;
                    }
                    else
                    {
                        textBox_Output_Result.Clear();
                        textBox_Output_Result.Text = textBox_Output_Result.Text + num1;
                        num1 = 0;
                    }
                }
            }


        }

        private void btnPlus_Click(object sender, EventArgs e)
        {

            string[] arr = textBox_Output_Result.Text.Split(" ");

            if (textBox_Output_Result.Text != "")
            {
                    
                if (num1 == 0 && arr.Length <= 2)
                {
                    num1 = Convert.ToDouble(textBox_Output_Result.Text);
                    textBox_Output_Result.Text = textBox_Output_Result.Text + " + ";
                }
                if (num1 == 0 && arr[2] != "")
                {
                    num1 = Convert.ToDouble(arr[0]);
                }
            }
            if (arr.Length == 3)
            {
                if (arr[2] != "" && textBox_Output_Result.Text.Contains(" + ") ||
                    arr[2] != "" && textBox_Output_Result.Text.Contains(" - ") ||
                    arr[2] != "" && textBox_Output_Result.Text.Contains(" * ") ||
                    arr[2] != "" && textBox_Output_Result.Text.Contains(" / "))
                {
                    num2 = Convert.ToDouble(arr[2]);
                    if (arr[1] == "-")
                    {
                        num2 = num1 - num2;
                    }
                    else if (arr[1] == "+")
                    {
                        num2 += num1;
                    }
                    else if (arr[1] == "*")
                    {
                        num2 *= num1;
                    }
                    else if (arr[1] == "/")
                    {
                        num2 = num1 / num2;
                    }
                    textBox_Output_Result.Clear();
                    textBox_Output_Result.Text = textBox_Output_Result.Text + num2 + " + ";
                    num1 = 0;
                }
            }
            if (textBox_Output_Result.Text.Contains(" - "))
            {
                textBox_Output_Result.Text = textBox_Output_Result.Text.Replace(" - ", " + ");
            }
            else if (textBox_Output_Result.Text.Contains(" * "))
            {
                textBox_Output_Result.Text = textBox_Output_Result.Text.Replace(" * ", " + ");
            }
            else if (textBox_Output_Result.Text.Contains(" / "))
            {
                textBox_Output_Result.Text = textBox_Output_Result.Text.Replace(" / ", " + ");
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            string[] arr = textBox_Output_Result.Text.Split(" ");

            if (textBox_Output_Result.Text != "")
            {

                if (num1 == 0 && arr.Length <= 2)
                {
                    num1 = Convert.ToDouble(textBox_Output_Result.Text);
                    textBox_Output_Result.Text = textBox_Output_Result.Text + " - ";
                }
                if (num1 == 0 && arr[2] != "")
                {
                    num1 = Convert.ToDouble(arr[0]);
                }
            }
            if (arr.Length == 3)
            {
                if (arr[2] != "" && textBox_Output_Result.Text.Contains(" + ") ||
                    arr[2] != "" && textBox_Output_Result.Text.Contains(" - ") ||
                    arr[2] != "" && textBox_Output_Result.Text.Contains(" * ") ||
                    arr[2] != "" && textBox_Output_Result.Text.Contains(" / "))
                {
                    num2 = Convert.ToDouble(arr[2]);
                    if (arr[1] == "-")
                    {
                        num2 = num1 - num2;
                    }
                    else if (arr[1] == "+")
                    {
                        num2 += num1;
                    }
                    else if (arr[1] == "*")
                    {
                        num2 *= num1;
                    }
                    else if (arr[1] == "/")
                    {
                        num2 = num1 / num2;
                    }

                    textBox_Output_Result.Clear();
                    textBox_Output_Result.Text = textBox_Output_Result.Text + num2 + " - ";
                    num1 = 0;
                }
            }
            if (textBox_Output_Result.Text.Contains(" + "))
            {
                textBox_Output_Result.Text = textBox_Output_Result.Text.Replace(" + ", " - ");
            }
            else if (textBox_Output_Result.Text.Contains(" * "))
            {
                textBox_Output_Result.Text = textBox_Output_Result.Text.Replace(" * ", " - ");
            }
            else if (textBox_Output_Result.Text.Contains(" / "))
            {
                textBox_Output_Result.Text = textBox_Output_Result.Text.Replace(" / ", " - ");
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            string[] arr = textBox_Output_Result.Text.Split(" ");

            if (textBox_Output_Result.Text != "")
            {

                if (num1 == 0 && arr.Length <= 2)
                {
                    num1 = Convert.ToDouble(textBox_Output_Result.Text);
                    textBox_Output_Result.Text = textBox_Output_Result.Text + " * ";
                }
                if (num1 == 0 && arr[2] != "")
                {
                    num1 = Convert.ToDouble(arr[0]);
                }
            }
            if (arr.Length == 3)
            {
                if (arr[2] != "" && textBox_Output_Result.Text.Contains(" + ") ||
                    arr[2] != "" && textBox_Output_Result.Text.Contains(" - ") ||
                    arr[2] != "" && textBox_Output_Result.Text.Contains(" * ") ||
                    arr[2] != "" && textBox_Output_Result.Text.Contains(" / "))
                {
                    num2 = Convert.ToDouble(arr[2]);
                    if (arr[1] == "-")
                    {
                        num2 = num1 - num2;
                    }
                    else if (arr[1] == "+")
                    {
                        num2 += num1;
                    }
                    else if (arr[1] == "*")
                    {
                        num2 *= num1;
                    }
                    else if (arr[1] == "/")
                    {
                        num2 = num1 / num2;
                    }
                    textBox_Output_Result.Clear();
                    textBox_Output_Result.Text = textBox_Output_Result.Text + num2 + " * ";
                    num1 = 0;
                }
            }
            if (textBox_Output_Result.Text.Contains(" - "))
            {
                textBox_Output_Result.Text = textBox_Output_Result.Text.Replace(" - ", " * ");
            }
            else if (textBox_Output_Result.Text.Contains(" + "))
            {
                textBox_Output_Result.Text = textBox_Output_Result.Text.Replace(" - ", " * ");
            }
            else if (textBox_Output_Result.Text.Contains(" / "))
            {
                textBox_Output_Result.Text = textBox_Output_Result.Text.Replace(" / ", " * ");
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            string[] arr = textBox_Output_Result.Text.Split(" ");

            if (textBox_Output_Result.Text != "")
            {

                if (num1 == 0 && arr.Length <= 2)
                {
                    num1 = Convert.ToDouble(textBox_Output_Result.Text);
                    textBox_Output_Result.Text = textBox_Output_Result.Text + " / ";
                }
                if (num1 == 0 && arr[2] != "")
                {
                    num1 = Convert.ToDouble(arr[0]);
                }
            }
            if (arr.Length == 3)
            {
                if (arr[2] != "" && textBox_Output_Result.Text.Contains(" + ") ||
                    arr[2] != "" && textBox_Output_Result.Text.Contains(" - ") ||
                    arr[2] != "" && textBox_Output_Result.Text.Contains(" * ") ||
                    arr[2] != "" && textBox_Output_Result.Text.Contains(" / "))
                {
                    num2 = Convert.ToDouble(arr[2]);
                    if (arr[1] == "-")
                    {
                        num2 = num1 - num2;
                    }
                    else if (arr[1] == "+")
                    {
                        num2 += num1;
                    }
                    else if (arr[1] == "*")
                    {
                        num2 *= num1;
                    }
                    else if (arr[1] == "/")
                    {
                        num2 = num1 / num2;
                    }
                    textBox_Output_Result.Clear();
                    textBox_Output_Result.Text = textBox_Output_Result.Text + num2 + " / ";
                    num1 = 0;
                }
            }
            if (textBox_Output_Result.Text.Contains(" + "))
            {
                textBox_Output_Result.Text = textBox_Output_Result.Text.Replace(" + ", " / ");
            }
            else if (textBox_Output_Result.Text.Contains(" * "))
            {
                textBox_Output_Result.Text = textBox_Output_Result.Text.Replace(" * ", " / ");
            }
            else if (textBox_Output_Result.Text.Contains(" - "))
            {
                textBox_Output_Result.Text = textBox_Output_Result.Text.Replace(" - ", " / ");
            }
        }
    }
}
