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
    public partial class Task3_4Form : Form
    {
        private bool isButtonVisible;

        public Task3_4Form()
        {
            this.InitializeComponent();
        }

        public List<BaseUnit> Units { get; set; }

        private void Task3_4Form_Load(object sender, EventArgs e)
        {
            this.fromComboBox.DataSource = new List<BaseUnit>
            {
                new FeetsUnit(),
                new YardsUnit(),
                new InchesUnit(),
                new MilesUnit()
            };

            this.toComboBox.DataSource = new List<BaseUnit>
            {
                new FeetsUnit(),
                new YardsUnit(),
                new InchesUnit(),
                new MilesUnit()
            };

            if (DialogResult.Yes == MessageBox.Show("Work with button?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.isButtonVisible = true;
            }

            if (this.isButtonVisible)
            {
                this.calculateButton.Visible = true;
            }
        }

        private void Convert()
        {
            try
            {
                switch (this.toComboBox.SelectedItem.ToString())
                {
                    case "Feets": this.resultTextBox.Text = ((this.fromComboBox.SelectedItem as BaseUnit).ToFeet(double.Parse(this.convertTextBox.Text))).ToString(); break;
                    case "Yards": this.resultTextBox.Text = ((this.fromComboBox.SelectedItem as BaseUnit).ToYards(double.Parse(this.convertTextBox.Text))).ToString(); break;
                    case "Inches": this.resultTextBox.Text = ((this.fromComboBox.SelectedItem as BaseUnit).ToInches(double.Parse(this.convertTextBox.Text))).ToString(); break;
                    case "Miles": this.resultTextBox.Text = ((this.fromComboBox.SelectedItem as BaseUnit).ToMiles(double.Parse(this.convertTextBox.Text))).ToString(); break;
                    default:
                        break;
                }
            }
            catch
            {
            }
        }

        private void convertTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!this.isButtonVisible)
            {
                this.Convert();
            }
        }

        private void fromComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!this.isButtonVisible)
            {
                this.Convert();
            }
        }

        private void toComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!this.isButtonVisible)
            {
                this.Convert();
            }
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            this.Convert();
        }
    }

    public abstract class BaseUnit
    {
        protected string Name { get; set; }

        public abstract double ToYards(double value);

        public abstract double ToInches(double value);

        public abstract double ToFeet(double value);

        public abstract double ToMiles(double value);

        public override string ToString()
        {
            return this.Name;
        }
    }

    public class FeetsUnit : BaseUnit
    {
        public FeetsUnit()
        {
            this.Name = "Feets";
        }

        public override double ToYards(double value)
        {
            return value * 0.333333333;
        }

        public override double ToInches(double value)
        {
            return value * 12;
        }

        public override double ToMiles(double value)
        {
            return value * 0.000189393939;
        }

        public override double ToFeet(double value)
        {
            return value;
        }
    }

    public class YardsUnit : BaseUnit
    {
        public YardsUnit()
        {
            this.Name = "Yards";
        }

        public override double ToYards(double value)
        {
            return value;
        }

        public override double ToInches(double value)
        {
            return value * 36;
        }

        public override double ToMiles(double value)
        {
            return value * 0.000568181818;
        }

        public override double ToFeet(double value)
        {
            return value * 3;
        }
    }

    public class InchesUnit : BaseUnit
    {
        public InchesUnit()
        {
            this.Name = "Inches";
        }

        public override double ToYards(double value)
        {
            return value * 0.0277777778;
        }

        public override double ToInches(double value)
        {
            return value * 36;
        }

        public override double ToMiles(double value)
        {
            return value * 1.57828283 * Math.Pow(10, -5);
        }

        public override double ToFeet(double value)
        {
            return value * 0.0833333333;
        }
    }

    public class MilesUnit : BaseUnit
    {
        public MilesUnit()
        {
            this.Name = "Miles";
        }

        public override double ToYards(double value)
        {
            return value * 1760;
        }

        public override double ToInches(double value)
        {
            return value * 63360;
        }

        public override double ToMiles(double value)
        {
            return value;
        }

        public override double ToFeet(double value)
        {
            return value * 5280;
        }
    }
}
