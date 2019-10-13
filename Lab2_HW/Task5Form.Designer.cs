using System;
using System.Windows.Forms;

namespace Lab2_HW
{
    partial class Task5Form
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newClientMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientNumberLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.oldUsageTextBox = new System.Windows.Forms.TextBox();
            this.newUsageTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.currentUsageLabel = new System.Windows.Forms.Label();
            this.rateGroupBox = new System.Windows.Forms.GroupBox();
            this.rate3RadioButton = new System.Windows.Forms.RadioButton();
            this.rate2RadioButton = new System.Windows.Forms.RadioButton();
            this.rate1RadioButton = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.amountForPayLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.rateGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(370, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newClientMenuItem,
            this.exitMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.menuToolStripMenuItem.Text = "Меню";
            // 
            // newClientMenuItem
            // 
            this.newClientMenuItem.Name = "newClientMenuItem";
            this.newClientMenuItem.Size = new System.Drawing.Size(216, 26);
            this.newClientMenuItem.Text = "Нов клиент";
            this.newClientMenuItem.Click += new System.EventHandler(this.newClientMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(216, 26);
            this.exitMenuItem.Text = "Изход";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // clientNumberLabel
            // 
            this.clientNumberLabel.AutoSize = true;
            this.clientNumberLabel.Location = new System.Drawing.Point(123, 29);
            this.clientNumberLabel.Name = "clientNumberLabel";
            this.clientNumberLabel.Size = new System.Drawing.Size(16, 17);
            this.clientNumberLabel.TabIndex = 1;
            this.clientNumberLabel.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Клиент номер:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Старо показание на електромера:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ново показание на електромера:";
            // 
            // oldUsageTextBox
            // 
            this.oldUsageTextBox.Location = new System.Drawing.Point(256, 54);
            this.oldUsageTextBox.Name = "oldUsageTextBox";
            this.oldUsageTextBox.Size = new System.Drawing.Size(100, 22);
            this.oldUsageTextBox.TabIndex = 5;
            this.oldUsageTextBox.TextChanged += new System.EventHandler(this.oldUsageTextBox_TextChanged);
            // 
            // newUsageTextBox
            // 
            this.newUsageTextBox.Location = new System.Drawing.Point(256, 88);
            this.newUsageTextBox.Name = "newUsageTextBox";
            this.newUsageTextBox.Size = new System.Drawing.Size(100, 22);
            this.newUsageTextBox.TabIndex = 6;
            this.newUsageTextBox.TextChanged += new System.EventHandler(this.newUsageTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Потребление:";
            // 
            // currentUsageLabel
            // 
            this.currentUsageLabel.AutoSize = true;
            this.currentUsageLabel.Location = new System.Drawing.Point(123, 124);
            this.currentUsageLabel.Name = "currentUsageLabel";
            this.currentUsageLabel.Size = new System.Drawing.Size(46, 17);
            this.currentUsageLabel.TabIndex = 8;
            this.currentUsageLabel.Text = "label5";
            // 
            // rateGroupBox
            // 
            this.rateGroupBox.Controls.Add(this.rate3RadioButton);
            this.rateGroupBox.Controls.Add(this.rate2RadioButton);
            this.rateGroupBox.Controls.Add(this.rate1RadioButton);
            this.rateGroupBox.Location = new System.Drawing.Point(18, 145);
            this.rateGroupBox.Name = "rateGroupBox";
            this.rateGroupBox.Size = new System.Drawing.Size(338, 46);
            this.rateGroupBox.TabIndex = 9;
            this.rateGroupBox.TabStop = false;
            this.rateGroupBox.Text = "Тарифа";
            // 
            // rate3RadioButton
            // 
            this.rate3RadioButton.AutoSize = true;
            this.rate3RadioButton.Location = new System.Drawing.Point(273, 19);
            this.rate3RadioButton.Name = "rate3RadioButton";
            this.rate3RadioButton.Size = new System.Drawing.Size(57, 21);
            this.rate3RadioButton.TabIndex = 2;
            this.rate3RadioButton.TabStop = true;
            this.rate3RadioButton.Text = "0,54";
            this.rate3RadioButton.UseVisualStyleBackColor = true;
            this.rate3RadioButton.CheckedChanged += new System.EventHandler(this.rate3RadioButton_CheckedChanged);
            // 
            // rate2RadioButton
            // 
            this.rate2RadioButton.AutoSize = true;
            this.rate2RadioButton.Location = new System.Drawing.Point(140, 19);
            this.rate2RadioButton.Name = "rate2RadioButton";
            this.rate2RadioButton.Size = new System.Drawing.Size(57, 21);
            this.rate2RadioButton.TabIndex = 1;
            this.rate2RadioButton.TabStop = true;
            this.rate2RadioButton.Text = "0,44";
            this.rate2RadioButton.UseVisualStyleBackColor = true;
            this.rate2RadioButton.CheckedChanged += new System.EventHandler(this.rate2RadioButton_CheckedChanged);
            // 
            // rate1RadioButton
            // 
            this.rate1RadioButton.AutoSize = true;
            this.rate1RadioButton.Location = new System.Drawing.Point(7, 19);
            this.rate1RadioButton.Name = "rate1RadioButton";
            this.rate1RadioButton.Size = new System.Drawing.Size(57, 21);
            this.rate1RadioButton.TabIndex = 0;
            this.rate1RadioButton.TabStop = true;
            this.rate1RadioButton.Text = "0,34";
            this.rate1RadioButton.UseVisualStyleBackColor = true;
            this.rate1RadioButton.CheckedChanged += new System.EventHandler(this.rate1RadioButton_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Сума за плащане:";
            // 
            // amountForPayLabel
            // 
            this.amountForPayLabel.AutoSize = true;
            this.amountForPayLabel.Location = new System.Drawing.Point(151, 207);
            this.amountForPayLabel.Name = "amountForPayLabel";
            this.amountForPayLabel.Size = new System.Drawing.Size(0, 17);
            this.amountForPayLabel.TabIndex = 11;
            // 
            // Task5Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 240);
            this.Controls.Add(this.amountForPayLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rateGroupBox);
            this.Controls.Add(this.currentUsageLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.newUsageTextBox);
            this.Controls.Add(this.oldUsageTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clientNumberLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Task5Form";
            this.Text = "Task5Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Task5Form_Closing);
            this.Load += new System.EventHandler(this.Task5Form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.rateGroupBox.ResumeLayout(false);
            this.rateGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newClientMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.Label clientNumberLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox oldUsageTextBox;
        private System.Windows.Forms.TextBox newUsageTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label currentUsageLabel;
        private System.Windows.Forms.GroupBox rateGroupBox;
        private System.Windows.Forms.RadioButton rate3RadioButton;
        private System.Windows.Forms.RadioButton rate2RadioButton;
        private System.Windows.Forms.RadioButton rate1RadioButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label amountForPayLabel;
    }
}