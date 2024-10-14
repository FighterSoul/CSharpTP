using System;
using System.Windows.Forms;

namespace TP2EX10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.AcceptButton = btnOrder;
            this.CancelButton = btnQuit;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            string message = "Vous avez commandé : ";
            if (chkDish1.Checked) message += "\n- Plat1";
            if (chkDish2.Checked) message += "\n- Plat2";
            if (chkDish3.Checked) message += "\n- Plat3";
            MessageBox.Show(message, "Commande");
        }

        private void btnToggleCheck_Click(object sender, EventArgs e)
        {
            bool checkState = !chkDish1.Checked;
            chkDish1.Checked = checkState;
            chkDish2.Checked = checkState;
            chkDish3.Checked = checkState;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
