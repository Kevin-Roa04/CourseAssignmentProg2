
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
            this.flpFunction = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpFunction
            // 
            this.flpFunction.Location = new System.Drawing.Point(24, 12);
            this.flpFunction.Name = "flpFunction";
            this.flpFunction.Size = new System.Drawing.Size(462, 473);
            this.flpFunction.TabIndex = 0;
            // 
            // FormFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 497);
            this.Controls.Add(this.flpFunction);
            this.Name = "FormFunction";
            this.Text = "FormFunction";
            this.Activated += new System.EventHandler(this.FormFunction_Activated);
            this.Load += new System.EventHandler(this.FormFunction_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpFunction;
    }
}