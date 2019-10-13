namespace Lab2_HW
{
    partial class Task2Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.tempertureTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.unitComboBox = new System.Windows.Forms.ComboBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Convert:";
            // 
            // tempertureTextBox
            // 
            this.tempertureTextBox.Location = new System.Drawing.Point(80, 9);
            this.tempertureTextBox.Name = "tempertureTextBox";
            this.tempertureTextBox.Size = new System.Drawing.Size(100, 22);
            this.tempertureTextBox.TabIndex = 1;
            this.tempertureTextBox.TextChanged += new System.EventHandler(this.TempertureTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "from:";
            // 
            // unitComboBox
            // 
            this.unitComboBox.FormattingEnabled = true;
            this.unitComboBox.Items.AddRange(new object[] {
            "C",
            "F"});
            this.unitComboBox.Location = new System.Drawing.Point(232, 9);
            this.unitComboBox.Name = "unitComboBox";
            this.unitComboBox.Size = new System.Drawing.Size(45, 24);
            this.unitComboBox.TabIndex = 3;
            this.unitComboBox.SelectedIndexChanged += new System.EventHandler(this.UnitComboBox_SelectedIndexChanged);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(12, 43);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 17);
            this.resultLabel.TabIndex = 5;
            // 
            // Task2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 76);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.unitComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tempertureTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Task2Form";
            this.Text = "TempertureConverter";
            this.Load += new System.EventHandler(this.Task2Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tempertureTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox unitComboBox;
        private System.Windows.Forms.Label resultLabel;
    }
}