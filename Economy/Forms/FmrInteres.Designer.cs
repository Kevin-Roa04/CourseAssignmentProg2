
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmrInteres));
            this.label1 = new System.Windows.Forms.Label();
            this.lblinteres = new System.Windows.Forms.Label();
            this.lblfuturo = new System.Windows.Forms.Label();
            this.llbpresente = new System.Windows.Forms.Label();
            this.lblaños = new System.Windows.Forms.Label();
            this.llbcapital = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtxaños = new Economy.RJTextBox();
            this.txtinteres = new Economy.RJTextBox();
            this.txtpresente = new Economy.RJTextBox();
            this.cmbcapital = new Economy.BeatifulComponents.RJComboBox();
            this.txtfuturo = new Economy.RJTextBox();
            this.button1 = new Economy.BeatifulComponents.RJButton();
            this.label4 = new System.Windows.Forms.Label();
            this.ellipseControl1 = new Economy.BeatifulComponents.EllipseControl();
            this.cmbmostrasr = new Economy.BeatifulComponents.RJComboBox();
            this.PbClose = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "----";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblinteres
            // 
            this.lblinteres.AutoSize = true;
            this.lblinteres.ForeColor = System.Drawing.Color.DimGray;
            this.lblinteres.Location = new System.Drawing.Point(57, 158);
            this.lblinteres.Name = "lblinteres";
            this.lblinteres.Size = new System.Drawing.Size(53, 18);
            this.lblinteres.TabIndex = 7;
            this.lblinteres.Text = "Interés ";
            // 
            // lblfuturo
            // 
            this.lblfuturo.AutoSize = true;
            this.lblfuturo.ForeColor = System.Drawing.Color.DimGray;
            this.lblfuturo.Location = new System.Drawing.Point(57, 30);
            this.lblfuturo.Name = "lblfuturo";
            this.lblfuturo.Size = new System.Drawing.Size(46, 18);
            this.lblfuturo.TabIndex = 8;
            this.lblfuturo.Text = "Futuro";
            // 
            // llbpresente
            // 
            this.llbpresente.AutoSize = true;
            this.llbpresente.ForeColor = System.Drawing.Color.DimGray;
            this.llbpresente.Location = new System.Drawing.Point(47, 77);
            this.llbpresente.Name = "llbpresente";
            this.llbpresente.Size = new System.Drawing.Size(58, 18);
            this.llbpresente.TabIndex = 9;
            this.llbpresente.Text = "Presente";
            // 
            // lblaños
            // 
            this.lblaños.AutoSize = true;
            this.lblaños.ForeColor = System.Drawing.Color.DimGray;
            this.lblaños.Location = new System.Drawing.Point(57, 235);
            this.lblaños.Name = "lblaños";
            this.lblaños.Size = new System.Drawing.Size(51, 18);
            this.lblaños.TabIndex = 10;
            this.lblaños.Text = "Periodo";
            // 
            // llbcapital
            // 
            this.llbcapital.AutoSize = true;
            this.llbcapital.ForeColor = System.Drawing.Color.DimGray;
            this.llbcapital.Location = new System.Drawing.Point(35, 305);
            this.llbcapital.Name = "llbcapital";
            this.llbcapital.Size = new System.Drawing.Size(83, 18);
            this.llbcapital.TabIndex = 30;
            this.llbcapital.Text = "Capitalizable";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 18);
            this.label2.TabIndex = 41;
            this.label2.Text = " ¿Qué desea hacer?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(67, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 42;
            this.label3.Text = "Respuesta";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtxaños);
            this.groupBox1.Controls.Add(this.txtinteres);
            this.groupBox1.Controls.Add(this.txtpresente);
            this.groupBox1.Controls.Add(this.cmbcapital);
            this.groupBox1.Controls.Add(this.txtfuturo);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblinteres);
            this.groupBox1.Controls.Add(this.lblfuturo);
            this.groupBox1.Controls.Add(this.llbpresente);
            this.groupBox1.Controls.Add(this.lblaños);
            this.groupBox1.Controls.Add(this.llbcapital);
            this.groupBox1.Location = new System.Drawing.Point(19, 113);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(460, 415);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculos";
            // 
            // txtxaños
            // 
            this.txtxaños.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtxaños.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtxaños.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.txtxaños.BorderRadius = 6;
            this.txtxaños.BorderSize = 2;
            this.txtxaños.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtxaños.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtxaños.Location = new System.Drawing.Point(134, 220);
            this.txtxaños.Margin = new System.Windows.Forms.Padding(4);
            this.txtxaños.Multiline = false;
            this.txtxaños.Name = "txtxaños";
            this.txtxaños.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtxaños.PasswordChar = false;
            this.txtxaños.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(164)))), ((int)(((byte)(163)))));
            this.txtxaños.PlaceholderText = "";
            this.txtxaños.Size = new System.Drawing.Size(116, 33);
            this.txtxaños.TabIndex = 61;
            this.txtxaños.Texts = "";
            this.txtxaños.UnderlinedStyle = false;
            // 
            // txtinteres
            // 
            this.txtinteres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtinteres.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtinteres.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.txtinteres.BorderRadius = 6;
            this.txtinteres.BorderSize = 2;
            this.txtinteres.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtinteres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtinteres.Location = new System.Drawing.Point(134, 143);
            this.txtinteres.Margin = new System.Windows.Forms.Padding(4);
            this.txtinteres.Multiline = false;
            this.txtinteres.Name = "txtinteres";
            this.txtinteres.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtinteres.PasswordChar = false;
            this.txtinteres.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(164)))), ((int)(((byte)(163)))));
            this.txtinteres.PlaceholderText = "";
            this.txtinteres.Size = new System.Drawing.Size(116, 33);
            this.txtinteres.TabIndex = 62;
            this.txtinteres.Texts = "";
            this.txtinteres.UnderlinedStyle = false;
            // 
            // txtpresente
            // 
            this.txtpresente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtpresente.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtpresente.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.txtpresente.BorderRadius = 6;
            this.txtpresente.BorderSize = 2;
            this.txtpresente.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtpresente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtpresente.Location = new System.Drawing.Point(134, 62);
            this.txtpresente.Margin = new System.Windows.Forms.Padding(4);
            this.txtpresente.Multiline = false;
            this.txtpresente.Name = "txtpresente";
            this.txtpresente.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtpresente.PasswordChar = false;
            this.txtpresente.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(164)))), ((int)(((byte)(163)))));
            this.txtpresente.PlaceholderText = "";
            this.txtpresente.Size = new System.Drawing.Size(116, 33);
            this.txtpresente.TabIndex = 63;
            this.txtpresente.Texts = "";
            this.txtpresente.UnderlinedStyle = false;
            // 
            // cmbcapital
            // 
            this.cmbcapital.BackColor = System.Drawing.Color.White;
            this.cmbcapital.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.cmbcapital.BorderSize = 1;
            this.cmbcapital.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbcapital.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbcapital.ForeColor = System.Drawing.Color.DimGray;
            this.cmbcapital.IconColor = System.Drawing.Color.Gray;
            this.cmbcapital.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbcapital.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbcapital.Location = new System.Drawing.Point(125, 293);
            this.cmbcapital.Name = "cmbcapital";
            this.cmbcapital.Padding = new System.Windows.Forms.Padding(1);
            this.cmbcapital.Size = new System.Drawing.Size(169, 30);
            this.cmbcapital.TabIndex = 64;
            this.cmbcapital.Texts = "";
            // 
            // txtfuturo
            // 
            this.txtfuturo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtfuturo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtfuturo.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.txtfuturo.BorderRadius = 6;
            this.txtfuturo.BorderSize = 2;
            this.txtfuturo.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtfuturo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtfuturo.Location = new System.Drawing.Point(134, 15);
            this.txtfuturo.Margin = new System.Windows.Forms.Padding(4);
            this.txtfuturo.Multiline = false;
            this.txtfuturo.Name = "txtfuturo";
            this.txtfuturo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtfuturo.PasswordChar = false;
            this.txtfuturo.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(164)))), ((int)(((byte)(163)))));
            this.txtfuturo.PlaceholderText = "";
            this.txtfuturo.Size = new System.Drawing.Size(116, 33);
            this.txtfuturo.TabIndex = 59;
            this.txtfuturo.Texts = "";
            this.txtfuturo.UnderlinedStyle = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(179)))), ((int)(((byte)(151)))));
            this.button1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(179)))), ((int)(((byte)(151)))));
            this.button1.BorderColor = System.Drawing.Color.White;
            this.button1.BorderRadius = 10;
            this.button1.BorderSize = 0;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(281, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 40);
            this.button1.TabIndex = 61;
            this.button1.Text = "Aceptar";
            this.button1.TextColor = System.Drawing.Color.White;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(273, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 18);
            this.label4.TabIndex = 50;
            this.label4.Text = "%";
            // 
            // ellipseControl1
            // 
            this.ellipseControl1.CornerRadius = 10;
            this.ellipseControl1.TargetControl = this;
            // 
            // cmbmostrasr
            // 
            this.cmbmostrasr.BackColor = System.Drawing.Color.White;
            this.cmbmostrasr.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.cmbmostrasr.BorderSize = 1;
            this.cmbmostrasr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbmostrasr.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbmostrasr.ForeColor = System.Drawing.Color.DimGray;
            this.cmbmostrasr.IconColor = System.Drawing.Color.Gray;
            this.cmbmostrasr.Items.AddRange(new object[] {
            "Futuro",
            "Presente",
            "Período"});
            this.cmbmostrasr.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbmostrasr.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbmostrasr.Location = new System.Drawing.Point(153, 56);
            this.cmbmostrasr.Name = "cmbmostrasr";
            this.cmbmostrasr.Padding = new System.Windows.Forms.Padding(1);
            this.cmbmostrasr.Size = new System.Drawing.Size(169, 30);
            this.cmbmostrasr.TabIndex = 58;
            this.cmbmostrasr.Texts = "";
            this.cmbmostrasr.OnSelectedIndexChanged += new System.EventHandler(this.cmbmostrasr_OnSelectedIndexChanged);
            // 
            // PbClose
            // 
            this.PbClose.BackColor = System.Drawing.Color.Transparent;
            this.PbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbClose.Image = ((System.Drawing.Image)(resources.GetObject("PbClose.Image")));
            this.PbClose.Location = new System.Drawing.Point(472, 12);
            this.PbClose.Name = "PbClose";
            this.PbClose.Size = new System.Drawing.Size(13, 13);
            this.PbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbClose.TabIndex = 59;
            this.PbClose.TabStop = false;
            this.PbClose.Click += new System.EventHandler(this.PbClose_Click);
            // 
            // FmrInteres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(497, 601);
            this.Controls.Add(this.PbClose);
            this.Controls.Add(this.cmbmostrasr);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FmrInteres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interés  Nominal";
            this.Load += new System.EventHandler(this.FmrInteres_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FmrInteres_MouseDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblinteres;
        private System.Windows.Forms.Label lblfuturo;
        private System.Windows.Forms.Label llbpresente;
        private System.Windows.Forms.Label lblaños;
        private System.Windows.Forms.Label llbcapital;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private Economy.BeatifulComponents.EllipseControl ellipseControl1;
        private System.Windows.Forms.Label label4;
        private Economy.BeatifulComponents.RJButton button1;
        public Economy.BeatifulComponents.RJComboBox cmbmostrasr;
        public Economy.RJTextBox txtfuturo;
        public Economy.RJTextBox txtxaños;
        public Economy.RJTextBox txtinteres;
        public Economy.RJTextBox txtpresente;
        public Economy.BeatifulComponents.RJComboBox cmbcapital;
        private System.Windows.Forms.PictureBox PbClose;
    }
}

