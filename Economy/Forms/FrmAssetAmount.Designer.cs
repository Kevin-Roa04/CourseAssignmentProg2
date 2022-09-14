namespace Economy.Forms
{
    partial class FrmAssetAmount
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtAssetAmount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txtAssetAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Set the Asset Amount";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(187, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Accept";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAssetAmount
            // 
            this.txtAssetAmount.Location = new System.Drawing.Point(202, 34);
            this.txtAssetAmount.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtAssetAmount.Name = "txtAssetAmount";
            this.txtAssetAmount.Size = new System.Drawing.Size(179, 23);
            this.txtAssetAmount.TabIndex = 3;
            // 
            // AssetAmount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 143);
            this.Controls.Add(this.txtAssetAmount);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "AssetAmount";
            this.Text = "AssetAmount";
            ((System.ComponentModel.ISupportInitialize)(this.txtAssetAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown txtAssetAmount;
    }
}