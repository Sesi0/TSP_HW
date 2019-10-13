using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_HW
{
    public partial class Task6Form : Form
    {
        public Task6Form()
        {
            this.InitializeComponent();
        }

        private void Task6Form_Load(object sender, EventArgs e)
        {
            this.widthTextBox.Text = "1";
            this.heightTextBox.Text = "1";
        }

        private void widthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.widthScrollBar.Value = int.Parse(this.widthTextBox.Text);
                this.CalculateArea();
            }
            catch
            { 
            }
        }

        private void widthScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            try
            {
                this.widthTextBox.Text = this.widthScrollBar.Value.ToString();
                this.CalculateArea();
            }
            catch
            {
            }
        }

        private void heightTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.heightScrollBar.Value = int.Parse(this.heightTextBox.Text);
                this.CalculateArea();
            }
            catch
            {
            }
        }

        private void heightScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            try
            {
                this.heightTextBox.Text = this.heightScrollBar.Value.ToString();
                this.CalculateArea();
            }
            catch
            {
            }
        }

        private void CalculateArea()
        {
            this.areaLabel.Text = (this.heightScrollBar.Value * this.widthScrollBar.Value).ToString();
        }
    }
}
