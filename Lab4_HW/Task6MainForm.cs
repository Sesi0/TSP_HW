using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_HW
{
    public partial class Task6MainForm : Form
    {
        private string[] toppings = { "anchovies", "bacon", "mushrooms", "onions", "peppers", "sausage" };

        public Task6MainForm()
        {
            this.InitializeComponent();
            this.toppingCheckedListBox.Items.AddRange(this.toppings);
        }

        private void Task6MainForm_Load(object sender, EventArgs e)
        {
            this.smallRadioButton.Checked = true;
            this.thinRadioButton.Checked = true;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                string checkedToppings = string.Empty;
                foreach (var checkedItem in this.toppingCheckedListBox.CheckedItems)
                {
                    checkedToppings += checkedItem.ToString() + ", ";
                }

                if (!string.IsNullOrEmpty(checkedToppings))
                {
                    checkedToppings = checkedToppings.Remove(checkedToppings.Length - 2);
                }

                string orderInfo = $"You ordered a {(this.smallRadioButton.Checked ? "small" : this.mediumRadioButton.Checked ? "medium" : "large")} {(this.thinRadioButton.Checked ? "thin" : "thick")} pizza{(this.extraCheeseCheckBox.Checked ? " with extra cheese " : " ")}and {this.toppingCheckedListBox.CheckedItems.Count} topping/s: {checkedToppings}.";

                // Size of pizza
                var total = this.smallRadioButton.Checked ? 9.25M : this.mediumRadioButton.Checked ? 11.5M : 17.75M;

                // Extra cheese
                total += this.extraCheeseCheckBox.Checked ? 1.5M : 0M;

                // Toppings
                total += this.toppingCheckedListBox.CheckedItems.Count;

                this.infoRichTextBox.Text = orderInfo + $"\nYour order total: {total}$";
            }
            catch
            {
            }
        }
    }
}
