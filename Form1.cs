using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private decimal firstvalue;
        private char operation;
        private decimal secondvalue;
        private void btn_number1_Click(object sender, EventArgs e)
        {
            if (lbl_Screen.Text=="0")
            {
               lbl_Screen.Text = ""; 
            }
            lbl_Screen.Text += "1";
        }

        private void btn_number2_Click(object sender, EventArgs e)
        {
            if (lbl_Screen.Text == "0")
            {
                lbl_Screen.Text = "";
            }
            lbl_Screen.Text += "2";
        }

        private void btn_number3_Click(object sender, EventArgs e)
        {
            if (lbl_Screen.Text == "0")
            {
                lbl_Screen.Text = "";
            }
            lbl_Screen.Text += "3";
        }

        private void btn_number4_Click(object sender, EventArgs e)
        {
            if (lbl_Screen.Text == "0")
            {
                lbl_Screen.Text = "";
            }
            lbl_Screen.Text += "4";
        }

        private void btn_number5_Click(object sender, EventArgs e)
        {
            if (lbl_Screen.Text == "0")
            {
                lbl_Screen.Text = "";
            }
            lbl_Screen.Text += "5";
        }

        private void btn_number6_Click(object sender, EventArgs e)
        {
            if (lbl_Screen.Text == "0")
            {
                lbl_Screen.Text = "";
            }
            lbl_Screen.Text += "6";
        }

        private void btn_number7_Click(object sender, EventArgs e)
        {
            if (lbl_Screen.Text == "0")
            {
                lbl_Screen.Text = "";
            }
            lbl_Screen.Text += "7";
        }

        private void btn_number8_Click(object sender, EventArgs e)
        {
            if (lbl_Screen.Text == "0")
            {
                lbl_Screen.Text = "";
            }
            lbl_Screen.Text += "8";
        }

        private void btn_number9_Click(object sender, EventArgs e)
        {
            if (lbl_Screen.Text == "0")
            {
                lbl_Screen.Text = "";
            }
            lbl_Screen.Text += "9";
        }

        private void btn_number0_Click(object sender, EventArgs e)
        {
            if (lbl_Screen.Text == "0")
            {
                lbl_Screen.Text = "";
            }
            lbl_Screen.Text += "0";
        }

        private void btn_sum_Click(object sender, EventArgs e)
        {
            firstvalue = Convert.ToDecimal(lbl_Screen.Text);
            operation = '+';
            lbl_Screen.Text = "";
        }

        private void btn_subraction_Click(object sender, EventArgs e)
        {
            firstvalue = Convert.ToDecimal(lbl_Screen.Text);
            operation = '-';
            lbl_Screen.Text = "";
        }

        private void btn_multiplication_Click(object sender, EventArgs e)
        {
            firstvalue = Convert.ToDecimal(lbl_Screen.Text);
            operation = '*';
            lbl_Screen.Text = "";
        }

        private void btn_division_Click(object sender, EventArgs e)
        {
            firstvalue = Convert.ToDecimal(lbl_Screen.Text);
            operation = '/';
            lbl_Screen.Text = "";
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            lbl_Screen.Text = "0";
            firstvalue = 0;
            secondvalue = 0;
            operation = ' ';
        }

        private void btn_comma_Click(object sender, EventArgs e)
        {
            lbl_Screen.Text += ",";
        }

        private void btn_equal_Click_1(object sender, EventArgs e)
        {
            secondvalue = Convert.ToDecimal(lbl_Screen.Text);
            decimal result;
            switch (operation)
            {
                case '+':
                    result = firstvalue + secondvalue;
                    break;
                case '-':
                    result = firstvalue - secondvalue;
                    break;
                case '*':
                    result = firstvalue * secondvalue;
                    break;
                case '/':
                    result = firstvalue / secondvalue;
                    break;
                default:
                    result = 0;
                    break;
            }

            lbl_Screen.Text = Convert.ToString(result);
        }

        private void btn_clearElement_Click(object sender, EventArgs e)
        {
            lbl_Screen.Text = "0";
        }
    }
}
