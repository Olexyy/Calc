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
    public partial class CalculatorForm : Form
    {
        private string Memory { get; set; }
        private bool ExtendedMode { get; set; }
        private CalculatorBase Base { get; set; }
        public CalculatorForm()
        {
            this.InitializeComponent();
            this.Base = new CalculatorBase();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBoxExpression.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBoxExpression.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBoxExpression.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.textBoxExpression.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBoxExpression.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.textBoxExpression.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.textBoxExpression.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.textBoxExpression.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.textBoxExpression.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            this.textBoxExpression.Text += "0";
        }

        public void Classical(string symbol)
        {
            if (String.IsNullOrEmpty(this.textBoxResult.Text))
            {
                this.labelOperator.Text = symbol;
                this.textBoxResult.Text = this.textBoxExpression.Text;
                this.textBoxExpression.Text = String.Empty;
            }
            else
            {
                if (!String.IsNullOrEmpty(this.textBoxExpression.Text))
                {
                    string expression = this.textBoxResult.Text + this.labelOperator.Text + this.textBoxExpression.Text;
                    // do math to expression on var expression
                    this.textBoxExpression.Text = String.Empty;
                    this.textBoxResult.Text = String.Empty; ///result of maths
                    this.labelOperator.Text = symbol;
                }
            }
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            this.Classical("/");
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            this.Classical("*");
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            this.Classical("-");
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            this.Classical("+");
        }

        private void buttonNegate_Click(object sender, EventArgs e)
        {
            this.Classical("-");
        }

        private void buttonMod_Click(object sender, EventArgs e)
        {
            this.Classical("%");
        }

        private void buttonMemoryRecall_Click(object sender, EventArgs e)
        {
            // todo: implement
        }

        private void buttonMemoryPlus_Click(object sender, EventArgs e)
        {
            // todo: implement
        }

        private void buttonMemoryClear_Click(object sender, EventArgs e)
        {
            // todo: implement
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            // todo: implement
        }

        private void buttonExReset_Click(object sender, EventArgs e)
        {
            this.textBoxExpression.Text += String.Empty;
        }
    }
}
