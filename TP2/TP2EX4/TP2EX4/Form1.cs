using System;
using System.Windows.Forms;

namespace TP2EX4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtUnitPrice.Text, out double unitPrice) && int.TryParse(txtQuantity.Text, out int quantity) && double.TryParse(txtVAT.Text, out double vat))
            {
                if (unitPrice > 0 && quantity > 0 && vat >= 0 && vat <= 100)
                {
                    double totalPrice = unitPrice * quantity * (1 + vat / 100);
                    txtTotalPrice.Text = totalPrice.ToString("F2");
                }
                else
                {
                    lblError.Text = "Veuillez entrer des valeurs valides.";
                    lblError.ForeColor = System.Drawing.Color.Red;
                }
            }
        }
    }
}
