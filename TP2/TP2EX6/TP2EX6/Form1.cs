using System;
using System.Windows.Forms;

namespace TP2EX6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumber.Text, out int number) && number > 0)
            {
                txtResult.Clear();

                for (int i = 1; i <= 10; i++)
                {
                    txtResult.AppendText($"{number} x {i} = {number * i}\r\n");
                }
            }
            else
            {
                MessageBox.Show("Veuillez entrer un nombre entier valide.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumber.Clear();
            txtResult.Clear();

            txtNumber.Focus();
        }
    }
}
