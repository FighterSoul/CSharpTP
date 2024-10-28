namespace TP2EX7
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton rdoRed;
        private System.Windows.Forms.RadioButton rdoGreen;
        private System.Windows.Forms.RadioButton rdoBlue;
        private System.Windows.Forms.RadioButton rdoDefault;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rdoRed = new System.Windows.Forms.RadioButton();
            this.rdoGreen = new System.Windows.Forms.RadioButton();
            this.rdoBlue = new System.Windows.Forms.RadioButton();
            this.rdoDefault = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();

            this.btnOK.Location = new System.Drawing.Point(50, 200);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 30);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);

            this.btnCancel.Location = new System.Drawing.Point(200, 200);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            this.rdoRed.AutoSize = true;
            this.rdoRed.Location = new System.Drawing.Point(50, 50);
            this.rdoRed.Name = "rdoRed";
            this.rdoRed.Size = new System.Drawing.Size(81, 24);
            this.rdoRed.TabIndex = 2;
            this.rdoRed.TabStop = true;
            this.rdoRed.Text = "Rouge";
            this.rdoRed.UseVisualStyleBackColor = true;

            this.rdoGreen.AutoSize = true;
            this.rdoGreen.Location = new System.Drawing.Point(50, 100);
            this.rdoGreen.Name = "rdoGreen";
            this.rdoGreen.Size = new System.Drawing.Size(65, 24);
            this.rdoGreen.TabIndex = 3;
            this.rdoGreen.TabStop = true;
            this.rdoGreen.Text = "Vert";
            this.rdoGreen.UseVisualStyleBackColor = true;

            this.rdoBlue.AutoSize = true;
            this.rdoBlue.Location = new System.Drawing.Point(50, 150);
            this.rdoBlue.Name = "rdoBlue";
            this.rdoBlue.Size = new System.Drawing.Size(64, 24);
            this.rdoBlue.TabIndex = 4;
            this.rdoBlue.TabStop = true;
            this.rdoBlue.Text = "Bleu";
            this.rdoBlue.UseVisualStyleBackColor = true;

            this.rdoDefault.AutoSize = true;
            this.rdoDefault.Location = new System.Drawing.Point(200, 150);
            this.rdoDefault.Name = "rdoDefault";
            this.rdoDefault.Size = new System.Drawing.Size(89, 24);
            this.rdoDefault.TabIndex = 5;
            this.rdoDefault.TabStop = true;
            this.rdoDefault.Text = "Défaut";
            this.rdoDefault.UseVisualStyleBackColor = true;

            this.ClientSize = new System.Drawing.Size(350, 250);
            this.Controls.Add(this.rdoDefault);
            this.Controls.Add(this.rdoBlue);
            this.Controls.Add(this.rdoGreen);
            this.Controls.Add(this.rdoRed);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

    }
}



