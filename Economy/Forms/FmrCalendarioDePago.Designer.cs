
namespace Economy.Forms
{
    partial class FmrCalendarioDePago
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
            this.cmelegir = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtknversion = new System.Windows.Forms.TextBox();
            this.txtplazo = new System.Windows.Forms.TextBox();
            this.txtinters = new System.Windows.Forms.TextBox();
            this.datacalendario = new System.Windows.Forms.DataGridView();
            this.colaños = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coluabono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluinteres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columcuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colsaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpocaculos = new System.Windows.Forms.GroupBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datacalendario)).BeginInit();
            this.grpocaculos.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmelegir
            // 
            this.cmelegir.FormattingEnabled = true;
            this.cmelegir.Items.AddRange(new object[] {
            "Metodo de cuota nivelada",
            "Metodo de cuota proporcional"});
            this.cmelegir.Location = new System.Drawing.Point(266, 45);
            this.cmelegir.Name = "cmelegir";
            this.cmelegir.Size = new System.Drawing.Size(199, 23);
            this.cmelegir.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Que desea hacer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Interes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Plazo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Inversion";
            // 
            // txtknversion
            // 
            this.txtknversion.Location = new System.Drawing.Point(146, 32);
            this.txtknversion.Name = "txtknversion";
            this.txtknversion.Size = new System.Drawing.Size(126, 23);
            this.txtknversion.TabIndex = 5;
            // 
            // txtplazo
            // 
            this.txtplazo.Location = new System.Drawing.Point(146, 123);
            this.txtplazo.Name = "txtplazo";
            this.txtplazo.Size = new System.Drawing.Size(126, 23);
            this.txtplazo.TabIndex = 7;
            // 
            // txtinters
            // 
            this.txtinters.Location = new System.Drawing.Point(146, 75);
            this.txtinters.Name = "txtinters";
            this.txtinters.Size = new System.Drawing.Size(126, 23);
            this.txtinters.TabIndex = 8;
            // 
            // datacalendario
            // 
            this.datacalendario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datacalendario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colaños,
            this.coluabono,
            this.Coluinteres,
            this.columcuota,
            this.Colsaldo});
            this.datacalendario.Location = new System.Drawing.Point(327, 84);
            this.datacalendario.Name = "datacalendario";
            this.datacalendario.RowTemplate.Height = 25;
            this.datacalendario.Size = new System.Drawing.Size(520, 229);
            this.datacalendario.TabIndex = 9;
            // 
            // colaños
            // 
            this.colaños.HeaderText = "Años";
            this.colaños.Name = "colaños";
            // 
            // coluabono
            // 
            this.coluabono.HeaderText = "Abono";
            this.coluabono.Name = "coluabono";
            // 
            // Coluinteres
            // 
            this.Coluinteres.HeaderText = "Intereses";
            this.Coluinteres.Name = "Coluinteres";
            // 
            // columcuota
            // 
            this.columcuota.HeaderText = "Cuota";
            this.columcuota.Name = "columcuota";
            // 
            // Colsaldo
            // 
            this.Colsaldo.HeaderText = "Saldo Insoluto";
            this.Colsaldo.Name = "Colsaldo";
            // 
            // grpocaculos
            // 
            this.grpocaculos.Controls.Add(this.label4);
            this.grpocaculos.Controls.Add(this.label3);
            this.grpocaculos.Controls.Add(this.txtinters);
            this.grpocaculos.Controls.Add(this.label2);
            this.grpocaculos.Controls.Add(this.txtplazo);
            this.grpocaculos.Controls.Add(this.txtknversion);
            this.grpocaculos.Location = new System.Drawing.Point(12, 108);
            this.grpocaculos.Name = "grpocaculos";
            this.grpocaculos.Size = new System.Drawing.Size(308, 177);
            this.grpocaculos.TabIndex = 10;
            this.grpocaculos.TabStop = false;
            this.grpocaculos.Text = "Propiedades del proyecto";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(351, 358);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // FmrCalendarioDePago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 450);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.grpocaculos);
            this.Controls.Add(this.datacalendario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmelegir);
            this.Name = "FmrCalendarioDePago";
            this.Text = "FmrCalendarioDePago";
            ((System.ComponentModel.ISupportInitialize)(this.datacalendario)).EndInit();
            this.grpocaculos.ResumeLayout(false);
            this.grpocaculos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmelegir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtknversion;
        private System.Windows.Forms.TextBox txtplazo;
        private System.Windows.Forms.TextBox txtinters;
        private System.Windows.Forms.DataGridView datacalendario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colaños;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluabono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluinteres;
        private System.Windows.Forms.DataGridViewTextBoxColumn columcuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colsaldo;
        private System.Windows.Forms.GroupBox grpocaculos;
        private System.Windows.Forms.Button btnAceptar;
    }
}