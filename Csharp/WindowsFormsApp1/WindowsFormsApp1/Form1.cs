using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Calculator : Form
    {
        private int result;
        private string ops = "";
        private bool isDone = false;
        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void one_Click(object sender, EventArgs e)
        {
            addDigit("1");
        }
        private void two_Click(object sender, EventArgs e)
        {
            addDigit("2");
        }
        private void three_Click(object sender, EventArgs e)
        {
            addDigit("3");
        }
        private void four_Click(object sender, EventArgs e)
        {
            addDigit("4");
        }
        private void five_Click(object sender, EventArgs e)
        {
            addDigit("5");
        }
        private void six_Click(object sender, EventArgs e)
        {
            addDigit("6");
        }
        private void seven_Click(object sender, EventArgs e)
        {
            addDigit("7");
        }
        private void eight_Click(object sender, EventArgs e)
        {
            addDigit("8");
        }
        private void nine_Click(object sender, EventArgs e)
        {
            addDigit("9");
        }
        private void zero_Click(object sender, EventArgs e)
        {
            addDigit("0");
        }
        private void plus_Click(object sender, EventArgs e)
        {
            operations("+");
        }

        private void minus_Click(object sender, EventArgs e)
        {
            operations("-");        }

        private void mult_Click(object sender, EventArgs e)
        {
            operations("*");
        }

        private void divide_Click(object sender, EventArgs e)
        {
            if (display.Text == "0") MessageBox.Show("Rest In pee");
            operations("/");
        }
        private void clear_Click(object sender, EventArgs e)
        {
            display.Text = "0";
            result = 0;
            ops = "";
        }
        private void res_Click(object sender, EventArgs e)
        {
            if (display.Text == "0") MessageBox.Show("Can't be zero dummas");
            switch (ops)
            {
                case "+":
                    result += Convert.ToInt32(display.Text);
                    display.Text = Convert.ToString(result);
                    isDone = true;
                    break;
                case "-":
                    result -= Convert.ToInt32(display.Text);
                    display.Text = Convert.ToString(result);
                    isDone = true;
                    break;
                case "*":
                    result *= Convert.ToInt32(display.Text);
                    display.Text = Convert.ToString(result);
                    isDone = true;
                    break;
                case "/":
                    result /= Convert.ToInt32(display.Text);
                    display.Text = Convert.ToString(result);
                    isDone = true;
                    break;
                default:
                    MessageBox.Show("Dum Dum");
                    break;
            }
        }
        private void operations(string op)
        {
            result += Convert.ToInt32(display.Text);
            ops = op;
            display.Text = "0";
            isDone = false;
        }
        private void addDigit(string num)
        {
            if (display.Text == "0" || isDone)
            {
                display.Text = num;
                isDone = false;
            }
            else display.Text += num;
        }
        private void display_Click(object sender, EventArgs e)
        {

        }
    }
}
