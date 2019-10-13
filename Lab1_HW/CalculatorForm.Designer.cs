namespace Lab1_HW
{
    partial class CalculatorForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.operand1TextBox = new System.Windows.Forms.TextBox();
            this.operand2TextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.substractButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.evenOrOddButton = new System.Windows.Forms.Button();
            this.operand1OddOrEvenLabel = new System.Windows.Forms.Label();
            this.operand2OddOrEvenLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operand 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Operand 2:";
            // 
            // operand1TextBox
            // 
            this.operand1TextBox.Location = new System.Drawing.Point(91, 13);
            this.operand1TextBox.Name = "operand1TextBox";
            this.operand1TextBox.Size = new System.Drawing.Size(126, 22);
            this.operand1TextBox.TabIndex = 2;
            // 
            // operand2TextBox
            // 
            this.operand2TextBox.Location = new System.Drawing.Point(91, 47);
            this.operand2TextBox.Name = "operand2TextBox";
            this.operand2TextBox.Size = new System.Drawing.Size(126, 22);
            this.operand2TextBox.TabIndex = 3;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(7, 82);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(48, 73);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // substractButton
            // 
            this.substractButton.Location = new System.Drawing.Point(61, 82);
            this.substractButton.Name = "substractButton";
            this.substractButton.Size = new System.Drawing.Size(48, 73);
            this.substractButton.TabIndex = 5;
            this.substractButton.Text = "-";
            this.substractButton.UseVisualStyleBackColor = true;
            this.substractButton.Click += new System.EventHandler(this.SubstractButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Location = new System.Drawing.Point(115, 82);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(48, 73);
            this.multiplyButton.TabIndex = 6;
            this.multiplyButton.Text = "*";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click);
            // 
            // divideButton
            // 
            this.divideButton.Location = new System.Drawing.Point(169, 82);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(48, 73);
            this.divideButton.TabIndex = 7;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.DivideButton_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(249, 28);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(70, 22);
            this.resultTextBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "=";
            // 
            // evenOrOddButton
            // 
            this.evenOrOddButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.evenOrOddButton.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.evenOrOddButton.Location = new System.Drawing.Point(223, 80);
            this.evenOrOddButton.Name = "evenOrOddButton";
            this.evenOrOddButton.Size = new System.Drawing.Size(96, 75);
            this.evenOrOddButton.TabIndex = 10;
            this.evenOrOddButton.Text = "Even or odd?";
            this.evenOrOddButton.UseVisualStyleBackColor = false;
            this.evenOrOddButton.Click += new System.EventHandler(this.EvenOrOddButton_Click);
            // 
            // operand1OddOrEvenLabel
            // 
            this.operand1OddOrEvenLabel.AutoSize = true;
            this.operand1OddOrEvenLabel.Location = new System.Drawing.Point(230, 11);
            this.operand1OddOrEvenLabel.Name = "operand1OddOrEvenLabel";
            this.operand1OddOrEvenLabel.Size = new System.Drawing.Size(0, 17);
            this.operand1OddOrEvenLabel.TabIndex = 12;
            // 
            // operand2OddOrEvenLabel
            // 
            this.operand2OddOrEvenLabel.AutoSize = true;
            this.operand2OddOrEvenLabel.Location = new System.Drawing.Point(230, 53);
            this.operand2OddOrEvenLabel.Name = "operand2OddOrEvenLabel";
            this.operand2OddOrEvenLabel.Size = new System.Drawing.Size(0, 17);
            this.operand2OddOrEvenLabel.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Add (\"+\")",
            "Substract (\"-\")",
            "Multiply (\"*\")",
            "Divide (\"/\")",
            "Odd or Even?"});
            this.comboBox1.Location = new System.Drawing.Point(7, 185);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(312, 24);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Or choose option from the combobox:";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Tomato;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.Location = new System.Drawing.Point(7, 215);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(312, 54);
            this.exitButton.TabIndex = 16;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(331, 281);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.operand2OddOrEvenLabel);
            this.Controls.Add(this.operand1OddOrEvenLabel);
            this.Controls.Add(this.evenOrOddButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.substractButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.operand2TextBox);
            this.Controls.Add(this.operand1TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CalculatorForm";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.CalculatorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox operand1TextBox;
        private System.Windows.Forms.TextBox operand2TextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button substractButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button evenOrOddButton;
        private System.Windows.Forms.Label operand1OddOrEvenLabel;
        private System.Windows.Forms.Label operand2OddOrEvenLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button exitButton;
    }
}

