namespace Assignment3
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
            this.labelName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelHeight = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelWeight = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.groupBoxResults = new System.Windows.Forms.GroupBox();
            this.labelBMIResultOutput = new System.Windows.Forms.Label();
            this.labelWeightCategory = new System.Windows.Forms.Label();
            this.labelBMI = new System.Windows.Forms.Label();
            this.labelWeightCategoryOoutput = new System.Windows.Forms.Label();
            this.groupBoxResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(44, 25);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(60, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Your Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(126, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(254, 20);
            this.textBox1.TabIndex = 1;
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(52, 55);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(38, 13);
            this.labelHeight.TabIndex = 2;
            this.labelHeight.Text = "Height";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(126, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(254, 20);
            this.textBox2.TabIndex = 3;
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(52, 87);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(41, 13);
            this.labelWeight.TabIndex = 4;
            this.labelWeight.Text = "Weight";
            this.labelWeight.Click += new System.EventHandler(this.labelWeight_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(126, 84);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(254, 20);
            this.textBox3.TabIndex = 5;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(55, 137);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(172, 23);
            this.buttonCalculate.TabIndex = 6;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            // 
            // groupBoxResults
            // 
            this.groupBoxResults.Controls.Add(this.labelWeightCategoryOoutput);
            this.groupBoxResults.Controls.Add(this.labelBMIResultOutput);
            this.groupBoxResults.Controls.Add(this.labelWeightCategory);
            this.groupBoxResults.Controls.Add(this.labelBMI);
            this.groupBoxResults.Location = new System.Drawing.Point(47, 196);
            this.groupBoxResults.Name = "groupBoxResults";
            this.groupBoxResults.Size = new System.Drawing.Size(409, 196);
            this.groupBoxResults.TabIndex = 7;
            this.groupBoxResults.TabStop = false;
            this.groupBoxResults.Text = "Results";
            // 
            // labelBMIResultOutput
            // 
            this.labelBMIResultOutput.BackColor = System.Drawing.SystemColors.Control;
            this.labelBMIResultOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelBMIResultOutput.Location = new System.Drawing.Point(156, 24);
            this.labelBMIResultOutput.Name = "labelBMIResultOutput";
            this.labelBMIResultOutput.Size = new System.Drawing.Size(82, 14);
            this.labelBMIResultOutput.TabIndex = 2;
            // 
            // labelWeightCategory
            // 
            this.labelWeightCategory.AutoSize = true;
            this.labelWeightCategory.Location = new System.Drawing.Point(10, 49);
            this.labelWeightCategory.Name = "labelWeightCategory";
            this.labelWeightCategory.Size = new System.Drawing.Size(85, 13);
            this.labelWeightCategory.TabIndex = 1;
            this.labelWeightCategory.Text = "Weight category";
            // 
            // labelBMI
            // 
            this.labelBMI.AutoSize = true;
            this.labelBMI.Location = new System.Drawing.Point(10, 25);
            this.labelBMI.Name = "labelBMI";
            this.labelBMI.Size = new System.Drawing.Size(26, 13);
            this.labelBMI.TabIndex = 0;
            this.labelBMI.Text = "BMI";
            // 
            // labelWeightCategoryOoutput
            // 
            this.labelWeightCategoryOoutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelWeightCategoryOoutput.Location = new System.Drawing.Point(156, 45);
            this.labelWeightCategoryOoutput.Name = "labelWeightCategoryOoutput";
            this.labelWeightCategoryOoutput.Size = new System.Drawing.Size(81, 17);
            this.labelWeightCategoryOoutput.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 498);
            this.Controls.Add(this.groupBoxResults);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxResults.ResumeLayout(false);
            this.groupBoxResults.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.GroupBox groupBoxResults;
        private System.Windows.Forms.Label labelWeightCategory;
        private System.Windows.Forms.Label labelBMI;
        private System.Windows.Forms.Label labelBMIResultOutput;
        private System.Windows.Forms.Label labelWeightCategoryOoutput;
    }
}

