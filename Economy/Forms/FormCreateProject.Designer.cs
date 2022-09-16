
namespace Economy.Forms
{
    partial class FormCreateProject
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreateProject));
            this.PC0 = new Economy.BeatifulComponents.ProjectComponent();
            this.PC1 = new Economy.BeatifulComponents.ProjectComponent();
            this.PC2 = new Economy.BeatifulComponents.ProjectComponent();
            this.flpCProject = new System.Windows.Forms.FlowLayoutPanel();
            this.PC3 = new Economy.BeatifulComponents.ProjectComponent();
            this.PC4 = new Economy.BeatifulComponents.ProjectComponent();
            this.PC5 = new Economy.BeatifulComponents.ProjectComponent();
            this.PC6 = new Economy.BeatifulComponents.ProjectComponent();
            this.flpProjects = new System.Windows.Forms.FlowLayoutPanel();
            this.PbClose = new System.Windows.Forms.PictureBox();
            this.FadeIn = new System.Windows.Forms.Timer(this.components);
            this.txtSearch = new Economy.RJTextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtProjectName = new Economy.RJTextBox();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.lblLetters = new System.Windows.Forms.Label();
            this.btnCreate = new Economy.BeatifulComponents.RJButton();
            this.flpCProject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // PC0
            // 
            this.PC0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.PC0.BorderRadius = 16;
            this.PC0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PC0.Description = "Interés y gráfica";
            this.PC0.ForeColor = System.Drawing.Color.Black;
            this.PC0.Letter = "IG";
            this.PC0.Location = new System.Drawing.Point(3, 3);
            this.PC0.Name = "PC0";
            this.PC0.NameProject = "";
            this.PC0.Size = new System.Drawing.Size(150, 150);
            this.PC0.TabIndex = 0;
            // 
            // PC1
            // 
            this.PC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(215)))), ((int)(((byte)(185)))));
            this.PC1.BorderRadius = 16;
            this.PC1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PC1.Description = "Funciones en excel";
            this.PC1.ForeColor = System.Drawing.Color.Black;
            this.PC1.Letter = "FE";
            this.PC1.Location = new System.Drawing.Point(159, 3);
            this.PC1.Name = "PC1";
            this.PC1.NameProject = "";
            this.PC1.Size = new System.Drawing.Size(150, 150);
            this.PC1.TabIndex = 1;
            // 
            // PC2
            // 
            this.PC2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(248)))));
            this.PC2.BorderRadius = 16;
            this.PC2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PC2.Description = "Intereses nominales";
            this.PC2.ForeColor = System.Drawing.Color.Black;
            this.PC2.Letter = "IN";
            this.PC2.Location = new System.Drawing.Point(315, 3);
            this.PC2.Name = "PC2";
            this.PC2.NameProject = "";
            this.PC2.Size = new System.Drawing.Size(150, 150);
            this.PC2.TabIndex = 2;
            // 
            // flpCProject
            // 
            this.flpCProject.AutoScroll = true;
            this.flpCProject.Controls.Add(this.PC0);
            this.flpCProject.Controls.Add(this.PC1);
            this.flpCProject.Controls.Add(this.PC2);
            this.flpCProject.Controls.Add(this.PC3);
            this.flpCProject.Controls.Add(this.PC4);
            this.flpCProject.Controls.Add(this.PC5);
            this.flpCProject.Controls.Add(this.PC6);
            this.flpCProject.Location = new System.Drawing.Point(13, 69);
            this.flpCProject.Name = "flpCProject";
            this.flpCProject.Size = new System.Drawing.Size(626, 177);
            this.flpCProject.TabIndex = 3;
            this.flpCProject.WrapContents = false;
            // 
            // PC3
            // 
            this.PC3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.PC3.BorderRadius = 16;
            this.PC3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PC3.Description = "Calcular interés";
            this.PC3.ForeColor = System.Drawing.Color.Black;
            this.PC3.Letter = "CI";
            this.PC3.Location = new System.Drawing.Point(471, 3);
            this.PC3.Name = "PC3";
            this.PC3.NameProject = "";
            this.PC3.Size = new System.Drawing.Size(150, 150);
            this.PC3.TabIndex = 3;
            // 
            // PC4
            // 
            this.PC4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(144)))));
            this.PC4.BorderRadius = 16;
            this.PC4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PC4.Description = "Amortización";
            this.PC4.ForeColor = System.Drawing.Color.Black;
            this.PC4.Letter = "A";
            this.PC4.Location = new System.Drawing.Point(627, 3);
            this.PC4.Name = "PC4";
            this.PC4.NameProject = "";
            this.PC4.Size = new System.Drawing.Size(150, 150);
            this.PC4.TabIndex = 5;
            // 
            // PC5
            // 
            this.PC5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(232)))));
            this.PC5.BorderRadius = 16;
            this.PC5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PC5.Description = "Depreciación";
            this.PC5.ForeColor = System.Drawing.Color.Black;
            this.PC5.Letter = "D";
            this.PC5.Location = new System.Drawing.Point(783, 3);
            this.PC5.Name = "PC5";
            this.PC5.NameProject = "";
            this.PC5.Size = new System.Drawing.Size(150, 150);
            this.PC5.TabIndex = 5;
            // 
            // PC6
            // 
            this.PC6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(157)))), ((int)(((byte)(156)))));
            this.PC6.BorderRadius = 16;
            this.PC6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PC6.Description = "Flujo neto de efectivo";
            this.PC6.ForeColor = System.Drawing.Color.Black;
            this.PC6.Letter = "FNE";
            this.PC6.Location = new System.Drawing.Point(939, 3);
            this.PC6.Name = "PC6";
            this.PC6.NameProject = "";
            this.PC6.Size = new System.Drawing.Size(150, 150);
            this.PC6.TabIndex = 4;
            // 
            // flpProjects
            // 
            this.flpProjects.AutoScroll = true;
            this.flpProjects.Location = new System.Drawing.Point(12, 252);
            this.flpProjects.Name = "flpProjects";
            this.flpProjects.Size = new System.Drawing.Size(651, 369);
            this.flpProjects.TabIndex = 4;
            // 
            // PbClose
            // 
            this.PbClose.BackColor = System.Drawing.Color.Transparent;
            this.PbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbClose.Image = ((System.Drawing.Image)(resources.GetObject("PbClose.Image")));
            this.PbClose.Location = new System.Drawing.Point(869, 8);
            this.PbClose.Name = "PbClose";
            this.PbClose.Size = new System.Drawing.Size(13, 13);
            this.PbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbClose.TabIndex = 52;
            this.PbClose.TabStop = false;
            this.PbClose.Click += new System.EventHandler(this.PbClose_Click);
            // 
            // FadeIn
            // 
            this.FadeIn.Enabled = true;
            this.FadeIn.Interval = 30;
            this.FadeIn.Tick += new System.EventHandler(this.FadeIn_Tick);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtSearch.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtSearch.BorderRadius = 6;
            this.txtSearch.BorderSize = 2;
            this.txtSearch.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearch.Location = new System.Drawing.Point(16, 29);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSearch.PasswordChar = false;
            this.txtSearch.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(164)))), ((int)(((byte)(163)))));
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.Size = new System.Drawing.Size(619, 33);
            this.txtSearch.TabIndex = 53;
            this.txtSearch.Texts = "";
            this.txtSearch.UnderlinedStyle = false;
            this.txtSearch._TextChanged += new System.EventHandler(this.txtSearch__TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.Color.Silver;
            this.lblName.Location = new System.Drawing.Point(41, 7);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(114, 18);
            this.lblName.TabIndex = 54;
            this.lblName.Text = "Buscar por nombre";
            // 
            // txtProjectName
            // 
            this.txtProjectName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtProjectName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtProjectName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtProjectName.BorderRadius = 6;
            this.txtProjectName.BorderSize = 2;
            this.txtProjectName.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProjectName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtProjectName.Location = new System.Drawing.Point(672, 107);
            this.txtProjectName.Margin = new System.Windows.Forms.Padding(4);
            this.txtProjectName.Multiline = false;
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtProjectName.PasswordChar = false;
            this.txtProjectName.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(164)))), ((int)(((byte)(163)))));
            this.txtProjectName.PlaceholderText = "";
            this.txtProjectName.Size = new System.Drawing.Size(205, 33);
            this.txtProjectName.TabIndex = 55;
            this.txtProjectName.Texts = "";
            this.txtProjectName.UnderlinedStyle = false;
            this.txtProjectName.Visible = false;
            this.txtProjectName._TextChanged += new System.EventHandler(this.txtNameProject__TextChanged);
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.BackColor = System.Drawing.Color.Transparent;
            this.lblProjectName.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProjectName.ForeColor = System.Drawing.Color.Silver;
            this.lblProjectName.Location = new System.Drawing.Point(676, 87);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(127, 18);
            this.lblProjectName.TabIndex = 56;
            this.lblProjectName.Text = "Nombre del proyecto";
            this.lblProjectName.Visible = false;
            // 
            // lblLetters
            // 
            this.lblLetters.AutoSize = true;
            this.lblLetters.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLetters.ForeColor = System.Drawing.Color.Silver;
            this.lblLetters.Location = new System.Drawing.Point(828, 146);
            this.lblLetters.Name = "lblLetters";
            this.lblLetters.Size = new System.Drawing.Size(0, 18);
            this.lblLetters.TabIndex = 57;
            this.lblLetters.Visible = false;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(179)))), ((int)(((byte)(151)))));
            this.btnCreate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(179)))), ((int)(((byte)(151)))));
            this.btnCreate.BorderColor = System.Drawing.Color.White;
            this.btnCreate.BorderRadius = 20;
            this.btnCreate.BorderSize = 1;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(707, 167);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(135, 43);
            this.btnCreate.TabIndex = 58;
            this.btnCreate.Text = "Crear";
            this.btnCreate.TextColor = System.Drawing.Color.White;
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Visible = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // FormCreateProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(890, 633);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblLetters);
            this.Controls.Add(this.lblProjectName);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.PbClose);
            this.Controls.Add(this.flpProjects);
            this.Controls.Add(this.flpCProject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCreateProject";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCreateProject";
            this.Load += new System.EventHandler(this.FormCreateProject_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormCreateProject_MouseDown);
            this.flpCProject.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BeatifulComponents.ProjectComponent projectComponent1;
        private BeatifulComponents.ProjectComponent PC0;
        private BeatifulComponents.ProjectComponent PC1;
        private BeatifulComponents.ProjectComponent PC2;
        private System.Windows.Forms.FlowLayoutPanel flpCProject;
        private BeatifulComponents.ProjectComponent PC3;
        private BeatifulComponents.ProjectComponent PC4;
        private BeatifulComponents.ProjectComponent PC5;
        private BeatifulComponents.ProjectComponent PC6;
        private System.Windows.Forms.FlowLayoutPanel flpProjects;
        private System.Windows.Forms.PictureBox PbClose;
        private System.Windows.Forms.Timer FadeIn;
        private RJTextBox txtSearch;
        private System.Windows.Forms.Label lblName;
        private RJTextBox txtProjectName;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.Label lblLetters;
        private BeatifulComponents.RJButton btnCreate;
    }
}