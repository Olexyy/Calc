namespace Calculator
{
    partial class CalculatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelExpression = new System.Windows.Forms.Label();
            this.textBoxExpression = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.groupBoxEditing = new System.Windows.Forms.GroupBox();
            this.buttonExOpenBracers = new System.Windows.Forms.Button();
            this.buttonExCloseBracers = new System.Windows.Forms.Button();
            this.buttonExErase = new System.Windows.Forms.Button();
            this.buttonExReset = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonNegate = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonMod = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMemoryRecall = new System.Windows.Forms.Button();
            this.buttonMemoryPlus = new System.Windows.Forms.Button();
            this.buttonMemoryClear = new System.Windows.Forms.Button();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.groupBoxEditing.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelExpression
            // 
            this.labelExpression.AutoSize = true;
            this.labelExpression.Location = new System.Drawing.Point(13, 13);
            this.labelExpression.Name = "labelExpression";
            this.labelExpression.Size = new System.Drawing.Size(58, 13);
            this.labelExpression.TabIndex = 0;
            this.labelExpression.Text = "Expression";
            // 
            // textBoxExpression
            // 
            this.textBoxExpression.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxExpression.Location = new System.Drawing.Point(77, 10);
            this.textBoxExpression.Name = "textBoxExpression";
            this.textBoxExpression.Size = new System.Drawing.Size(233, 20);
            this.textBoxExpression.TabIndex = 1;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(13, 38);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(37, 13);
            this.labelResult.TabIndex = 2;
            this.labelResult.Text = "Result";
            // 
            // textBoxResult
            // 
            this.textBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxResult.Enabled = false;
            this.textBoxResult.Location = new System.Drawing.Point(77, 36);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(233, 20);
            this.textBoxResult.TabIndex = 3;
            // 
            // groupBoxEditing
            // 
            this.groupBoxEditing.Controls.Add(this.buttonExReset);
            this.groupBoxEditing.Controls.Add(this.buttonExOpenBracers);
            this.groupBoxEditing.Controls.Add(this.buttonExErase);
            this.groupBoxEditing.Controls.Add(this.buttonExCloseBracers);
            this.groupBoxEditing.Location = new System.Drawing.Point(12, 62);
            this.groupBoxEditing.Name = "groupBoxEditing";
            this.groupBoxEditing.Size = new System.Drawing.Size(298, 60);
            this.groupBoxEditing.TabIndex = 4;
            this.groupBoxEditing.TabStop = false;
            this.groupBoxEditing.Text = "Editing";
            // 
            // buttonExOpenBracers
            // 
            this.buttonExOpenBracers.Location = new System.Drawing.Point(6, 19);
            this.buttonExOpenBracers.Name = "buttonExOpenBracers";
            this.buttonExOpenBracers.Size = new System.Drawing.Size(38, 30);
            this.buttonExOpenBracers.TabIndex = 0;
            this.buttonExOpenBracers.Text = "(";
            this.buttonExOpenBracers.UseVisualStyleBackColor = true;
            // 
            // buttonExCloseBracers
            // 
            this.buttonExCloseBracers.Location = new System.Drawing.Point(50, 19);
            this.buttonExCloseBracers.Name = "buttonExCloseBracers";
            this.buttonExCloseBracers.Size = new System.Drawing.Size(38, 30);
            this.buttonExCloseBracers.TabIndex = 5;
            this.buttonExCloseBracers.Text = ")";
            this.buttonExCloseBracers.UseVisualStyleBackColor = true;
            // 
            // buttonExErase
            // 
            this.buttonExErase.Location = new System.Drawing.Point(232, 19);
            this.buttonExErase.Name = "buttonExErase";
            this.buttonExErase.Size = new System.Drawing.Size(60, 30);
            this.buttonExErase.TabIndex = 6;
            this.buttonExErase.Text = "Erase";
            this.buttonExErase.UseVisualStyleBackColor = true;
            // 
            // buttonExReset
            // 
            this.buttonExReset.Location = new System.Drawing.Point(151, 19);
            this.buttonExReset.Name = "buttonExReset";
            this.buttonExReset.Size = new System.Drawing.Size(75, 30);
            this.buttonExReset.TabIndex = 7;
            this.buttonExReset.Text = "Reset";
            this.buttonExReset.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(62, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 30);
            this.button2.TabIndex = 9;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(106, 138);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(38, 30);
            this.button3.TabIndex = 10;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(18, 174);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(38, 30);
            this.button4.TabIndex = 11;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(62, 174);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(38, 30);
            this.button5.TabIndex = 12;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(106, 174);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(38, 30);
            this.button6.TabIndex = 13;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(18, 210);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(38, 30);
            this.button7.TabIndex = 14;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(62, 210);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(38, 30);
            this.button8.TabIndex = 15;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(106, 210);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(38, 30);
            this.button9.TabIndex = 16;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // buttonMinus
            // 
            this.buttonMinus.Location = new System.Drawing.Point(150, 210);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(38, 30);
            this.buttonMinus.TabIndex = 17;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            // 
            // buttonDivide
            // 
            this.buttonDivide.Location = new System.Drawing.Point(150, 138);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(38, 30);
            this.buttonDivide.TabIndex = 18;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = true;
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Location = new System.Drawing.Point(150, 174);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(38, 30);
            this.buttonMultiply.TabIndex = 19;
            this.buttonMultiply.Text = "*";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            // 
            // buttonNegate
            // 
            this.buttonNegate.Location = new System.Drawing.Point(18, 246);
            this.buttonNegate.Name = "buttonNegate";
            this.buttonNegate.Size = new System.Drawing.Size(38, 30);
            this.buttonNegate.TabIndex = 20;
            this.buttonNegate.Text = "+/-";
            this.buttonNegate.UseVisualStyleBackColor = true;
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(62, 246);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(38, 30);
            this.button0.TabIndex = 21;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            // 
            // buttonMod
            // 
            this.buttonMod.Location = new System.Drawing.Point(106, 246);
            this.buttonMod.Name = "buttonMod";
            this.buttonMod.Size = new System.Drawing.Size(38, 30);
            this.buttonMod.TabIndex = 22;
            this.buttonMod.Text = "mod";
            this.buttonMod.UseVisualStyleBackColor = true;
            // 
            // buttonPlus
            // 
            this.buttonPlus.Location = new System.Drawing.Point(150, 246);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(38, 30);
            this.buttonPlus.TabIndex = 23;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            // 
            // buttonMemoryRecall
            // 
            this.buttonMemoryRecall.Location = new System.Drawing.Point(266, 138);
            this.buttonMemoryRecall.Name = "buttonMemoryRecall";
            this.buttonMemoryRecall.Size = new System.Drawing.Size(38, 30);
            this.buttonMemoryRecall.TabIndex = 24;
            this.buttonMemoryRecall.Text = "MR";
            this.buttonMemoryRecall.UseVisualStyleBackColor = true;
            // 
            // buttonMemoryPlus
            // 
            this.buttonMemoryPlus.Location = new System.Drawing.Point(266, 174);
            this.buttonMemoryPlus.Name = "buttonMemoryPlus";
            this.buttonMemoryPlus.Size = new System.Drawing.Size(38, 30);
            this.buttonMemoryPlus.TabIndex = 25;
            this.buttonMemoryPlus.Text = "M+";
            this.buttonMemoryPlus.UseVisualStyleBackColor = true;
            // 
            // buttonMemoryClear
            // 
            this.buttonMemoryClear.Location = new System.Drawing.Point(266, 210);
            this.buttonMemoryClear.Name = "buttonMemoryClear";
            this.buttonMemoryClear.Size = new System.Drawing.Size(38, 30);
            this.buttonMemoryClear.TabIndex = 26;
            this.buttonMemoryClear.Text = "MC";
            this.buttonMemoryClear.UseVisualStyleBackColor = true;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(266, 246);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(38, 30);
            this.buttonCalculate.TabIndex = 27;
            this.buttonCalculate.Text = "=";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 288);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.buttonMemoryClear);
            this.Controls.Add(this.buttonMemoryPlus);
            this.Controls.Add(this.buttonMemoryRecall);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonMod);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.buttonNegate);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBoxEditing);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.textBoxExpression);
            this.Controls.Add(this.labelExpression);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CalculatorForm";
            this.Text = "Calculator";
            this.groupBoxEditing.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelExpression;
        private System.Windows.Forms.TextBox textBoxExpression;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.GroupBox groupBoxEditing;
        private System.Windows.Forms.Button buttonExOpenBracers;
        private System.Windows.Forms.Button buttonExCloseBracers;
        private System.Windows.Forms.Button buttonExErase;
        private System.Windows.Forms.Button buttonExReset;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonNegate;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonMod;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMemoryRecall;
        private System.Windows.Forms.Button buttonMemoryPlus;
        private System.Windows.Forms.Button buttonMemoryClear;
        private System.Windows.Forms.Button buttonCalculate;
    }
}

