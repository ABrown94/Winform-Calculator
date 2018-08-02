using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Windows_Form
{
    public partial class Calculator : Form
    {
        string operation = "";
        decimal total = 0;
        decimal currentNum = 0;
        bool clearscreen = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (clearscreen == true)
            {
                InputTextbox.Text = "";
                clearscreen = false;
            }
            Button number = sender as Button;
            InputTextbox.Text += number.Text;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            clearscreen = true;          
            total = Convert.ToDecimal(InputTextbox.Text);           

            if (sender == AddButton)
            {
                operation = "+";                
            }
            if (sender == SubtractButton)
            {
                operation = "-";              
            }
            if (sender == MultiplyButton)
            {
                operation = "*";              
            }
            if (sender == DivideButton)
            {
                operation = "/";               
            }
            if(sender == SquareButton)
            {
                operation = "x²";
            }
            if (sender == squareRootButton)
            {
                operation = "√";
            }
            InputTextbox.Text = operation;
        }
        private void EqualButton_Click(object sender, EventArgs e)
        {
            currentNum = Convert.ToDecimal(InputTextbox.Text);
            clearscreen = true;
            Calculate(total, currentNum, operation);
        }
        public void Calculate(decimal total, decimal currentNum, string operation)
        {
            switch (operation)
            {
                case "+":
                    total += currentNum;
                    InputTextbox.Text = (total).ToString();
                    break;
                case "-":
                    total -= currentNum;
                    InputTextbox.Text = (total).ToString();
                    break;
                case "*":
                    total *= currentNum;
                    InputTextbox.Text = (total).ToString();
                    break;
                case "/":
                    total /= currentNum;
                    InputTextbox.Text = (total).ToString();
                    break;
                //case "√":
                //    total += Math.Sqrt(currentNum);
                //    InputTextbox.Text = (total).ToString();
                //   break;
                //case "x²":
                //    total += Math.Pow(total, currentNum);
                //    InputTextbox.Text = (total).ToString();
                //    break;
            }
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            clearscreen = true;
            InputTextbox.Text = "";
        }
        private void BackspaceButton_Click(object sender, EventArgs e)
        {
            InputTextbox.Text = InputTextbox.Text.Remove(InputTextbox.Text.Length - 1, 1);
        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Button b = sender as Button;
            b.Width += 10;
            b.Height += 10;
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            Button b = sender as Button;
            b.Width -= 10;
            b.Height -= 10;
        }

    }
    
}
