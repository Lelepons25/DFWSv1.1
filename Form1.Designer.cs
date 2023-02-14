namespace DFWSv1._1
{
    partial class Homepage
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
            this.FruitsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FruitsButton
            // 
            this.FruitsButton.Location = new System.Drawing.Point(56, 172);
            this.FruitsButton.Name = "FruitsButton";
            this.FruitsButton.Size = new System.Drawing.Size(107, 37);
            this.FruitsButton.TabIndex = 0;
            this.FruitsButton.Text = "Fruits";
            this.FruitsButton.UseVisualStyleBackColor = true;
            this.FruitsButton.Click += new System.EventHandler(this.FruitsButton_Click);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 473);
            this.Controls.Add(this.FruitsButton);
            this.Name = "Homepage";
            this.Text = "DFWS";
            this.Load += new System.EventHandler(this.Homepage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FruitsButton;
    }
}

