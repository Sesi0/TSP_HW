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
    public partial class Task5Form : Form
    {
        private int currentClientNumber;

        private List<Client> clients;

        public Task5Form()
        {
            this.InitializeComponent();
            this.clients = new List<Client>();
        }

        private void Task5Form_Load(object sender, EventArgs e)
        {
            this.AddNewClient();
        }

        private void Task5Form_Closing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = DialogResult.Yes != MessageBox.Show(
                             this,
                             $"Общо клиенти: {this.clients.Count()}" +
                             $"\nОбщо потребение на всички клиенти: {this.clients.Sum(c => c.GetCurrentUsage())}" +
                             $"\nОбщо за плащане на всички клиенти: {this.clients.Sum(c => c.GetAmountToPay())}" +
                              "\nСигурни ли сте, че искате да излезете от програмата това ще загуби всичките Ви данни?",
                              "Внимание!",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Exclamation);
        }

        private void AddNewClient()
        {
            this.currentClientNumber++;
            this.clients.Add(new Client() { ClientNumber = currentClientNumber });
            this.ClearUI();
        }

        private Client GetCurrentClient()
        {
            return this.clients.FirstOrDefault(c => c.ClientNumber == this.currentClientNumber);
        }

        private void ClearUI()
        {
            this.clientNumberLabel.Text = this.currentClientNumber.ToString();
            this.rate1RadioButton.Checked = true;
            this.newUsageTextBox.Clear();
            this.oldUsageTextBox.Clear();
            this.currentUsageLabel.ResetText();
            this.amountForPayLabel.ResetText();
        }

        private void CalculateCurrentUsage()
        {
            this.currentUsageLabel.Text = (this.GetCurrentClient().GetCurrentUsage()).ToString();
        }

        private void CalculateAmountToPay()
        {
            this.amountForPayLabel.Text = (this.GetCurrentClient().GetAmountToPay()).ToString();
        }

        private void oldUsageTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.GetCurrentClient().OldUsage = double.Parse(this.oldUsageTextBox.Text);
                this.CalculateCurrentUsage();
                this.CalculateAmountToPay();
            }
            catch
            {
            }
        }

        private void newUsageTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.GetCurrentClient().NewUsage = double.Parse(this.newUsageTextBox.Text);
                this.CalculateCurrentUsage();
                this.CalculateAmountToPay();
            }
            catch
            {
            }
        }

        private void rate1RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rate1RadioButton.Checked)
            {
                try
                {
                    this.GetCurrentClient().ChosenRate = double.Parse(this.rate1RadioButton.Text);
                    this.CalculateCurrentUsage();
                    this.CalculateAmountToPay();
                }
                catch
                {
                }
            }
        }

        private void rate2RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rate2RadioButton.Checked)
            {
                try
                {
                    this.GetCurrentClient().ChosenRate = double.Parse(this.rate2RadioButton.Text);
                    this.CalculateCurrentUsage();
                    this.CalculateAmountToPay();
                }
                catch
                {
                }
            }
        }

        private void rate3RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rate3RadioButton.Checked)
            {
                try
                {
                    this.GetCurrentClient().ChosenRate = double.Parse(this.rate3RadioButton.Text);
                    this.CalculateCurrentUsage();
                    this.CalculateAmountToPay();
                }
                catch
                {
                }
            }
        }

        private void newClientMenuItem_Click(object sender, EventArgs e)
        {
            this.AddNewClient();
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class Client
    {
        public int ClientNumber { get; set; }

        public double OldUsage { get; set; }

        public double NewUsage { get; set; }

        public double ChosenRate { get; set; }

        public double GetCurrentUsage()
        {
            return this.OldUsage + this.NewUsage;
        }

        public double GetAmountToPay()
        {
            return this.GetCurrentUsage() * this.ChosenRate;
        }
    }
}
