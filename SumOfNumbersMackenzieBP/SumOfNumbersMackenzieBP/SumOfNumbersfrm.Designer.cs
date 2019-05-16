namespace SumOfNumbersMackenzieBP
{
    partial class SumOfNumbersfrm
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
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblAnswer1 = new System.Windows.Forms.Label();
            this.lblAnswer2 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(36, 44);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 0;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(33, 9);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(135, 13);
            this.lblNumber.TabIndex = 1;
            this.lblNumber.Text = "Put number into box below.";
            // 
            // lblAnswer1
            // 
            this.lblAnswer1.AutoSize = true;
            this.lblAnswer1.Location = new System.Drawing.Point(22, 160);
            this.lblAnswer1.Name = "lblAnswer1";
            this.lblAnswer1.Size = new System.Drawing.Size(116, 13);
            this.lblAnswer1.TabIndex = 2;
            this.lblAnswer1.Text = "The sum of numbers is:";
            this.lblAnswer1.Click += new System.EventHandler(this.lblAnswer1_Click);
            // 
            // lblAnswer2
            // 
            this.lblAnswer2.AutoSize = true;
            this.lblAnswer2.Location = new System.Drawing.Point(144, 160);
            this.lblAnswer2.Name = "lblAnswer2";
            this.lblAnswer2.Size = new System.Drawing.Size(28, 13);
            this.lblAnswer2.TabIndex = 3;
            this.lblAnswer2.Text = "Text";
            this.lblAnswer2.Click += new System.EventHandler(this.lblAnswer2_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(36, 93);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(102, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "C:\\Calculate.exe";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(197, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // SumOfNumbersfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblAnswer2);
            this.Controls.Add(this.lblAnswer1);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.txtNumber);
            this.Name = "SumOfNumbersfrm";
            this.Text = "SumOfNumbers By: Mackenzie Brown Plourde";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblAnswer1;
        private System.Windows.Forms.Label lblAnswer2;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
    }
}

