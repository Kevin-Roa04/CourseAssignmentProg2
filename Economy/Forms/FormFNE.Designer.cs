
namespace Economy.Forms
{
    partial class FormFNE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFNE));
            this.txtYears = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.VisualizarConclusion = new System.Windows.Forms.Label();
            this.rjButton5 = new Economy.BeatifulComponents.RJButton();
            this.rjButton4 = new Economy.BeatifulComponents.RJButton();
            this.rjButton3 = new Economy.BeatifulComponents.RJButton();
            this.rjButton2 = new Economy.BeatifulComponents.RJButton();
            this.rjButton1 = new Economy.BeatifulComponents.RJButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTMAR = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvFNE = new System.Windows.Forms.DataGridView();
            this.rbSF = new System.Windows.Forms.RadioButton();
            this.rbCF = new System.Windows.Forms.RadioButton();
            this.PbClose = new System.Windows.Forms.PictureBox();
            this.ellipseControl1 = new Economy.BeatifulComponents.EllipseControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtYears)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTMAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFNE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // txtYears
            // 
            this.txtYears.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtYears.Location = new System.Drawing.Point(139, 45);
            this.txtYears.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtYears.Name = "txtYears";
            this.txtYears.Size = new System.Drawing.Size(82, 21);
            this.txtYears.TabIndex = 0;
            this.txtYears.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtYears.ValueChanged += new System.EventHandler(this.txtYears_ValueChanged);
            this.txtYears.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtYears_KeyUp);
            this.txtYears.Validating += new System.ComponentModel.CancelEventHandler(this.txtYears_Validating);
            this.txtYears.Validated += new System.EventHandler(this.txtYears_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(82, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Años";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.VisualizarConclusion);
            this.groupBox1.Controls.Add(this.rjButton5);
            this.groupBox1.Controls.Add(this.rjButton4);
            this.groupBox1.Controls.Add(this.rjButton3);
            this.groupBox1.Controls.Add(this.rjButton2);
            this.groupBox1.Controls.Add(this.rjButton1);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTMAR);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtYears);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 444);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuración del Proyecto";
            // 
            // VisualizarConclusion
            // 
            this.VisualizarConclusion.AutoSize = true;
            this.VisualizarConclusion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VisualizarConclusion.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.VisualizarConclusion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(179)))), ((int)(((byte)(151)))));
            this.VisualizarConclusion.Location = new System.Drawing.Point(6, 414);
            this.VisualizarConclusion.Name = "VisualizarConclusion";
            this.VisualizarConclusion.Size = new System.Drawing.Size(122, 18);
            this.VisualizarConclusion.TabIndex = 18;
            this.VisualizarConclusion.Text = "Visualizar Conclusión";
            this.VisualizarConclusion.Visible = false;
            this.VisualizarConclusion.Click += new System.EventHandler(this.VisualizarConclusion_Click);
            // 
            // rjButton5
            // 
            this.rjButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(102)))));
            this.rjButton5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(102)))));
            this.rjButton5.BorderColor = System.Drawing.Color.White;
            this.rjButton5.BorderRadius = 25;
            this.rjButton5.BorderSize = 1;
            this.rjButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjButton5.FlatAppearance.BorderSize = 0;
            this.rjButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton5.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rjButton5.ForeColor = System.Drawing.Color.White;
            this.rjButton5.Location = new System.Drawing.Point(21, 337);
            this.rjButton5.Name = "rjButton5";
            this.rjButton5.Size = new System.Drawing.Size(247, 45);
            this.rjButton5.TabIndex = 17;
            this.rjButton5.Text = "Calcular FNE";
            this.rjButton5.TextColor = System.Drawing.Color.White;
            this.rjButton5.UseVisualStyleBackColor = false;
            this.rjButton5.Click += new System.EventHandler(this.rjButton5_Click);
            // 
            // rjButton4
            // 
            this.rjButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(146)))), ((int)(((byte)(219)))));
            this.rjButton4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(146)))), ((int)(((byte)(219)))));
            this.rjButton4.BorderColor = System.Drawing.Color.White;
            this.rjButton4.BorderRadius = 25;
            this.rjButton4.BorderSize = 1;
            this.rjButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjButton4.FlatAppearance.BorderSize = 0;
            this.rjButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton4.Font = new System.Drawing.Font("Trebuchet MS", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rjButton4.ForeColor = System.Drawing.Color.White;
            this.rjButton4.Location = new System.Drawing.Point(66, 282);
            this.rjButton4.Name = "rjButton4";
            this.rjButton4.Size = new System.Drawing.Size(163, 45);
            this.rjButton4.TabIndex = 16;
            this.rjButton4.Text = "Agregar Préstamo";
            this.rjButton4.TextColor = System.Drawing.Color.White;
            this.rjButton4.UseVisualStyleBackColor = false;
            this.rjButton4.Click += new System.EventHandler(this.rjButton4_Click);
            // 
            // rjButton3
            // 
            this.rjButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(146)))), ((int)(((byte)(219)))));
            this.rjButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(146)))), ((int)(((byte)(219)))));
            this.rjButton3.BorderColor = System.Drawing.Color.White;
            this.rjButton3.BorderRadius = 25;
            this.rjButton3.BorderSize = 1;
            this.rjButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjButton3.FlatAppearance.BorderSize = 0;
            this.rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton3.Font = new System.Drawing.Font("Trebuchet MS", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rjButton3.ForeColor = System.Drawing.Color.White;
            this.rjButton3.Location = new System.Drawing.Point(66, 227);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(163, 45);
            this.rjButton3.TabIndex = 15;
            this.rjButton3.Text = "Agregar Inversiones";
            this.rjButton3.TextColor = System.Drawing.Color.White;
            this.rjButton3.UseVisualStyleBackColor = false;
            this.rjButton3.Click += new System.EventHandler(this.rjButton3_Click);
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.rjButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.rjButton2.BorderColor = System.Drawing.Color.White;
            this.rjButton2.BorderRadius = 25;
            this.rjButton2.BorderSize = 1;
            this.rjButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Trebuchet MS", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Location = new System.Drawing.Point(66, 172);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(163, 45);
            this.rjButton2.TabIndex = 14;
            this.rjButton2.Text = "Agregar Costos";
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(179)))), ((int)(((byte)(151)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(179)))), ((int)(((byte)(151)))));
            this.rjButton1.BorderColor = System.Drawing.Color.White;
            this.rjButton1.BorderRadius = 25;
            this.rjButton1.BorderSize = 1;
            this.rjButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Trebuchet MS", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(66, 117);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(163, 45);
            this.rjButton1.TabIndex = 13;
            this.rjButton1.Text = "Agregar Ganancias";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Gray;
            this.pictureBox4.Location = new System.Drawing.Point(235, 303);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(10, 10);
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Gray;
            this.pictureBox3.Location = new System.Drawing.Point(235, 245);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 10);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Gray;
            this.pictureBox2.Location = new System.Drawing.Point(235, 190);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 10);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gray;
            this.pictureBox1.Location = new System.Drawing.Point(235, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 10);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(227, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "%";
            // 
            // txtTMAR
            // 
            this.txtTMAR.DecimalPlaces = 2;
            this.txtTMAR.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTMAR.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTMAR.Location = new System.Drawing.Point(139, 80);
            this.txtTMAR.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtTMAR.Name = "txtTMAR";
            this.txtTMAR.Size = new System.Drawing.Size(82, 21);
            this.txtTMAR.TabIndex = 7;
            this.txtTMAR.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtTMAR.ValueChanged += new System.EventHandler(this.txtTMAR_ValueChanged);
            this.txtTMAR.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTMAR_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(82, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "TMAR";
            // 
            // dgvFNE
            // 
            this.dgvFNE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFNE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFNE.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFNE.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvFNE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFNE.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFNE.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFNE.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFNE.ColumnHeadersHeight = 30;
            this.dgvFNE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvFNE.EnableHeadersVisualStyles = false;
            this.dgvFNE.Location = new System.Drawing.Point(309, 61);
            this.dgvFNE.Name = "dgvFNE";
            this.dgvFNE.ReadOnly = true;
            this.dgvFNE.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MintCream;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFNE.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFNE.RowHeadersVisible = false;
            this.dgvFNE.RowTemplate.Height = 25;
            this.dgvFNE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFNE.Size = new System.Drawing.Size(666, 415);
            this.dgvFNE.TabIndex = 3;
            // 
            // rbSF
            // 
            this.rbSF.AutoSize = true;
            this.rbSF.Checked = true;
            this.rbSF.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbSF.Location = new System.Drawing.Point(673, 33);
            this.rbSF.Name = "rbSF";
            this.rbSF.Size = new System.Drawing.Size(129, 22);
            this.rbSF.TabIndex = 4;
            this.rbSF.TabStop = true;
            this.rbSF.Text = "Sin Financiamiento";
            this.rbSF.UseVisualStyleBackColor = true;
            this.rbSF.CheckedChanged += new System.EventHandler(this.rbSF_CheckedChanged);
            // 
            // rbCF
            // 
            this.rbCF.AutoSize = true;
            this.rbCF.Enabled = false;
            this.rbCF.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbCF.Location = new System.Drawing.Point(419, 33);
            this.rbCF.Name = "rbCF";
            this.rbCF.Size = new System.Drawing.Size(134, 22);
            this.rbCF.TabIndex = 5;
            this.rbCF.Text = "Con Financiamiento";
            this.rbCF.UseVisualStyleBackColor = true;
            this.rbCF.CheckedChanged += new System.EventHandler(this.rbCF_CheckedChanged);
            // 
            // PbClose
            // 
            this.PbClose.BackColor = System.Drawing.Color.Transparent;
            this.PbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbClose.Image = ((System.Drawing.Image)(resources.GetObject("PbClose.Image")));
            this.PbClose.Location = new System.Drawing.Point(962, 12);
            this.PbClose.Name = "PbClose";
            this.PbClose.Size = new System.Drawing.Size(13, 13);
            this.PbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbClose.TabIndex = 19;
            this.PbClose.TabStop = false;
            this.PbClose.Click += new System.EventHandler(this.PbClose_Click);
            // 
            // ellipseControl1
            // 
            this.ellipseControl1.CornerRadius = 10;
            this.ellipseControl1.TargetControl = this;
            // 
            // FormFNE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(987, 488);
            this.Controls.Add(this.PbClose);
            this.Controls.Add(this.rbCF);
            this.Controls.Add(this.rbSF);
            this.Controls.Add(this.dgvFNE);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFNE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FNE";
            this.Load += new System.EventHandler(this.FormFNE_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormFNE_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.txtYears)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTMAR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFNE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown txtYears;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvFNE;
        private System.Windows.Forms.RadioButton rbSF;
        private System.Windows.Forms.RadioButton rbCF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtTMAR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private BeatifulComponents.RJButton rjButton1;
        private BeatifulComponents.RJButton rjButton2;
        private BeatifulComponents.RJButton rjButton3;
        private BeatifulComponents.RJButton rjButton4;
        private BeatifulComponents.RJButton rjButton5;
        private System.Windows.Forms.PictureBox PbClose;
        private BeatifulComponents.EllipseControl ellipseControl1;
        private System.Windows.Forms.Label VisualizarConclusion;
    }
}