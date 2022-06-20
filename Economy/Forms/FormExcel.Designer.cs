
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
            this.btnFX = new Economy.BeatifulComponents.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcel)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvExcel
            // 
            this.dgvExcel.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.dgvExcel.Location = new System.Drawing.Point(12, 55);
            this.dgvExcel.Name = "dgvExcel";
            this.dgvExcel.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvExcel.RowHeadersVisible = false;
            this.dgvExcel.RowTemplate.Height = 25;
            this.dgvExcel.Size = new System.Drawing.Size(776, 383);
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
            // btnFX
            // 
            this.btnFX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnFX.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnFX.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFX.BorderRadius = 0;
            this.btnFX.BorderSize = 0;
            this.btnFX.FlatAppearance.BorderSize = 0;
            this.btnFX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFX.ForeColor = System.Drawing.Color.White;
            this.btnFX.Location = new System.Drawing.Point(29, 12);
            this.btnFX.Name = "btnFX";
            this.btnFX.Size = new System.Drawing.Size(73, 22);
            this.btnFX.TabIndex = 3;
            this.btnFX.Text = "FX";
            this.btnFX.TextColor = System.Drawing.Color.White;
            this.btnFX.UseVisualStyleBackColor = false;
            this.btnFX.Visible = false;
            this.btnFX.Click += new System.EventHandler(this.buttonFX_Click);
            // 
            // FormExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 450);
            this.Controls.Add(this.dgvExcel);
            this.Controls.Add(this.btnFX);
            this.Name = "FormExcel";
            this.Text = "FormExcel";
            this.Activated += new System.EventHandler(this.FormExcel_Activated);
            this.Deactivate += new System.EventHandler(this.FormExcel_Deactivate);
            this.Load += new System.EventHandler(this.FormExcel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcel)).EndInit();
            this.ResumeLayout(false);

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
        private BeatifulComponents.RJButton btnFX;
    }
}