
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
            this.txtYears = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rjButton5 = new Economy.BeatifulComponents.RJButton();
            this.rjButton4 = new Economy.BeatifulComponents.RJButton();
            this.rjButton3 = new Economy.BeatifulComponents.RJButton();
            this.rjButton2 = new Economy.BeatifulComponents.RJButton();
            this.rjButton1 = new Economy.BeatifulComponents.RJButton();
            this.dgvFNE = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.txtYears)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFNE)).BeginInit();
            this.SuspendLayout();
            // 
            // txtYears
            // 
            this.txtYears.Location = new System.Drawing.Point(126, 38);
            this.txtYears.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.txtYears.Name = "txtYears";
            this.txtYears.Size = new System.Drawing.Size(67, 23);
            this.txtYears.TabIndex = 0;
            this.txtYears.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.txtYears.ValueChanged += new System.EventHandler(this.txtYears_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Years";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rjButton5);
            this.groupBox1.Controls.Add(this.rjButton4);
            this.groupBox1.Controls.Add(this.rjButton3);
            this.groupBox1.Controls.Add(this.rjButton2);
            this.groupBox1.Controls.Add(this.rjButton1);
            this.groupBox1.Controls.Add(this.txtYears);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 491);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Project Settings";
            // 
            // rjButton5
            // 
            this.rjButton5.BackColor = System.Drawing.Color.SlateGray;
            this.rjButton5.BackgroundColor = System.Drawing.Color.SlateGray;
            this.rjButton5.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton5.BorderRadius = 0;
            this.rjButton5.BorderSize = 0;
            this.rjButton5.FlatAppearance.BorderSize = 0;
            this.rjButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rjButton5.ForeColor = System.Drawing.Color.White;
            this.rjButton5.Location = new System.Drawing.Point(0, 229);
            this.rjButton5.Name = "rjButton5";
            this.rjButton5.Size = new System.Drawing.Size(270, 40);
            this.rjButton5.TabIndex = 5;
            this.rjButton5.Text = "Accept";
            this.rjButton5.TextColor = System.Drawing.Color.White;
            this.rjButton5.UseVisualStyleBackColor = false;
            this.rjButton5.Click += new System.EventHandler(this.rjButton5_Click);
            // 
            // rjButton4
            // 
            this.rjButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rjButton4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rjButton4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton4.BorderRadius = 0;
            this.rjButton4.BorderSize = 0;
            this.rjButton4.FlatAppearance.BorderSize = 0;
            this.rjButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton4.ForeColor = System.Drawing.Color.White;
            this.rjButton4.Location = new System.Drawing.Point(69, 180);
            this.rjButton4.Name = "rjButton4";
            this.rjButton4.Size = new System.Drawing.Size(124, 31);
            this.rjButton4.TabIndex = 3;
            this.rjButton4.Text = "Add Loan";
            this.rjButton4.TextColor = System.Drawing.Color.White;
            this.rjButton4.UseVisualStyleBackColor = false;
            this.rjButton4.Click += new System.EventHandler(this.rjButton4_Click);
            // 
            // rjButton3
            // 
            this.rjButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rjButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rjButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton3.BorderRadius = 0;
            this.rjButton3.BorderSize = 0;
            this.rjButton3.FlatAppearance.BorderSize = 0;
            this.rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton3.ForeColor = System.Drawing.Color.White;
            this.rjButton3.Location = new System.Drawing.Point(69, 142);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(124, 32);
            this.rjButton3.TabIndex = 3;
            this.rjButton3.Text = "Add Depreciations";
            this.rjButton3.TextColor = System.Drawing.Color.White;
            this.rjButton3.UseVisualStyleBackColor = false;
            this.rjButton3.Click += new System.EventHandler(this.rjButton3_Click);
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.Red;
            this.rjButton2.BackgroundColor = System.Drawing.Color.Red;
            this.rjButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton2.BorderRadius = 0;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Location = new System.Drawing.Point(69, 103);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(124, 33);
            this.rjButton2.TabIndex = 4;
            this.rjButton2.Text = "Add Costs";
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 0;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(69, 67);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(124, 30);
            this.rjButton1.TabIndex = 3;
            this.rjButton1.Text = "Add Profits";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // dgvFNE
            // 
            this.dgvFNE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFNE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFNE.Location = new System.Drawing.Point(294, 21);
            this.dgvFNE.Name = "dgvFNE";
            this.dgvFNE.ReadOnly = true;
            this.dgvFNE.RowTemplate.Height = 25;
            this.dgvFNE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFNE.Size = new System.Drawing.Size(681, 482);
            this.dgvFNE.TabIndex = 3;
            // 
            // FormFNE
            // 
            this.ClientSize = new System.Drawing.Size(987, 515);
            this.Controls.Add(this.dgvFNE);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormFNE";
            this.Text = "FNE";
            this.Load += new System.EventHandler(this.FormFNE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtYears)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFNE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown txtYears;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private BeatifulComponents.RJButton rjButton5;
        private BeatifulComponents.RJButton rjButton4;
        private BeatifulComponents.RJButton rjButton3;
        private BeatifulComponents.RJButton rjButton2;
        private BeatifulComponents.RJButton rjButton1;
        private System.Windows.Forms.DataGridView dgvFNE;
    }
}