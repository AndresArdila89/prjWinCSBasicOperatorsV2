namespace prjWinCSBasicOperatorsV2
{
    partial class frmOperators
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtValue1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chArithmetics = new System.Windows.Forms.CheckBox();
            this.radAddition = new System.Windows.Forms.RadioButton();
            this.btnCompute = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDisplayRes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chComparison = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValue2 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.radDifferent = new System.Windows.Forms.RadioButton();
            this.radEqual = new System.Windows.Forms.RadioButton();
            this.btnEvaluate = new System.Windows.Forms.Button();
            this.radSmall = new System.Windows.Forms.RadioButton();
            this.radGreat = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.radDivision = new System.Windows.Forms.RadioButton();
            this.radMultiplication = new System.Windows.Forms.RadioButton();
            this.radSubstraction = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(531, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "BASIC OPERATORS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtValue1
            // 
            this.txtValue1.Location = new System.Drawing.Point(91, 37);
            this.txtValue1.Name = "txtValue1";
            this.txtValue1.Size = new System.Drawing.Size(100, 26);
            this.txtValue1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Value 1";
            // 
            // chArithmetics
            // 
            this.chArithmetics.AutoSize = true;
            this.chArithmetics.Location = new System.Drawing.Point(102, 217);
            this.chArithmetics.Name = "chArithmetics";
            this.chArithmetics.Size = new System.Drawing.Size(118, 24);
            this.chArithmetics.TabIndex = 3;
            this.chArithmetics.Text = "Arithmetics";
            this.chArithmetics.UseVisualStyleBackColor = true;
            this.chArithmetics.CheckedChanged += new System.EventHandler(this.chArithmetics_CheckedChanged);
            // 
            // radAddition
            // 
            this.radAddition.AutoSize = true;
            this.radAddition.Location = new System.Drawing.Point(18, 90);
            this.radAddition.Name = "radAddition";
            this.radAddition.Size = new System.Drawing.Size(93, 24);
            this.radAddition.TabIndex = 4;
            this.radAddition.TabStop = true;
            this.radAddition.Text = "Addition";
            this.radAddition.UseVisualStyleBackColor = true;
            // 
            // btnCompute
            // 
            this.btnCompute.Enabled = false;
            this.btnCompute.Location = new System.Drawing.Point(66, 148);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(390, 68);
            this.btnCompute.TabIndex = 5;
            this.btnCompute.Text = "COMPUTE";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.txtDisplayRes);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.chComparison);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.chArithmetics);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 851);
            this.panel1.TabIndex = 6;
            // 
            // txtDisplayRes
            // 
            this.txtDisplayRes.Location = new System.Drawing.Point(30, 731);
            this.txtDisplayRes.Multiline = true;
            this.txtDisplayRes.Name = "txtDisplayRes";
            this.txtDisplayRes.Size = new System.Drawing.Size(531, 99);
            this.txtDisplayRes.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(194, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Select type of operators";
            // 
            // chComparison
            // 
            this.chComparison.AutoSize = true;
            this.chComparison.Location = new System.Drawing.Point(386, 217);
            this.chComparison.Name = "chComparison";
            this.chComparison.Size = new System.Drawing.Size(123, 24);
            this.chComparison.TabIndex = 12;
            this.chComparison.Text = "Comparison";
            this.chComparison.UseVisualStyleBackColor = true;
            this.chComparison.CheckedChanged += new System.EventHandler(this.chComparison_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.txtValue2);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtValue1);
            this.panel4.Location = new System.Drawing.Point(30, 63);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(531, 100);
            this.panel4.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(329, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Value 2";
            // 
            // txtValue2
            // 
            this.txtValue2.Location = new System.Drawing.Point(405, 37);
            this.txtValue2.Name = "txtValue2";
            this.txtValue2.Size = new System.Drawing.Size(100, 26);
            this.txtValue2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.radDifferent);
            this.panel3.Controls.Add(this.radEqual);
            this.panel3.Controls.Add(this.btnEvaluate);
            this.panel3.Controls.Add(this.radSmall);
            this.panel3.Controls.Add(this.radGreat);
            this.panel3.Location = new System.Drawing.Point(30, 489);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(531, 235);
            this.panel3.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Navy;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(1, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(267, 44);
            this.label4.TabIndex = 9;
            this.label4.Text = "Comparison Operators";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radDifferent
            // 
            this.radDifferent.AutoSize = true;
            this.radDifferent.Location = new System.Drawing.Point(407, 98);
            this.radDifferent.Name = "radDifferent";
            this.radDifferent.Size = new System.Drawing.Size(98, 24);
            this.radDifferent.TabIndex = 8;
            this.radDifferent.TabStop = true;
            this.radDifferent.Text = "Different";
            this.radDifferent.UseVisualStyleBackColor = true;
            // 
            // radEqual
            // 
            this.radEqual.AutoSize = true;
            this.radEqual.Location = new System.Drawing.Point(277, 98);
            this.radEqual.Name = "radEqual";
            this.radEqual.Size = new System.Drawing.Size(73, 24);
            this.radEqual.TabIndex = 7;
            this.radEqual.TabStop = true;
            this.radEqual.Text = "Equal";
            this.radEqual.UseVisualStyleBackColor = true;
            // 
            // btnEvaluate
            // 
            this.btnEvaluate.Enabled = false;
            this.btnEvaluate.Location = new System.Drawing.Point(67, 154);
            this.btnEvaluate.Name = "btnEvaluate";
            this.btnEvaluate.Size = new System.Drawing.Size(390, 68);
            this.btnEvaluate.TabIndex = 5;
            this.btnEvaluate.Text = "EVALUATE";
            this.btnEvaluate.UseVisualStyleBackColor = true;
            this.btnEvaluate.Click += new System.EventHandler(this.btnEvaluate_Click);
            // 
            // radSmall
            // 
            this.radSmall.AutoSize = true;
            this.radSmall.Location = new System.Drawing.Point(149, 98);
            this.radSmall.Name = "radSmall";
            this.radSmall.Size = new System.Drawing.Size(71, 24);
            this.radSmall.TabIndex = 6;
            this.radSmall.TabStop = true;
            this.radSmall.Text = "Small";
            this.radSmall.UseVisualStyleBackColor = true;
            // 
            // radGreat
            // 
            this.radGreat.AutoSize = true;
            this.radGreat.Location = new System.Drawing.Point(19, 98);
            this.radGreat.Name = "radGreat";
            this.radGreat.Size = new System.Drawing.Size(73, 24);
            this.radGreat.TabIndex = 4;
            this.radGreat.TabStop = true;
            this.radGreat.Text = "Great";
            this.radGreat.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.radDivision);
            this.panel2.Controls.Add(this.radMultiplication);
            this.panel2.Controls.Add(this.btnCompute);
            this.panel2.Controls.Add(this.radSubstraction);
            this.panel2.Controls.Add(this.radAddition);
            this.panel2.Location = new System.Drawing.Point(30, 251);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(531, 232);
            this.panel2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Brown;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(1, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 44);
            this.label3.TabIndex = 9;
            this.label3.Text = "Arithmetic Operators";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radDivision
            // 
            this.radDivision.AutoSize = true;
            this.radDivision.Location = new System.Drawing.Point(414, 90);
            this.radDivision.Name = "radDivision";
            this.radDivision.Size = new System.Drawing.Size(89, 24);
            this.radDivision.TabIndex = 8;
            this.radDivision.TabStop = true;
            this.radDivision.Text = "Division";
            this.radDivision.UseVisualStyleBackColor = true;
            // 
            // radMultiplication
            // 
            this.radMultiplication.AutoSize = true;
            this.radMultiplication.Location = new System.Drawing.Point(268, 90);
            this.radMultiplication.Name = "radMultiplication";
            this.radMultiplication.Size = new System.Drawing.Size(132, 24);
            this.radMultiplication.TabIndex = 7;
            this.radMultiplication.TabStop = true;
            this.radMultiplication.Text = "Multiplication";
            this.radMultiplication.UseVisualStyleBackColor = true;
            // 
            // radSubstraction
            // 
            this.radSubstraction.AutoSize = true;
            this.radSubstraction.Location = new System.Drawing.Point(125, 90);
            this.radSubstraction.Name = "radSubstraction";
            this.radSubstraction.Size = new System.Drawing.Size(129, 24);
            this.radSubstraction.TabIndex = 6;
            this.radSubstraction.TabStop = true;
            this.radSubstraction.Text = "Substraction";
            this.radSubstraction.UseVisualStyleBackColor = true;
            // 
            // frmOperators
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(614, 864);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmOperators";
            this.Text = "frmOperators";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValue1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chArithmetics;
        private System.Windows.Forms.RadioButton radAddition;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radDivision;
        private System.Windows.Forms.RadioButton radMultiplication;
        private System.Windows.Forms.RadioButton radSubstraction;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radDifferent;
        private System.Windows.Forms.RadioButton radEqual;
        private System.Windows.Forms.Button btnEvaluate;
        private System.Windows.Forms.RadioButton radSmall;
        private System.Windows.Forms.RadioButton radGreat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chComparison;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValue2;
        private System.Windows.Forms.TextBox txtDisplayRes;
    }
}

