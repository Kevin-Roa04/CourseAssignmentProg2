namespace Proto1._0
{
    partial class FrmDepreciacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelDepreciation = new System.Windows.Forms.Label();
            this.lblInitialValue = new System.Windows.Forms.Label();
            this.nudInitialValue = new System.Windows.Forms.NumericUpDown();
            this.lblResidualValue = new System.Windows.Forms.Label();
            this.nudResidualValue = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.nudCoeficiente = new System.Windows.Forms.NumericUpDown();
            this.lblCoeficiente = new System.Windows.Forms.Label();
            this.cmbMethod = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nudYears = new System.Windows.Forms.NumericUpDown();
            this.lblYears = new System.Windows.Forms.Label();
            this.DgvDepreciation = new System.Windows.Forms.DataGridView();
            this.Años = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Depreciación = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepreciaciónAcumulada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorEnLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudInitialValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudResidualValue)).BeginInit();
            this.gbData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCoeficiente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYears)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDepreciation)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDepreciation
            // 
            this.labelDepreciation.AutoSize = true;
            this.labelDepreciation.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.labelDepreciation.Location = new System.Drawing.Point(512, 27);
            this.labelDepreciation.Name = "labelDepreciation";
            this.labelDepreciation.Size = new System.Drawing.Size(265, 31);
            this.labelDepreciation.TabIndex = 3;
            this.labelDepreciation.Text = "Tabla de depreciación";
            // 
            // lblInitialValue
            // 
            this.lblInitialValue.AutoSize = true;
            this.lblInitialValue.Location = new System.Drawing.Point(6, 31);
            this.lblInitialValue.Name = "lblInitialValue";
            this.lblInitialValue.Size = new System.Drawing.Size(66, 15);
            this.lblInitialValue.TabIndex = 6;
            this.lblInitialValue.Text = "Valor Inicial";
            // 
            // nudInitialValue
            // 
            this.nudInitialValue.DecimalPlaces = 2;
            this.nudInitialValue.Location = new System.Drawing.Point(149, 29);
            this.nudInitialValue.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudInitialValue.Name = "nudInitialValue";
            this.nudInitialValue.Size = new System.Drawing.Size(191, 21);
            this.nudInitialValue.TabIndex = 7;
            // 
            // lblResidualValue
            // 
            this.lblResidualValue.AutoSize = true;
            this.lblResidualValue.Location = new System.Drawing.Point(6, 60);
            this.lblResidualValue.Name = "lblResidualValue";
            this.lblResidualValue.Size = new System.Drawing.Size(132, 15);
            this.lblResidualValue.TabIndex = 8;
            this.lblResidualValue.Text = "Valor Residual (Opcional)";
            // 
            // nudResidualValue
            // 
            this.nudResidualValue.DecimalPlaces = 2;
            this.nudResidualValue.Location = new System.Drawing.Point(149, 56);
            this.nudResidualValue.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudResidualValue.Name = "nudResidualValue";
            this.nudResidualValue.Size = new System.Drawing.Size(191, 21);
            this.nudResidualValue.TabIndex = 9;
            this.nudResidualValue.ValueChanged += new System.EventHandler(this.nudResidualValue_ValueChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(74, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 25);
            this.button2.TabIndex = 12;
            this.button2.Text = "Calcular";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.nudCoeficiente);
            this.gbData.Controls.Add(this.lblCoeficiente);
            this.gbData.Controls.Add(this.button2);
            this.gbData.Controls.Add(this.cmbMethod);
            this.gbData.Controls.Add(this.label6);
            this.gbData.Controls.Add(this.nudYears);
            this.gbData.Controls.Add(this.lblYears);
            this.gbData.Controls.Add(this.lblInitialValue);
            this.gbData.Controls.Add(this.nudInitialValue);
            this.gbData.Controls.Add(this.lblResidualValue);
            this.gbData.Controls.Add(this.nudResidualValue);
            this.gbData.Location = new System.Drawing.Point(14, 12);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(358, 397);
            this.gbData.TabIndex = 14;
            this.gbData.TabStop = false;
            this.gbData.Text = "Información";
            // 
            // nudCoeficiente
            // 
            this.nudCoeficiente.Location = new System.Drawing.Point(149, 142);
            this.nudCoeficiente.Name = "nudCoeficiente";
            this.nudCoeficiente.Size = new System.Drawing.Size(191, 21);
            this.nudCoeficiente.TabIndex = 17;
            this.nudCoeficiente.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudCoeficiente.Visible = false;
            // 
            // lblCoeficiente
            // 
            this.lblCoeficiente.AutoSize = true;
            this.lblCoeficiente.Location = new System.Drawing.Point(6, 144);
            this.lblCoeficiente.Name = "lblCoeficiente";
            this.lblCoeficiente.Size = new System.Drawing.Size(59, 15);
            this.lblCoeficiente.TabIndex = 16;
            this.lblCoeficiente.Text = "Coeficiente";
            this.lblCoeficiente.Visible = false;
            // 
            // cmbMethod
            // 
            this.cmbMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMethod.FormattingEnabled = true;
            this.cmbMethod.Location = new System.Drawing.Point(149, 113);
            this.cmbMethod.Name = "cmbMethod";
            this.cmbMethod.Size = new System.Drawing.Size(191, 23);
            this.cmbMethod.TabIndex = 15;
            this.cmbMethod.SelectedIndexChanged += new System.EventHandler(this.cmbMethod_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Método de depreciación";
            // 
            // nudYears
            // 
            this.nudYears.Location = new System.Drawing.Point(149, 86);
            this.nudYears.Name = "nudYears";
            this.nudYears.Size = new System.Drawing.Size(191, 21);
            this.nudYears.TabIndex = 11;
            // 
            // lblYears
            // 
            this.lblYears.AutoSize = true;
            this.lblYears.Location = new System.Drawing.Point(5, 88);
            this.lblYears.Name = "lblYears";
            this.lblYears.Size = new System.Drawing.Size(31, 15);
            this.lblYears.TabIndex = 10;
            this.lblYears.Text = "Años";
            // 
            // DgvDepreciation
            // 
            this.DgvDepreciation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvDepreciation.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvDepreciation.BackgroundColor = System.Drawing.Color.White;
            this.DgvDepreciation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvDepreciation.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvDepreciation.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDepreciation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvDepreciation.ColumnHeadersHeight = 30;
            this.DgvDepreciation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvDepreciation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Años,
            this.Depreciación,
            this.DepreciaciónAcumulada,
            this.ValorEnLibro});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvDepreciation.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvDepreciation.EnableHeadersVisualStyles = false;
            this.DgvDepreciation.Location = new System.Drawing.Point(392, 61);
            this.DgvDepreciation.Name = "DgvDepreciation";
            this.DgvDepreciation.ReadOnly = true;
            this.DgvDepreciation.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MintCream;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDepreciation.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvDepreciation.RowHeadersVisible = false;
            this.DgvDepreciation.RowTemplate.Height = 25;
            this.DgvDepreciation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvDepreciation.Size = new System.Drawing.Size(553, 337);
            this.DgvDepreciation.TabIndex = 3;
            // 
            // Años
            // 
            this.Años.HeaderText = "Años";
            this.Años.Name = "Años";
            this.Años.ReadOnly = true;
            this.Años.Width = 68;
            // 
            // Depreciación
            // 
            this.Depreciación.HeaderText = "Depreciación";
            this.Depreciación.Name = "Depreciación";
            this.Depreciación.ReadOnly = true;
            this.Depreciación.Width = 133;
            // 
            // DepreciaciónAcumulada
            // 
            this.DepreciaciónAcumulada.HeaderText = "DepreciaciónAcumulada";
            this.DepreciaciónAcumulada.Name = "DepreciaciónAcumulada";
            this.DepreciaciónAcumulada.ReadOnly = true;
            this.DepreciaciónAcumulada.Width = 218;
            // 
            // ValorEnLibro
            // 
            this.ValorEnLibro.HeaderText = "ValorEnLibro";
            this.ValorEnLibro.Name = "ValorEnLibro";
            this.ValorEnLibro.ReadOnly = true;
            this.ValorEnLibro.Width = 123;
            // 
            // FrmDepreciacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(957, 421);
            this.Controls.Add(this.DgvDepreciation);
            this.Controls.Add(this.gbData);
            this.Controls.Add(this.labelDepreciation);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Name = "FrmDepreciacion";
            this.Text = "Depreciación";
            this.Load += new System.EventHandler(this.Depreciacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudInitialValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudResidualValue)).EndInit();
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCoeficiente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYears)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDepreciation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelDepreciation;
        private System.Windows.Forms.Label lblInitialValue;
        private System.Windows.Forms.NumericUpDown nudInitialValue;
        private System.Windows.Forms.Label lblResidualValue;
        private System.Windows.Forms.NumericUpDown nudResidualValue;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.ComboBox cmbMethod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudYears;
        private System.Windows.Forms.Label lblYears;
        private System.Windows.Forms.DataGridView DgvDepreciation;
        private System.Windows.Forms.NumericUpDown nudCoeficiente;
        private System.Windows.Forms.Label lblCoeficiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Años;
        private System.Windows.Forms.DataGridViewTextBoxColumn Depreciación;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepreciaciónAcumulada;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorEnLibro;
    }
}