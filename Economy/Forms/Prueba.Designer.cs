namespace Economy.Forms
{
    partial class Prueba
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
            this.ordinaryAnnuity1 = new Economy.BeatifulComponents.AnnutiesComponents.OrdinaryAnnuity();
            this.SuspendLayout();
            // 
            // ordinaryAnnuity1
            // 
            this.ordinaryAnnuity1.BackColor = System.Drawing.Color.White;
            this.ordinaryAnnuity1.Duration = 3;
            this.ordinaryAnnuity1.Interest = "(1+0.3)";
            this.ordinaryAnnuity1.InterestD = "0.3 * (1+0.3)";
            this.ordinaryAnnuity1.Location = new System.Drawing.Point(235, 48);
            this.ordinaryAnnuity1.Name = "ordinaryAnnuity1";
            this.ordinaryAnnuity1.PAO = 3000D;
            this.ordinaryAnnuity1.Size = new System.Drawing.Size(296, 154);
            this.ordinaryAnnuity1.TabIndex = 0;
            // 
            // Prueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ordinaryAnnuity1);
            this.Name = "Prueba";
            this.Text = "Prueba";
            this.Load += new System.EventHandler(this.Prueba_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private BeatifulComponents.AnnutiesComponents.OrdinaryAnnuity ordinaryAnnuity1;
    }
}