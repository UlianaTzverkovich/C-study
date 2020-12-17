using Calculator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Engieeniring : SimpleCalculator.CalcUI
    {
        SquareEquationForm equationForm;
        public Engieeniring()
        {
            InitializeComponent();
        }

        private void cmdXToThePowerOfY_Click(object sender, EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.ePow);
        }

        private void cmdSqrtX_Click(object sender, EventArgs e)
        {
            CalcEngine.EngeneerCalcOperation(CalcEngine.Operator.eSqrt);
        }

        private void cmdGetReverseValue_Click(object sender, EventArgs e)
        {
            CalcEngine.EngeneerCalcOperation(CalcEngine.Operator.eReverse);
        }

        private void cmdSquareOfX_Click(object sender, EventArgs e)
        {
            CalcEngine.EngeneerCalcOperation(CalcEngine.Operator.eSquare);
        }

        private void cmdFactorialX_Click(object sender, EventArgs e)
        {
            CalcEngine.EngeneerCalcOperation(CalcEngine.Operator.eFactorial);
        }

        private void cmdSquareRootX_Click(object sender, EventArgs e)
        {
            CalcEngine.EngeneerCalcOperation(CalcEngine.Operator.eCubeRoot);
        }

        private void cmdSquareEquation_Click(object sender, EventArgs e)
        {
            SquareEquationForm equationForm = new SquareEquationForm();
            equationForm.Show();
        }

        private void IngeneersCalc_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void IngeneersCalc_Load(object sender, EventArgs e)
        {

        }
    }
}
