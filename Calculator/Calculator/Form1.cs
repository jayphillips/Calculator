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
        string input = string.Empty;
        string firstNumber = string.Empty;
        string secondNumber = string.Empty;
        string operation;
        double result = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "1";
            this.textBox1.Text += input;
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "2";
            this.textBox1.Text += input;
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "3";
            this.textBox1.Text += input;
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "4";
            this.textBox1.Text += input;
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "5";
            this.textBox1.Text += input;
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "6";
            this.textBox1.Text += input;
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "7";
            this.textBox1.Text += input;
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "8";
            this.textBox1.Text += input;
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "9";
            this.textBox1.Text += input;
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "0";
            this.textBox1.Text += input;
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            input += ".";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            firstNumber = string.Empty;
            secondNumber = string.Empty;
            this.input = string.Empty;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            firstNumber = input;
            operation = "+";
            input = string.Empty;
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            firstNumber = input;
            operation = "-";
            input = string.Empty;
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            firstNumber = input;
            operation = "*";
            input = string.Empty;

        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            firstNumber = input;
            operation = "/";
            input = string.Empty;

        }

        private void doubleZeroButton_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "00";
            this.textBox1.Text += input;

        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            secondNumber = input;
            double numberOne;
            double numberTwo;
            double.TryParse(firstNumber, out numberOne);
            double.TryParse(secondNumber, out numberTwo);

            switch (operation)
            {
                case "+":
                    result = numberOne + numberTwo;
                    textBox1.Text = result.ToString();
                    break;
                case "-":
                    result = numberOne - numberTwo;
                    textBox1.Text = result.ToString();
                    break;
                case "*":
                    result = numberOne * numberTwo;
                    textBox1.Text = result.ToString();
                    break;
                case "/":
                    if (numberTwo != 0)
                    {
                        result = numberOne / numberTwo;
                        textBox1.Text = result.ToString();
                        break;
                    }
                    else
                    {
                        textBox1.Text = "You can not divide by zero!";
                        break;
                    }
                    
                    
                default:
                    textBox1.Text = "You did not enter an operation.";
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
