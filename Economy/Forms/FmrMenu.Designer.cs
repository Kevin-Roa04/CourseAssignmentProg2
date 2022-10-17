
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
            this.cmbmenu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbmenu
            // 
            this.cmbmenu.FormattingEnabled = true;
            this.cmbmenu.Items.AddRange(new object[] {
            "Interés semejante a su periodo",
            "Interés no semejante a su periodo"});
            this.cmbmenu.Location = new System.Drawing.Point(12, 48);
            this.cmbmenu.Name = "cmbmenu";
            this.cmbmenu.Size = new System.Drawing.Size(287, 23);
            this.cmbmenu.TabIndex = 0;
            this.cmbmenu.SelectedIndexChanged += new System.EventHandler(this.cmbmenu_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione el modo";
            // 
            // FmrMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 118);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbmenu);
            this.Name = "FmrMenu";
            this.Text = "FmrMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbmenu;
        private System.Windows.Forms.Label label1;
    }
}