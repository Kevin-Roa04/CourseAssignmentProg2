namespace Economy.Forms
{
    partial class FrmInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInformation));
            this.PbClose = new System.Windows.Forms.PictureBox();
            this.ellipseControl1 = new Economy.BeatifulComponents.EllipseControl();
            this.rtbInformation = new System.Windows.Forms.RichTextBox();
            this.lblInformation = new System.Windows.Forms.Label();
            this.pbClipBoard = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClipBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // PbClose
            // 
            this.PbClose.BackColor = System.Drawing.Color.Transparent;
            this.PbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbClose.Image = ((System.Drawing.Image)(resources.GetObject("PbClose.Image")));
            this.PbClose.Location = new System.Drawing.Point(384, 12);
            this.PbClose.Name = "PbClose";
            this.PbClose.Size = new System.Drawing.Size(13, 13);
            this.PbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbClose.TabIndex = 52;
            this.PbClose.TabStop = false;
            this.PbClose.Click += new System.EventHandler(this.PbClose_Click);
            // 
            // ellipseControl1
            // 
            this.ellipseControl1.CornerRadius = 10;
            this.ellipseControl1.TargetControl = this;
            // 
            // rtbInformation
            // 
            this.rtbInformation.BackColor = System.Drawing.Color.White;
            this.rtbInformation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbInformation.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtbInformation.ForeColor = System.Drawing.Color.DimGray;
            this.rtbInformation.Location = new System.Drawing.Point(12, 49);
            this.rtbInformation.Name = "rtbInformation";
            this.rtbInformation.ReadOnly = true;
            this.rtbInformation.Size = new System.Drawing.Size(385, 444);
            this.rtbInformation.TabIndex = 53;
            this.rtbInformation.Text = "";
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInformation.ForeColor = System.Drawing.Color.DimGray;
            this.lblInformation.Location = new System.Drawing.Point(27, 31);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(73, 18);
            this.lblInformation.TabIndex = 54;
            this.lblInformation.Text = "Información";
            // 
            // pbClipBoard
            // 
            this.pbClipBoard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClipBoard.Image = ((System.Drawing.Image)(resources.GetObject("pbClipBoard.Image")));
            this.pbClipBoard.Location = new System.Drawing.Point(116, 24);
            this.pbClipBoard.Name = "pbClipBoard";
            this.pbClipBoard.Size = new System.Drawing.Size(25, 25);
            this.pbClipBoard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClipBoard.TabIndex = 55;
            this.pbClipBoard.TabStop = false;
            this.pbClipBoard.Click += new System.EventHandler(this.pbClipBoard_Click);
            // 
            // FrmInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(409, 505);
            this.Controls.Add(this.pbClipBoard);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.rtbInformation);
            this.Controls.Add(this.PbClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInformation";
            this.Text = "FrmInformation";
            this.Load += new System.EventHandler(this.FrmInformation_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmInformation_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.PbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClipBoard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PbClose;
        private BeatifulComponents.EllipseControl ellipseControl1;
        private System.Windows.Forms.RichTextBox rtbInformation;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.PictureBox pbClipBoard;
    }
}