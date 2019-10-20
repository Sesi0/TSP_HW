namespace Lab4_HW
{
    partial class Task1MainForm
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
            this.button_pal = new System.Windows.Forms.Button();
            this.button_ascii = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_pal
            // 
            this.button_pal.Location = new System.Drawing.Point(60, 15);
            this.button_pal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_pal.Name = "button_pal";
            this.button_pal.Size = new System.Drawing.Size(113, 33);
            this.button_pal.TabIndex = 0;
            this.button_pal.Text = "Палиндром";
            this.button_pal.UseVisualStyleBackColor = true;
            this.button_pal.Click += new System.EventHandler(this.button_pal_Click);
            // 
            // button_ascii
            // 
            this.button_ascii.Location = new System.Drawing.Point(60, 197);
            this.button_ascii.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_ascii.Name = "button_ascii";
            this.button_ascii.Size = new System.Drawing.Size(104, 37);
            this.button_ascii.TabIndex = 1;
            this.button_ascii.Text = "ASCII код";
            this.button_ascii.UseVisualStyleBackColor = true;
            this.button_ascii.Click += new System.EventHandler(this.button_ascii_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(60, 110);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 261);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_ascii);
            this.Controls.Add(this.button_pal);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Task1MainForm";
            this.Text = "Task1MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_pal;
        private System.Windows.Forms.Button button_ascii;
        private System.Windows.Forms.TextBox textBox1;
    }
}

