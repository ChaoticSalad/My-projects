namespace Currency
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
            this.lblForeign = new System.Windows.Forms.Label();
            this.lblRub = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbForeign = new System.Windows.Forms.TextBox();
            this.tbRubles = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblForeign
            // 
            this.lblForeign.AutoSize = true;
            this.lblForeign.Location = new System.Drawing.Point(12, 37);
            this.lblForeign.Name = "lblForeign";
            this.lblForeign.Size = new System.Drawing.Size(35, 13);
            this.lblForeign.TabIndex = 0;
            this.lblForeign.Text = "label1";
            // 
            // lblRub
            // 
            this.lblRub.AutoSize = true;
            this.lblRub.Location = new System.Drawing.Point(134, 37);
            this.lblRub.Name = "lblRub";
            this.lblRub.Size = new System.Drawing.Size(30, 13);
            this.lblRub.TabIndex = 1;
            this.lblRub.Text = "RUB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "=";
            // 
            // tbForeign
            // 
            this.tbForeign.Location = new System.Drawing.Point(12, 53);
            this.tbForeign.Name = "tbForeign";
            this.tbForeign.Size = new System.Drawing.Size(100, 20);
            this.tbForeign.TabIndex = 3;
            this.tbForeign.TextChanged += new System.EventHandler(this.tbForeign_TextChanged);
            // 
            // tbRubles
            // 
            this.tbRubles.Location = new System.Drawing.Point(137, 53);
            this.tbRubles.Name = "tbRubles";
            this.tbRubles.Size = new System.Drawing.Size(100, 20);
            this.tbRubles.TabIndex = 4;
            this.tbRubles.TextChanged += new System.EventHandler(this.tbRubles_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 132);
            this.Controls.Add(this.tbRubles);
            this.Controls.Add(this.tbForeign);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblRub);
            this.Controls.Add(this.lblForeign);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblForeign;
        private System.Windows.Forms.Label lblRub;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbForeign;
        private System.Windows.Forms.TextBox tbRubles;
    }
}

