using Economy.AppCore.IServices;
using Economy.Domain.Entities;
using Economy.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Economy.Forms
{
    public partial class FormGraphInterest : Form
    {
        #region -> FormShadow

        private const int CS_DropShadow = 0x00020000;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DropShadow;
                return cp;
            }
        }
        #endregion
        #region -> FormBorder
        private int borderRadius = 10;

        private GraphicsPath GetCustomPanelPath(RectangleF rectangle, float radius)
        {
            float curveSize = radius * 2F;
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.StartFigure();
            graphicsPath.AddArc((rectangle.Width - curveSize), rectangle.Height - curveSize, curveSize, curveSize, 0, 90);
            graphicsPath.AddArc(rectangle.X, (rectangle.Height - curveSize), curveSize, curveSize, 90, 90);
            graphicsPath.AddArc(rectangle.X, rectangle.Y, curveSize, curveSize, 180, 90);
            graphicsPath.AddArc((rectangle.Width - curveSize), rectangle.Y, curveSize, curveSize, 270, 90);
            graphicsPath.CloseFigure();
            return graphicsPath;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            RectangleF rectangleF = new RectangleF(0, 0, this.Width, this.Height);

            if (borderRadius > 2)
            {
                using (GraphicsPath graphicsPath = GetCustomPanelPath(rectangleF, borderRadius))
                using (Pen pen = new Pen(this.BackColor, 2))
                {

                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    this.Region = new Region(graphicsPath);

                    e.Graphics.DrawPath(pen, graphicsPath);
                }

            }
            else this.Region = new Region(rectangleF);

        }

        #endregion

        private int TotalPeriod = -1;
        private Project Project;

        #region -> Interests service
        public IInterestServices<Annuity> AnnuityServices { get; set; }
        public IInterestServices<Serie> SerieServices { get; set; }
        public IInterestServices<Interest> InterestServices { get; set; }
        #endregion
        public FormGraphInterest(Project project)
        {
            this.Project = project;
            InitializeComponent();

        }

        #region -> form movement

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

        private void pnGraph_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormGraphInterest_Load(object sender, EventArgs e)
        {
            this.cmbTypeIdgv.Items.AddRange(Enum.GetValues(typeof(TypeSA)).Cast<object>().ToArray());
            this.cmbTypeSA.Items.AddRange(Enum.GetValues(typeof(TypeSA)).Cast<object>().ToArray());
            this.cmbTypeSerie.Items.AddRange(Enum.GetValues(typeof(TypeSeries)).Cast<object>().ToArray());
            this.cmbFlowType.Items.AddRange(Enum.GetValues(typeof(FlowType)).Cast<object>().ToArray());

            this.txtDuration.KeyPress += new KeyPressEventHandler(ValidateNumberAndPoint);
            this.txtInitial.KeyPress += new KeyPressEventHandler(ValidateNumberAndPoint);
            this.txtEnd.KeyPress += new KeyPressEventHandler(ValidateNumberAndPoint);
            this.txtDownPayment.KeyPress += new KeyPressEventHandler(ValidateNumber);
            this.txtFinalPayment.KeyPress += new KeyPressEventHandler(ValidateNumber);
            this.txtQuantity.KeyPress += new KeyPressEventHandler(ValidateNumber);
            this.txtRate.KeyPress += new KeyPressEventHandler(ValidateNumber);

        }

        private void ValidateNumberAndPoint(object sender, KeyPressEventArgs e)
        {

            if (Char.IsPunctuation(e.KeyChar) || Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Unable to letters or Punctuation marks");
            }
            if (e.KeyChar == 44)
            {
                e.Handled = true;
                MessageBox.Show("Unable comma");
            }

            if (e.KeyChar.ToString() == "=")
            {
                e.Handled = true;
                MessageBox.Show("Unable equal");
            }

            if (e.KeyChar.ToString() == "+")
            {
                e.Handled = true;
                MessageBox.Show("Unable sum");
            }

        }
        private void ValidateNumber(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Unable to letters");
            }
            if (e.KeyChar == 44)
            {
                e.Handled = true;
                MessageBox.Show("Unable comma");
            }
            if (e.KeyChar.ToString() == "-")
            {
                e.Handled = true;
                MessageBox.Show("Unable minus");
            }
            if (e.KeyChar.ToString() == "=")
            {
                e.Handled = true;
                MessageBox.Show("Unable equal");
            }

            if (e.KeyChar.ToString() == "+")
            {
                e.Handled = true;
                MessageBox.Show("Unable sum");
            }


        }
        private void lblQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Unable to letters");
            }
            if (e.KeyChar == 44)
            {
                e.Handled = true;
                MessageBox.Show("Unable comma");
            }
            if (e.KeyChar.ToString() == "=")
            {
                e.Handled = true;
                MessageBox.Show("Unable equal");
            }

            if (e.KeyChar.ToString() == "+")
            {
                e.Handled = true;
                MessageBox.Show("Unable sum");
            }
        }

        private void pbNext_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtDuration.Texts))
            {
                MessageBox.Show("Write the total period");
                return;
            }
            TotalPeriod = Convert.ToInt32(txtDuration.Texts);
            ActivateForm();


        }
        private void ActivateForm()
        {
            lblDuration.Visible = false;
            txtDuration.Visible = false;
            pbNext.Visible = false;
            lblTI.Visible = true;
            cmbTypeSA.Visible = true;
        }

        #region -> form function
        private void AnnuityFunction()
        {
            lblInitial.Visible = true;
            txtInitial.Visible = true;
            lblEnd.Visible = true;
            txtEnd.Visible = true;
            lblRate.Visible = true;
            txtRate.Visible = true;
            lblFlowType.Visible = true;
            cmbFlowType.Visible = true;
            lblWI.Visible = true;
            lblWI.Text = "C$";
            txtQuantity.Visible = true;
        }
        private void SerieFunction()
        {
            lblTypeSerie.Visible = true;
            cmbTypeSerie.Visible = true;
            cmbTypeSerie.SelectedIndex = -1;
            lblDecremental.Visible = true;
            cbDecremental.Visible = true;
            lblInitial.Visible = true;
            txtInitial.Visible = true;
            lblEnd.Visible = true;
            txtEnd.Visible = true;
            lblRate.Visible = true;
            txtRate.Visible = true;
            lblFlowType.Visible = true;
            cmbFlowType.Visible = true;
            lblDownPayment.Visible = true;
            txtDownPayment.Visible = true;
            lblFinalPayment.Visible = true;
            txtFinalPayment.Visible = true;
        }

        private void InterestFunction()
        {
            lblInitial.Visible = true;
            txtInitial.Visible = true;
            lblWI.Visible = true;
            lblWI.Text = "C$";
            txtQuantity.Visible = true;
            lblRate.Visible = true;
            txtRate.Visible = true;
            lblFlowType.Visible = true;
            cmbFlowType.Visible = true;
        }
        private void ChangeVisibleForm()
        {
            lblTypeSerie.Visible = false;
            cmbTypeSerie.Visible = false;
            lblDecremental.Visible = false;
            cbDecremental.Visible = false;
            lblInitial.Visible = false;
            txtInitial.Visible = false;
            lblEnd.Visible = false;
            txtEnd.Visible = false;
            lblRate.Visible = false;
            txtRate.Visible = false;
            lblFlowType.Visible = false;
            cmbFlowType.Visible = false;
            lblWI.Visible = false;
            txtQuantity.Visible = false;
            lblDownPayment.Visible = false;
            txtDownPayment.Visible = false;
            lblFinalPayment.Visible = false;
            txtFinalPayment.Visible = false;
        }
        #endregion
        private void cmbTypeSA_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            /*
             * 0 = Annuity
             * 1= serie
             * 2=Interest
             * 
             */
            if (cmbTypeSA.SelectedIndex > -1)
            {
                btnCreate.Visible = true;
                if (cmbTypeSA.SelectedIndex == 0)
                {
                    ChangeVisibleForm();
                    AnnuityFunction();
                }
                if (cmbTypeSA.SelectedIndex == 1)
                {
                    ChangeVisibleForm();
                    SerieFunction();
                }
                if (cmbTypeSA.SelectedIndex == 2)
                {
                    ChangeVisibleForm();
                    InterestFunction();
                }
            }
            else
            {
                btnCreate.Visible = true;
                ChangeVisibleForm();
            }
        }



        private void cmbTypeSerie_OnSelectedIndexChanged_1(object sender, EventArgs e)
        {

            if (cmbTypeSerie.SelectedIndex > -1)
            {
                lblWI.Visible = true;
                txtQuantity.Visible = true;
                if (cmbTypeSerie.SelectedIndex == 0)
                {
                    lblWI.Text = "G";
                }
                if (cmbTypeSerie.SelectedIndex == 1)
                {
                    lblWI.Text = "rate j%";
                }
            }
        }

        private void pnGraph_Paint(object sender, PaintEventArgs e)
        {

        }
        #region -> Interest rate validators
        private bool ValidateFormAnnuity()
        {
            if (String.IsNullOrEmpty(txtInitial.Texts)
                || String.IsNullOrEmpty(txtEnd.Texts)
                || String.IsNullOrEmpty(txtRate.Texts)
                || cmbFlowType.SelectedIndex < 0
                || String.IsNullOrEmpty(txtQuantity.Texts)
                )
            {
                return false;
            }

            return true;
        }

        private bool ValidateFormInterest()
        {
            if (String.IsNullOrEmpty(txtInitial.Texts)
                || String.IsNullOrEmpty(txtQuantity.Texts)
                || string.IsNullOrEmpty(txtRate.Texts)
                || cmbFlowType.SelectedIndex < 0)
            {
                return false;
            }
            return true;
        }
        private bool ValidateFormSeriePayment()
        {
            if (String.IsNullOrEmpty(txtFinalPayment.Texts)
                && String.IsNullOrEmpty(txtDownPayment.Texts)
                && String.IsNullOrEmpty(txtQuantity.Texts))
            {
                return false;
            }
            else if (String.IsNullOrEmpty(txtQuantity.Texts)
                && String.IsNullOrEmpty(txtDownPayment.Texts))
            {
                return false;
            }
            else if (String.IsNullOrEmpty(txtQuantity.Texts)
                && String.IsNullOrEmpty(txtFinalPayment.Texts))
            {
                return false;
            }
            else if (String.IsNullOrEmpty(txtFinalPayment.Texts)
                && String.IsNullOrEmpty(txtDownPayment.Texts))
            {
                return false;
            }
            return true;
        }
        private bool ValidateFormSerie()
        {
            if (String.IsNullOrEmpty(txtInitial.Texts)
                || String.IsNullOrEmpty(txtEnd.Texts)
                || String.IsNullOrEmpty(txtRate.Texts)
                || cmbFlowType.SelectedIndex < 0
                || cmbTypeSerie.SelectedIndex < 0
            )
            {
                return false;
            }
            return true;
        }
        #endregion
        private void btnCreate_Click(object sender, EventArgs e)
        {

            /*
             * 0 = Annuity
             * 1= serie
             * 2=Interest
             * 
             */
            
            try
            {
                if (cmbTypeSA.SelectedIndex == 0)
                {
                    if (!ValidateFormAnnuity())
                    {
                        MessageBox.Show("Fill out the entire form");
                        return;
                    }
                    Annuity annuity = new Annuity
                    {
                        ProjectId=Project.Id,
                        FlowType=((FlowType)cmbFlowType.SelectedIndex).ToString(),
                        Initial=Convert.ToInt32(txtInitial.Texts),
                        End=Convert.ToInt32(txtEnd.Texts),
                        Payment=Convert.ToDecimal(txtQuantity.Texts),
                        Rate=Convert.ToDecimal(txtRate.Texts),
                        Project=Project,
                        TotalPeriod=TotalPeriod
                    };
                    this.AnnuityServices.Create(annuity);
                }
                else if (cmbTypeSA.SelectedIndex == 1)
                {
                    if (!ValidateFormSerie())
                    {
                        MessageBox.Show("Fill out the entire form");
                        return;
                    }
                    if (!ValidateFormSeriePayment())
                    {
                        MessageBox.Show("It is only allowed for a box to be empty, fill in the others (downpayment, finalPayment, Quantity)");
                        return;
                    }
                 
                    decimal prueba =string.IsNullOrEmpty(txtFinalPayment.Texts)==true?0 : Convert.ToDecimal(txtFinalPayment.Texts);
                    Serie serie = new Serie
                    {
                        DownPayment= string.IsNullOrEmpty(txtDownPayment.Texts) == true ? 0.0M : Convert.ToDecimal(txtDownPayment.Texts),
                        FinalPayment= string.IsNullOrEmpty(txtFinalPayment.Texts) == true ? 0.0M : Convert.ToDecimal(txtFinalPayment.Texts),
                        Initial=Convert.ToInt32(txtInitial.Texts),
                        End=Convert.ToInt32(txtEnd.Texts),
                        FlowType=((FlowType)cmbFlowType.SelectedIndex).ToString(),
                        Project=Project,
                        ProjectId=Project.Id,
                        Incremental=cbDecremental.Checked==true ? false : true,
                        Quantity=string.IsNullOrEmpty(txtQuantity.Texts)==true ?0.0M : Convert.ToDecimal(txtQuantity.Texts),
                        Rate=Convert.ToDecimal(txtRate.Texts),
                        TotalPeriod=TotalPeriod,
                        Type=((TypeSeries)cmbTypeSerie.SelectedIndex).ToString()
                    };
                    this.SerieServices.Create(serie);
                }
                else if (cmbTypeSA.SelectedIndex == 2)
                {
                    if (!ValidateFormInterest())
                    {
                        MessageBox.Show("Fill out the entire form");
                        return;
                    }
                    Interest interest = new Interest
                    {
                        Initial=Convert.ToInt32(txtInitial.Texts),
                        End=Convert.ToInt32(txtInitial.Texts),
                        FlowType=((FlowType)cmbFlowType.SelectedIndex).ToString(),
                        Project=Project,
                        ProjectId=Project.Id,
                        Rate=Convert.ToDecimal(txtRate.Texts),
                        Payment=Convert.ToDecimal(txtQuantity.Texts),
                        TotalPeriod=TotalPeriod
                    };
                    this.InterestServices.Create(interest);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            lblTypeIdgv.Visible = true;
            cmbTypeIdgv.Visible = true;
            customPanel1.Visible = true;
        }
    }
}
