using System;
using System.Windows.Forms;

namespace TP2EX8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumber1.Text, out double number1) && double.TryParse(txtNumber2.Text, out double number2))
            {
                double result = 0;

                if (rdoAddition.Checked)
                {
                    result = number1 + number2;
                }
                else if (rdoSubtraction.Checked)
                {
                    result = number1 - number2;
                }
                else if (rdoMultiplication.Checked)
                {
                    result = number1 * number2;
                }
                else if (rdoDivision.Checked)
                {
                    if (number2 != 0)
                    {
                        result = number1 / number2;
                    }
                    else
                    {
                        MessageBox.Show("Division by zero is not allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                txtResult.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Please enter valid numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumber1.Clear();
            txtNumber2.Clear();
            txtResult.Clear();
            rdoAddition.Checked = false;
            rdoSubtraction.Checked = false;
            rdoMultiplication.Checked = false;
            rdoDivision.Checked = false;
        }

    }
}
