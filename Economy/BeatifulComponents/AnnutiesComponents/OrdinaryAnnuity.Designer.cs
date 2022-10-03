namespace Economy.BeatifulComponents.AnnutiesComponents
{
    partial class OrdinaryAnnuity
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblP = new System.Windows.Forms.Label();
            this.gbN = new System.Windows.Forms.GroupBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lbldurationN = new System.Windows.Forms.Label();
            this.lblInterestN = new System.Windows.Forms.Label();
            this.gbD = new System.Windows.Forms.GroupBox();
            this.lbldurationD = new System.Windows.Forms.Label();
            this.lblInterestD = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbSignificado = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ellipseControl1 = new Economy.BeatifulComponents.EllipseControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPayment = new System.Windows.Forms.Label();
            this.gbN.SuspendLayout();
            this.gbD.SuspendLayout();
            this.gbSignificado.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblP.Location = new System.Drawing.Point(15, 77);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(34, 18);
            this.lblP.TabIndex = 0;
            this.lblP.Text = "PAo=";
            this.lblP.Click += new System.EventHandler(this.lblP_Click);
            // 
            // gbN
            // 
            this.gbN.BackColor = System.Drawing.Color.Transparent;
            this.gbN.Controls.Add(this.lblNumber);
            this.gbN.Controls.Add(this.lbldurationN);
            this.gbN.Controls.Add(this.lblInterestN);
            this.gbN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbN.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbN.Location = new System.Drawing.Point(3, 16);
            this.gbN.Name = "gbN";
            this.gbN.Size = new System.Drawing.Size(65, 30);
            this.gbN.TabIndex = 1;
            this.gbN.TabStop = false;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(40, 10);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(18, 18);
            this.lblNumber.TabIndex = 4;
            this.lblNumber.Text = "-1";
            // 
            // lbldurationN
            // 
            this.lbldurationN.AutoSize = true;
            this.lbldurationN.BackColor = System.Drawing.Color.Transparent;
            this.lbldurationN.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbldurationN.Location = new System.Drawing.Point(31, 5);
            this.lbldurationN.Name = "lbldurationN";
            this.lbldurationN.Size = new System.Drawing.Size(10, 11);
            this.lbldurationN.TabIndex = 1;
            this.lbldurationN.Text = "n";
            // 
            // lblInterestN
            // 
            this.lblInterestN.AutoSize = true;
            this.lblInterestN.Location = new System.Drawing.Point(6, 9);
            this.lblInterestN.Name = "lblInterestN";
            this.lblInterestN.Size = new System.Drawing.Size(31, 18);
            this.lblInterestN.TabIndex = 0;
            this.lblInterestN.Text = "(1+i)";
            // 
            // gbD
            // 
            this.gbD.BackColor = System.Drawing.Color.Transparent;
            this.gbD.Controls.Add(this.lbldurationD);
            this.gbD.Controls.Add(this.lblInterestD);
            this.gbD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbD.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbD.Location = new System.Drawing.Point(3, 53);
            this.gbD.Name = "gbD";
            this.gbD.Size = new System.Drawing.Size(63, 33);
            this.gbD.TabIndex = 2;
            this.gbD.TabStop = false;
            // 
            // lbldurationD
            // 
            this.lbldurationD.AutoSize = true;
            this.lbldurationD.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbldurationD.Location = new System.Drawing.Point(46, 8);
            this.lbldurationD.Name = "lbldurationD";
            this.lbldurationD.Size = new System.Drawing.Size(10, 11);
            this.lbldurationD.TabIndex = 1;
            this.lbldurationD.Text = "n";
            // 
            // lblInterestD
            // 
            this.lblInterestD.AutoSize = true;
            this.lblInterestD.Location = new System.Drawing.Point(5, 12);
            this.lblInterestD.Name = "lblInterestD";
            this.lblInterestD.Size = new System.Drawing.Size(46, 18);
            this.lblInterestD.TabIndex = 0;
            this.lblInterestD.Text = "i * (1+i)";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(2, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(70, 1);
            this.panel1.TabIndex = 3;
            // 
            // gbSignificado
            // 
            this.gbSignificado.Controls.Add(this.label6);
            this.gbSignificado.Controls.Add(this.label5);
            this.gbSignificado.Controls.Add(this.label4);
            this.gbSignificado.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbSignificado.Location = new System.Drawing.Point(169, 6);
            this.gbSignificado.Name = "gbSignificado";
            this.gbSignificado.Size = new System.Drawing.Size(121, 141);
            this.gbSignificado.TabIndex = 4;
            this.gbSignificado.TabStop = false;
            this.gbSignificado.Text = "Significado";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(6, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 36);
            this.label6.TabIndex = 7;
            this.label6.Text = "n: duración de la anualidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(6, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "i: tasa de interés";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 35);
            this.label4.TabIndex = 5;
            this.label4.Text = "PAo: Presente anualidad ordinaria";
            // 
            // ellipseControl1
            // 
            this.ellipseControl1.CornerRadius = 8;
            this.ellipseControl1.TargetControl = this;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gbN);
            this.panel2.Controls.Add(this.gbD);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(89, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(77, 99);
            this.panel2.TabIndex = 5;
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Location = new System.Drawing.Point(45, 80);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(59, 15);
            this.lblPayment.TabIndex = 6;
            this.lblPayment.Text = "Payment*";
            // 
            // OrdinaryAnnuity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gbSignificado);
            this.Controls.Add(this.lblP);
            this.Name = "OrdinaryAnnuity";
            this.Size = new System.Drawing.Size(296, 154);
            this.Load += new System.EventHandler(this.OrdinaryAnnuity_Load);
            this.gbN.ResumeLayout(false);
            this.gbN.PerformLayout();
            this.gbD.ResumeLayout(false);
            this.gbD.PerformLayout();
            this.gbSignificado.ResumeLayout(false);
            this.gbSignificado.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.GroupBox gbN;
        private System.Windows.Forms.Label lbldurationN;
        private System.Windows.Forms.Label lblInterestN;
        private System.Windows.Forms.GroupBox gbD;
        private System.Windows.Forms.Label lbldurationD;
        private System.Windows.Forms.Label lblInterestD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbSignificado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private EllipseControl ellipseControl1;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPayment;
    }
}
