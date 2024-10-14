using System;
using System.Windows.Forms;

namespace FormColorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (rdoRed.Checked)
                this.BackColor = System.Drawing.Color.Red;
            else if (rdoGreen.Checked)
                this.BackColor = System.Drawing.Color.Green;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.SystemColors.Control;
        }
    }
}
