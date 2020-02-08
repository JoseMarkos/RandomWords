namespace TextoRandom
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
            this.labelDisorder = new System.Windows.Forms.Label();
            this.labelInstructions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDisorder
            // 
            this.labelDisorder.AutoSize = true;
            this.labelDisorder.Location = new System.Drawing.Point(58, 320);
            this.labelDisorder.Name = "labelDisorder";
            this.labelDisorder.Size = new System.Drawing.Size(35, 13);
            this.labelDisorder.TabIndex = 0;
            this.labelDisorder.Text = "label1";
            // 
            // labelInstructions
            // 
            this.labelInstructions.AutoSize = true;
            this.labelInstructions.Location = new System.Drawing.Point(58, 44);
            this.labelInstructions.Name = "labelInstructions";
            this.labelInstructions.Size = new System.Drawing.Size(72, 13);
            this.labelInstructions.TabIndex = 1;
            this.labelInstructions.Text = "instructions ...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 364);
            this.Controls.Add(this.labelInstructions);
            this.Controls.Add(this.labelDisorder);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDisorder;
        private System.Windows.Forms.Label labelInstructions;
    }
}

