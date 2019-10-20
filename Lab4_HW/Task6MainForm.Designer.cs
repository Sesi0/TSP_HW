namespace Lab4_HW
{
    partial class Task6MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.extraCheeseCheckBox = new System.Windows.Forms.CheckBox();
            this.toppingCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.smallRadioButton = new System.Windows.Forms.RadioButton();
            this.mediumRadioButton = new System.Windows.Forms.RadioButton();
            this.largeRadioButton = new System.Windows.Forms.RadioButton();
            this.thinRadioButton = new System.Windows.Forms.RadioButton();
            this.thickRadioButton = new System.Windows.Forms.RadioButton();
            this.infoRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.largeRadioButton);
            this.groupBox1.Controls.Add(this.mediumRadioButton);
            this.groupBox1.Controls.Add(this.smallRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Size";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.thickRadioButton);
            this.groupBox2.Controls.Add(this.thinRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(13, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 83);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Crust";
            // 
            // extraCheeseCheckBox
            // 
            this.extraCheeseCheckBox.AutoSize = true;
            this.extraCheeseCheckBox.Location = new System.Drawing.Point(20, 209);
            this.extraCheeseCheckBox.Name = "extraCheeseCheckBox";
            this.extraCheeseCheckBox.Size = new System.Drawing.Size(144, 21);
            this.extraCheeseCheckBox.TabIndex = 2;
            this.extraCheeseCheckBox.Text = "Extra cheese 1.50";
            this.extraCheeseCheckBox.UseVisualStyleBackColor = true;
            // 
            // toppingCheckedListBox
            // 
            this.toppingCheckedListBox.FormattingEnabled = true;
            this.toppingCheckedListBox.Location = new System.Drawing.Point(240, 46);
            this.toppingCheckedListBox.Name = "toppingCheckedListBox";
            this.toppingCheckedListBox.Size = new System.Drawing.Size(176, 157);
            this.toppingCheckedListBox.TabIndex = 3;
            // 
            // smallRadioButton
            // 
            this.smallRadioButton.AutoSize = true;
            this.smallRadioButton.Location = new System.Drawing.Point(7, 22);
            this.smallRadioButton.Name = "smallRadioButton";
            this.smallRadioButton.Size = new System.Drawing.Size(95, 21);
            this.smallRadioButton.TabIndex = 0;
            this.smallRadioButton.TabStop = true;
            this.smallRadioButton.Text = "Small 9.25";
            this.smallRadioButton.UseVisualStyleBackColor = true;
            // 
            // mediumRadioButton
            // 
            this.mediumRadioButton.AutoSize = true;
            this.mediumRadioButton.Location = new System.Drawing.Point(7, 47);
            this.mediumRadioButton.Name = "mediumRadioButton";
            this.mediumRadioButton.Size = new System.Drawing.Size(118, 21);
            this.mediumRadioButton.TabIndex = 1;
            this.mediumRadioButton.TabStop = true;
            this.mediumRadioButton.Text = "Medium 11.50";
            this.mediumRadioButton.UseVisualStyleBackColor = true;
            // 
            // largeRadioButton
            // 
            this.largeRadioButton.AutoSize = true;
            this.largeRadioButton.Location = new System.Drawing.Point(7, 72);
            this.largeRadioButton.Name = "largeRadioButton";
            this.largeRadioButton.Size = new System.Drawing.Size(106, 21);
            this.largeRadioButton.TabIndex = 2;
            this.largeRadioButton.TabStop = true;
            this.largeRadioButton.Text = "Large 13.75";
            this.largeRadioButton.UseVisualStyleBackColor = true;
            // 
            // thinRadioButton
            // 
            this.thinRadioButton.AutoSize = true;
            this.thinRadioButton.Location = new System.Drawing.Point(7, 22);
            this.thinRadioButton.Name = "thinRadioButton";
            this.thinRadioButton.Size = new System.Drawing.Size(57, 21);
            this.thinRadioButton.TabIndex = 0;
            this.thinRadioButton.TabStop = true;
            this.thinRadioButton.Text = "Thin";
            this.thinRadioButton.UseVisualStyleBackColor = true;
            // 
            // thickRadioButton
            // 
            this.thickRadioButton.AutoSize = true;
            this.thickRadioButton.Location = new System.Drawing.Point(7, 50);
            this.thickRadioButton.Name = "thickRadioButton";
            this.thickRadioButton.Size = new System.Drawing.Size(63, 21);
            this.thickRadioButton.TabIndex = 1;
            this.thickRadioButton.TabStop = true;
            this.thickRadioButton.Text = "Thick";
            this.thickRadioButton.UseVisualStyleBackColor = true;
            // 
            // infoRichTextBox
            // 
            this.infoRichTextBox.Location = new System.Drawing.Point(12, 250);
            this.infoRichTextBox.Name = "infoRichTextBox";
            this.infoRichTextBox.ReadOnly = true;
            this.infoRichTextBox.Size = new System.Drawing.Size(404, 188);
            this.infoRichTextBox.TabIndex = 4;
            this.infoRichTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Toppings- a dollar for each";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(240, 209);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(176, 23);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // Task6MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 450);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.infoRichTextBox);
            this.Controls.Add(this.toppingCheckedListBox);
            this.Controls.Add(this.extraCheeseCheckBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Task6MainForm";
            this.Text = "Task6MainForm";
            this.Load += new System.EventHandler(this.Task6MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton largeRadioButton;
        private System.Windows.Forms.RadioButton mediumRadioButton;
        private System.Windows.Forms.RadioButton smallRadioButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton thickRadioButton;
        private System.Windows.Forms.RadioButton thinRadioButton;
        private System.Windows.Forms.CheckBox extraCheeseCheckBox;
        private System.Windows.Forms.CheckedListBox toppingCheckedListBox;
        private System.Windows.Forms.RichTextBox infoRichTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calculateButton;
    }
}