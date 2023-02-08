using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double number1;
        double number2;
        double result;
        string Operator;
        string answer;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Clear();
                txtDisplay.Text = "1";

            }
            else
            {
                txtDisplay.Text += "1"; 
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Clear();
                txtDisplay.Text = "2";

            }
            else
            {
                txtDisplay.Text += "2";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Clear();
                txtDisplay.Text = "3";

            }
            else
            {
                txtDisplay.Text += "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Clear();
                txtDisplay.Text = "4";

            }
            else
            {
                txtDisplay.Text += "4";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Clear();
                txtDisplay.Text = "5";

            }
            else
            {
                txtDisplay.Text += "5";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Clear();
                txtDisplay.Text = "6";

            }
            else
            {
                txtDisplay.Text += "6";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Clear();
                txtDisplay.Text = "7";

            }
            else
            {
                txtDisplay.Text += "7";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Clear();
                txtDisplay.Text = "8";

            }
            else
            {
                txtDisplay.Text += "8";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Clear();
                txtDisplay.Text = "9";

            }
            else
            {
                txtDisplay.Text += "9";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Clear();
                txtDisplay.Text = "0";

            }
            else
            {
                txtDisplay.Text += "0";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ".";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            txtDisplay.Text = "0";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string backspace = null;

            if (txtDisplay.Text.Length > 0)
            {
                StringBuilder sb = new StringBuilder(value: txtDisplay.Text);

                sb.Remove(txtDisplay.Text.Length -1,1);

                backspace = sb.ToString();

                txtDisplay.Text = backspace;
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            number1 = Double.Parse(txtDisplay.Text);
            txtDisplay.Text = "";
            Operator = "+";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            number2 = Double.Parse(txtDisplay.Text);

            if(Operator == "+") {
                result = number1 + number2;
                txtDisplay.Text = result.ToString();
            }

            else if (Operator == "-")
            {
                result = number1 - number2;
                txtDisplay.Text = result.ToString();
            }

            else if (Operator == "*")
            {
                result = number1 * number2;
                txtDisplay.Text = result.ToString();
            }
            else if (Operator == "/")
            {
                result = number1 / number2;
                txtDisplay.Text = result.ToString();
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            number1 = Double.Parse(txtDisplay.Text);
            txtDisplay.Text = "";
            Operator = "-";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            number1 = Double.Parse(txtDisplay.Text);
            txtDisplay.Text = "";
            Operator = "*";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            number1 = Double.Parse(txtDisplay.Text);
            txtDisplay.Text = "";
            Operator = "/";
        }
    }
}
