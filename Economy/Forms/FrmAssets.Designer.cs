using Economy.AppCore.Helper;

namespace Economy.Forms
{
    partial class FrmAssets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAssets));
            this.label1 = new System.Windows.Forms.Label();
            this.txtAssets = new System.Windows.Forms.TextBox();
            this.dgvAssets = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.notDepreciable = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Depreciable = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.btnDepreciacion = new System.Windows.Forms.Button();
            this.PbClose = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarMontoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbClose)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Encuentra tu Activo Financiero";
            // 
            // txtAssets
            // 
            this.txtAssets.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtAssets.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtAssets.Location = new System.Drawing.Point(223, 34);
            this.txtAssets.Name = "txtAssets";
            this.txtAssets.PlaceholderText = "Activos";
            this.txtAssets.Size = new System.Drawing.Size(221, 23);
            this.txtAssets.TabIndex = 2;
            // 
            // dgvAssets
            // 
            this.dgvAssets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAssets.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAssets.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAssets.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAssets.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAssets.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAssets.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAssets.ColumnHeadersHeight = 30;
            this.dgvAssets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAssets.EnableHeadersVisualStyles = false;
            this.dgvAssets.Location = new System.Drawing.Point(24, 63);
            this.dgvAssets.MaximumSize = new System.Drawing.Size(574, 383);
            this.dgvAssets.Name = "dgvAssets";
            this.dgvAssets.ReadOnly = true;
            this.dgvAssets.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MintCream;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAssets.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAssets.RowHeadersVisible = false;
            this.dgvAssets.RowTemplate.Height = 25;
            this.dgvAssets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssets.Size = new System.Drawing.Size(491, 383);
            this.dgvAssets.TabIndex = 3;
            this.dgvAssets.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAssets_CellMouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(452, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Agregar Activo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(521, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Activos no Depreciables";
            // 
            // notDepreciable
            // 
            this.notDepreciable.AutoSize = true;
            this.notDepreciable.Location = new System.Drawing.Point(660, 79);
            this.notDepreciable.Name = "notDepreciable";
            this.notDepreciable.Size = new System.Drawing.Size(17, 15);
            this.notDepreciable.TabIndex = 6;
            this.notDepreciable.Text = "--";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(538, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Activos Depreciables";
            // 
            // Depreciable
            // 
            this.Depreciable.AutoSize = true;
            this.Depreciable.Location = new System.Drawing.Point(660, 112);
            this.Depreciable.Name = "Depreciable";
            this.Depreciable.Size = new System.Drawing.Size(17, 15);
            this.Depreciable.TabIndex = 8;
            this.Depreciable.Text = "--";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(622, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(660, 140);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(17, 15);
            this.total.TabIndex = 10;
            this.total.Text = "--";
            // 
            // btnDepreciacion
            // 
            this.btnDepreciacion.Location = new System.Drawing.Point(553, 180);
            this.btnDepreciacion.Name = "btnDepreciacion";
            this.btnDepreciacion.Size = new System.Drawing.Size(138, 39);
            this.btnDepreciacion.TabIndex = 11;
            this.btnDepreciacion.Text = "Configura la Depreciación";
            this.btnDepreciacion.UseVisualStyleBackColor = true;
            this.btnDepreciacion.Click += new System.EventHandler(this.btnDepreciacion_Click);
            // 
            // PbClose
            // 
            this.PbClose.BackColor = System.Drawing.Color.Transparent;
            this.PbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbClose.Image = ((System.Drawing.Image)(resources.GetObject("PbClose.Image")));
            this.PbClose.Location = new System.Drawing.Point(700, 12);
            this.PbClose.Name = "PbClose";
            this.PbClose.Size = new System.Drawing.Size(13, 13);
            this.PbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbClose.TabIndex = 20;
            this.PbClose.TabStop = false;
            this.PbClose.Click += new System.EventHandler(this.PbClose_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarMontoToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // editarMontoToolStripMenuItem
            // 
            this.editarMontoToolStripMenuItem.Name = "editarMontoToolStripMenuItem";
            this.editarMontoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editarMontoToolStripMenuItem.Text = "Editar Monto";
            this.editarMontoToolStripMenuItem.Click += new System.EventHandler(this.editarMontoToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // FrmAssets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 473);
            this.Controls.Add(this.PbClose);
            this.Controls.Add(this.btnDepreciacion);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Depreciable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.notDepreciable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvAssets);
            this.Controls.Add(this.txtAssets);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAssets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAssets";
            this.Load += new System.EventHandler(this.FrmAssets_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmAssets_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbClose)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAssets;
        private System.Windows.Forms.DataGridView dgvAssets;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label notDepreciable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Depreciable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Button btnDepreciacion;
        private System.Windows.Forms.PictureBox PbClose;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editarMontoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
    }
}