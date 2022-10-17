
namespace InteresPratica
{
    partial class FmrInteres
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.txtpresente = new System.Windows.Forms.TextBox();
            this.txtfuturo = new System.Windows.Forms.TextBox();
            this.txtinteres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtxaños = new System.Windows.Forms.TextBox();
            this.lblinteres = new System.Windows.Forms.Label();
            this.lblfuturo = new System.Windows.Forms.Label();
            this.llbpresente = new System.Windows.Forms.Label();
            this.lblaños = new System.Windows.Forms.Label();
            this.llbcapital = new System.Windows.Forms.Label();
            this.cmbcapital = new System.Windows.Forms.ComboBox();
            this.cmbmostrasr = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ellipseControl1 = new Economy.BeatifulComponents.EllipseControl();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(295, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtpresente
            // 
            this.txtpresente.Location = new System.Drawing.Point(125, 61);
            this.txtpresente.Name = "txtpresente";
            this.txtpresente.Size = new System.Drawing.Size(187, 23);
            this.txtpresente.TabIndex = 2;
            this.txtpresente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txtfuturo
            // 
            this.txtfuturo.Location = new System.Drawing.Point(125, 22);
            this.txtfuturo.Name = "txtfuturo";
            this.txtfuturo.Size = new System.Drawing.Size(187, 23);
            this.txtfuturo.TabIndex = 3;
            this.txtfuturo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfuturo_KeyPress);
            // 
            // txtinteres
            // 
            this.txtinteres.Location = new System.Drawing.Point(125, 125);
            this.txtinteres.Name = "txtinteres";
            this.txtinteres.Size = new System.Drawing.Size(187, 23);
            this.txtinteres.TabIndex = 4;
            this.txtinteres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtinteres_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "----";
            // 
            // txtxaños
            // 
            this.txtxaños.Location = new System.Drawing.Point(125, 188);
            this.txtxaños.Name = "txtxaños";
            this.txtxaños.Size = new System.Drawing.Size(187, 23);
            this.txtxaños.TabIndex = 6;
            this.txtxaños.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtxaños_KeyPress);
            // 
            // lblinteres
            // 
            this.lblinteres.AutoSize = true;
            this.lblinteres.Location = new System.Drawing.Point(57, 136);
            this.lblinteres.Name = "lblinteres";
            this.lblinteres.Size = new System.Drawing.Size(45, 15);
            this.lblinteres.TabIndex = 7;
            this.lblinteres.Text = "Interés ";
            // 
            // lblfuturo
            // 
            this.lblfuturo.AutoSize = true;
            this.lblfuturo.Location = new System.Drawing.Point(57, 25);
            this.lblfuturo.Name = "lblfuturo";
            this.lblfuturo.Size = new System.Drawing.Size(42, 15);
            this.lblfuturo.TabIndex = 8;
            this.lblfuturo.Text = "Futuro";
            // 
            // llbpresente
            // 
            this.llbpresente.AutoSize = true;
            this.llbpresente.Location = new System.Drawing.Point(47, 64);
            this.llbpresente.Name = "llbpresente";
            this.llbpresente.Size = new System.Drawing.Size(52, 15);
            this.llbpresente.TabIndex = 9;
            this.llbpresente.Text = "Presente";
            // 
            // lblaños
            // 
            this.lblaños.AutoSize = true;
            this.lblaños.Location = new System.Drawing.Point(57, 196);
            this.lblaños.Name = "lblaños";
            this.lblaños.Size = new System.Drawing.Size(48, 15);
            this.lblaños.TabIndex = 10;
            this.lblaños.Text = "Periodo";
            // 
            // llbcapital
            // 
            this.llbcapital.AutoSize = true;
            this.llbcapital.Location = new System.Drawing.Point(35, 254);
            this.llbcapital.Name = "llbcapital";
            this.llbcapital.Size = new System.Drawing.Size(74, 15);
            this.llbcapital.TabIndex = 30;
            this.llbcapital.Text = "Capitalizable";
            // 
            // cmbcapital
            // 
            this.cmbcapital.FormattingEnabled = true;
            this.cmbcapital.Location = new System.Drawing.Point(125, 251);
            this.cmbcapital.Name = "cmbcapital";
            this.cmbcapital.Size = new System.Drawing.Size(187, 23);
            this.cmbcapital.TabIndex = 29;
            // 
            // cmbmostrasr
            // 
            this.cmbmostrasr.FormattingEnabled = true;
            this.cmbmostrasr.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cmbmostrasr.Items.AddRange(new object[] {
            "Futuro",
            "Presente",
            "Periodo",
            "Convertidor de Tasas"});
            this.cmbmostrasr.Location = new System.Drawing.Point(365, 39);
            this.cmbmostrasr.Name = "cmbmostrasr";
            this.cmbmostrasr.Size = new System.Drawing.Size(179, 23);
            this.cmbmostrasr.TabIndex = 40;
            this.cmbmostrasr.SelectedIndexChanged += new System.EventHandler(this.cmbmostrasr_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 15);
            this.label2.TabIndex = 41;
            this.label2.Text = " ¿ Que Desea Hacer ?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 42;
            this.label3.Text = "Respuesta";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtxaños);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtpresente);
            this.groupBox1.Controls.Add(this.txtfuturo);
            this.groupBox1.Controls.Add(this.txtinteres);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblinteres);
            this.groupBox1.Controls.Add(this.lblfuturo);
            this.groupBox1.Controls.Add(this.llbpresente);
            this.groupBox1.Controls.Add(this.lblaños);
            this.groupBox1.Controls.Add(this.cmbcapital);
            this.groupBox1.Controls.Add(this.llbcapital);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(236, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 346);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculos";
            // 
            // ellipseControl1
            // 
            this.ellipseControl1.CornerRadius = 25;
            this.ellipseControl1.TargetControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 15);
            this.label4.TabIndex = 50;
            this.label4.Text = "%";
            // 
            // FmrInteres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(179)))), ((int)(((byte)(151)))));
            this.ClientSize = new System.Drawing.Size(1008, 501);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbmostrasr);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FmrInteres";
            this.Text = "Interés  Nominal";
            this.Load += new System.EventHandler(this.FmrInteres_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtpresente;
        private System.Windows.Forms.TextBox txtfuturo;
        private System.Windows.Forms.TextBox txtinteres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtxaños;
        private System.Windows.Forms.Label lblinteres;
        private System.Windows.Forms.Label lblfuturo;
        private System.Windows.Forms.Label llbpresente;
        private System.Windows.Forms.Label lblaños;
        private System.Windows.Forms.Label llbcapital;
        private System.Windows.Forms.ComboBox cmbcapital;
        private System.Windows.Forms.ComboBox cmbmostrasr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private Economy.BeatifulComponents.EllipseControl ellipseControl1;
        private System.Windows.Forms.Label label4;
    }
}

