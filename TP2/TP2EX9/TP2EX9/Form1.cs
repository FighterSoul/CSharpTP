namespace TP2EX9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                double amount = double.Parse(txtAmount.Text);
                double result;

                if (rdoDinarToEuro.Checked)
                {
                    result = amount / 3.3;
                    lblResult.Text = $"{amount} Dinar = {result:F2} Euro";
                }
                else if (rdoEuroToDinar.Checked)
                {
                    result = amount * 3.3; 
                    lblResult.Text = $"{amount} Euro = {result:F2} Dinar";
                }
                else
                {
                    lblResult.Text = "Veuillez sélectionner une option de conversion.";
                }
            }
            catch (FormatException)
            {
                lblResult.Text = "Veuillez entrer un montant valide.";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAmount.Clear();
            rdoDinarToEuro.Checked = false;
            rdoEuroToDinar.Checked = false;
            lblResult.Text = string.Empty;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
