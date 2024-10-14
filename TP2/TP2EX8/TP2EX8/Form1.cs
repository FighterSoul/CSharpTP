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
            if (double.TryParse(txtNumber1.Text, out double num1) && double.TryParse(txtNumber2.Text, out double num2))
            {
                string operation = cmbOperation.SelectedItem.ToString();
                double result = 0;

                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                        // Add more operations as needed
                }

                lblResult.Text = $"Résultat: {result}";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumber1.Clear();
            txtNumber2.Clear();
            lblResult.Text = "";
        }
    }
}
