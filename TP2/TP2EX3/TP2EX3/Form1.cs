using System;
using System.Windows.Forms;

namespace TP2EX3
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
                txtSum.Text = (num1 + num2).ToString();
            }
            else
            {
                MessageBox.Show("Veuillez entrer des nombres valides.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumber1.Clear();
            txtNumber2.Clear();
            txtSum.Clear();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
