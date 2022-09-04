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
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssets)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Find the Financial Asset";
            // 
            // txtAssets
            // 
            this.txtAssets.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtAssets.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtAssets.Location = new System.Drawing.Point(318, 12);
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
            this.dgvAssets.Size = new System.Drawing.Size(776, 383);
            this.dgvAssets.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(560, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add Asset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmAssets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}