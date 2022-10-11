
namespace Economy.Forms
{
    partial class FormFunction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFunction));
            this.flpFunction = new System.Windows.Forms.FlowLayoutPanel();
            this.PbClose = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ellipseControl1 = new Economy.BeatifulComponents.EllipseControl();
            ((System.ComponentModel.ISupportInitialize)(this.PbClose)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpFunction
            // 
            this.flpFunction.BackColor = System.Drawing.Color.White;
            this.flpFunction.Location = new System.Drawing.Point(12, 28);
            this.flpFunction.Name = "flpFunction";
            this.flpFunction.Size = new System.Drawing.Size(538, 405);
            this.flpFunction.TabIndex = 0;
            // 
            // PbClose
            // 
            this.PbClose.BackColor = System.Drawing.Color.Transparent;
            this.PbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbClose.Image = ((System.Drawing.Image)(resources.GetObject("PbClose.Image")));
            this.PbClose.Location = new System.Drawing.Point(543, 9);
            this.PbClose.Name = "PbClose";
            this.PbClose.Size = new System.Drawing.Size(13, 13);
            this.PbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbClose.TabIndex = 20;
            this.PbClose.TabStop = false;
            this.PbClose.Click += new System.EventHandler(this.PbClose_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PbClose);
            this.panel1.Controls.Add(this.flpFunction);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 444);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // ellipseControl1
            // 
            this.ellipseControl1.CornerRadius = 9;
            this.ellipseControl1.TargetControl = this;
            // 
            // FormFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(567, 444);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFunction";
            this.Text = "Funciones ";
            this.Activated += new System.EventHandler(this.FormFunction_Activated);
            this.Load += new System.EventHandler(this.FormFunction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbClose)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpFunction;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PbClose;
        private BeatifulComponents.EllipseControl ellipseControl1;
    }
}