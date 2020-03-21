namespace SquareEquationApp_WinForms
{
    partial class Form1
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDiscriminant = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblFirstRoot = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSecondRoot = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPolyFactor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ax² + bx + c = 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter b:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter c:";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(105, 76);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 22);
            this.txtA.TabIndex = 4;
            this.txtA.TextChanged += new System.EventHandler(this.a_txt_TextChanged);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(105, 105);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 22);
            this.txtB.TabIndex = 5;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(105, 134);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 22);
            this.txtC.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter a:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(46, 180);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(159, 23);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "D =";
            // 
            // lblDiscriminant
            // 
            this.lblDiscriminant.AutoSize = true;
            this.lblDiscriminant.Location = new System.Drawing.Point(82, 227);
            this.lblDiscriminant.Name = "lblDiscriminant";
            this.lblDiscriminant.Size = new System.Drawing.Size(16, 17);
            this.lblDiscriminant.TabIndex = 10;
            this.lblDiscriminant.Text = "?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "x1 = ";
            // 
            // lblFirstRoot
            // 
            this.lblFirstRoot.AutoSize = true;
            this.lblFirstRoot.Location = new System.Drawing.Point(85, 248);
            this.lblFirstRoot.Name = "lblFirstRoot";
            this.lblFirstRoot.Size = new System.Drawing.Size(16, 17);
            this.lblFirstRoot.TabIndex = 12;
            this.lblFirstRoot.Text = "?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "x2 = ";
            // 
            // lblSecondRoot
            // 
            this.lblSecondRoot.AutoSize = true;
            this.lblSecondRoot.Location = new System.Drawing.Point(85, 269);
            this.lblSecondRoot.Name = "lblSecondRoot";
            this.lblSecondRoot.Size = new System.Drawing.Size(16, 17);
            this.lblSecondRoot.TabIndex = 14;
            this.lblSecondRoot.Text = "?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 319);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Polynomial factoring:";
            // 
            // lblPolyFactor
            // 
            this.lblPolyFactor.AutoSize = true;
            this.lblPolyFactor.Location = new System.Drawing.Point(49, 347);
            this.lblPolyFactor.Name = "lblPolyFactor";
            this.lblPolyFactor.Size = new System.Drawing.Size(80, 17);
            this.lblPolyFactor.TabIndex = 16;
            this.lblPolyFactor.Text = "Wait for it...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 450);
            this.Controls.Add(this.lblPolyFactor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblSecondRoot);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblFirstRoot);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblDiscriminant);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Square Equation App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDiscriminant;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblFirstRoot;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSecondRoot;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPolyFactor;
    }
}

