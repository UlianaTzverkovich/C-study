using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class SquareEquationForm : Form
    {
        public SquareEquationForm()
        {
            InitializeComponent();
        }

        private void cmdSollveSquareEquation_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBoxAVal.Text);
            double b = double.Parse(textBoxBVal.Text);
            double c = double.Parse(textBoxCVal.Text);

            double disc = Math.Pow(b, 2) - 4 * a * c;
            if (disc > 0)
            {
                labelSquareRootsAnswer.Text = "the equation has 2 roots: ";
                textBoxFirstRoot.Text = $"{Math.Round((-b + Math.Sqrt(disc) / 2 * a),2)}";
                textBoxSecondRoot.Text = $"{Math.Round((-b - Math.Sqrt(disc) / 2 * a),2)}";
            }
            else if (disc == 0)
            {
                labelSquareRootsAnswer.Text = "the equation has 1 root: ";
                textBoxFirstRoot.Text = $"{Math.Round((-b / 2 * a),2)}";
                textBoxSecondRoot.Text = "-";
            }
            else 
            {
                labelSquareRootsAnswer.Text = "the equation don't have any roots: ";
                textBoxFirstRoot.Text = "-";
                textBoxSecondRoot.Text = "-";
            }
        }

        private void textBoxAVal_TextChanged(object sender, EventArgs e)
        {
            double val;
            if (textBoxAVal.Text.Equals(""))
            {
                errorProvider1.Clear();
            }
            else if (!double.TryParse(this.textBoxAVal.Text, out val))
            {
                errorProvider1.SetError(textBoxAVal, "Must be a digit");
            }
            else errorProvider1.Clear();

        }

        private void textBoxBVal_TextChanged(object sender, EventArgs e)
        {
            double val;
            if (textBoxBVal.Text.Equals(""))
            {
                errorProvider1.Clear();
            }
            else if (!double.TryParse(this.textBoxBVal.Text, out val))
            {
                errorProvider1.SetError(textBoxBVal, "Must be a digit");
            }
            else errorProvider1.Clear();
        }

        private void textBoxCVal_TextChanged(object sender, EventArgs e)
        {
            double val;
            if (textBoxCVal.Text.Equals(""))
            {
                errorProvider1.Clear();
            }
            else if (!double.TryParse(this.textBoxCVal.Text, out val))
            {
                errorProvider1.SetError(textBoxCVal, "Must be a digit");
            }
            else errorProvider1.Clear();
        }
    }
}
