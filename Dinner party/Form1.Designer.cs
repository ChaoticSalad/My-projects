namespace Dinner
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFancy = new System.Windows.Forms.CheckBox();
            this.cbHealthy = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpDinner = new System.Windows.Forms.TabPage();
            this.tbBirthday = new System.Windows.Forms.TabPage();
            this.nudBirthday = new System.Windows.Forms.NumericUpDown();
            this.cbFancyBirthday = new System.Windows.Forms.CheckBox();
            this.lblBirthdayCost = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTooLong = new System.Windows.Forms.Label();
            this.tbCakeWriting = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpDinner.SuspendLayout();
            this.tbBirthday.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBirthday)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(3, 19);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of People";
            // 
            // cbFancy
            // 
            this.cbFancy.AutoSize = true;
            this.cbFancy.Checked = true;
            this.cbFancy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbFancy.Location = new System.Drawing.Point(3, 45);
            this.cbFancy.Name = "cbFancy";
            this.cbFancy.Size = new System.Drawing.Size(115, 17);
            this.cbFancy.TabIndex = 2;
            this.cbFancy.Text = "Fancy Decorations";
            this.cbFancy.UseVisualStyleBackColor = true;
            this.cbFancy.CheckedChanged += new System.EventHandler(this.cbFancy_CheckedChanged);
            // 
            // cbHealthy
            // 
            this.cbHealthy.AutoSize = true;
            this.cbHealthy.Location = new System.Drawing.Point(3, 68);
            this.cbHealthy.Name = "cbHealthy";
            this.cbHealthy.Size = new System.Drawing.Size(96, 17);
            this.cbHealthy.TabIndex = 3;
            this.cbHealthy.Text = "Healthy Option";
            this.cbHealthy.UseVisualStyleBackColor = true;
            this.cbHealthy.CheckedChanged += new System.EventHandler(this.cbHealthy_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cost:";
            // 
            // lblCost
            // 
            this.lblCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCost.Location = new System.Drawing.Point(40, 88);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(100, 23);
            this.lblCost.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpDinner);
            this.tabControl1.Controls.Add(this.tbBirthday);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(216, 178);
            this.tabControl1.TabIndex = 6;
            // 
            // tpDinner
            // 
            this.tpDinner.Controls.Add(this.lblCost);
            this.tpDinner.Controls.Add(this.label2);
            this.tpDinner.Controls.Add(this.cbHealthy);
            this.tpDinner.Controls.Add(this.cbFancy);
            this.tpDinner.Controls.Add(this.label1);
            this.tpDinner.Controls.Add(this.numericUpDown1);
            this.tpDinner.Location = new System.Drawing.Point(4, 22);
            this.tpDinner.Name = "tpDinner";
            this.tpDinner.Padding = new System.Windows.Forms.Padding(3);
            this.tpDinner.Size = new System.Drawing.Size(208, 152);
            this.tpDinner.TabIndex = 0;
            this.tpDinner.Text = "Dinner Party";
            this.tpDinner.UseVisualStyleBackColor = true;
            // 
            // tbBirthday
            // 
            this.tbBirthday.Controls.Add(this.label7);
            this.tbBirthday.Controls.Add(this.tbCakeWriting);
            this.tbBirthday.Controls.Add(this.lblTooLong);
            this.tbBirthday.Controls.Add(this.label5);
            this.tbBirthday.Controls.Add(this.label4);
            this.tbBirthday.Controls.Add(this.lblBirthdayCost);
            this.tbBirthday.Controls.Add(this.cbFancyBirthday);
            this.tbBirthday.Controls.Add(this.nudBirthday);
            this.tbBirthday.Location = new System.Drawing.Point(4, 22);
            this.tbBirthday.Name = "tbBirthday";
            this.tbBirthday.Padding = new System.Windows.Forms.Padding(3);
            this.tbBirthday.Size = new System.Drawing.Size(208, 152);
            this.tbBirthday.TabIndex = 1;
            this.tbBirthday.Text = "Birthday Party";
            this.tbBirthday.UseVisualStyleBackColor = true;
            this.tbBirthday.Click += new System.EventHandler(this.tbBirthday_Click);
            // 
            // nudBirthday
            // 
            this.nudBirthday.Location = new System.Drawing.Point(7, 28);
            this.nudBirthday.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudBirthday.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBirthday.Name = "nudBirthday";
            this.nudBirthday.Size = new System.Drawing.Size(120, 20);
            this.nudBirthday.TabIndex = 0;
            this.nudBirthday.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudBirthday.ValueChanged += new System.EventHandler(this.nudBirthday_ValueChanged);
            // 
            // cbFancyBirthday
            // 
            this.cbFancyBirthday.AutoSize = true;
            this.cbFancyBirthday.Checked = true;
            this.cbFancyBirthday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbFancyBirthday.Location = new System.Drawing.Point(7, 54);
            this.cbFancyBirthday.Name = "cbFancyBirthday";
            this.cbFancyBirthday.Size = new System.Drawing.Size(115, 17);
            this.cbFancyBirthday.TabIndex = 1;
            this.cbFancyBirthday.Text = "Fancy Decorations";
            this.cbFancyBirthday.UseVisualStyleBackColor = true;
            this.cbFancyBirthday.CheckedChanged += new System.EventHandler(this.cbFancyBirthday_CheckedChanged);
            // 
            // lblBirthdayCost
            // 
            this.lblBirthdayCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBirthdayCost.Location = new System.Drawing.Point(41, 120);
            this.lblBirthdayCost.Name = "lblBirthdayCost";
            this.lblBirthdayCost.Size = new System.Drawing.Size(100, 23);
            this.lblBirthdayCost.TabIndex = 2;
            this.lblBirthdayCost.Click += new System.EventHandler(this.lblBirthdayCost_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Number of People";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cake Writing";
            // 
            // lblTooLong
            // 
            this.lblTooLong.AutoSize = true;
            this.lblTooLong.BackColor = System.Drawing.Color.Red;
            this.lblTooLong.Location = new System.Drawing.Point(78, 78);
            this.lblTooLong.Name = "lblTooLong";
            this.lblTooLong.Size = new System.Drawing.Size(63, 13);
            this.lblTooLong.TabIndex = 5;
            this.lblTooLong.Text = "TOO LONG";
            // 
            // tbCakeWriting
            // 
            this.tbCakeWriting.Location = new System.Drawing.Point(7, 94);
            this.tbCakeWriting.Name = "tbCakeWriting";
            this.tbCakeWriting.Size = new System.Drawing.Size(195, 20);
            this.tbCakeWriting.TabIndex = 6;
            this.tbCakeWriting.Text = "Happy Birthday";
            this.tbCakeWriting.TextChanged += new System.EventHandler(this.tbCakeWriting_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Cost:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 203);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpDinner.ResumeLayout(false);
            this.tpDinner.PerformLayout();
            this.tbBirthday.ResumeLayout(false);
            this.tbBirthday.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBirthday)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbFancy;
        private System.Windows.Forms.CheckBox cbHealthy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpDinner;
        private System.Windows.Forms.TabPage tbBirthday;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbCakeWriting;
        private System.Windows.Forms.Label lblTooLong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBirthdayCost;
        private System.Windows.Forms.CheckBox cbFancyBirthday;
        private System.Windows.Forms.NumericUpDown nudBirthday;
    }
}

