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
    public partial class Task2Form : Form
    {
        private const double F = 33.8;
        private const double C = 1.8000;

        public Task2Form()
        {
            this.InitializeComponent();
        }

        private void CalculateTemperture()
        {
            try
            {
                double temp = double.Parse(this.tempertureTextBox.Text);

                // Means C is selected
                if (this.unitComboBox.SelectedIndex == 0)
                {
                    this.resultLabel.Text = $"{temp}C = {temp * 9d/5d + 32}F";
                }
                // Means F is selected
                else if (this.unitComboBox.SelectedIndex == 1)
                {
                    this.resultLabel.Text = $"{temp}F = {(temp - 32) * 5d/9d}C";
                }
                else
                {
                    this.resultLabel.Text = string.Empty;
                }
            }
            catch
            {
            }
        }

        private void Task2Form_Load(object sender, EventArgs e)
        {
        }

        private void TempertureTextBox_TextChanged(object sender, EventArgs e)
        {
            this.CalculateTemperture();
        }

        private void UnitComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.CalculateTemperture();
        }
    }
}
