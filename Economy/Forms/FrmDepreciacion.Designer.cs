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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDepreciacion));
            this.labelDepreciation = new System.Windows.Forms.Label();
            this.lblInitialValue = new System.Windows.Forms.Label();
            this.nudInitialValue = new System.Windows.Forms.NumericUpDown();
            this.lblResidualValue = new System.Windows.Forms.Label();
            this.nudResidualValue = new System.Windows.Forms.NumericUpDown();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.btnCreate = new Economy.BeatifulComponents.RJButton();
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
            this.ellipseControl1 = new Economy.BeatifulComponents.EllipseControl();
            this.ellipseControl2 = new Economy.BeatifulComponents.EllipseControl();
            this.PbClose = new System.Windows.Forms.PictureBox();
            this.FadeIn = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudInitialValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudResidualValue)).BeginInit();
            this.gbData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCoeficiente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYears)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDepreciation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDepreciation
            // 
            this.labelDepreciation.AutoSize = true;
            this.labelDepreciation.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDepreciation.ForeColor = System.Drawing.Color.DimGray;
            this.labelDepreciation.Location = new System.Drawing.Point(512, 32);
            this.labelDepreciation.Name = "labelDepreciation";
            this.labelDepreciation.Size = new System.Drawing.Size(294, 35);
            this.labelDepreciation.TabIndex = 3;
            this.labelDepreciation.Text = "Tabla de depreciación";
            // 
            // lblInitialValue
            // 
            this.lblInitialValue.AutoSize = true;
            this.lblInitialValue.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInitialValue.ForeColor = System.Drawing.Color.DimGray;
            this.lblInitialValue.Location = new System.Drawing.Point(10, 40);
            this.lblInitialValue.Name = "lblInitialValue";
            this.lblInitialValue.Size = new System.Drawing.Size(71, 18);
            this.lblInitialValue.TabIndex = 6;
            this.lblInitialValue.Text = "Valor Inicial";
            // 
            // nudInitialValue
            // 
            this.nudInitialValue.DecimalPlaces = 2;
            this.nudInitialValue.Location = new System.Drawing.Point(170, 38);
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
            this.lblResidualValue.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResidualValue.ForeColor = System.Drawing.Color.DimGray;
            this.lblResidualValue.Location = new System.Drawing.Point(10, 94);
            this.lblResidualValue.Name = "lblResidualValue";
            this.lblResidualValue.Size = new System.Drawing.Size(145, 18);
            this.lblResidualValue.TabIndex = 8;
            this.lblResidualValue.Text = "Valor Residual (Opcional)";
            // 
            // nudResidualValue
            // 
            this.nudResidualValue.DecimalPlaces = 2;
            this.nudResidualValue.Location = new System.Drawing.Point(170, 90);
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
            // gbData
            // 
            this.gbData.Controls.Add(this.btnCreate);
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
            this.gbData.Location = new System.Drawing.Point(14, 17);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(367, 397);
            this.gbData.TabIndex = 14;
            this.gbData.TabStop = false;
            this.gbData.Text = "Información";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(179)))), ((int)(((byte)(151)))));
            this.btnCreate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(179)))), ((int)(((byte)(151)))));
            this.btnCreate.BorderColor = System.Drawing.Color.White;
            this.btnCreate.BorderRadius = 25;
            this.btnCreate.BorderSize = 0;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(94, 327);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(159, 49);
            this.btnCreate.TabIndex = 34;
            this.btnCreate.Text = "Agregar";
            this.btnCreate.TextColor = System.Drawing.Color.White;
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // nudCoeficiente
            // 
            this.nudCoeficiente.Location = new System.Drawing.Point(170, 268);
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
            this.lblCoeficiente.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCoeficiente.ForeColor = System.Drawing.Color.DimGray;
            this.lblCoeficiente.Location = new System.Drawing.Point(10, 270);
            this.lblCoeficiente.Name = "lblCoeficiente";
            this.lblCoeficiente.Size = new System.Drawing.Size(72, 18);
            this.lblCoeficiente.TabIndex = 16;
            this.lblCoeficiente.Text = "Coeficiente";
            this.lblCoeficiente.Visible = false;
            // 
            // cmbMethod
            // 
            this.cmbMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMethod.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbMethod.FormattingEnabled = true;
            this.cmbMethod.Items.AddRange(new object[] {
            "Linea Recta",
            "Suma de Digito Años",
            "Saldo Decreciente"});
            this.cmbMethod.Location = new System.Drawing.Point(170, 203);
            this.cmbMethod.Name = "cmbMethod";
            this.cmbMethod.Size = new System.Drawing.Size(191, 26);
            this.cmbMethod.TabIndex = 15;
            this.cmbMethod.SelectedIndexChanged += new System.EventHandler(this.cmbMethod_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(10, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Método de depreciación";
            // 
            // nudYears
            // 
            this.nudYears.Location = new System.Drawing.Point(170, 148);
            this.nudYears.Name = "nudYears";
            this.nudYears.Size = new System.Drawing.Size(191, 21);
            this.nudYears.TabIndex = 11;
            // 
            // lblYears
            // 
            this.lblYears.AutoSize = true;
            this.lblYears.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblYears.ForeColor = System.Drawing.Color.DimGray;
            this.lblYears.Location = new System.Drawing.Point(9, 150);
            this.lblYears.Name = "lblYears";
            this.lblYears.Size = new System.Drawing.Size(34, 18);
            this.lblYears.TabIndex = 10;
            this.lblYears.Text = "Años";
            // 
            // DgvDepreciation
            // 
            this.DgvDepreciation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvDepreciation.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvDepreciation.BackgroundColor = System.Drawing.Color.White;
            this.DgvDepreciation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvDepreciation.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DgvDepreciation.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(179)))), ((int)(((byte)(151)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(179)))), ((int)(((byte)(151)))));
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
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvDepreciation.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvDepreciation.EnableHeadersVisualStyles = false;
            this.DgvDepreciation.Location = new System.Drawing.Point(409, 68);
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
            this.DgvDepreciation.Size = new System.Drawing.Size(495, 337);
            this.DgvDepreciation.TabIndex = 3;
            // 
            // Años
            // 
            this.Años.HeaderText = "Años";
            this.Años.Name = "Años";
            this.Años.ReadOnly = true;
            this.Años.Width = 63;
            // 
            // Depreciación
            // 
            this.Depreciación.HeaderText = "Depreciación";
            this.Depreciación.Name = "Depreciación";
            this.Depreciación.ReadOnly = true;
            this.Depreciación.Width = 117;
            // 
            // DepreciaciónAcumulada
            // 
            this.DepreciaciónAcumulada.HeaderText = "Depreciación Acumulada";
            this.DepreciaciónAcumulada.Name = "DepreciaciónAcumulada";
            this.DepreciaciónAcumulada.ReadOnly = true;
            this.DepreciaciónAcumulada.Width = 193;
            // 
            // ValorEnLibro
            // 
            this.ValorEnLibro.HeaderText = "Valor En Libro";
            this.ValorEnLibro.Name = "ValorEnLibro";
            this.ValorEnLibro.ReadOnly = true;
            this.ValorEnLibro.Width = 125;
            // 
            // ellipseControl1
            // 
            this.ellipseControl1.CornerRadius = 8;
            this.ellipseControl1.TargetControl = this.DgvDepreciation;
            // 
            // ellipseControl2
            // 
            this.ellipseControl2.CornerRadius = 10;
            this.ellipseControl2.TargetControl = this;
            // 
            // PbClose
            // 
            this.PbClose.BackColor = System.Drawing.Color.Transparent;
            this.PbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbClose.Image = ((System.Drawing.Image)(resources.GetObject("PbClose.Image")));
            this.PbClose.Location = new System.Drawing.Point(933, 9);
            this.PbClose.Name = "PbClose";
            this.PbClose.Size = new System.Drawing.Size(13, 13);
            this.PbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbClose.TabIndex = 52;
            this.PbClose.TabStop = false;
            this.PbClose.Click += new System.EventHandler(this.PbClose_Click);
            // 
            // FadeIn
            // 
            this.FadeIn.Enabled = true;
            this.FadeIn.Interval = 35;
            this.FadeIn.Tick += new System.EventHandler(this.FadeIn_Tick);
            // 
            // FrmDepreciacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(957, 440);
            this.Controls.Add(this.PbClose);
            this.Controls.Add(this.DgvDepreciation);
            this.Controls.Add(this.gbData);
            this.Controls.Add(this.labelDepreciation);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDepreciacion";
            this.Text = "Depreciación";
            this.Load += new System.EventHandler(this.Depreciacion_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmDepreciacion_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.nudInitialValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudResidualValue)).EndInit();
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCoeficiente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYears)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDepreciation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelDepreciation;
        private System.Windows.Forms.Label lblInitialValue;
        private System.Windows.Forms.NumericUpDown nudInitialValue;
        private System.Windows.Forms.Label lblResidualValue;
        private System.Windows.Forms.NumericUpDown nudResidualValue;
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
        private Economy.BeatifulComponents.EllipseControl ellipseControl1;
        private Economy.BeatifulComponents.RJButton btnCreate;
        private Economy.BeatifulComponents.EllipseControl ellipseControl2;
        private System.Windows.Forms.PictureBox PbClose;
        private System.Windows.Forms.Timer FadeIn;
    }
}