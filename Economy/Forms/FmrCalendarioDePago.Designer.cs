
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmrCalendarioDePago));
            this.cmelegir = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtknversion = new System.Windows.Forms.TextBox();
            this.txtplazo = new System.Windows.Forms.TextBox();
            this.txtinters = new System.Windows.Forms.TextBox();
            this.grpocaculos = new System.Windows.Forms.GroupBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dgvAmortization = new System.Windows.Forms.DataGridView();
            this.Años = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credit_Memo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Outstanding_Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PbClose = new System.Windows.Forms.PictureBox();
            this.ellipseControl1 = new Economy.BeatifulComponents.EllipseControl();
            this.ellipseControl2 = new Economy.BeatifulComponents.EllipseControl();
            this.grpocaculos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmortization)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // cmelegir
            // 
            this.cmelegir.FormattingEnabled = true;
            this.cmelegir.Items.AddRange(new object[] {
            "Metodo de cuota nivelada",
            "Metodo de cuota proporcional"});
            this.cmelegir.Location = new System.Drawing.Point(49, 49);
            this.cmelegir.Name = "cmelegir";
            this.cmelegir.Size = new System.Drawing.Size(199, 23);
            this.cmelegir.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Método de amortización";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(33, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Interés %";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(33, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Plazo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(33, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Préstamo";
            // 
            // txtknversion
            // 
            this.txtknversion.Location = new System.Drawing.Point(137, 121);
            this.txtknversion.Name = "txtknversion";
            this.txtknversion.Size = new System.Drawing.Size(126, 23);
            this.txtknversion.TabIndex = 5;
            // 
            // txtplazo
            // 
            this.txtplazo.Location = new System.Drawing.Point(137, 212);
            this.txtplazo.Name = "txtplazo";
            this.txtplazo.Size = new System.Drawing.Size(126, 23);
            this.txtplazo.TabIndex = 7;
            // 
            // txtinters
            // 
            this.txtinters.Location = new System.Drawing.Point(137, 164);
            this.txtinters.Name = "txtinters";
            this.txtinters.Size = new System.Drawing.Size(126, 23);
            this.txtinters.TabIndex = 8;
            // 
            // grpocaculos
            // 
            this.grpocaculos.Controls.Add(this.label4);
            this.grpocaculos.Controls.Add(this.btnAceptar);
            this.grpocaculos.Controls.Add(this.label1);
            this.grpocaculos.Controls.Add(this.cmelegir);
            this.grpocaculos.Controls.Add(this.label3);
            this.grpocaculos.Controls.Add(this.txtinters);
            this.grpocaculos.Controls.Add(this.label2);
            this.grpocaculos.Controls.Add(this.txtplazo);
            this.grpocaculos.Controls.Add(this.txtknversion);
            this.grpocaculos.Location = new System.Drawing.Point(12, 39);
            this.grpocaculos.Name = "grpocaculos";
            this.grpocaculos.Size = new System.Drawing.Size(297, 346);
            this.grpocaculos.TabIndex = 10;
            this.grpocaculos.TabStop = false;
            this.grpocaculos.Text = "Propiedades del proyecto";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(96, 273);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // dgvAmortization
            // 
            this.dgvAmortization.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAmortization.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAmortization.BackgroundColor = System.Drawing.Color.White;
            this.dgvAmortization.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAmortization.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAmortization.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAmortization.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAmortization.ColumnHeadersHeight = 30;
            this.dgvAmortization.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAmortization.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Años,
            this.Credit_Memo,
            this.Interest,
            this.Payment,
            this.Outstanding_Balance});
            this.dgvAmortization.EnableHeadersVisualStyles = false;
            this.dgvAmortization.Location = new System.Drawing.Point(324, 39);
            this.dgvAmortization.Name = "dgvAmortization";
            this.dgvAmortization.ReadOnly = true;
            this.dgvAmortization.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MintCream;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAmortization.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAmortization.RowHeadersVisible = false;
            this.dgvAmortization.RowTemplate.Height = 25;
            this.dgvAmortization.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAmortization.Size = new System.Drawing.Size(468, 346);
            this.dgvAmortization.TabIndex = 3;
            // 
            // Años
            // 
            this.Años.HeaderText = "Años";
            this.Años.Name = "Años";
            this.Años.ReadOnly = true;
            this.Años.Width = 68;
            // 
            // Credit_Memo
            // 
            this.Credit_Memo.HeaderText = "Abono";
            this.Credit_Memo.Name = "Credit_Memo";
            this.Credit_Memo.ReadOnly = true;
            this.Credit_Memo.Width = 82;
            // 
            // Interest
            // 
            this.Interest.HeaderText = "Interés";
            this.Interest.Name = "Interest";
            this.Interest.ReadOnly = true;
            this.Interest.Width = 82;
            // 
            // Payment
            // 
            this.Payment.HeaderText = "Cuota";
            this.Payment.Name = "Payment";
            this.Payment.ReadOnly = true;
            this.Payment.Width = 78;
            // 
            // Outstanding_Balance
            // 
            this.Outstanding_Balance.HeaderText = "SaldoInsoluto";
            this.Outstanding_Balance.Name = "Outstanding_Balance";
            this.Outstanding_Balance.ReadOnly = true;
            this.Outstanding_Balance.Width = 129;
            // 
            // PbClose
            // 
            this.PbClose.BackColor = System.Drawing.Color.Transparent;
            this.PbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbClose.Image = ((System.Drawing.Image)(resources.GetObject("PbClose.Image")));
            this.PbClose.Location = new System.Drawing.Point(795, 12);
            this.PbClose.Name = "PbClose";
            this.PbClose.Size = new System.Drawing.Size(13, 13);
            this.PbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbClose.TabIndex = 20;
            this.PbClose.TabStop = false;
            this.PbClose.Click += new System.EventHandler(this.PbClose_Click);
            // 
            // ellipseControl1
            // 
            this.ellipseControl1.CornerRadius = 10;
            this.ellipseControl1.TargetControl = this;
            // 
            // ellipseControl2
            // 
            this.ellipseControl2.CornerRadius = 7;
            this.ellipseControl2.TargetControl = this.dgvAmortization;
            // 
            // FmrCalendarioDePago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(820, 397);
            this.Controls.Add(this.PbClose);
            this.Controls.Add(this.dgvAmortization);
            this.Controls.Add(this.grpocaculos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmrCalendarioDePago";
            this.Text = "FmrCalendarioDePago";
            this.Load += new System.EventHandler(this.FmrCalendarioDePago_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FmrCalendarioDePago_MouseDown);
            this.grpocaculos.ResumeLayout(false);
            this.grpocaculos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmortization)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbClose)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox grpocaculos;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridView dgvAmortization;
        private System.Windows.Forms.PictureBox PbClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Años;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credit_Memo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interest;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Outstanding_Balance;
        private BeatifulComponents.EllipseControl ellipseControl1;
        private BeatifulComponents.EllipseControl ellipseControl2;
    }
}