namespace WalkingManMackenzieBP
{
    partial class frmWalk
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
            this.picWalk = new System.Windows.Forms.PictureBox();
            this.btnWalk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picWalk)).BeginInit();
            this.SuspendLayout();
            // 
            // picWalk
            // 
            this.picWalk.Image = global::WalkingManMackenzieBP.Properties.Resources.walk6;
            this.picWalk.Location = new System.Drawing.Point(45, 63);
            this.picWalk.Name = "picWalk";
            this.picWalk.Size = new System.Drawing.Size(202, 186);
            this.picWalk.TabIndex = 0;
            this.picWalk.TabStop = false;
            this.picWalk.Click += new System.EventHandler(this.picWalk_Click);
            // 
            // btnWalk
            // 
            this.btnWalk.Location = new System.Drawing.Point(102, 10);
            this.btnWalk.Name = "btnWalk";
            this.btnWalk.Size = new System.Drawing.Size(84, 47);
            this.btnWalk.TabIndex = 1;
            this.btnWalk.Text = "Walk";
            this.btnWalk.UseVisualStyleBackColor = true;
            this.btnWalk.Click += new System.EventHandler(this.btnWalk_Click);
            // 
            // frmWalk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnWalk);
            this.Controls.Add(this.picWalk);
            this.Name = "frmWalk";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picWalk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picWalk;
        private System.Windows.Forms.Button btnWalk;
    }
}

