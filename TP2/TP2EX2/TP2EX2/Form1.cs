using System;
using System.Windows.Forms;

namespace TP2EX2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            if (btnToggle.Text == "Afficher")
            {
                lblMessage.Text = "Bienvenue dans mon application";
                lblMessage.Visible = true;
                btnToggle.Text = "Effacer";
            }
            else
            {
                lblMessage.Visible = false;
                btnToggle.Text = "Afficher";
            }
        }
    }
}
