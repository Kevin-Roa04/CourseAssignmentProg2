namespace Economy.Forms
{
    partial class ConverterTasa
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
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Result3 = new System.Windows.Forms.Label();
            this.Result2 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.cmbTiempo = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.Result1 = new System.Windows.Forms.Label();
            this.numconvert = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numconvert)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.label1);
            this.groupBox11.Controls.Add(this.button1);
            this.groupBox11.Controls.Add(this.Result3);
            this.groupBox11.Controls.Add(this.Result2);
            this.groupBox11.Controls.Add(this.button12);
            this.groupBox11.Controls.Add(this.button10);
            this.groupBox11.Controls.Add(this.cmbTiempo);
            this.groupBox11.Controls.Add(this.label12);
            this.groupBox11.Controls.Add(this.button11);
            this.groupBox11.Controls.Add(this.result);
            this.groupBox11.Controls.Add(this.Result1);
            this.groupBox11.Controls.Add(this.numconvert);
            this.groupBox11.Controls.Add(this.label7);
            this.groupBox11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.groupBox11.Location = new System.Drawing.Point(23, 12);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(787, 347);
            this.groupBox11.TabIndex = 9;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Convertir tasas de interes ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(712, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 22);
            this.label1.TabIndex = 32;
            this.label1.Text = "Ayuda?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(563, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 31;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Result3
            // 
            this.Result3.AutoSize = true;
            this.Result3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Result3.Location = new System.Drawing.Point(10, 309);
            this.Result3.Name = "Result3";
            this.Result3.Size = new System.Drawing.Size(102, 22);
            this.Result3.TabIndex = 30;
            this.Result3.Text = "Tasa final: ";
            // 
            // Result2
            // 
            this.Result2.AutoSize = true;
            this.Result2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Result2.Location = new System.Drawing.Point(6, 216);
            this.Result2.Name = "Result2";
            this.Result2.Size = new System.Drawing.Size(102, 22);
            this.Result2.TabIndex = 29;
            this.Result2.Text = "Tasa final: ";
            // 
            // button12
            // 
            this.button12.ForeColor = System.Drawing.Color.Black;
            this.button12.Location = new System.Drawing.Point(0, 250);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(385, 26);
            this.button12.TabIndex = 28;
            this.button12.Text = "Nominal(J) a Efectiva(I)";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click_1);
            // 
            // button10
            // 
            this.button10.ForeColor = System.Drawing.Color.Black;
            this.button10.Location = new System.Drawing.Point(6, 166);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(385, 26);
            this.button10.TabIndex = 27;
            this.button10.Text = "Ip a Nominal(J)";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click_1);
            // 
            // cmbTiempo
            // 
            this.cmbTiempo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTiempo.FormattingEnabled = true;
            this.cmbTiempo.Location = new System.Drawing.Point(483, 68);
            this.cmbTiempo.Name = "cmbTiempo";
            this.cmbTiempo.Size = new System.Drawing.Size(290, 30);
            this.cmbTiempo.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(486, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(287, 22);
            this.label12.TabIndex = 25;
            this.label12.Text = "Seleccione el tiempo del periodo: ";
            // 
            // button11
            // 
            this.button11.ForeColor = System.Drawing.Color.Black;
            this.button11.Location = new System.Drawing.Point(10, 72);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(385, 26);
            this.button11.TabIndex = 22;
            this.button11.Text = "Nominal(J) a Ip";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click_1);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.result.Location = new System.Drawing.Point(731, 21);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 22);
            this.result.TabIndex = 21;
            // 
            // Result1
            // 
            this.Result1.AutoSize = true;
            this.Result1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Result1.Location = new System.Drawing.Point(10, 123);
            this.Result1.Name = "Result1";
            this.Result1.Size = new System.Drawing.Size(102, 22);
            this.Result1.TabIndex = 20;
            this.Result1.Text = "Tasa final: ";
            // 
            // numconvert
            // 
            this.numconvert.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numconvert.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numconvert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numconvert.DecimalPlaces = 2;
            this.numconvert.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numconvert.Location = new System.Drawing.Point(610, 169);
            this.numconvert.Name = "numconvert";
            this.numconvert.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numconvert.Size = new System.Drawing.Size(163, 26);
            this.numconvert.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(487, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tasa inicial: ";
            // 
            // ConverterTasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(821, 371);
            this.Controls.Add(this.groupBox11);
            this.Name = "ConverterTasa";
            this.Text = "ConverterTasa";
            this.Load += new System.EventHandler(this.ConverterTasa_Load);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numconvert)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label Result3;
        private System.Windows.Forms.Label Result2;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.ComboBox cmbTiempo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label Result1;
        private System.Windows.Forms.NumericUpDown numconvert;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}