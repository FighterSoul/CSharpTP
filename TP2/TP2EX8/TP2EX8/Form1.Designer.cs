namespace TP2EX8
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.RadioButton rdoAddition;
        private System.Windows.Forms.RadioButton rdoSubtraction;
        private System.Windows.Forms.RadioButton rdoMultiplication;
        private System.Windows.Forms.RadioButton rdoDivision;
        private System.Windows.Forms.GroupBox grpOperations;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblNumber1;
        private System.Windows.Forms.Label lblNumber2;
        private System.Windows.Forms.Label lblResult;

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
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.rdoAddition = new System.Windows.Forms.RadioButton();
            this.rdoSubtraction = new System.Windows.Forms.RadioButton();
            this.rdoMultiplication = new System.Windows.Forms.RadioButton();
            this.rdoDivision = new System.Windows.Forms.RadioButton();
            this.grpOperations = new System.Windows.Forms.GroupBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblNumber1 = new System.Windows.Forms.Label();
            this.lblNumber2 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();

            this.grpOperations.SuspendLayout();
            this.SuspendLayout();

            // Label for Number1
            this.lblNumber1.AutoSize = true;
            this.lblNumber1.Location = new System.Drawing.Point(20, 20);
            this.lblNumber1.Name = "lblNumber1";
            this.lblNumber1.Size = new System.Drawing.Size(60, 20);
            this.lblNumber1.TabIndex = 0;
            this.lblNumber1.Text = "Nombre1";

            // Label for Number2
            this.lblNumber2.AutoSize = true;
            this.lblNumber2.Location = new System.Drawing.Point(20, 60);
            this.lblNumber2.Name = "lblNumber2";
            this.lblNumber2.Size = new System.Drawing.Size(60, 20);
            this.lblNumber2.TabIndex = 1;
            this.lblNumber2.Text = "Nombre 2";

            // Label for Result
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(20, 100);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(60, 20);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Résultat";

            // TextBox for Number1
            this.txtNumber1.Location = new System.Drawing.Point(100, 20);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(100, 26);
            this.txtNumber1.TabIndex = 3;

            // TextBox for Number2
            this.txtNumber2.Location = new System.Drawing.Point(100, 60);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(100, 26);
            this.txtNumber2.TabIndex = 4;

            // TextBox for Result
            this.txtResult.Location = new System.Drawing.Point(100, 100);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 26);
            this.txtResult.TabIndex = 5;
            this.txtResult.ReadOnly = true;

            // GroupBox for Operations
            this.grpOperations.Controls.Add(this.rdoAddition);
            this.grpOperations.Controls.Add(this.rdoSubtraction);
            this.grpOperations.Controls.Add(this.rdoMultiplication);
            this.grpOperations.Controls.Add(this.rdoDivision);
            this.grpOperations.Location = new System.Drawing.Point(220, 20);
            this.grpOperations.Name = "grpOperations";
            this.grpOperations.Size = new System.Drawing.Size(120, 140);
            this.grpOperations.TabIndex = 6;
            this.grpOperations.TabStop = false;
            this.grpOperations.Text = "Opérations";

            // RadioButton for Addition
            this.rdoAddition.AutoSize = true;
            this.rdoAddition.Location = new System.Drawing.Point(10, 20);
            this.rdoAddition.Name = "rdoAddition";
            this.rdoAddition.Size = new System.Drawing.Size(75, 24);
            this.rdoAddition.TabIndex = 0;
            this.rdoAddition.TabStop = true;
            this.rdoAddition.Text = "Addition";
            this.rdoAddition.UseVisualStyleBackColor = true;

            // RadioButton for Subtraction
            this.rdoSubtraction.AutoSize = true;
            this.rdoSubtraction.Location = new System.Drawing.Point(10, 50);
            this.rdoSubtraction.Name = "rdoSubtraction";
            this.rdoSubtraction.Size = new System.Drawing.Size(105, 24);
            this.rdoSubtraction.TabIndex = 1;
            this.rdoSubtraction.TabStop = true;
            this.rdoSubtraction.Text = "Soustraction";
            this.rdoSubtraction.UseVisualStyleBackColor = true;

            // RadioButton for Multiplication
            this.rdoMultiplication.AutoSize = true;
            this.rdoMultiplication.Location = new System.Drawing.Point(10, 80);
            this.rdoMultiplication.Name = "rdoMultiplication";
            this.rdoMultiplication.Size = new System.Drawing.Size(120, 24);
            this.rdoMultiplication.TabIndex = 2;
            this.rdoMultiplication.TabStop = true;
            this.rdoMultiplication.Text = "Multiplication";
            this.rdoMultiplication.UseVisualStyleBackColor = true;

            // RadioButton for Division
            this.rdoDivision.AutoSize = true;
            this.rdoDivision.Location = new System.Drawing.Point(10, 110);
            this.rdoDivision.Name = "rdoDivision";
            this.rdoDivision.Size = new System.Drawing.Size(80, 24);
            this.rdoDivision.TabIndex = 3;
            this.rdoDivision.TabStop = true;
            this.rdoDivision.Text = "Division";
            this.rdoDivision.UseVisualStyleBackColor = true;

            // Calculate Button
            this.btnCalculate.Location = new System.Drawing.Point(100, 150);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 30);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculer";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);

            // Clear Button
            this.btnClear.Location = new System.Drawing.Point(220, 150);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 30);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Annuler";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // Form1
            this.ClientSize = new System.Drawing.Size(370, 200);
            this.Controls.Add(this.lblNumber1);
            this.Controls.Add(this.lblNumber2);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.grpOperations);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnClear);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.grpOperations.ResumeLayout(false);
            this.grpOperations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
