﻿using Economy.AppCore.IServices;
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

      
        private int Coord_x = 0, coord_y;
        Graphics graphics=null;
        private Pen pen = new Pen(color: Color.Black,width:1);

        private int selection = -1;
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
            coord_y = (int)(graph.Height * 0.5);
          
        }
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        
        }
        private void PresentLbl()
        {
            if (SerieServices.GetIdProject(Project.Id).Count > 0 || InterestServices.GetIdProject(Project.Id).Count > 0
                || AnnuityServices.GetIdProject(Project.Id).Count > 0)
            {
                lblPresent.Visible = true;
                decimal SeriePresent = (decimal)SerieServices.FindByOption(x =>x.ProjectId==Project.Id && x.FlowType == FlowType.Entry.ToString()).Sum(x => x.Present) - (decimal)SerieServices.FindByOption(x => x.ProjectId == Project.Id && x.FlowType == FlowType.Exit.ToString()).Sum(x => x.Present);
                decimal InterestPresent = (decimal)InterestServices.FindByOption(x => x.ProjectId == Project.Id && x.FlowType == FlowType.Entry.ToString()).Sum(x => x.Present) - (decimal)InterestServices.FindByOption(x => x.ProjectId == Project.Id && x.FlowType == FlowType.Exit.ToString()).Sum(x => x.Present);
                decimal AnnuityPresent = (decimal)AnnuityServices.FindByOption(x => x.ProjectId == Project.Id && x.FlowType == FlowType.Entry.ToString()).Sum(x => x.Present) - (decimal)AnnuityServices.FindByOption(x => x.ProjectId == Project.Id && x.FlowType == FlowType.Exit.ToString()).Sum(x => x.Present);
                decimal total = (decimal)SeriePresent + InterestPresent + AnnuityPresent;
                total = Math.Abs(total);

                lblPresent.Text = $"Present: C$ {Math.Round(total,2)}";
            }

        }
        private void FormGraphInterest_Load(object sender, EventArgs e)
        {
            this.graphics = graph.CreateGraphics();
            graph.Refresh();
            PresentLbl();
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

    
        private void FillDGV()
        {
            dgvInterest.DataSource = null;
            if (cmbTypeIdgv.SelectedIndex > -1)
            {

                if (cmbTypeIdgv.SelectedIndex == 0)
                {
                    dgvInterest.DataSource = AnnuityServices.GetIdProject(Project.Id);
                }
                if (cmbTypeIdgv.SelectedIndex == 1)
                {
                    dgvInterest.DataSource = SerieServices.GetIdProject(Project.Id);
                }
                if (cmbTypeIdgv.SelectedIndex == 2)
                {
                    dgvInterest.DataSource = InterestServices.GetIdProject(Project.Id);
                }
                dgvInterest.Columns.Remove(dgvInterest.Columns["Project"]);
            }
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
                        ProjectId = Project.Id,
                        FlowType = ((FlowType)cmbFlowType.SelectedIndex).ToString(),
                        Initial = Convert.ToInt32(txtInitial.Texts),
                        End = Convert.ToInt32(txtEnd.Texts),
                        Payment = Convert.ToDecimal(txtQuantity.Texts),
                        Rate = Convert.ToDecimal(txtRate.Texts),
                        Project = Project,
                        TotalPeriod = TotalPeriod
                    };
                    this.AnnuityServices.Create(annuity);
                    DrawAnnuity(annuity);
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

                    decimal prueba = string.IsNullOrEmpty(txtFinalPayment.Texts) == true ? 0 : Convert.ToDecimal(txtFinalPayment.Texts);
                    Serie serie = new Serie
                    {
                        DownPayment = string.IsNullOrEmpty(txtDownPayment.Texts) == true ? 0.0M : Convert.ToDecimal(txtDownPayment.Texts),
                        FinalPayment = string.IsNullOrEmpty(txtFinalPayment.Texts) == true ? 0.0M : Convert.ToDecimal(txtFinalPayment.Texts),
                        Initial = Convert.ToInt32(txtInitial.Texts),
                        End = Convert.ToInt32(txtEnd.Texts),
                        FlowType = ((FlowType)cmbFlowType.SelectedIndex).ToString(),
                        Project = Project,
                        ProjectId = Project.Id,
                        Incremental = cbDecremental.Checked == true ? false : true,
                        Quantity = string.IsNullOrEmpty(txtQuantity.Texts) == true ? 0.0M : Convert.ToDecimal(txtQuantity.Texts),
                        Rate = Convert.ToDecimal(txtRate.Texts),
                        TotalPeriod = TotalPeriod,
                        Type = ((TypeSeries)cmbTypeSerie.SelectedIndex).ToString()
                    };
                    this.SerieServices.Create(serie);
                    DrawSeries(serie);
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
                        Initial = Convert.ToInt32(txtInitial.Texts),
                        End = Convert.ToInt32(txtInitial.Texts),
                        FlowType = ((FlowType)cmbFlowType.SelectedIndex).ToString(),
                        Project = Project,
                        ProjectId = Project.Id,
                        Rate = Convert.ToDecimal(txtRate.Texts),
                        Payment = Convert.ToDecimal(txtQuantity.Texts),
                        TotalPeriod = TotalPeriod
                    };
                    this.InterestServices.Create(interest);
                    DrawInterest(interest);
                }
                lblTypeIdgv.Visible = true;
                cmbTypeIdgv.Visible = true;
                customPanel1.Visible = true;
                FillDGV();
                
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            PresentLbl();
        }


        #region -> form movement

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void cmbTypeIdgv_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            FillDGV();
        }

        private void graph_Paint(object sender, PaintEventArgs e)
        {
            graphics = graph.CreateGraphics();
            if (TotalPeriod > 0)
            {
                DrawPlane(TotalPeriod);

            }
        }

        #region -> Draw interest and plane
        private void ClearPanel()
        {
            graphics.Clear(this.graph.BackColor);
        }
        public void DrawPlane( int TotalPeriod)
        {

            //graphics = Graphics.FromImage(bitmap);
            int TotalPeriods = TotalPeriod + 1 ;
            Point[] points =
             {
               new Point(Coord_x,coord_y),
                new Point(Coord_x+graph.Width,coord_y),
                new Point(Coord_x,coord_y)
            };
            
            graphics.DrawLines(new Pen(Color.DimGray), points);
            int SpaceBetweenNumbers = (int)(double)graph.Width / TotalPeriods;

            Font drawFont = new Font(lblInitial.Font.ToString(), 8);
            SolidBrush drawBrush = new SolidBrush(Color.DimGray);
            for (int i = 0; i < TotalPeriod; i++)
            {
                PointF point = new PointF((SpaceBetweenNumbers * i), coord_y - 15);
                graphics.DrawString($"{i}", drawFont, drawBrush, point);
              
            }
            //graph.BackgroundImage = bitmap;
        }
        private void DrawAnnuity(Annuity annuity)
        {
            // line configurations

            int space = Convert.ToInt32(graph.Width / (TotalPeriod+1));
            int HeightLine = annuity.FlowType == FlowType.Entry.ToString() ? Convert.ToInt32((graph.Height) * .2) : Convert.ToInt32(graph.Height * .8);
            int coord_y_entreLine = annuity.FlowType == FlowType.Entry.ToString() ? (coord_y - 15) : coord_y + 15;
            Color color = annuity.FlowType == FlowType.Entry.ToString() ? Color.Green : Color.Red;


            // initial line

            graphics.DrawLine(new Pen(Color.White), new Point(Coord_x, coord_y_entreLine),
                new Point((annuity.Initial * space), coord_y_entreLine));
            Point[] InitialPoints =
            {
                new Point((annuity.Initial*space)+3,coord_y_entreLine),
                new Point((annuity.Initial*space)+3,HeightLine),
            };
            graphics.DrawLines(new Pen(color), InitialPoints);

            // end line

            graphics.DrawLine(new Pen(Color.White), new Point(Coord_x, coord_y_entreLine),
               new Point((annuity.Initial * space) + 3, coord_y_entreLine));
            Point[] EndPoints =
            {
                new Point((annuity.End*space)+3,coord_y_entreLine),
                new Point((annuity.End*space)+3,HeightLine),
            };
            graphics.DrawLines(new Pen(color), EndPoints);

            // line Payment

            int pointPositionY = annuity.FlowType == FlowType.Entry.ToString() ? HeightLine - 4 : HeightLine + 8;
            Point[] linePoits =
            {
                new Point(InitialPoints[1].X,pointPositionY),
                new Point(EndPoints[1].X,pointPositionY)
            };
            graphics.DrawLines(new Pen(color), linePoits);

            // Payment Annuity

            float middle = Convert.ToSingle((annuity.Initial + annuity.End) / 2.0);
            int positionPayment = annuity.FlowType == FlowType.Entry.ToString() ? HeightLine - 18 : HeightLine + 12;
            Font drawFont = new Font(lblInitial.Font.ToString(), 8);
            SolidBrush drawBrush = new SolidBrush(color);
            graphics.DrawString(annuity.Payment.ToString(), drawFont, drawBrush, ((middle * space)), positionPayment);

        }
        private void DrawInterest(Interest interest)
        {

            int TotalPeriods = TotalPeriod + 1;
            //graphics = Graphics.FromImage(bitmap);
            int space = (int)((float)graph.Width / (float)Convert.ToSingle(TotalPeriods));
            int HeightLine = interest.FlowType == $"{FlowType.Entry}" ? Convert.ToInt32((graph.Height) * .2) : Convert.ToInt32(graph.Height * .8);
            int coord_y_entreLine = interest.FlowType == $"{FlowType.Entry}" ? (coord_y - 15) : coord_y + 15;
            Color color = interest.FlowType == $"{FlowType.Entry}" ? Color.Green : Color.Red;


            // initial line

            graphics.DrawLine(new Pen(Color.White), new Point(Coord_x, coord_y_entreLine),
                new Point((interest.Initial * space) + 5, coord_y_entreLine));
            Point[] InitialPoints =
            {
                new Point((interest.Initial*space)+5,coord_y_entreLine),
                new Point((interest.Initial*space)+5,HeightLine),
            };
            graphics.DrawLines(new Pen(color), InitialPoints);

            float positionStringPayment = ((float)(interest.Initial - 1) + (float)(interest.Initial + 1)) / (float)2;
            int positionPayment = interest.FlowType == $"{FlowType.Entry}" ? HeightLine - 18 : HeightLine + 12;
            Font drawFont = new Font(lblInitial.Font.ToString(), 8);
            SolidBrush drawBrush = new SolidBrush(color);
            graphics.DrawString(interest.Payment.ToString(), drawFont, drawBrush, ((positionStringPayment * space) - 10) + 5, positionPayment);
            //graph.BackgroundImage = bitmap;
        }

        private void DrawSeries(Serie serie)
        {
            // line configurations
            int space = Convert.ToInt32(graph.Width / (TotalPeriod+1));
            int HeightLine = serie.FlowType == FlowType.Entry.ToString() ? Convert.ToInt32((graph.Height) * .20) : Convert.ToInt32(graph.Height * .80);
            int coord_y_entreLine = serie.FlowType == FlowType.Entry.ToString() ? (coord_y - 15) : coord_y + 15;
            Color color = serie.FlowType == FlowType.Entry.ToString() ? Color.Green : Color.Red;
            int HeightInitialLine = serie.FlowType == FlowType.Entry.ToString() ? HeightLine + 35 : HeightLine - 35;

            // initial line
            graphics.DrawLine(new Pen(Color.White), new Point(Coord_x, coord_y_entreLine),
               new Point((serie.Initial * space) + 3, coord_y_entreLine));
            Point[] InitialPoints =
            {
                new Point((serie.Initial*space)+3,coord_y_entreLine),
               new Point((serie.Initial*space)+3,HeightInitialLine),
            };
            graphics.DrawLines(new Pen(color), InitialPoints);

            // end line
            Point[] EndPoints =
            {
                new Point((serie.End*space)+3,coord_y_entreLine),
                new Point((serie.End*space)+3,HeightLine),
            };
            graphics.DrawLines(new Pen(color), EndPoints);

            // line or curve payment
            if (serie.Type == TypeSeries.Arithmetic.ToString())
            {
                Point[] linePoint =
                {
                   InitialPoints[1],
                   EndPoints[1]
                };
                graphics.DrawCurve(new Pen(color), linePoint);
            }
            else
            {
                int curveLine = serie.FlowType == FlowType.Entry.ToString() ? HeightInitialLine + 30 : HeightInitialLine - 30;
                Point[] curvePoint =
                {
                    InitialPoints[1],
                    new Point(Convert.ToInt32((InitialPoints[1].X+EndPoints[1].X)/2.0),curveLine),
                    EndPoints[1]
                };
                graphics.DrawCurve(new Pen(color), curvePoint);
            }
            // paymentss
            float middle = Convert.ToSingle((serie.Initial + serie.End) / 2.0);
            int positionPayment = serie.FlowType == FlowType.Entry.ToString() ? HeightLine - 18 : HeightLine + 12;
            Font drawFont = new Font(lblInitial.Font.ToString(), 8);
            SolidBrush drawBrush = new SolidBrush(color);
            graphics.DrawString(serie.Type == TypeSeries.Arithmetic.ToString() ? "G= " + serie.Quantity.ToString() : "j= " + serie.Quantity.ToString() + "%", drawFont, drawBrush, ((middle * space)), positionPayment);

        }
        #endregion

        private void dgvInterest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selection = e.RowIndex;
            }
        }

        private void txtQuantity__TextChanged(object sender, EventArgs e)
        {
        }

        private void dgvInterest_DoubleClick(object sender, EventArgs e)
        {

            
            if (selection >= 0)
            {
                ClearPanel();
                DrawPlane(TotalPeriod);
                int InterestId = (int)dgvInterest.Rows[selection].Cells[0].Value;
                if (cmbTypeIdgv.SelectedIndex == 0)
                {
                    Annuity annuity=AnnuityServices.GetIdProject(Project.Id).Where(x => x.Id ==InterestId).FirstOrDefault();
                    DrawAnnuity(annuity);
                }
                if (cmbTypeIdgv.SelectedIndex == 1)
                {
                    Serie serie=SerieServices.GetIdProject(Project.Id).Where(x => x.Id == InterestId).FirstOrDefault();
                    DrawSeries(serie);
                }
                if(cmbTypeIdgv.SelectedIndex==2)
                {
                    Interest interest=InterestServices.GetIdProject(Project.Id).Where(x => x.Id == InterestId).FirstOrDefault();
                    DrawInterest(interest);
                }
            }
        }
    }
}
