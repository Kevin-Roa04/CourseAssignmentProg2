
namespace Economy.Forms
{
    partial class FormGraphInterest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGraphInterest));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbDecremental = new System.Windows.Forms.CheckBox();
            this.lblRate = new System.Windows.Forms.Label();
            this.txtRate = new Economy.RJTextBox();
            this.lblFinalPayment = new System.Windows.Forms.Label();
            this.lblDownPayment = new System.Windows.Forms.Label();
            this.txtFinalPayment = new Economy.RJTextBox();
            this.txtDownPayment = new Economy.RJTextBox();
            this.btnCreate = new Economy.BeatifulComponents.RJButton();
            this.txtQuantity = new Economy.RJTextBox();
            this.lblWI = new System.Windows.Forms.Label();
            this.lblDecremental = new System.Windows.Forms.Label();
            this.lblFlowType = new System.Windows.Forms.Label();
            this.cmbFlowType = new Economy.BeatifulComponents.RJComboBox();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblInitial = new System.Windows.Forms.Label();
            this.txtEnd = new Economy.RJTextBox();
            this.txtInitial = new Economy.RJTextBox();
            this.lblTypeSerie = new System.Windows.Forms.Label();
            this.cmbTypeSerie = new Economy.BeatifulComponents.RJComboBox();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblTI = new System.Windows.Forms.Label();
            this.cmbTypeSA = new Economy.BeatifulComponents.RJComboBox();
            this.pbNext = new System.Windows.Forms.PictureBox();
            this.txtDuration = new Economy.RJTextBox();
            this.customPanel1 = new Economy.BeatifulComponents.CustomPanel();
            this.dgvInterest = new System.Windows.Forms.DataGridView();
            this.cmbTypeIdgv = new Economy.BeatifulComponents.RJComboBox();
            this.lblTypeIdgv = new System.Windows.Forms.Label();
            this.graph = new System.Windows.Forms.Panel();
            this.lblPresent = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).BeginInit();
            this.customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInterest)).BeginInit();
            this.graph.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbDecremental);
            this.panel1.Controls.Add(this.lblRate);
            this.panel1.Controls.Add(this.txtRate);
            this.panel1.Controls.Add(this.lblFinalPayment);
            this.panel1.Controls.Add(this.lblDownPayment);
            this.panel1.Controls.Add(this.txtFinalPayment);
            this.panel1.Controls.Add(this.txtDownPayment);
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Controls.Add(this.txtQuantity);
            this.panel1.Controls.Add(this.lblWI);
            this.panel1.Controls.Add(this.lblDecremental);
            this.panel1.Controls.Add(this.lblFlowType);
            this.panel1.Controls.Add(this.cmbFlowType);
            this.panel1.Controls.Add(this.lblEnd);
            this.panel1.Controls.Add(this.lblInitial);
            this.panel1.Controls.Add(this.txtEnd);
            this.panel1.Controls.Add(this.txtInitial);
            this.panel1.Controls.Add(this.lblTypeSerie);
            this.panel1.Controls.Add(this.cmbTypeSerie);
            this.panel1.Controls.Add(this.lblDuration);
            this.panel1.Controls.Add(this.lblTI);
            this.panel1.Controls.Add(this.cmbTypeSA);
            this.panel1.Controls.Add(this.pbNext);
            this.panel1.Controls.Add(this.txtDuration);
            this.panel1.Location = new System.Drawing.Point(7, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 681);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // cbDecremental
            // 
            this.cbDecremental.AutoSize = true;
            this.cbDecremental.Location = new System.Drawing.Point(121, 213);
            this.cbDecremental.Name = "cbDecremental";
            this.cbDecremental.Size = new System.Drawing.Size(15, 14);
            this.cbDecremental.TabIndex = 40;
            this.cbDecremental.UseVisualStyleBackColor = true;
            this.cbDecremental.Visible = false;
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(164)))), ((int)(((byte)(163)))));
            this.lblRate.Location = new System.Drawing.Point(50, 347);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(47, 18);
            this.lblRate.TabIndex = 39;
            this.lblRate.Text = "Rate i%";
            this.lblRate.Visible = false;
            // 
            // txtRate
            // 
            this.txtRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtRate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtRate.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtRate.BorderRadius = 6;
            this.txtRate.BorderSize = 2;
            this.txtRate.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRate.Location = new System.Drawing.Point(103, 339);
            this.txtRate.Margin = new System.Windows.Forms.Padding(4);
            this.txtRate.Multiline = false;
            this.txtRate.Name = "txtRate";
            this.txtRate.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtRate.PasswordChar = false;
            this.txtRate.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(164)))), ((int)(((byte)(163)))));
            this.txtRate.PlaceholderText = "";
            this.txtRate.Size = new System.Drawing.Size(77, 33);
            this.txtRate.TabIndex = 38;
            this.txtRate.Texts = "";
            this.txtRate.UnderlinedStyle = false;
            this.txtRate.Visible = false;
            // 
            // lblFinalPayment
            // 
            this.lblFinalPayment.AutoSize = true;
            this.lblFinalPayment.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFinalPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(164)))), ((int)(((byte)(163)))));
            this.lblFinalPayment.Location = new System.Drawing.Point(169, 524);
            this.lblFinalPayment.Name = "lblFinalPayment";
            this.lblFinalPayment.Size = new System.Drawing.Size(84, 18);
            this.lblFinalPayment.TabIndex = 37;
            this.lblFinalPayment.Text = "Final payment\r\n";
            this.lblFinalPayment.Visible = false;
            // 
            // lblDownPayment
            // 
            this.lblDownPayment.AutoSize = true;
            this.lblDownPayment.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDownPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(164)))), ((int)(((byte)(163)))));
            this.lblDownPayment.Location = new System.Drawing.Point(44, 524);
            this.lblDownPayment.Name = "lblDownPayment";
            this.lblDownPayment.Size = new System.Drawing.Size(89, 18);
            this.lblDownPayment.TabIndex = 36;
            this.lblDownPayment.Text = "Down payment";
            this.lblDownPayment.Visible = false;
            // 
            // txtFinalPayment
            // 
            this.txtFinalPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtFinalPayment.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtFinalPayment.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtFinalPayment.BorderRadius = 6;
            this.txtFinalPayment.BorderSize = 2;
            this.txtFinalPayment.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFinalPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFinalPayment.Location = new System.Drawing.Point(162, 546);
            this.txtFinalPayment.Margin = new System.Windows.Forms.Padding(4);
            this.txtFinalPayment.Multiline = false;
            this.txtFinalPayment.Name = "txtFinalPayment";
            this.txtFinalPayment.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtFinalPayment.PasswordChar = false;
            this.txtFinalPayment.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(164)))), ((int)(((byte)(163)))));
            this.txtFinalPayment.PlaceholderText = "";
            this.txtFinalPayment.Size = new System.Drawing.Size(101, 33);
            this.txtFinalPayment.TabIndex = 35;
            this.txtFinalPayment.Texts = "";
            this.txtFinalPayment.UnderlinedStyle = false;
            this.txtFinalPayment.Visible = false;
            // 
            // txtDownPayment
            // 
            this.txtDownPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtDownPayment.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtDownPayment.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtDownPayment.BorderRadius = 6;
            this.txtDownPayment.BorderSize = 2;
            this.txtDownPayment.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDownPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDownPayment.Location = new System.Drawing.Point(35, 546);
            this.txtDownPayment.Margin = new System.Windows.Forms.Padding(4);
            this.txtDownPayment.Multiline = false;
            this.txtDownPayment.Name = "txtDownPayment";
            this.txtDownPayment.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDownPayment.PasswordChar = false;
            this.txtDownPayment.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(164)))), ((int)(((byte)(163)))));
            this.txtDownPayment.PlaceholderText = "";
            this.txtDownPayment.Size = new System.Drawing.Size(101, 33);
            this.txtDownPayment.TabIndex = 34;
            this.txtDownPayment.Texts = "";
            this.txtDownPayment.UnderlinedStyle = false;
            this.txtDownPayment.Visible = false;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(179)))), ((int)(((byte)(151)))));
            this.btnCreate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(179)))), ((int)(((byte)(151)))));
            this.btnCreate.BorderColor = System.Drawing.Color.White;
            this.btnCreate.BorderRadius = 25;
            this.btnCreate.BorderSize = 1;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(79, 614);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(159, 49);
            this.btnCreate.TabIndex = 33;
            this.btnCreate.Text = "Create";
            this.btnCreate.TextColor = System.Drawing.Color.White;
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Visible = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtQuantity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtQuantity.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtQuantity.BorderRadius = 6;
            this.txtQuantity.BorderSize = 2;
            this.txtQuantity.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtQuantity.Location = new System.Drawing.Point(162, 458);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantity.Multiline = false;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtQuantity.PasswordChar = false;
            this.txtQuantity.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(164)))), ((int)(((byte)(163)))));
            this.txtQuantity.PlaceholderText = "";
            this.txtQuantity.Size = new System.Drawing.Size(101, 33);
            this.txtQuantity.TabIndex = 32;
            this.txtQuantity.Texts = "";
            this.txtQuantity.UnderlinedStyle = false;
            this.txtQuantity.Visible = false;
            this.txtQuantity._TextChanged += new System.EventHandler(this.txtQuantity__TextChanged);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lblQuantity_KeyPress);
            // 
            // lblWI
            // 
            this.lblWI.AutoSize = true;
            this.lblWI.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(164)))), ((int)(((byte)(163)))));
            this.lblWI.Location = new System.Drawing.Point(32, 466);
            this.lblWI.Name = "lblWI";
            this.lblWI.Size = new System.Drawing.Size(115, 18);
            this.lblWI.TabIndex = 31;
            this.lblWI.Text = "Waiting for interest";
            this.lblWI.Visible = false;
            // 
            // lblDecremental
            // 
            this.lblDecremental.AutoSize = true;
            this.lblDecremental.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDecremental.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(164)))), ((int)(((byte)(163)))));
            this.lblDecremental.Location = new System.Drawing.Point(35, 212);
            this.lblDecremental.Name = "lblDecremental";
            this.lblDecremental.Size = new System.Drawing.Size(78, 18);
            this.lblDecremental.TabIndex = 30;
            this.lblDecremental.Text = "Decremental\r\n";
            this.lblDecremental.Visible = false;
            // 
            // lblFlowType
            // 
            this.lblFlowType.AutoSize = true;
            this.lblFlowType.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFlowType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(164)))), ((int)(((byte)(163)))));
            this.lblFlowType.Location = new System.Drawing.Point(33, 404);
            this.lblFlowType.Name = "lblFlowType";
            this.lblFlowType.Size = new System.Drawing.Size(59, 18);
            this.lblFlowType.TabIndex = 29;
            this.lblFlowType.Text = "FlowType";
            this.lblFlowType.Visible = false;
            // 
            // cmbFlowType
            // 
            this.cmbFlowType.BackColor = System.Drawing.Color.White;
            this.cmbFlowType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.cmbFlowType.BorderSize = 1;
            this.cmbFlowType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbFlowType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbFlowType.ForeColor = System.Drawing.Color.DimGray;
            this.cmbFlowType.IconColor = System.Drawing.Color.Gray;
            this.cmbFlowType.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbFlowType.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbFlowType.Location = new System.Drawing.Point(120, 398);
            this.cmbFlowType.Name = "cmbFlowType";
            this.cmbFlowType.Padding = new System.Windows.Forms.Padding(1);
            this.cmbFlowType.Size = new System.Drawing.Size(130, 30);
            this.cmbFlowType.TabIndex = 28;
            this.cmbFlowType.Texts = "";
            this.cmbFlowType.Visible = false;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(164)))), ((int)(((byte)(163)))));
            this.lblEnd.Location = new System.Drawing.Point(210, 253);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(28, 18);
            this.lblEnd.TabIndex = 27;
            this.lblEnd.Text = "End";
            this.lblEnd.Visible = false;
            // 
            // lblInitial
            // 
            this.lblInitial.AutoSize = true;
            this.lblInitial.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInitial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(164)))), ((int)(((byte)(163)))));
            this.lblInitial.Location = new System.Drawing.Point(76, 253);
            this.lblInitial.Name = "lblInitial";
            this.lblInitial.Size = new System.Drawing.Size(38, 18);
            this.lblInitial.TabIndex = 26;
            this.lblInitial.Text = "Initial";
            this.lblInitial.Visible = false;
            // 
            // txtEnd
            // 
            this.txtEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtEnd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtEnd.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtEnd.BorderRadius = 6;
            this.txtEnd.BorderSize = 2;
            this.txtEnd.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEnd.Location = new System.Drawing.Point(176, 275);
            this.txtEnd.Margin = new System.Windows.Forms.Padding(4);
            this.txtEnd.Multiline = false;
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtEnd.PasswordChar = false;
            this.txtEnd.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(164)))), ((int)(((byte)(163)))));
            this.txtEnd.PlaceholderText = "";
            this.txtEnd.Size = new System.Drawing.Size(101, 33);
            this.txtEnd.TabIndex = 25;
            this.txtEnd.Texts = "";
            this.txtEnd.UnderlinedStyle = false;
            this.txtEnd.Visible = false;
            // 
            // txtInitial
            // 
            this.txtInitial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtInitial.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtInitial.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtInitial.BorderRadius = 6;
            this.txtInitial.BorderSize = 2;
            this.txtInitial.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtInitial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtInitial.Location = new System.Drawing.Point(46, 275);
            this.txtInitial.Margin = new System.Windows.Forms.Padding(4);
            this.txtInitial.Multiline = false;
            this.txtInitial.Name = "txtInitial";
            this.txtInitial.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtInitial.PasswordChar = false;
            this.txtInitial.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(164)))), ((int)(((byte)(163)))));
            this.txtInitial.PlaceholderText = "";
            this.txtInitial.Size = new System.Drawing.Size(101, 33);
            this.txtInitial.TabIndex = 24;
            this.txtInitial.Texts = "";
            this.txtInitial.UnderlinedStyle = false;
            this.txtInitial.Visible = false;
            // 
            // lblTypeSerie
            // 
            this.lblTypeSerie.AutoSize = true;
            this.lblTypeSerie.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTypeSerie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(164)))), ((int)(((byte)(163)))));
            this.lblTypeSerie.Location = new System.Drawing.Point(33, 161);
            this.lblTypeSerie.Name = "lblTypeSerie";
            this.lblTypeSerie.Size = new System.Drawing.Size(65, 18);
            this.lblTypeSerie.TabIndex = 23;
            this.lblTypeSerie.Text = "Serie type";
            this.lblTypeSerie.Visible = false;
            // 
            // cmbTypeSerie
            // 
            this.cmbTypeSerie.BackColor = System.Drawing.Color.White;
            this.cmbTypeSerie.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.cmbTypeSerie.BorderSize = 1;
            this.cmbTypeSerie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbTypeSerie.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbTypeSerie.ForeColor = System.Drawing.Color.DimGray;
            this.cmbTypeSerie.IconColor = System.Drawing.Color.Gray;
            this.cmbTypeSerie.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbTypeSerie.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbTypeSerie.Location = new System.Drawing.Point(120, 156);
            this.cmbTypeSerie.Name = "cmbTypeSerie";
            this.cmbTypeSerie.Padding = new System.Windows.Forms.Padding(1);
            this.cmbTypeSerie.Size = new System.Drawing.Size(130, 30);
            this.cmbTypeSerie.TabIndex = 22;
            this.cmbTypeSerie.Texts = "";
            this.cmbTypeSerie.Visible = false;
            this.cmbTypeSerie.OnSelectedIndexChanged += new System.EventHandler(this.cmbTypeSerie_OnSelectedIndexChanged_1);
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDuration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(164)))), ((int)(((byte)(163)))));
            this.lblDuration.Location = new System.Drawing.Point(33, 35);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(55, 18);
            this.lblDuration.TabIndex = 21;
            this.lblDuration.Text = "Duration\r\n";
            // 
            // lblTI
            // 
            this.lblTI.AutoSize = true;
            this.lblTI.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(164)))), ((int)(((byte)(163)))));
            this.lblTI.Location = new System.Drawing.Point(35, 104);
            this.lblTI.Name = "lblTI";
            this.lblTI.Size = new System.Drawing.Size(81, 18);
            this.lblTI.TabIndex = 20;
            this.lblTI.Text = "Interest type";
            this.lblTI.Visible = false;
            // 
            // cmbTypeSA
            // 
            this.cmbTypeSA.BackColor = System.Drawing.Color.White;
            this.cmbTypeSA.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.cmbTypeSA.BorderSize = 1;
            this.cmbTypeSA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbTypeSA.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbTypeSA.ForeColor = System.Drawing.Color.DimGray;
            this.cmbTypeSA.IconColor = System.Drawing.Color.Gray;
            this.cmbTypeSA.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbTypeSA.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbTypeSA.Location = new System.Drawing.Point(120, 97);
            this.cmbTypeSA.Name = "cmbTypeSA";
            this.cmbTypeSA.Padding = new System.Windows.Forms.Padding(1);
            this.cmbTypeSA.Size = new System.Drawing.Size(130, 30);
            this.cmbTypeSA.TabIndex = 18;
            this.cmbTypeSA.Texts = "";
            this.cmbTypeSA.Visible = false;
            this.cmbTypeSA.OnSelectedIndexChanged += new System.EventHandler(this.cmbTypeSA_OnSelectedIndexChanged);
            // 
            // pbNext
            // 
            this.pbNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbNext.Image = ((System.Drawing.Image)(resources.GetObject("pbNext.Image")));
            this.pbNext.Location = new System.Drawing.Point(212, 33);
            this.pbNext.Name = "pbNext";
            this.pbNext.Size = new System.Drawing.Size(25, 24);
            this.pbNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNext.TabIndex = 17;
            this.pbNext.TabStop = false;
            this.pbNext.Click += new System.EventHandler(this.pbNext_Click);
            // 
            // txtDuration
            // 
            this.txtDuration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtDuration.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtDuration.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.txtDuration.BorderRadius = 6;
            this.txtDuration.BorderSize = 2;
            this.txtDuration.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDuration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDuration.Location = new System.Drawing.Point(100, 28);
            this.txtDuration.Margin = new System.Windows.Forms.Padding(4);
            this.txtDuration.Multiline = false;
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDuration.PasswordChar = false;
            this.txtDuration.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(164)))), ((int)(((byte)(163)))));
            this.txtDuration.PlaceholderText = "";
            this.txtDuration.Size = new System.Drawing.Size(101, 33);
            this.txtDuration.TabIndex = 16;
            this.txtDuration.Texts = "";
            this.txtDuration.UnderlinedStyle = false;
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderRadius = 18;
            this.customPanel1.Controls.Add(this.dgvInterest);
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 90F;
            this.customPanel1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(179)))), ((int)(((byte)(151)))));
            this.customPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(179)))), ((int)(((byte)(151)))));
            this.customPanel1.Location = new System.Drawing.Point(365, 378);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(685, 313);
            this.customPanel1.TabIndex = 43;
            this.customPanel1.Visible = false;
            // 
            // dgvInterest
            // 
            this.dgvInterest.AllowUserToAddRows = false;
            this.dgvInterest.AllowUserToDeleteRows = false;
            this.dgvInterest.BackgroundColor = System.Drawing.Color.White;
            this.dgvInterest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInterest.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvInterest.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(179)))), ((int)(((byte)(151)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInterest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInterest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInterest.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInterest.EnableHeadersVisualStyles = false;
            this.dgvInterest.GridColor = System.Drawing.Color.Linen;
            this.dgvInterest.Location = new System.Drawing.Point(1, 6);
            this.dgvInterest.Name = "dgvInterest";
            this.dgvInterest.ReadOnly = true;
            this.dgvInterest.RowHeadersVisible = false;
            this.dgvInterest.RowTemplate.Height = 25;
            this.dgvInterest.Size = new System.Drawing.Size(683, 307);
            this.dgvInterest.TabIndex = 0;
            this.dgvInterest.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInterest_CellContentClick);
            this.dgvInterest.DoubleClick += new System.EventHandler(this.dgvInterest_DoubleClick);
            // 
            // cmbTypeIdgv
            // 
            this.cmbTypeIdgv.BackColor = System.Drawing.Color.White;
            this.cmbTypeIdgv.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.cmbTypeIdgv.BorderSize = 1;
            this.cmbTypeIdgv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbTypeIdgv.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbTypeIdgv.ForeColor = System.Drawing.Color.DimGray;
            this.cmbTypeIdgv.IconColor = System.Drawing.Color.Gray;
            this.cmbTypeIdgv.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbTypeIdgv.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbTypeIdgv.Location = new System.Drawing.Point(512, 341);
            this.cmbTypeIdgv.Name = "cmbTypeIdgv";
            this.cmbTypeIdgv.Padding = new System.Windows.Forms.Padding(1);
            this.cmbTypeIdgv.Size = new System.Drawing.Size(143, 30);
            this.cmbTypeIdgv.TabIndex = 41;
            this.cmbTypeIdgv.Texts = "";
            this.cmbTypeIdgv.Visible = false;
            this.cmbTypeIdgv.OnSelectedIndexChanged += new System.EventHandler(this.cmbTypeIdgv_OnSelectedIndexChanged);
            // 
            // lblTypeIdgv
            // 
            this.lblTypeIdgv.AutoSize = true;
            this.lblTypeIdgv.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTypeIdgv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(164)))), ((int)(((byte)(163)))));
            this.lblTypeIdgv.Location = new System.Drawing.Point(427, 348);
            this.lblTypeIdgv.Name = "lblTypeIdgv";
            this.lblTypeIdgv.Size = new System.Drawing.Size(81, 18);
            this.lblTypeIdgv.TabIndex = 42;
            this.lblTypeIdgv.Text = "Interest type";
            this.lblTypeIdgv.Visible = false;
            // 
            // graph
            // 
            this.graph.Controls.Add(this.lblPresent);
            this.graph.Location = new System.Drawing.Point(366, 8);
            this.graph.Name = "graph";
            this.graph.Size = new System.Drawing.Size(684, 327);
            this.graph.TabIndex = 44;
            this.graph.Paint += new System.Windows.Forms.PaintEventHandler(this.graph_Paint);
            // 
            // lblPresent
            // 
            this.lblPresent.AutoSize = true;
            this.lblPresent.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPresent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(164)))), ((int)(((byte)(163)))));
            this.lblPresent.Location = new System.Drawing.Point(308, 7);
            this.lblPresent.Name = "lblPresent";
            this.lblPresent.Size = new System.Drawing.Size(54, 18);
            this.lblPresent.TabIndex = 0;
            this.lblPresent.Text = "Present:";
            this.lblPresent.Visible = false;
            // 
            // FormGraphInterest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1062, 703);
            this.Controls.Add(this.graph);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbTypeIdgv);
            this.Controls.Add(this.lblTypeIdgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGraphInterest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGraphInterest";
            this.Load += new System.EventHandler(this.FormGraphInterest_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).EndInit();
            this.customPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInterest)).EndInit();
            this.graph.ResumeLayout(false);
            this.graph.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbNext;
        private RJTextBox txtDuration;
        private BeatifulComponents.RJComboBox cmbTypeSA;
        private RJTextBox txtQuantity;
        private System.Windows.Forms.Label lblWI;
        private System.Windows.Forms.Label lblDecremental;
        private System.Windows.Forms.Label lblFlowType;
        private BeatifulComponents.RJComboBox cmbFlowType;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblInitial;
        private RJTextBox txtEnd;
        private RJTextBox txtInitial;
        private System.Windows.Forms.Label lblTypeSerie;
        private BeatifulComponents.RJComboBox cmbTypeSerie;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblTI;
        private BeatifulComponents.RJButton btnCreate;
        private System.Windows.Forms.Label lblFinalPayment;
        private System.Windows.Forms.Label lblDownPayment;
        private RJTextBox txtFinalPayment;
        private RJTextBox txtDownPayment;
        private System.Windows.Forms.Label lblRate;
        private RJTextBox txtRate;
        private System.Windows.Forms.CheckBox cbDecremental;
        private BeatifulComponents.CustomPanel customPanel1;
        private System.Windows.Forms.DataGridView dgvInterest;
        private BeatifulComponents.RJComboBox cmbTypeIdgv;
        private System.Windows.Forms.Label lblTypeIdgv;
        private System.Windows.Forms.Panel graph;
        private System.Windows.Forms.Label lblPresent;
    }
}