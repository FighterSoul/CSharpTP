using System;
using System.Windows.Forms;

namespace TP2EX7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            UpdateBackgroundColor();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.SystemColors.Control;
        }

        private void Color_CheckedChanged(object sender, EventArgs e)
        {
            UpdateBackgroundColor();
        }

        private void UpdateBackgroundColor()
        {
            if (rdoRed.Checked)
                this.BackColor = System.Drawing.Color.Red;
            else if (rdoGreen.Checked)
                this.BackColor = System.Drawing.Color.Green;
            else if (rdoBlue.Checked)
                this.BackColor = System.Drawing.Color.Blue;
            else if (rdoDefault.Checked)
                this.BackColor = System.Drawing.SystemColors.Control;
        }
    }
}



