namespace Proto1._0
{
    partial class Inicio
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
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 119);
            this.button1.TabIndex = 0;
            this.button1.Text = "Intereses";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "Intereses: \t\t",
            "♠ Interes simple\t",
            "- Calcular presente",
            "- Calcular futuro",
            "- Calcular interes",
            "- Calcular periodos",
            "♠Interes Compuesto",
            "- Calcular presente",
            "- Calcular futuro",
            "- Calcular interes",
            "- Calcular periodos ",
            "♠ Convertir tasas de interes",
            "- Nominal a efectiva periodica",
            "- Efectiva periodica a nominal",
            "- Nominal a efectiva "});
            this.listBox1.Location = new System.Drawing.Point(12, 205);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(246, 304);
            this.listBox1.TabIndex = 4;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(269, 521);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
    }
}