namespace BeeHive
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnNextShift = new System.Windows.Forms.Button();
            this.cbWorkerBeeJob = new System.Windows.Forms.ComboBox();
            this.nudShifts = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudShifts)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(557, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Assign this job to a bee";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNextShift
            // 
            this.btnNextShift.Location = new System.Drawing.Point(575, 12);
            this.btnNextShift.Name = "btnNextShift";
            this.btnNextShift.Size = new System.Drawing.Size(213, 86);
            this.btnNextShift.TabIndex = 1;
            this.btnNextShift.Text = "Work the next shift";
            this.btnNextShift.UseVisualStyleBackColor = true;
            this.btnNextShift.Click += new System.EventHandler(this.btnNextShift_Click);
            // 
            // cbWorkerBeeJob
            // 
            this.cbWorkerBeeJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWorkerBeeJob.FormattingEnabled = true;
            this.cbWorkerBeeJob.Items.AddRange(new object[] {
            "Nectar collector",
            "Honey manufacturing",
            "Egg care",
            "Baby bee tutoring",
            "Hive maintenance",
            "Sting patrol"});
            this.cbWorkerBeeJob.Location = new System.Drawing.Point(12, 48);
            this.cbWorkerBeeJob.Name = "cbWorkerBeeJob";
            this.cbWorkerBeeJob.Size = new System.Drawing.Size(431, 21);
            this.cbWorkerBeeJob.TabIndex = 2;
            this.cbWorkerBeeJob.SelectedIndexChanged += new System.EventHandler(this.cbWorkerBeeJob_SelectedIndexChanged);
            // 
            // nudShifts
            // 
            this.nudShifts.Location = new System.Drawing.Point(449, 49);
            this.nudShifts.Name = "nudShifts";
            this.nudShifts.Size = new System.Drawing.Size(120, 20);
            this.nudShifts.TabIndex = 3;
            this.nudShifts.ValueChanged += new System.EventHandler(this.nudShifts_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 105);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(776, 333);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Job";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(449, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Shifts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Worker Bee Assignments";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.nudShifts);
            this.Controls.Add(this.cbWorkerBeeJob);
            this.Controls.Add(this.btnNextShift);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudShifts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnNextShift;
        private System.Windows.Forms.ComboBox cbWorkerBeeJob;
        private System.Windows.Forms.NumericUpDown nudShifts;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

