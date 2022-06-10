
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
            this.cpFX = new Economy.BeatifulComponents.CustomPanel();
            this.lbFX = new System.Windows.Forms.ListBox();
            this.cpFX.SuspendLayout();
            this.SuspendLayout();
            // 
            // cpFX
            // 
            this.cpFX.BackColor = System.Drawing.Color.White;
            this.cpFX.BorderRadius = 30;
            this.cpFX.Controls.Add(this.lbFX);
            this.cpFX.ForeColor = System.Drawing.Color.Black;
            this.cpFX.GradientAngle = 90F;
            this.cpFX.GradientBottomColor = System.Drawing.Color.Yellow;
            this.cpFX.GradientTopColor = System.Drawing.Color.Orange;
            this.cpFX.Location = new System.Drawing.Point(12, 12);
            this.cpFX.Name = "cpFX";
            this.cpFX.Size = new System.Drawing.Size(331, 320);
            this.cpFX.TabIndex = 0;
            // 
            // lbFX
            // 
            this.lbFX.FormattingEnabled = true;
            this.lbFX.ItemHeight = 15;
            this.lbFX.Location = new System.Drawing.Point(33, 32);
            this.lbFX.Name = "lbFX";
            this.lbFX.Size = new System.Drawing.Size(257, 259);
            this.lbFX.TabIndex = 0;
            this.lbFX.DoubleClick += new System.EventHandler(this.lbFX_DoubleClick);
            // 
            // FormFX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 360);
            this.Controls.Add(this.cpFX);
            this.Name = "FormFX";
            this.Text = "FormFX";
            this.Load += new System.EventHandler(this.FormFX_Load);
            this.cpFX.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private BeatifulComponents.CustomPanel cpFX;
        private System.Windows.Forms.ListBox lbFX;
    }
}