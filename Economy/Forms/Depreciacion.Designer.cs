namespace Proto1._0
{
    partial class Depreciacion
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
            this.Years = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Depreciation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Depreciation_Acum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book_Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.labelDepreciation.Location = new System.Drawing.Point(550, 43);
            this.labelDepreciation.Name = "labelDepreciation";
            this.labelDepreciation.Size = new System.Drawing.Size(294, 31);
            this.labelDepreciation.TabIndex = 3;
            this.labelDepreciation.Text = "Tabla de la depreciacion";
            // 
            // lblInitialValue
            // 
            this.lblInitialValue.AutoSize = true;
            this.lblInitialValue.Location = new System.Drawing.Point(6, 31);
            this.lblInitialValue.Name = "lblInitialValue";
            this.lblInitialValue.Size = new System.Drawing.Size(64, 15);
            this.lblInitialValue.TabIndex = 6;
            this.lblInitialValue.Text = "Initial Value";
            // 
            // nudInitialValue
            // 
            this.nudInitialValue.DecimalPlaces = 2;
            this.nudInitialValue.Location = new System.Drawing.Point(268, 29);
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
            this.lblResidualValue.Size = new System.Drawing.Size(130, 15);
            this.lblResidualValue.TabIndex = 8;
            this.lblResidualValue.Text = "Residual Value (Optional)";
            // 
            // nudResidualValue
            // 
            this.nudResidualValue.DecimalPlaces = 2;
            this.nudResidualValue.Location = new System.Drawing.Point(268, 56);
            this.nudResidualValue.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudResidualValue.Name = "nudResidualValue";
            this.nudResidualValue.Size = new System.Drawing.Size(191, 21);
            this.nudResidualValue.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(112, 277);
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
            this.gbData.Size = new System.Drawing.Size(474, 180);
            this.gbData.TabIndex = 14;
            this.gbData.TabStop = false;
            this.gbData.Text = "Data";
            // 
            // nudCoeficiente
            // 
            this.nudCoeficiente.Location = new System.Drawing.Point(268, 142);
            this.nudCoeficiente.Name = "nudCoeficiente";
            this.nudCoeficiente.Size = new System.Drawing.Size(191, 21);
            this.nudCoeficiente.TabIndex = 17;
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
            this.cmbMethod.Location = new System.Drawing.Point(268, 113);
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
            this.label6.Size = new System.Drawing.Size(80, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Type of Method";
            // 
            // nudYears
            // 
            this.nudYears.Location = new System.Drawing.Point(268, 86);
            this.nudYears.Name = "nudYears";
            this.nudYears.Size = new System.Drawing.Size(191, 21);
            this.nudYears.TabIndex = 11;
            // 
            // lblYears
            // 
            this.lblYears.AutoSize = true;
            this.lblYears.Location = new System.Drawing.Point(5, 88);
            this.lblYears.Name = "lblYears";
            this.lblYears.Size = new System.Drawing.Size(33, 15);
            this.lblYears.TabIndex = 10;
            this.lblYears.Text = "Years";
            // 
            // DgvDepreciation
            // 
            this.DgvDepreciation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDepreciation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Years,
            this.Depreciation,
            this.Depreciation_Acum,
            this.Book_Value});
            this.DgvDepreciation.Location = new System.Drawing.Point(494, 92);
            this.DgvDepreciation.Name = "DgvDepreciation";
            this.DgvDepreciation.RowHeadersVisible = false;
            this.DgvDepreciation.RowTemplate.Height = 25;
            this.DgvDepreciation.Size = new System.Drawing.Size(402, 317);
            this.DgvDepreciation.TabIndex = 15;
            // 
            // Years
            // 
            this.Years.HeaderText = "Years";
            this.Years.Name = "Years";
            // 
            // Depreciation
            // 
            this.Depreciation.HeaderText = "Depreciation";
            this.Depreciation.Name = "Depreciation";
            // 
            // Depreciation_Acum
            // 
            this.Depreciation_Acum.HeaderText = "Acumulated_Depreciation";
            this.Depreciation_Acum.Name = "Depreciation_Acum";
            // 
            // Book_Value
            // 
            this.Book_Value.HeaderText = "Book_Value";
            this.Book_Value.Name = "Book_Value";
            // 
            // Depreciacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(910, 421);
            this.Controls.Add(this.DgvDepreciation);
            this.Controls.Add(this.gbData);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelDepreciation);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Name = "Depreciacion";
            this.Text = "Depreciacion";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Years;
        private System.Windows.Forms.DataGridViewTextBoxColumn Depreciation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Depreciation_Acum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_Value;
    }
}