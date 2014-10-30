using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitTestCalculatorApp
{
    public partial class CalculatorApp : Form
    {
        private Calculator aCalculator;

        public CalculatorApp()
        {
            InitializeComponent();
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            aCalculator = new Calculator();
            resultTextBox.Text = aCalculator.Add(Convert.ToInt16(firstNumberTextBox.Text), Convert.ToInt16(secondNumberTextBox.Text)).ToString();
        }

        private void subButton_Click(object sender, EventArgs e)
        {
            aCalculator = new Calculator();
            resultTextBox.Text = aCalculator.Subtract(Convert.ToDouble(firstNumberTextBox.Text), Convert.ToDouble(secondNumberTextBox.Text)).ToString();

        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            aCalculator = new Calculator();
            resultTextBox.Text = aCalculator.multiply(Convert.ToInt16(firstNumberTextBox.Text), Convert.ToInt16(secondNumberTextBox.Text)).ToString();
        }

        private void devideButton_Click(object sender, EventArgs e)
        {
            aCalculator = new Calculator();
            resultTextBox.Text = aCalculator.Devide(Convert.ToDouble(firstNumberTextBox.Text),
                Convert.ToDouble(secondNumberTextBox.Text)).ToString();
        }
    }
}
