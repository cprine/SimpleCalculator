using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class frmSimpleClaculator : Form
    {
        public frmSimpleClaculator()
        {
            InitializeComponent();
        }
        private decimal Calculate(decimal operand1, string operator1, decimal operand2)
        {
            decimal result = 0m;

            if (operator1 == "+")
            {
                result = operand1 + operand2;
            }
            else if (operator1 == "-")
            {
                result = operand1 - operand2;
            }
            else if (operator1 == "*")
            {
                result = operand1 * operand2;
            }
            else if (operator1 == "/")
            {
                result = operand1 / operand2;
            }

            return result;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal operand1 = Convert.ToDecimal(txtOperand1.Text);
            string operator1 = Convert.ToString(txtOperator.Text);
            decimal operand2 = Convert.ToDecimal(txtOperand2.Text);

            txtResult.Text = Convert.ToString(Calculate(operand1, operator1, operand2));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
