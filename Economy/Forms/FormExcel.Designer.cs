
namespace Economy.Forms
{
    partial class FormExcel
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
            this.dgvExcel = new System.Windows.Forms.DataGridView();
            this.A1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.E1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.H1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnBotones = new System.Windows.Forms.Panel();
            this.btnFB = new Economy.BeatifulComponents.RJButton();
            this.btnFE = new Economy.BeatifulComponents.RJButton();
            this.msOpciones = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcel)).BeginInit();
            this.pnBotones.SuspendLayout();
            this.msOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvExcel
            // 
            this.dgvExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExcel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.A1,
            this.B1,
            this.C1,
            this.D1,
            this.E1,
            this.F1,
            this.G1,
            this.H1});
            this.dgvExcel.EnableHeadersVisualStyles = false;
            this.dgvExcel.Location = new System.Drawing.Point(10, 68);
            this.dgvExcel.Name = "dgvExcel";
            this.dgvExcel.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvExcel.RowHeadersVisible = false;
            this.dgvExcel.RowTemplate.Height = 25;
            this.dgvExcel.Size = new System.Drawing.Size(784, 370);
            this.dgvExcel.TabIndex = 2;
            this.dgvExcel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExcel_CellClick);
            this.dgvExcel.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvExcel_CellMouseUp);
            this.dgvExcel.CurrentCellChanged += new System.EventHandler(this.dgvExcel_CurrentCellChanged);
            // 
            // A1
            // 
            this.A1.HeaderText = "A";
            this.A1.Name = "A1";
            // 
            // B1
            // 
            this.B1.HeaderText = "B";
            this.B1.Name = "B1";
            // 
            // C1
            // 
            this.C1.HeaderText = "C";
            this.C1.Name = "C1";
            // 
            // D1
            // 
            this.D1.HeaderText = "D";
            this.D1.Name = "D1";
            // 
            // E1
            // 
            this.E1.HeaderText = "E";
            this.E1.Name = "E1";
            // 
            // F1
            // 
            this.F1.HeaderText = "F";
            this.F1.Name = "F1";
            // 
            // G1
            // 
            this.G1.HeaderText = "G";
            this.G1.Name = "G1";
            // 
            // H1
            // 
            this.H1.HeaderText = "H";
            this.H1.Name = "H1";
            // 
            // pnBotones
            // 
            this.pnBotones.Controls.Add(this.btnFB);
            this.pnBotones.Controls.Add(this.btnFE);
            this.pnBotones.Location = new System.Drawing.Point(10, 29);
            this.pnBotones.Name = "pnBotones";
            this.pnBotones.Size = new System.Drawing.Size(784, 41);
            this.pnBotones.TabIndex = 8;
            // 
            // btnFB
            // 
            this.btnFB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(202)))), ((int)(((byte)(140)))));
            this.btnFB.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(202)))), ((int)(((byte)(140)))));
            this.btnFB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFB.BorderRadius = 0;
            this.btnFB.BorderSize = 0;
            this.btnFB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFB.FlatAppearance.BorderSize = 0;
            this.btnFB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFB.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFB.ForeColor = System.Drawing.Color.White;
            this.btnFB.Location = new System.Drawing.Point(614, 4);
            this.btnFB.Name = "btnFB";
            this.btnFB.Size = new System.Drawing.Size(151, 29);
            this.btnFB.TabIndex = 4;
            this.btnFB.Text = "Funciones basicas";
            this.btnFB.TextColor = System.Drawing.Color.White;
            this.btnFB.UseVisualStyleBackColor = false;
            this.btnFB.Click += new System.EventHandler(this.btnFB_Click);
            this.btnFB.MouseEnter += new System.EventHandler(this.btnFB_MouseEnter);
            this.btnFB.MouseLeave += new System.EventHandler(this.btnFB_MouseLeave);
            // 
            // btnFE
            // 
            this.btnFE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(202)))), ((int)(((byte)(140)))));
            this.btnFE.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(202)))), ((int)(((byte)(140)))));
            this.btnFE.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFE.BorderRadius = 0;
            this.btnFE.BorderSize = 0;
            this.btnFE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFE.FlatAppearance.BorderSize = 0;
            this.btnFE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFE.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFE.ForeColor = System.Drawing.Color.White;
            this.btnFE.Location = new System.Drawing.Point(399, 4);
            this.btnFE.Name = "btnFE";
            this.btnFE.Size = new System.Drawing.Size(175, 29);
            this.btnFE.TabIndex = 3;
            this.btnFE.Text = "Funciones especiales";
            this.btnFE.TextColor = System.Drawing.Color.White;
            this.btnFE.UseVisualStyleBackColor = false;
            this.btnFE.Visible = false;
            this.btnFE.Click += new System.EventHandler(this.buttonFX_Click);
            this.btnFE.MouseEnter += new System.EventHandler(this.btnFX_MouseEnter);
            this.btnFE.MouseLeave += new System.EventHandler(this.btnFX_MouseLeave);
            // 
            // msOpciones
            // 
            this.msOpciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(179)))), ((int)(((byte)(151)))));
            this.msOpciones.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.msOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.exportarToolStripMenuItem,
            this.importarToolStripMenuItem});
            this.msOpciones.Location = new System.Drawing.Point(0, 0);
            this.msOpciones.Name = "msOpciones";
            this.msOpciones.Size = new System.Drawing.Size(803, 29);
            this.msOpciones.TabIndex = 7;
            this.msOpciones.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(179)))), ((int)(((byte)(151)))));
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem});
            this.archivoToolStripMenuItem.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(78, 25);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(179)))), ((int)(((byte)(151)))));
            this.guardarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(179)))), ((int)(((byte)(151)))));
            this.exportarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aExcelToolStripMenuItem,
            this.pDFToolStripMenuItem});
            this.exportarToolStripMenuItem.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exportarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.Size = new System.Drawing.Size(84, 25);
            this.exportarToolStripMenuItem.Text = "Exportar";
            // 
            // aExcelToolStripMenuItem
            // 
            this.aExcelToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(179)))), ((int)(((byte)(151)))));
            this.aExcelToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aExcelToolStripMenuItem.Name = "aExcelToolStripMenuItem";
            this.aExcelToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
            this.aExcelToolStripMenuItem.Text = "Excel";
            this.aExcelToolStripMenuItem.Click += new System.EventHandler(this.aExcelToolStripMenuItem_Click);
            // 
            // pDFToolStripMenuItem
            // 
            this.pDFToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(179)))), ((int)(((byte)(151)))));
            this.pDFToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.pDFToolStripMenuItem.Name = "pDFToolStripMenuItem";
            this.pDFToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
            this.pDFToolStripMenuItem.Text = "PDF";
            this.pDFToolStripMenuItem.Click += new System.EventHandler(this.pDFToolStripMenuItem_Click);
            // 
            // importarToolStripMenuItem
            // 
            this.importarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(179)))), ((int)(((byte)(151)))));
            this.importarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excelToolStripMenuItem});
            this.importarToolStripMenuItem.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.importarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.importarToolStripMenuItem.Name = "importarToolStripMenuItem";
            this.importarToolStripMenuItem.Size = new System.Drawing.Size(87, 25);
            this.importarToolStripMenuItem.Text = "Importar";
            // 
            // excelToolStripMenuItem
            // 
            this.excelToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(179)))), ((int)(((byte)(151)))));
            this.excelToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            this.excelToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
            this.excelToolStripMenuItem.Text = "Excel";
            this.excelToolStripMenuItem.Click += new System.EventHandler(this.excelToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(179)))), ((int)(((byte)(151)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 420);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(179)))), ((int)(((byte)(151)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(793, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 420);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(179)))), ((int)(((byte)(151)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(10, 439);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(783, 10);
            this.panel3.TabIndex = 11;
            // 
            // FormExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 449);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnBotones);
            this.Controls.Add(this.msOpciones);
            this.Controls.Add(this.dgvExcel);
            this.Name = "FormExcel";
            this.Text = "FormExcel";
            this.Activated += new System.EventHandler(this.FormExcel_Activated);
            this.Load += new System.EventHandler(this.FormExcel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcel)).EndInit();
            this.pnBotones.ResumeLayout(false);
            this.msOpciones.ResumeLayout(false);
            this.msOpciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn A1;
        private System.Windows.Forms.DataGridViewTextBoxColumn B1;
        private System.Windows.Forms.DataGridViewTextBoxColumn C1;
        private System.Windows.Forms.DataGridViewTextBoxColumn D1;
        private System.Windows.Forms.DataGridViewTextBoxColumn E1;
        private System.Windows.Forms.DataGridViewTextBoxColumn F1;
        private System.Windows.Forms.DataGridViewTextBoxColumn G1;
        private System.Windows.Forms.DataGridViewTextBoxColumn H1;
        private System.Windows.Forms.Panel pnBotones;
        private BeatifulComponents.RJButton btnFE;
        private System.Windows.Forms.MenuStrip msOpciones;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private BeatifulComponents.RJButton btnFB;
    }
}