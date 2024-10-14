namespace TP2EX10
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnToggleCheck;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.CheckBox chkDish1;
        private System.Windows.Forms.CheckBox chkDish2;
        private System.Windows.Forms.CheckBox chkDish3;

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
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnToggleCheck = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.chkDish1 = new System.Windows.Forms.CheckBox();
            this.chkDish2 = new System.Windows.Forms.CheckBox();
            this.chkDish3 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
           
            this.btnOrder.Location = new System.Drawing.Point(50, 150);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(100, 30);
            this.btnOrder.TabIndex = 0;
            this.btnOrder.Text = "Commander";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
           
            this.btnToggleCheck.Location = new System.Drawing.Point(200, 150);
            this.btnToggleCheck.Name = "btnToggleCheck";
            this.btnToggleCheck.Size = new System.Drawing.Size(150, 30);
            this.btnToggleCheck.TabIndex = 1;
            this.btnToggleCheck.Text = "Cocher tout";
            this.btnToggleCheck.UseVisualStyleBackColor = true;
            this.btnToggleCheck.Click += new System.EventHandler(this.btnToggleCheck_Click);
            
            this.btnQuit.Location = new System.Drawing.Point(400, 150);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(100, 30);
            this.btnQuit.TabIndex = 2;
            this.btnQuit.Text = "Quitter";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            
            this.chkDish1.AutoSize = true;
            this.chkDish1.Location = new System.Drawing.Point(50, 30);
            this.chkDish1.Name = "chkDish1";
            this.chkDish1.Size = new System.Drawing.Size(60, 24);
            this.chkDish1.TabIndex = 3;
            this.chkDish1.Text = "Plat1";
            this.chkDish1.UseVisualStyleBackColor = true;
            
            this.chkDish2.AutoSize = true;
            this.chkDish2.Location = new System.Drawing.Point(50, 70);
            this.chkDish2.Name = "chkDish2";
            this.chkDish2.Size = new System.Drawing.Size(60, 24);
            this.chkDish2.TabIndex = 4;
            this.chkDish2.Text = "Plat2";
            this.chkDish2.UseVisualStyleBackColor = true;
            
            this.chkDish3.AutoSize = true;
            this.chkDish3.Location = new System.Drawing.Point(50, 110);
            this.chkDish3.Name = "chkDish3";
            this.chkDish3.Size = new System.Drawing.Size(60, 24);
            this.chkDish3.TabIndex = 5;
            this.chkDish3.Text = "Plat3";
            this.chkDish3.UseVisualStyleBackColor = true;
            
            this.ClientSize = new System.Drawing.Size(550, 250);
            this.Controls.Add(this.chkDish3);
            this.Controls.Add(this.chkDish2);
            this.Controls.Add(this.chkDish1);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnToggleCheck);
            this.Controls.Add(this.btnOrder);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
