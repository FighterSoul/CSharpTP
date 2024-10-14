namespace TP2EX9
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.RadioButton rdoDinarToEuro;
        private System.Windows.Forms.RadioButton rdoEuroToDinar;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblResult; // Ajout du label pour le résultat

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
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.rdoDinarToEuro = new System.Windows.Forms.RadioButton();
            this.rdoEuroToDinar = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label(); // Initialisation du label
            this.SuspendLayout();
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(50, 30);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 26);
            this.txtAmount.TabIndex = 0;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(50, 150);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(100, 30);
            this.btnConvert.TabIndex = 1;
            this.btnConvert.Text = "Convertir";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // rdoDinarToEuro
            // 
            this.rdoDinarToEuro.AutoSize = true;
            this.rdoDinarToEuro.Location = new System.Drawing.Point(50, 70);
            this.rdoDinarToEuro.Name = "rdoDinarToEuro";
            this.rdoDinarToEuro.Size = new System.Drawing.Size(140, 24);
            this.rdoDinarToEuro.TabIndex = 2;
            this.rdoDinarToEuro.TabStop = true;
            this.rdoDinarToEuro.Text = "Dinar vers Euro";
            this.rdoDinarToEuro.UseVisualStyleBackColor = true;
            // 
            // rdoEuroToDinar
            // 
            this.rdoEuroToDinar.AutoSize = true;
            this.rdoEuroToDinar.Location = new System.Drawing.Point(200, 70);
            this.rdoEuroToDinar.Name = "rdoEuroToDinar";
            this.rdoEuroToDinar.Size = new System.Drawing.Size(140, 24);
            this.rdoEuroToDinar.TabIndex = 3;
            this.rdoEuroToDinar.TabStop = true;
            this.rdoEuroToDinar.Text = "Euro vers Dinar";
            this.rdoEuroToDinar.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(200, 150);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 30);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Annuler";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(350, 150);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(100, 30);
            this.btnQuit.TabIndex = 5;
            this.btnQuit.Text = "Quitter";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(50, 200);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 20);
            this.lblResult.TabIndex = 6;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(500, 250);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.rdoEuroToDinar);
            this.Controls.Add(this.rdoDinarToEuro);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtAmount);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
