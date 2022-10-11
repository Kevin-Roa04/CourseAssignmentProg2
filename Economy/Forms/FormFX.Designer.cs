
namespace Economy.Forms
{
    partial class FormFX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFX));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbFX = new System.Windows.Forms.ListBox();
            this.PbClose = new System.Windows.Forms.PictureBox();
            this.ellipseControl1 = new Economy.BeatifulComponents.EllipseControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbFX);
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 290);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // lbFX
            // 
            this.lbFX.BackColor = System.Drawing.Color.White;
            this.lbFX.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbFX.ForeColor = System.Drawing.Color.DarkGray;
            this.lbFX.FormattingEnabled = true;
            this.lbFX.ItemHeight = 22;
            this.lbFX.Location = new System.Drawing.Point(12, 17);
            this.lbFX.Name = "lbFX";
            this.lbFX.Size = new System.Drawing.Size(352, 268);
            this.lbFX.TabIndex = 0;
            this.lbFX.SelectedIndexChanged += new System.EventHandler(this.lbFX_SelectedIndexChanged);
            this.lbFX.DoubleClick += new System.EventHandler(this.lbFX_DoubleClick);
            // 
            // PbClose
            // 
            this.PbClose.BackColor = System.Drawing.Color.Transparent;
            this.PbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbClose.Image = ((System.Drawing.Image)(resources.GetObject("PbClose.Image")));
            this.PbClose.Location = new System.Drawing.Point(356, 7);
            this.PbClose.Name = "PbClose";
            this.PbClose.Size = new System.Drawing.Size(13, 13);
            this.PbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbClose.TabIndex = 53;
            this.PbClose.TabStop = false;
            this.PbClose.Click += new System.EventHandler(this.PbClose_Click);
            // 
            // ellipseControl1
            // 
            this.ellipseControl1.CornerRadius = 11;
            this.ellipseControl1.TargetControl = this;
            // 
            // FormFX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(379, 335);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PbClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFX";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FormFX_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormFX_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PbClose;
        private System.Windows.Forms.ListBox lbFX;
        private BeatifulComponents.EllipseControl ellipseControl1;
    }
}