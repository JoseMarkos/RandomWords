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
            this.labelInstructions = new System.Windows.Forms.Label();
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.splitDisplay = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitDisplay)).BeginInit();
            this.splitDisplay.Panel1.SuspendLayout();
            this.splitDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelInstructions
            // 
            this.labelInstructions.AutoSize = true;
            this.labelInstructions.Location = new System.Drawing.Point(22, 21);
            this.labelInstructions.Name = "labelInstructions";
            this.labelInstructions.Size = new System.Drawing.Size(72, 13);
            this.labelInstructions.TabIndex = 1;
            this.labelInstructions.Text = "instructions ...";
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.Location = new System.Drawing.Point(0, 0);
            this.splitMain.Name = "splitMain";
            this.splitMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.splitDisplay);
            this.splitMain.Size = new System.Drawing.Size(633, 239);
            this.splitMain.SplitterDistance = 181;
            this.splitMain.TabIndex = 2;
            // 
            // splitDisplay
            // 
            this.splitDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitDisplay.Location = new System.Drawing.Point(0, 0);
            this.splitDisplay.Name = "splitDisplay";
            this.splitDisplay.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitDisplay.Panel1
            // 
            this.splitDisplay.Panel1.Controls.Add(this.labelInstructions);
            this.splitDisplay.Size = new System.Drawing.Size(633, 181);
            this.splitDisplay.SplitterDistance = 90;
            this.splitDisplay.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(633, 239);
            this.Controls.Add(this.splitMain);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarea 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitMain.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.splitDisplay.Panel1.ResumeLayout(false);
            this.splitDisplay.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitDisplay)).EndInit();
            this.splitDisplay.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelInstructions;
        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.SplitContainer splitDisplay;
    }
}

