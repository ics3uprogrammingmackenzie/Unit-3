namespace RandoNumbersMacBP
{
    partial class frmRandomNumbers
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
            this.lblGuess = new System.Windows.Forms.Label();
            this.lblWin = new System.Windows.Forms.Label();
            this.lblLoss = new System.Windows.Forms.Label();
            this.btnCheak = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblGuess
            // 
            this.lblGuess.AutoSize = true;
            this.lblGuess.Location = new System.Drawing.Point(12, 19);
            this.lblGuess.Name = "lblGuess";
            this.lblGuess.Size = new System.Drawing.Size(158, 13);
            this.lblGuess.TabIndex = 0;
            this.lblGuess.Text = "Guess a number between 1 - 10";
            // 
            // lblWin
            // 
            this.lblWin.AutoSize = true;
            this.lblWin.Location = new System.Drawing.Point(26, 180);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(99, 13);
            this.lblWin.TabIndex = 1;
            this.lblWin.Text = "You Guessed Right";
            // 
            // lblLoss
            // 
            this.lblLoss.AutoSize = true;
            this.lblLoss.Location = new System.Drawing.Point(180, 180);
            this.lblLoss.Name = "lblLoss";
            this.lblLoss.Size = new System.Drawing.Size(106, 13);
            this.lblLoss.TabIndex = 2;
            this.lblLoss.Text = "You Guessed Wrong";
            // 
            // btnCheak
            // 
            this.btnCheak.Location = new System.Drawing.Point(101, 96);
            this.btnCheak.Name = "btnCheak";
            this.btnCheak.Size = new System.Drawing.Size(75, 23);
            this.btnCheak.TabIndex = 3;
            this.btnCheak.Text = "Check";
            this.btnCheak.UseVisualStyleBackColor = true;
            this.btnCheak.Click += new System.EventHandler(this.btnCheak_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(183, 12);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 20);
            this.txtInput.TabIndex = 4;
            // 
            // frmRandomNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnCheak);
            this.Controls.Add(this.lblLoss);
            this.Controls.Add(this.lblWin);
            this.Controls.Add(this.lblGuess);
            this.Name = "frmRandomNumbers";
            this.Text = "RandomNumbers By Mackenzie Brown Plourde";
            this.Load += new System.EventHandler(this.frmRandomNumbers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGuess;
        private System.Windows.Forms.Label lblWin;
        private System.Windows.Forms.Label lblLoss;
        private System.Windows.Forms.Button btnCheak;
        private System.Windows.Forms.TextBox txtInput;
    }
}

