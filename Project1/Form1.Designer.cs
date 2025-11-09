namespace BMI_Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtLengte = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BMIberekenen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGewicht = new System.Windows.Forms.TextBox();
            this.txtLeeftijd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblBMI = new System.Windows.Forms.Label();
            this.lblAdvies = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lengte in cm:";
            // 
            // txtLengte
            // 
            this.txtLengte.Location = new System.Drawing.Point(188, 118);
            this.txtLengte.Name = "txtLengte";
            this.txtLengte.Size = new System.Drawing.Size(100, 22);
            this.txtLengte.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(141, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "BMI Calculator";
            // 
            // BMIberekenen
            // 
            this.BMIberekenen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BMIberekenen.Location = new System.Drawing.Point(131, 288);
            this.BMIberekenen.Name = "BMIberekenen";
            this.BMIberekenen.Size = new System.Drawing.Size(224, 55);
            this.BMIberekenen.TabIndex = 3;
            this.BMIberekenen.Text = "BMI berekenen";
            this.BMIberekenen.UseVisualStyleBackColor = true;
            this.BMIberekenen.Click += new System.EventHandler(this.BMIberekenen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gewicht in kg:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "leeftijd:";
            // 
            // txtGewicht
            // 
            this.txtGewicht.Location = new System.Drawing.Point(188, 163);
            this.txtGewicht.Name = "txtGewicht";
            this.txtGewicht.Size = new System.Drawing.Size(100, 22);
            this.txtGewicht.TabIndex = 6;
            // 
            // txtLeeftijd
            // 
            this.txtLeeftijd.Location = new System.Drawing.Point(188, 208);
            this.txtLeeftijd.Name = "txtLeeftijd";
            this.txtLeeftijd.Size = new System.Drawing.Size(100, 22);
            this.txtLeeftijd.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(129, 484);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "BMI:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(128, 532);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Advies:";
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.Location = new System.Drawing.Point(219, 484);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(46, 17);
            this.lblBMI.TabIndex = 10;
            this.lblBMI.Text = "label7";
            // 
            // lblAdvies
            // 
            this.lblAdvies.AutoSize = true;
            this.lblAdvies.Location = new System.Drawing.Point(219, 532);
            this.lblAdvies.Name = "lblAdvies";
            this.lblAdvies.Size = new System.Drawing.Size(46, 17);
            this.lblAdvies.TabIndex = 11;
            this.lblAdvies.Text = "label8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(486, 634);
            this.Controls.Add(this.lblAdvies);
            this.Controls.Add(this.lblBMI);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLeeftijd);
            this.Controls.Add(this.txtGewicht);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BMIberekenen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLengte);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLengte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BMIberekenen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGewicht;
        private System.Windows.Forms.TextBox txtLeeftijd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.Label lblAdvies;
    }
}

