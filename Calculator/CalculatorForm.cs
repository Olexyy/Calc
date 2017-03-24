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
        private Double Memory { get; set; }
        Calculus calc;
        Analyzer analyzer;

        public CalculatorForm()
        {
            this.InitializeComponent();
            Memory = 0;
            calc = new Calculus();
            analyzer = new Analyzer();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddToExpression("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddToExpression("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddToExpression("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddToExpression("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddToExpression("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddToExpression("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddToExpression("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddToExpression("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AddToExpression("9");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            AddToExpression("0");
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            AddToExpression("/");
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            AddToExpression("*");
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            AddToExpression("-");
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            AddToExpression("+");
        }

        private void buttonMod_Click(object sender, EventArgs e)
        {
            AddToExpression("%");
        }

        private void buttonOpenBracket_Click(object sender, EventArgs e)
        {
            AddToExpression("(");
        }

        private void buttonCloseBracket_Click(object sender, EventArgs e)
        {
            AddToExpression(")");
        }

        private void buttonNeg_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "";
        }

        private void buttonEq_Click(object sender, EventArgs e)
        {
            if (textBoxExpression.Text.Length < 65535)
            {                
                Result result = analyzer.Calculate(textBoxExpression.Text + "@");
                if (result.errors == String.Empty)
                    textBoxResult.Text = result.rslt.ToString();
                else
                    textBoxResult.Text = result.errors;
            }
            else
                textBoxResult.Text = "Error 07. Too long expression!";
        }

        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            if (textBoxExpression.Text != String.Empty)
                textBoxExpression.Text = textBoxExpression.Text.Remove(textBoxExpression.Text.Length - 1);
        }

        private void buttonMR_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text = Memory.ToString();
        }

        private void buttonMPlus_Click(object sender, EventArgs e)
        {
            Double final;
            bool isDouble = Double.TryParse(textBoxResult.Text, out final);
            if (isDouble)
            {
                Result rslt = calc.Run(Memory, final, "+");
                if (rslt.errors == String.Empty)
                    Memory = rslt.rslt;
                else
                    textBoxResult.Text = rslt.errors;
            }
            else
                textBoxResult.Text = "Wrong parameters";
        }

        private void buttonMC_Click(object sender, EventArgs e)
        {
            Memory = 0;
        }

        private void AddToExpression(string symbol)
        {
            textBoxExpression.Text += symbol;
        }
    }
}
