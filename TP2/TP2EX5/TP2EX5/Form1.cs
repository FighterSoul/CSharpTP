using System;
using System.Windows.Forms;

namespace TP2EX5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtDinar.Text, out double dinar) && dinar > 0)
            {
                double euro = dinar / 3.2;  
                txtEuro.Text = euro.ToString("F2");
            }
            else
            {
                MessageBox.Show("Veuillez entrer un montant valide.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDinar.Clear();
            txtEuro.Clear();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
