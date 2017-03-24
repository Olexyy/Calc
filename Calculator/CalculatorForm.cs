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
        private string Input { get; set; }
        private string Memory { get; set; }
        private bool ExtendedMode { get; set; }
        private CalculatorBase Base { get; set; }
        public CalculatorForm()
        {
            this.InitializeComponent();
            this.Base = new CalculatorBase();
        }
        private void textBoxExpression_TextChanged(object sender, EventArgs e)
        {

            if (this.Input.Contains('(') || this.Input.Contains(')'))
                this.ExtendedMode = true;
            else
                this.ExtendedMode = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Input = "1";
            textBoxExpression.Text += Input;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Input = "2";
            textBoxExpression.Text += Input;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button0_Click(object sender, EventArgs e)
        {

        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {

        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {

        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {

        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {

        }

        private void buttonNegate_Click(object sender, EventArgs e)
        {

        }

        private void buttonMod_Click(object sender, EventArgs e)
        {

        }

        private void buttonMemoryRecall_Click(object sender, EventArgs e)
        {

        }

        private void buttonMemoryPlus_Click(object sender, EventArgs e)
        {

        }

        private void buttonMemoryClear_Click(object sender, EventArgs e)
        {

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {

        }
    }
}
