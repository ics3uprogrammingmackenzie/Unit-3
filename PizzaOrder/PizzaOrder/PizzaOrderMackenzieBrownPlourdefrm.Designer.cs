namespace PizzaOrder
{
    partial class PizzaOrderMackenzieBrownPlourdefrm
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
            this.numSize = new System.Windows.Forms.NumericUpDown();
            this.numTopings = new System.Windows.Forms.NumericUpDown();
            this.btnPizza = new System.Windows.Forms.Button();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblTopings = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblLedgend = new System.Windows.Forms.Label();
            this.lblDisgrace = new System.Windows.Forms.Label();
            this.numPineapple = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTopings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPineapple)).BeginInit();
            this.SuspendLayout();
            // 
            // numSize
            // 
            this.numSize.Location = new System.Drawing.Point(181, 35);
            this.numSize.Name = "numSize";
            this.numSize.Size = new System.Drawing.Size(120, 20);
            this.numSize.TabIndex = 0;
            this.numSize.ValueChanged += new System.EventHandler(this.numSize_ValueChanged);
            // 
            // numTopings
            // 
            this.numTopings.Location = new System.Drawing.Point(181, 98);
            this.numTopings.Name = "numTopings";
            this.numTopings.Size = new System.Drawing.Size(120, 20);
            this.numTopings.TabIndex = 1;
            // 
            // btnPizza
            // 
            this.btnPizza.Location = new System.Drawing.Point(154, 205);
            this.btnPizza.Name = "btnPizza";
            this.btnPizza.Size = new System.Drawing.Size(147, 23);
            this.btnPizza.TabIndex = 2;
            this.btnPizza.Text = "P I Z Z A  T I M E";
            this.btnPizza.UseVisualStyleBackColor = true;
            this.btnPizza.Click += new System.EventHandler(this.btnPizza_Click);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(12, 35);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(55, 13);
            this.lblSize.TabIndex = 3;
            this.lblSize.Text = "Pizza Size";
            // 
            // lblTopings
            // 
            this.lblTopings.AutoSize = true;
            this.lblTopings.Location = new System.Drawing.Point(12, 98);
            this.lblTopings.Name = "lblTopings";
            this.lblTopings.Size = new System.Drawing.Size(93, 13);
            this.lblTopings.TabIndex = 4;
            this.lblTopings.Text = "Number of topings";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(151, 260);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(35, 13);
            this.lblAmount.TabIndex = 5;
            this.lblAmount.Text = "label3";
            // 
            // lblLedgend
            // 
            this.lblLedgend.AutoSize = true;
            this.lblLedgend.Location = new System.Drawing.Point(336, 42);
            this.lblLedgend.Name = "lblLedgend";
            this.lblLedgend.Size = new System.Drawing.Size(429, 13);
            this.lblLedgend.TabIndex = 6;
            this.lblLedgend.Text = "Size: 1 = Large $9.99 2  X Large = $12.99 1 toping = $.75  2 = $1.35  3 = $2.15 4" +
    " = $2.75";
            // 
            // lblDisgrace
            // 
            this.lblDisgrace.AutoSize = true;
            this.lblDisgrace.Location = new System.Drawing.Point(12, 154);
            this.lblDisgrace.Name = "lblDisgrace";
            this.lblDisgrace.Size = new System.Drawing.Size(54, 13);
            this.lblDisgrace.TabIndex = 7;
            this.lblDisgrace.Text = "Pineapple";
            // 
            // numPineapple
            // 
            this.numPineapple.Location = new System.Drawing.Point(181, 152);
            this.numPineapple.Name = "numPineapple";
            this.numPineapple.Size = new System.Drawing.Size(120, 20);
            this.numPineapple.TabIndex = 8;
            // 
            // PizzaOrderMackenzieBrownPlourdefrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numPineapple);
            this.Controls.Add(this.lblDisgrace);
            this.Controls.Add(this.lblLedgend);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblTopings);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.btnPizza);
            this.Controls.Add(this.numTopings);
            this.Controls.Add(this.numSize);
            this.Name = "PizzaOrderMackenzieBrownPlourdefrm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PizzaOrderMackenzieBrownPlourdefrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTopings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPineapple)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numSize;
        private System.Windows.Forms.NumericUpDown numTopings;
        private System.Windows.Forms.Button btnPizza;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblTopings;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblLedgend;
        private System.Windows.Forms.Label lblDisgrace;
        private System.Windows.Forms.NumericUpDown numPineapple;
    }
}

