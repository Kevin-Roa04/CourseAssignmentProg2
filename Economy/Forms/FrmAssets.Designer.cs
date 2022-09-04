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
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssets)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Find the Financial Asset";
            // 
            // txtAssets
            // 
            this.txtAssets.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtAssets.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtAssets.Location = new System.Drawing.Point(192, 12);
            this.txtAssets.Name = "txtAssets";
            this.txtAssets.PlaceholderText = "Assets";
            this.txtAssets.Size = new System.Drawing.Size(221, 23);
            this.txtAssets.TabIndex = 2;
            // 
            // dgvAssets
            // 
            this.dgvAssets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssets.Location = new System.Drawing.Point(12, 55);
            this.dgvAssets.Name = "dgvAssets";
            this.dgvAssets.RowTemplate.Height = 25;
            this.dgvAssets.Size = new System.Drawing.Size(547, 383);
            this.dgvAssets.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(434, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add Asset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(578, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Not depreciable assets";
            // 
            // notDepreciable
            // 
            this.notDepreciable.AutoSize = true;
            this.notDepreciable.Location = new System.Drawing.Point(731, 71);
            this.notDepreciable.Name = "notDepreciable";
            this.notDepreciable.Size = new System.Drawing.Size(17, 15);
            this.notDepreciable.TabIndex = 6;
            this.notDepreciable.Text = "--";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(600, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Depreciable assets";
            // 
            // Depreciable
            // 
            this.Depreciable.AutoSize = true;
            this.Depreciable.Location = new System.Drawing.Point(731, 104);
            this.Depreciable.Name = "Depreciable";
            this.Depreciable.Size = new System.Drawing.Size(17, 15);
            this.Depreciable.TabIndex = 8;
            this.Depreciable.Text = "--";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(671, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(731, 132);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(17, 15);
            this.total.TabIndex = 10;
            this.total.Text = "--";
            // 
            // btnDepreciacion
            // 
            this.btnDepreciacion.Location = new System.Drawing.Point(626, 175);
            this.btnDepreciacion.Name = "btnDepreciacion";
            this.btnDepreciacion.Size = new System.Drawing.Size(138, 23);
            this.btnDepreciacion.TabIndex = 11;
            this.btnDepreciacion.Text = "Depreciation Setup";
            this.btnDepreciacion.UseVisualStyleBackColor = true;
            this.btnDepreciacion.Click += new System.EventHandler(this.btnDepreciacion_Click);
            // 
            // FrmAssets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "FrmAssets";
            this.Text = "FrmAssets";
            this.Load += new System.EventHandler(this.FrmAssets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssets)).EndInit();
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
    }
}