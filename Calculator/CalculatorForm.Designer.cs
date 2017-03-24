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
            this.labelExp = new System.Windows.Forms.Label();
            this.labelRes = new System.Windows.Forms.Label();
            this.textBoxExpression = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.groupBoxEdit = new System.Windows.Forms.GroupBox();
            this.buttonCloseBracket = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonOpenBracket = new System.Windows.Forms.Button();
            this.buttonBackspace = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMin = new System.Windows.Forms.Button();
            this.buttonMult = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.buttonEq = new System.Windows.Forms.Button();
            this.buttonMC = new System.Windows.Forms.Button();
            this.buttonMPlus = new System.Windows.Forms.Button();
            this.buttonMR = new System.Windows.Forms.Button();
            this.buttonMod = new System.Windows.Forms.Button();
            this.buttonNeg = new System.Windows.Forms.Button();
            this.groupBoxEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelExp
            // 
            this.labelExp.AutoSize = true;
            this.labelExp.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExp.Location = new System.Drawing.Point(12, 9);
            this.labelExp.Name = "labelExp";
            this.labelExp.Size = new System.Drawing.Size(68, 19);
            this.labelExp.TabIndex = 0;
            this.labelExp.Text = "Expression";
            // 
            // labelRes
            // 
            this.labelRes.AutoSize = true;
            this.labelRes.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRes.Location = new System.Drawing.Point(12, 48);
            this.labelRes.Name = "labelRes";
            this.labelRes.Size = new System.Drawing.Size(43, 19);
            this.labelRes.TabIndex = 1;
            this.labelRes.Text = "Result";
            // 
            // textBoxExpression
            // 
            this.textBoxExpression.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxExpression.Location = new System.Drawing.Point(120, 9);
            this.textBoxExpression.Name = "textBoxExpression";
            this.textBoxExpression.ReadOnly = true;
            this.textBoxExpression.Size = new System.Drawing.Size(184, 20);
            this.textBoxExpression.TabIndex = 2;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(120, 48);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(184, 20);
            this.textBoxResult.TabIndex = 3;
            // 
            // groupBoxEdit
            // 
            this.groupBoxEdit.Controls.Add(this.buttonCloseBracket);
            this.groupBoxEdit.Controls.Add(this.buttonClear);
            this.groupBoxEdit.Controls.Add(this.buttonOpenBracket);
            this.groupBoxEdit.Controls.Add(this.buttonBackspace);
            this.groupBoxEdit.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxEdit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBoxEdit.Location = new System.Drawing.Point(15, 85);
            this.groupBoxEdit.Name = "groupBoxEdit";
            this.groupBoxEdit.Size = new System.Drawing.Size(289, 48);
            this.groupBoxEdit.TabIndex = 4;
            this.groupBoxEdit.TabStop = false;
            this.groupBoxEdit.Text = "Edit";
            // 
            // buttonCloseBracket
            // 
            this.buttonCloseBracket.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCloseBracket.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonCloseBracket.Location = new System.Drawing.Point(61, 19);
            this.buttonCloseBracket.Name = "buttonCloseBracket";
            this.buttonCloseBracket.Size = new System.Drawing.Size(48, 23);
            this.buttonCloseBracket.TabIndex = 6;
            this.buttonCloseBracket.Text = ")";
            this.buttonCloseBracket.UseVisualStyleBackColor = true;
            this.buttonCloseBracket.Click += new System.EventHandler(this.buttonCloseBracket_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.ForeColor = System.Drawing.Color.Red;
            this.buttonClear.Location = new System.Drawing.Point(130, 19);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(64, 23);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonOpenBracket
            // 
            this.buttonOpenBracket.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenBracket.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonOpenBracket.Location = new System.Drawing.Point(6, 19);
            this.buttonOpenBracket.Name = "buttonOpenBracket";
            this.buttonOpenBracket.Size = new System.Drawing.Size(49, 23);
            this.buttonOpenBracket.TabIndex = 5;
            this.buttonOpenBracket.Text = "(";
            this.buttonOpenBracket.UseVisualStyleBackColor = true;
            this.buttonOpenBracket.Click += new System.EventHandler(this.buttonOpenBracket_Click);
            // 
            // buttonBackspace
            // 
            this.buttonBackspace.ForeColor = System.Drawing.Color.Red;
            this.buttonBackspace.Location = new System.Drawing.Point(207, 19);
            this.buttonBackspace.Name = "buttonBackspace";
            this.buttonBackspace.Size = new System.Drawing.Size(75, 23);
            this.buttonBackspace.TabIndex = 8;
            this.buttonBackspace.Text = "Backspace";
            this.buttonBackspace.UseVisualStyleBackColor = true;
            this.buttonBackspace.Click += new System.EventHandler(this.buttonBackspace_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(15, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(68, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 29);
            this.button2.TabIndex = 6;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(120, 145);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(37, 29);
            this.button3.TabIndex = 7;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(15, 190);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(37, 29);
            this.button4.TabIndex = 8;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(68, 190);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(37, 29);
            this.button5.TabIndex = 9;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(120, 190);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(37, 29);
            this.button6.TabIndex = 10;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(15, 235);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(37, 29);
            this.button7.TabIndex = 11;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(68, 235);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(37, 29);
            this.button8.TabIndex = 12;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Location = new System.Drawing.Point(120, 235);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(37, 29);
            this.button9.TabIndex = 13;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button0.Location = new System.Drawing.Point(68, 280);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(37, 29);
            this.button0.TabIndex = 14;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlus.ForeColor = System.Drawing.Color.Red;
            this.buttonPlus.Location = new System.Drawing.Point(172, 280);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(37, 29);
            this.buttonPlus.TabIndex = 18;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonMin
            // 
            this.buttonMin.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMin.ForeColor = System.Drawing.Color.Red;
            this.buttonMin.Location = new System.Drawing.Point(172, 235);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(37, 29);
            this.buttonMin.TabIndex = 17;
            this.buttonMin.Text = "-";
            this.buttonMin.UseVisualStyleBackColor = true;
            this.buttonMin.Click += new System.EventHandler(this.buttonMin_Click);
            // 
            // buttonMult
            // 
            this.buttonMult.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMult.ForeColor = System.Drawing.Color.Red;
            this.buttonMult.Location = new System.Drawing.Point(172, 190);
            this.buttonMult.Name = "buttonMult";
            this.buttonMult.Size = new System.Drawing.Size(37, 29);
            this.buttonMult.TabIndex = 16;
            this.buttonMult.Text = "*";
            this.buttonMult.UseVisualStyleBackColor = true;
            this.buttonMult.Click += new System.EventHandler(this.buttonMult_Click);
            // 
            // buttonDiv
            // 
            this.buttonDiv.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDiv.ForeColor = System.Drawing.Color.Red;
            this.buttonDiv.Location = new System.Drawing.Point(172, 145);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(37, 29);
            this.buttonDiv.TabIndex = 15;
            this.buttonDiv.Text = "/";
            this.buttonDiv.UseVisualStyleBackColor = true;
            this.buttonDiv.Click += new System.EventHandler(this.buttonDiv_Click);
            // 
            // buttonEq
            // 
            this.buttonEq.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEq.ForeColor = System.Drawing.Color.Red;
            this.buttonEq.Location = new System.Drawing.Point(267, 280);
            this.buttonEq.Name = "buttonEq";
            this.buttonEq.Size = new System.Drawing.Size(37, 29);
            this.buttonEq.TabIndex = 22;
            this.buttonEq.Text = "=";
            this.buttonEq.UseVisualStyleBackColor = true;
            this.buttonEq.Click += new System.EventHandler(this.buttonEq_Click);
            // 
            // buttonMC
            // 
            this.buttonMC.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMC.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonMC.Location = new System.Drawing.Point(267, 235);
            this.buttonMC.Name = "buttonMC";
            this.buttonMC.Size = new System.Drawing.Size(37, 29);
            this.buttonMC.TabIndex = 21;
            this.buttonMC.Text = "MC";
            this.buttonMC.UseVisualStyleBackColor = true;
            this.buttonMC.Click += new System.EventHandler(this.buttonMC_Click);
            // 
            // buttonMPlus
            // 
            this.buttonMPlus.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMPlus.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonMPlus.Location = new System.Drawing.Point(267, 190);
            this.buttonMPlus.Name = "buttonMPlus";
            this.buttonMPlus.Size = new System.Drawing.Size(37, 29);
            this.buttonMPlus.TabIndex = 20;
            this.buttonMPlus.Text = "M+";
            this.buttonMPlus.UseVisualStyleBackColor = true;
            this.buttonMPlus.Click += new System.EventHandler(this.buttonMPlus_Click);
            // 
            // buttonMR
            // 
            this.buttonMR.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMR.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonMR.Location = new System.Drawing.Point(267, 145);
            this.buttonMR.Name = "buttonMR";
            this.buttonMR.Size = new System.Drawing.Size(37, 29);
            this.buttonMR.TabIndex = 19;
            this.buttonMR.Text = "MR";
            this.buttonMR.UseVisualStyleBackColor = true;
            this.buttonMR.Click += new System.EventHandler(this.buttonMR_Click);
            // 
            // buttonMod
            // 
            this.buttonMod.Font = new System.Drawing.Font("Segoe Print", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMod.ForeColor = System.Drawing.Color.Red;
            this.buttonMod.Location = new System.Drawing.Point(120, 280);
            this.buttonMod.Name = "buttonMod";
            this.buttonMod.Size = new System.Drawing.Size(37, 29);
            this.buttonMod.TabIndex = 23;
            this.buttonMod.Text = "mod";
            this.buttonMod.UseVisualStyleBackColor = true;
            this.buttonMod.Click += new System.EventHandler(this.buttonMod_Click);
            // 
            // buttonNeg
            // 
            this.buttonNeg.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNeg.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonNeg.Location = new System.Drawing.Point(15, 279);
            this.buttonNeg.Name = "buttonNeg";
            this.buttonNeg.Size = new System.Drawing.Size(37, 29);
            this.buttonNeg.TabIndex = 24;
            this.buttonNeg.Text = "00";
            this.buttonNeg.UseVisualStyleBackColor = true;
            this.buttonNeg.Click += new System.EventHandler(this.buttonNeg_Click);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 324);
            this.Controls.Add(this.buttonNeg);
            this.Controls.Add(this.buttonMod);
            this.Controls.Add(this.buttonEq);
            this.Controls.Add(this.buttonMC);
            this.Controls.Add(this.buttonMPlus);
            this.Controls.Add(this.buttonMR);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonMin);
            this.Controls.Add(this.buttonMult);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBoxEdit);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxExpression);
            this.Controls.Add(this.labelRes);
            this.Controls.Add(this.labelExp);
            this.Name = "CalculatorForm";
            this.Text = "Calculator";
            this.groupBoxEdit.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelExp;
        private System.Windows.Forms.Label labelRes;
        private System.Windows.Forms.TextBox textBoxExpression;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.GroupBox groupBoxEdit;
        private System.Windows.Forms.Button buttonCloseBracket;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonOpenBracket;
        private System.Windows.Forms.Button buttonBackspace;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMin;
        private System.Windows.Forms.Button buttonMult;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Button buttonEq;
        private System.Windows.Forms.Button buttonMC;
        private System.Windows.Forms.Button buttonMPlus;
        private System.Windows.Forms.Button buttonMR;
        private System.Windows.Forms.Button buttonMod;
        private System.Windows.Forms.Button buttonNeg;
    }
}

