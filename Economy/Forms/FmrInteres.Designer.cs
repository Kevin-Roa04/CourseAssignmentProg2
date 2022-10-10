
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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(337, 389);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtpresente
            // 
            this.txtpresente.Location = new System.Drawing.Point(143, 81);
            this.txtpresente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtpresente.Name = "txtpresente";
            this.txtpresente.Size = new System.Drawing.Size(213, 27);
            this.txtpresente.TabIndex = 2;
            this.txtpresente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txtfuturo
            // 
            this.txtfuturo.Location = new System.Drawing.Point(143, 29);
            this.txtfuturo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtfuturo.Name = "txtfuturo";
            this.txtfuturo.Size = new System.Drawing.Size(213, 27);
            this.txtfuturo.TabIndex = 3;
            this.txtfuturo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfuturo_KeyPress);
            // 
            // txtinteres
            // 
            this.txtinteres.Location = new System.Drawing.Point(143, 167);
            this.txtinteres.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtinteres.Name = "txtinteres";
            this.txtinteres.Size = new System.Drawing.Size(213, 27);
            this.txtinteres.TabIndex = 4;
            this.txtinteres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtinteres_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "----";
            // 
            // txtxaños
            // 
            this.txtxaños.Location = new System.Drawing.Point(143, 251);
            this.txtxaños.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtxaños.Name = "txtxaños";
            this.txtxaños.Size = new System.Drawing.Size(213, 27);
            this.txtxaños.TabIndex = 6;
            this.txtxaños.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtxaños_KeyPress);
            // 
            // lblinteres
            // 
            this.lblinteres.AutoSize = true;
            this.lblinteres.Location = new System.Drawing.Point(65, 181);
            this.lblinteres.Name = "lblinteres";
            this.lblinteres.Size = new System.Drawing.Size(53, 20);
            this.lblinteres.TabIndex = 7;
            this.lblinteres.Text = "Interes";
            // 
            // lblfuturo
            // 
            this.lblfuturo.AutoSize = true;
            this.lblfuturo.Location = new System.Drawing.Point(65, 33);
            this.lblfuturo.Name = "lblfuturo";
            this.lblfuturo.Size = new System.Drawing.Size(51, 20);
            this.lblfuturo.TabIndex = 8;
            this.lblfuturo.Text = "Futuro";
            // 
            // llbpresente
            // 
            this.llbpresente.AutoSize = true;
            this.llbpresente.Location = new System.Drawing.Point(54, 85);
            this.llbpresente.Name = "llbpresente";
            this.llbpresente.Size = new System.Drawing.Size(65, 20);
            this.llbpresente.TabIndex = 9;
            this.llbpresente.Text = "Presente";
            // 
            // lblaños
            // 
            this.lblaños.AutoSize = true;
            this.lblaños.Location = new System.Drawing.Point(65, 261);
            this.lblaños.Name = "lblaños";
            this.lblaños.Size = new System.Drawing.Size(42, 20);
            this.lblaños.TabIndex = 10;
            this.lblaños.Text = "Años";
            // 
            // llbcapital
            // 
            this.llbcapital.AutoSize = true;
            this.llbcapital.Location = new System.Drawing.Point(40, 339);
            this.llbcapital.Name = "llbcapital";
            this.llbcapital.Size = new System.Drawing.Size(96, 20);
            this.llbcapital.TabIndex = 30;
            this.llbcapital.Text = "Capitalizable";
            // 
            // cmbcapital
            // 
            this.cmbcapital.FormattingEnabled = true;
            this.cmbcapital.Location = new System.Drawing.Point(143, 335);
            this.cmbcapital.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbcapital.Name = "cmbcapital";
            this.cmbcapital.Size = new System.Drawing.Size(213, 28);
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
            this.cmbmostrasr.Location = new System.Drawing.Point(417, 52);
            this.cmbmostrasr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbmostrasr.Name = "cmbmostrasr";
            this.cmbmostrasr.Size = new System.Drawing.Size(204, 28);
            this.cmbmostrasr.TabIndex = 40;
            this.cmbmostrasr.SelectedIndexChanged += new System.EventHandler(this.cmbmostrasr_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(448, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Que Desea Hacer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "Respuesta";
            // 
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(270, 125);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(526, 461);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculos";
            // 
            // ellipseControl1
            // 
            this.ellipseControl1.CornerRadius = 25;
            this.ellipseControl1.TargetControl = this;
            // 
            // FmrInteres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(179)))), ((int)(((byte)(151)))));
            this.ClientSize = new System.Drawing.Size(1152, 668);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbmostrasr);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FmrInteres";
            this.Text = "Interes Nominal";
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
    }
}

