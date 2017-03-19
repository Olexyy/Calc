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
        private char[] Allowed { get { return new char[] { '(', ')', ',', '.', '+', '-', '*', '/', ' ' }; } }
        private bool ExtendedMode { get; set; }
        public CalculatorForm()
        {
            InitializeComponent();
        }
        private void TrimInput()
        {
            this.Input = new string(this.Input.ToCharArray().Where(c => !Char.IsWhiteSpace(c)).ToArray());
        }
        private bool ValidateInput()
        {
            bool error = false;
            int open = 0;
            int close = 0;
            foreach (char symbol in this.Input)
            {
                if (!(Char.IsDigit(symbol) || this.Allowed.Contains(symbol)))
                    error = true;
                if (symbol == '(')
                    open++;
                if (symbol == ')')
                    close++;
            }
            return ((open == close) && (!error));
        }

        private void textBoxExpression_TextChanged(object sender, EventArgs e)
        {
            if (this.Input.Contains('(') || this.Input.Contains(')'))
                this.ExtendedMode = true;
            else
                this.ExtendedMode = false;
        }
    }
}
