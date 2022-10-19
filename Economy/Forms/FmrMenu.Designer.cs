
namespace Economy.Forms
{
    partial class FmrMenu
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
            this.cmbmenu = new Economy.BeatifulComponents.RJComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(92, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione el modo";
            // 
            // cmbmenu
            // 
            this.cmbmenu.BackColor = System.Drawing.Color.White;
            this.cmbmenu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.cmbmenu.BorderSize = 1;
            this.cmbmenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbmenu.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbmenu.ForeColor = System.Drawing.Color.DimGray;
            this.cmbmenu.IconColor = System.Drawing.Color.Gray;
            this.cmbmenu.Items.AddRange(new object[] {
            "Semanas",
            "Mes",
            "Bimestres",
            "Trimestres",
            "Cuatrimestres",
            "Semestres",
            "Años"});
            this.cmbmenu.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbmenu.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbmenu.Location = new System.Drawing.Point(12, 62);
            this.cmbmenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbmenu.Name = "cmbmenu";
            this.cmbmenu.Padding = new System.Windows.Forms.Padding(1);
            this.cmbmenu.Size = new System.Drawing.Size(287, 36);
            this.cmbmenu.TabIndex = 55;
            this.cmbmenu.Texts = "";
            // 
            // FmrMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(311, 142);
            this.Controls.Add(this.cmbmenu);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FmrMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public BeatifulComponents.RJComboBox cmbmenu;
    }
}