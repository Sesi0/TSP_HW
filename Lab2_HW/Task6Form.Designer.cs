namespace Lab2_HW
{
    partial class Task6Form
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
            this.widthScrollBar = new System.Windows.Forms.HScrollBar();
            this.heightScrollBar = new System.Windows.Forms.VScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.areaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // widthScrollBar
            // 
            this.widthScrollBar.Location = new System.Drawing.Point(30, 9);
            this.widthScrollBar.Minimum = 1;
            this.widthScrollBar.Name = "widthScrollBar";
            this.widthScrollBar.Size = new System.Drawing.Size(400, 21);
            this.widthScrollBar.TabIndex = 0;
            this.widthScrollBar.Value = 1;
            this.widthScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.widthScrollBar_Scroll);
            // 
            // heightScrollBar
            // 
            this.heightScrollBar.Location = new System.Drawing.Point(10, 30);
            this.heightScrollBar.Minimum = 1;
            this.heightScrollBar.Name = "heightScrollBar";
            this.heightScrollBar.Size = new System.Drawing.Size(21, 400);
            this.heightScrollBar.TabIndex = 1;
            this.heightScrollBar.Value = 1;
            this.heightScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.heightScrollBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Width:";
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(189, 59);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(47, 22);
            this.widthTextBox.TabIndex = 3;
            this.widthTextBox.TextChanged += new System.EventHandler(this.widthTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Height:";
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(94, 133);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(47, 22);
            this.heightTextBox.TabIndex = 5;
            this.heightTextBox.TextChanged += new System.EventHandler(this.heightTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "AREA:";
            // 
            // areaLabel
            // 
            this.areaLabel.AutoSize = true;
            this.areaLabel.Location = new System.Drawing.Point(244, 133);
            this.areaLabel.Name = "areaLabel";
            this.areaLabel.Size = new System.Drawing.Size(0, 17);
            this.areaLabel.TabIndex = 7;
            // 
            // Task6Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 433);
            this.Controls.Add(this.areaLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.heightScrollBar);
            this.Controls.Add(this.widthScrollBar);
            this.Name = "Task6Form";
            this.Text = "Task6Form";
            this.Load += new System.EventHandler(this.Task6Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar widthScrollBar;
        private System.Windows.Forms.VScrollBar heightScrollBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label areaLabel;
    }
}