using System;
using System.Windows.Forms;

namespace Lab1_HW
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            this.InitializeComponent();
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("This application can show the 2 operands if they are odd or even!", "ODD/EVEN", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.resultTextBox.Text = Calculator.AddNumbers(double.Parse(this.operand1TextBox.Text), double.Parse(this.operand2TextBox.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("Operand 1 or Operand 2 is in incorrect format!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SubstractButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.resultTextBox.Text = Calculator.SubstractNumbers(double.Parse(this.operand1TextBox.Text), double.Parse(this.operand2TextBox.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("Operand 1 or Operand 2 is in incorrect format!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.resultTextBox.Text = Calculator.MultiplyNumbers(double.Parse(this.operand1TextBox.Text), double.Parse(this.operand2TextBox.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("Operand 1 or Operand 2 is in incorrect format!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.resultTextBox.Text = Calculator.DivideNumbers(double.Parse(this.operand1TextBox.Text), double.Parse(this.operand2TextBox.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("Operand 1 or Operand 2 is in incorrect format!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void EvenOrOddButton_Click(object sender, EventArgs e)
        {
            try
            {
                double value1 = double.Parse(this.operand1TextBox.Text);
                double value2 = double.Parse(this.operand2TextBox.Text);

                if (value1 % 2 == 0)
                {
                    this.operand1OddOrEvenLabel.Text = "is even!";
                }
                else
                {
                    this.operand1OddOrEvenLabel.Text = "is odd!";
                }

                if (value2 % 2 == 0)
                {
                    this.operand2OddOrEvenLabel.Text = "is even!";
                }
                else
                {
                    this.operand2OddOrEvenLabel.Text = "is odd!";
                }
            }
            catch
            {
                MessageBox.Show("Operand 1 or Operand 2 is in incorrect format!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.comboBox1.SelectedIndex)
            {
                case 0: this.AddButton_Click(null, null); break;
                case 1: this.SubstractButton_Click(null, null); break;
                case 2: this.MultiplyButton_Click(null, null); break;
                case 3: this.DivideButton_Click(null, null); break;
                case 4: this.EvenOrOddButton_Click(null, null); break;
                default:
                    break;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit application?", "Exiting application..", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
