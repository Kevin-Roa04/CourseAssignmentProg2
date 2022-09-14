namespace Economy.Forms
{
    partial class CalculateIntCompuesto
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.R7 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.R8 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.R6 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.R5 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.numpe = new System.Windows.Forms.NumericUpDown();
            this.numfut = new System.Windows.Forms.NumericUpDown();
            this.numpre = new System.Windows.Forms.NumericUpDown();
            this.numint = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numpe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numfut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numpre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numint)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox7);
            this.groupBox2.Controls.Add(this.groupBox8);
            this.groupBox2.Controls.Add(this.groupBox9);
            this.groupBox2.Controls.Add(this.groupBox10);
            this.groupBox2.Controls.Add(this.numpe);
            this.groupBox2.Controls.Add(this.numfut);
            this.groupBox2.Controls.Add(this.numpre);
            this.groupBox2.Controls.Add(this.numint);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(593, 507);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Interes Compuesto";
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox7.Controls.Add(this.R7);
            this.groupBox7.Controls.Add(this.button6);
            this.groupBox7.Location = new System.Drawing.Point(292, 269);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(290, 114);
            this.groupBox7.TabIndex = 16;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Calcular interes";
            // 
            // R7
            // 
            this.R7.AutoSize = true;
            this.R7.Location = new System.Drawing.Point(16, 79);
            this.R7.Name = "R7";
            this.R7.Size = new System.Drawing.Size(115, 22);
            this.R7.TabIndex = 3;
            this.R7.Text = "Respuesta = ";
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Location = new System.Drawing.Point(173, 29);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(111, 33);
            this.button6.TabIndex = 2;
            this.button6.Text = "Calcular";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.R8);
            this.groupBox8.Controls.Add(this.button7);
            this.groupBox8.Location = new System.Drawing.Point(292, 389);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(290, 114);
            this.groupBox8.TabIndex = 14;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Calcular Periodo";
            // 
            // R8
            // 
            this.R8.AutoSize = true;
            this.R8.Location = new System.Drawing.Point(16, 87);
            this.R8.Name = "R8";
            this.R8.Size = new System.Drawing.Size(215, 22);
            this.R8.TabIndex = 4;
            this.R8.Text = "Respuesta redondeada = ";
            // 
            // button7
            // 
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button7.Location = new System.Drawing.Point(173, 29);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(111, 33);
            this.button7.TabIndex = 3;
            this.button7.Text = "Calcular";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // groupBox9
            // 
            this.groupBox9.BackColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox9.Controls.Add(this.R6);
            this.groupBox9.Controls.Add(this.button8);
            this.groupBox9.Location = new System.Drawing.Point(292, 149);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(290, 114);
            this.groupBox9.TabIndex = 17;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Calcular Futuro";
            // 
            // R6
            // 
            this.R6.AutoSize = true;
            this.R6.Location = new System.Drawing.Point(16, 78);
            this.R6.Name = "R6";
            this.R6.Size = new System.Drawing.Size(115, 22);
            this.R6.TabIndex = 2;
            this.R6.Text = "Respuesta = ";
            // 
            // button8
            // 
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button8.Location = new System.Drawing.Point(173, 29);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(111, 33);
            this.button8.TabIndex = 1;
            this.button8.Text = "Calcular";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // groupBox10
            // 
            this.groupBox10.BackColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox10.Controls.Add(this.R5);
            this.groupBox10.Controls.Add(this.button9);
            this.groupBox10.Location = new System.Drawing.Point(292, 29);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(290, 114);
            this.groupBox10.TabIndex = 18;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Calcular Presente";
            // 
            // R5
            // 
            this.R5.AutoSize = true;
            this.R5.Location = new System.Drawing.Point(16, 65);
            this.R5.Name = "R5";
            this.R5.Size = new System.Drawing.Size(115, 22);
            this.R5.TabIndex = 1;
            this.R5.Text = "Respuesta = ";
            // 
            // button9
            // 
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button9.Location = new System.Drawing.Point(173, 29);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(111, 33);
            this.button9.TabIndex = 0;
            this.button9.Text = "Calcular";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // numpe
            // 
            this.numpe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numpe.Location = new System.Drawing.Point(116, 376);
            this.numpe.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numpe.Name = "numpe";
            this.numpe.Size = new System.Drawing.Size(150, 30);
            this.numpe.TabIndex = 19;
            // 
            // numfut
            // 
            this.numfut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numfut.DecimalPlaces = 2;
            this.numfut.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numfut.Location = new System.Drawing.Point(116, 136);
            this.numfut.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numfut.Name = "numfut";
            this.numfut.Size = new System.Drawing.Size(150, 30);
            this.numfut.TabIndex = 15;
            // 
            // numpre
            // 
            this.numpre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numpre.DecimalPlaces = 2;
            this.numpre.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numpre.Location = new System.Drawing.Point(116, 39);
            this.numpre.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numpre.Name = "numpre";
            this.numpre.Size = new System.Drawing.Size(150, 30);
            this.numpre.TabIndex = 13;
            // 
            // numint
            // 
            this.numint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numint.DecimalPlaces = 2;
            this.numint.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numint.Location = new System.Drawing.Point(116, 256);
            this.numint.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numint.Name = "numint";
            this.numint.Size = new System.Drawing.Size(150, 30);
            this.numint.TabIndex = 12;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(11, 378);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 22);
            this.label16.TabIndex = 11;
            this.label16.Text = "Periodos";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(29, 258);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 22);
            this.label17.TabIndex = 10;
            this.label17.Text = "Interes";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(29, 138);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 22);
            this.label18.TabIndex = 9;
            this.label18.Text = "Futuro";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(14, 39);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(80, 22);
            this.label19.TabIndex = 8;
            this.label19.Text = "Presente";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(255, 525);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(625, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ayuda?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CalculateIntCompuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(701, 566);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Name = "CalculateIntCompuesto";
            this.Text = "Interes compuesto";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numpe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numfut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numpre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label R7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label R8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label R6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label R5;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.NumericUpDown numpe;
        private System.Windows.Forms.NumericUpDown numfut;
        private System.Windows.Forms.NumericUpDown numpre;
        private System.Windows.Forms.NumericUpDown numint;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}