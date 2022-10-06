using Economy.AppCore.IServices;
using Economy.AppCore.Processes;
using Economy.Domain.Entities;
using Economy.Domain.Entities.DTO.Interests;
using Economy.Domain.Enums;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace Economy.Forms
{
    public partial class FormGraphInterest : Form
    {
        private bool Image = false;
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

        public IProjectServices projectServices { get; set; }
        private Interest Interest = null;
        private Serie Serie = null;
        private Annuity Annuity = null;

        Timer ReDraws = new System.Timers.Timer(1000);
        private int Coord_x = 0, coord_y;
        private int graphHeight;
        private int graphWidth;

        private int selection = -1;
        public int TotalPeriod = -1;
        public decimal rate = -1;
        private Project Project;
        public FormCreateProject FormCreateProject;

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
            this.graphHeight = (graph.Height);
            this.graphWidth = graph.Width;
            this.pbDelete.Image= Properties.Resources.dump;
            this.pbDelete.AllowDrop = true;


        }
        private void OnTimedEvent(object source, System.Timers.ElapsedEventArgs e)
        {

            graph_Paint(null, null);
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void CleanForms()
        {
            txtDownPayment.Texts = "";
            txtFinalPayment.Texts = "";
            txtInitial.Texts = "";
            txtEnd.Texts = "";
            txtQuantity.Texts = "";
            cmbFlowType.SelectedIndex = -1;

        }
        private void lblValues(decimal present, decimal future)
        {
            lblPresent.Visible = true;
            lblFuture.Visible = true;
            if (present != 0 && future != 0)
            {
                lblPresent.Text = $"Present: C$ {Math.Round(present, 2)}";
                lblFuture.Text = $"Future: C$ {Math.Round(future, 2)}";
                return;
            }
            if (SerieServices.GetIdProject(Project.Id).Count > 0 || InterestServices.GetIdProject(Project.Id).Count > 0
                || AnnuityServices.GetIdProject(Project.Id).Count > 0)
            {

                decimal SeriePresent = (decimal)SerieServices.FindByOption(x => x.ProjectId == Project.Id && x.FlowType == FlowType.Entry.ToString()).Sum(x => x.Present) - (decimal)SerieServices.FindByOption(x => x.ProjectId == Project.Id && x.FlowType == FlowType.Exit.ToString()).Sum(x => x.Present);
                decimal InterestPresent = (decimal)InterestServices.FindByOption(x => x.ProjectId == Project.Id && x.FlowType == FlowType.Entry.ToString()).Sum(x => x.Present) - (decimal)InterestServices.FindByOption(x => x.ProjectId == Project.Id && x.FlowType == FlowType.Exit.ToString()).Sum(x => x.Present);
                decimal AnnuityPresent = (decimal)AnnuityServices.FindByOption(x => x.ProjectId == Project.Id && x.FlowType == FlowType.Entry.ToString()).Sum(x => x.Present) - (decimal)AnnuityServices.FindByOption(x => x.ProjectId == Project.Id && x.FlowType == FlowType.Exit.ToString()).Sum(x => x.Present);
                decimal TotalPresent = (decimal)SeriePresent + InterestPresent + AnnuityPresent;
                TotalPresent = Math.Abs(TotalPresent);

                decimal rate = (Convert.ToDecimal(txtRate.Texts) / 100);
                decimal rateYear = ((decimal)Math.Pow((double)(1 + rate), TotalPeriod));
                decimal TotalFuture = TotalPresent * rateYear;
                TotalFuture = Math.Abs(TotalFuture);

                lblPresent.Text = $"Presente: C$ {Math.Round(TotalPresent, 2)}";
                lblFuture.Text = $"Futuro: C$ {Math.Round(TotalFuture, 2)}";
            }
            else
            {
                lblPresent.Text = $"Present: C$ {Math.Round(0.0, 2)}";
                lblFuture.Text = $"Future: C$ {Math.Round(0.0, 2)}";
                return;
            }
        }
       
        Dictionary<string, string> typeAnnuities = new Dictionary<string, string>();
        Dictionary<string, string> typeSerie = new Dictionary<string, string>();
     
        private void FormGraphInterest_Load(object sender, EventArgs e)
        {
            this.ReDraws.Elapsed += new System.Timers.ElapsedEventHandler(OnTimedEvent);
            this.ReDraws.Interval = 3000;
            this.ReDraws.AutoReset = true;
            this.ReDraws.Enabled = true;
            ToolTip toolTipChanged = new ToolTip();
            toolTipChanged.SetToolTip(this.pbChanged, "Cambiar los valores de la duración del proyecto y la tasa.");
            graph.Refresh();
            lblValues(0, 0);


          
            this.txtDuration.KeyPress += new KeyPressEventHandler(ValidateNumberAndPoint);
            this.txtInitial.KeyPress += new KeyPressEventHandler(ValidateNumberAndPoint);
            this.txtEnd.KeyPress += new KeyPressEventHandler(ValidateNumberAndPoint);
            this.txtDownPayment.KeyPress += new KeyPressEventHandler(ValidateNumber);
            this.txtFinalPayment.KeyPress += new KeyPressEventHandler(ValidateNumber);
            this.txtQuantity.KeyPress += new KeyPressEventHandler(ValidateNumber);
            this.txtRate.KeyPress += new KeyPressEventHandler(ValidateNumber);
            typeAnnuities.Add("Ordinary", "Ordinaria");
            typeAnnuities.Add("Anticipated", "Anticipada");
            typeAnnuities.Add("Deferred", "Diferida");
          
            typeSerie.Add("Arithmetic", "Aritmética");
            typeSerie.Add("Geometric", "Geométrica");
        }
        public int VerificateInterest(object t)
        {

            List<object> lists = new List<object>();
            lists.AddRange(AnnuityServices.GetIdProject(Project.Id).Where(x => x.FlowType == (string)t.GetType().GetProperty("FlowType").GetValue(t)
            &&
               DateTime.Compare(x.Date, (DateTime)t.GetType().GetProperty("Date").GetValue(t)) < 0
            ));
            lists.AddRange(InterestServices.GetIdProject(Project.Id).Where(x => x.FlowType == (string)t.GetType().GetProperty("FlowType").GetValue(t)
            &&
             DateTime.Compare(x.Date, (DateTime)t.GetType().GetProperty("Date").GetValue(t)) < 0

            ));
            lists.AddRange(SerieServices.GetIdProject(Project.Id).Where(x => x.FlowType == (string)t.GetType().GetProperty("FlowType").GetValue(t)
             &&
                DateTime.Compare(x.Date, (DateTime)t.GetType().GetProperty("Date").GetValue(t)) < 0
             ));



            int i = lists.Where(x => (string)x.GetType().GetProperty("FlowType").GetValue(x) == (string)t.GetType().GetProperty("FlowType").GetValue(t)
             && (int)x.GetType().GetProperty("Id").GetValue(x) != (int)t.GetType().GetProperty("Id").GetValue(t)
             && (int)t.GetType().GetProperty("Initial").GetValue(t) >= (int)x.GetType().GetProperty("Initial").GetValue(x)
             && (int)t.GetType().GetProperty("Initial").GetValue(t) <= (int)x.GetType().GetProperty("End").GetValue(x)
             || (int)t.GetType().GetProperty("End").GetValue(t) >= (int)x.GetType().GetProperty("Initial").GetValue(x)
             || (int)t.GetType().GetProperty("End").GetValue(t) <= (int)x.GetType().GetProperty("End").GetValue(x)
             || (int)t.GetType().GetProperty("Initial").GetValue(t) < (int)x.GetType().GetProperty("Initial").GetValue(x)
             && (int)x.GetType().GetProperty("End").GetValue(x) < (int)t.GetType().GetProperty("End").GetValue(t)
            ).Count();
            return i;

        }

        private void ValidateNumberAndPoint(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar > 57 || e.KeyChar < 48)
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
        }
        private void ValidateNumber(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar > 57 || e.KeyChar < 48)
            {
                if (e.KeyChar == 46)
                {
                    e.Handled = false;
                    return;
                }
                if (e.KeyChar == (char)8)
                {
                    e.Handled = false;
                    return;
                }
                e.Handled = true;
            }

        }
        private void lblQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar > 57 || e.KeyChar < 48)
            {
                if (e.KeyChar == 46)
                {
                    e.Handled = false;
                    return;
                }
                e.Handled = true;
            }
            else if (e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
        }

        private void pbNext_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtDuration.Texts) || String.IsNullOrEmpty(txtRate.Texts))
            {
                MessageBox.Show("Escriba la duración del proyecto o la tasa del proyecto.");
                return;
            }
            if(Convert.ToDecimal(txtRate.Texts) <= 0)
            {
                MessageBox.Show("La tasa del proyecto no puede ser 0");
                return;
            }
            if (Convert.ToInt64(txtDuration.Texts) < 2)
            {
                txtDuration.Texts = "";
                MessageBox.Show("La duración no puede ser 0 ni 1");
                return;
            }
            if(TotalPeriod!=-1 && rate !=-1)
            {
                if (!ValidateDuration())
                {
                    MessageBox.Show("Existe un flujo de caja que tiene más años que la duración.");
                    return;
                }
                TotalPeriod = Convert.ToInt32(txtDuration.Texts);
                rate = Convert.ToDecimal(txtRate.Texts);
              
                UpdateInterests();
                ClearPanel();
                graph_Paint(null, null);

                lblValues(0, 0);
                FillDGV();
            
                ActivateForm();
            }
            else
            {
                TotalPeriod = Convert.ToInt32(txtDuration.Texts);
                rate = Convert.ToDecimal(txtRate.Texts);
                ActivateForm();
                pbChanged.Visible = true;
            }
        }
        public void UpdateInterests()
        {

            foreach (Annuity annuity in AnnuityServices.GetIdProject(Project.Id))
            {
                
                annuity.Rate = rate;
                annuity.TotalPeriod = TotalPeriod;
                AnnuityServices.Update(annuity);
            }

            foreach (Serie serie in SerieServices.GetIdProject(Project.Id))
            {
                serie.Rate = rate;
                serie.TotalPeriod = TotalPeriod;
                SerieServices.Update(serie);
            }
            foreach (Interest interest in InterestServices.GetIdProject(Project.Id))
            {
                interest.Rate = rate;
                interest.TotalPeriod = TotalPeriod;
                InterestServices.Update(interest);
            }
        }
        public bool ValidateDuration()
        {
            int duration = (int)Convert.ToInt64(txtDuration.Texts);
            foreach (Annuity annuity in AnnuityServices.GetIdProject(Project.Id))
            { 
                if(annuity.Initial>duration || annuity.End > duration)
                {
                    return false;
                }
            }
            foreach(Serie serie in SerieServices.GetIdProject(Project.Id))
            {
                if(serie.Initial>duration || serie.End > duration)
                {
                    return false;
                }
            }
            foreach(Interest interest in InterestServices.GetIdProject(Project.Id))
            {
                if(interest.Initial>duration || interest.End > duration)
                {
                    return false;
                }
            }
            return true;
        }
        public void ActivateForm()
        {
            txtRate.Enabled = false;
            lblDuration.Visible = false;
            txtDuration.Visible = false;
            pbNext.Visible = false;
            lblTI.Visible = true;
            cmbTypeSA.Visible = true;

        }
        public void DesactiveForm()
        {
            txtRate.Enabled = true;
            lblDuration.Visible = true;
            txtDuration.Visible = true;
            pbNext.Visible = true;
            txtDownPayment.Visible = false;
            txtFinalPayment.Visible = false;
            txtEnd.Visible = false;
            txtInitial.Visible = false;
            cmbFlowType.Visible = false;
            btnCreate.Visible = false;
            txtQuantity.Visible = false;
            cmbTypeSA.Visible = false;
            cmbTypeSA.Visible = false;
            cbDecremental.Visible = false;
            cmbTypeSerie.Visible = false;
            lblDecremental.Visible = false;
            lblInitial.Visible = false;
            lblTI.Visible = false;
            lblWI.Visible = false;
            lblEnd.Visible = false;
            lblFinalPayment.Visible = false;
            lblFlowType.Visible = false;
            lblTypeSerie.Visible = false;
            lblDownPayment.Visible = false; 
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
                    lblWI.Text = "tasa j%";
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
                    List<AnualidadDTO> anualidadDTOs = new List<AnualidadDTO>();
                    foreach (Annuity annuity in AnnuityServices.GetIdProject(Project.Id))
                    {
                        anualidadDTOs.Add(new AnualidadDTO()
                        {
                            Id = annuity.Id,
                            Inicio = annuity.Initial,
                            Final = annuity.End,
                            Flujo = annuity.FlowType == "Entry" ? "Entrada" : "Salida",
                            Futuro = annuity.Future,
                            Pago = annuity.Payment,
                            Presente = annuity.Present,
                            Tasa = annuity.Rate,
                            Tipo = typeAnnuities[annuity.Type]
                        });
                    }
                    dgvInterest.DataSource = anualidadDTOs;
                }
                if (cmbTypeIdgv.SelectedIndex == 1)
                {
                    List<SerieDTO> serieDTOs = new List<SerieDTO>();
                    foreach (Serie serie in SerieServices.GetIdProject(Project.Id))
                    {
                        serieDTOs.Add(new SerieDTO()
                        {
                            Id = serie.Id,
                            Inicio = serie.Initial,
                            Final = serie.End,
                            Flujo = serie.FlowType == "Entry" ? "Entrada" : "Salida",
                            Futuro = serie.Future,
                            Presente = serie.Present,
                            Tasa = serie.Rate,
                            Tipo = typeSerie[serie.Type],
                            Cantidad = serie.Quantity,
                            Incremental = serie.Incremental,
                            PagoFinal = serie.FinalPayment,
                            PagoInicial = serie.DownPayment
                        });
                    }
                    dgvInterest.DataSource = serieDTOs;
                }
                if (cmbTypeIdgv.SelectedIndex == 2)
                {
                    List<InteresDTO> interesDTOs = new List<InteresDTO>();
                    foreach (Interest interest in InterestServices.GetIdProject(Project.Id))
                    {
                        interesDTOs.Add(new InteresDTO()
                        {
                            Id = interest.Id,
                            Inicio = interest.Initial,
                            Final = interest.End,
                            Flujo = interest.FlowType =="Entry"? "Entrada":"Salida",
                            Futuro = interest.Future,
                            Pago = interest.Payment,
                            Presente = interest.Present,
                            Tasa = interest.Rate,
                        });
                    }
                    dgvInterest.DataSource = interesDTOs;
                }

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
                        MessageBox.Show("Rellene todo el formulario.");
                        return;
                    }
                    Annuity annuity = new Annuity
                    {
                        ProjectId = Project.Id,
                        FlowType = ((FlowType)cmbFlowType.SelectedIndex).ToString(),
                        Initial = Convert.ToInt32(txtInitial.Texts),
                        End = Convert.ToInt32(txtEnd.Texts),
                        Payment = Convert.ToDecimal(txtQuantity.Texts),
                        Rate = rate,
                        Project = Project,
                        TotalPeriod = TotalPeriod,
                        Date = DateTime.UtcNow

                    };
                    this.AnnuityServices.Create(annuity);
                    graph_Paint(null, null);
                }
                else if (cmbTypeSA.SelectedIndex == 1)
                {
                    if (!ValidateFormSerie())
                    {
                        MessageBox.Show("Rellene todo el formulario.");
                        return;
                    }
                    if (!ValidateFormSeriePayment())
                    {
                        MessageBox.Show("Solo se permite que una casilla esté vacía, rellene las demás (pago inicial, pago final, cantidad)");
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
                        Rate = rate,
                        TotalPeriod = TotalPeriod,
                        Type = ((TypeSeries)cmbTypeSerie.SelectedIndex).ToString(),
                        Date = DateTime.UtcNow
                    };
                    this.SerieServices.Create(serie);
                    graph_Paint(null, null);
                }
                else if (cmbTypeSA.SelectedIndex == 2)
                {
                    if (!ValidateFormInterest())
                    {
                        MessageBox.Show("Rellene todo el formulario.");
                        return;
                    }
                    Interest interest = new Interest
                    {
                        Initial = Convert.ToInt32(txtInitial.Texts),
                        End = Convert.ToInt32(txtInitial.Texts),
                        FlowType = ((FlowType)cmbFlowType.SelectedIndex).ToString(),
                        Project = Project,
                        ProjectId = Project.Id,
                        Rate = rate,
                        Payment = Convert.ToDecimal(txtQuantity.Texts),
                        TotalPeriod = TotalPeriod,
                        Date = DateTime.UtcNow
                    };
                    this.InterestServices.Create(interest);
                    graph_Paint(null, null);

                }
                lblTypeIdgv.Visible = true;
                cmbTypeIdgv.Visible = true;
                customPanel1.Visible = true;
                CleanForms();
                FillDGV();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            lblValues(0, 0);
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
            Graphics graphics = null;
            if (Image != false)
            {
                graphics = e.Graphics;
            }
            if (TotalPeriod > 0)
            {
                DrawPlane(TotalPeriod, graphics);
            }
            if (Annuity != null)
            {
                DrawAnnuity(Annuity, graphics);
                return;
            }
            if (Serie != null)
            {
                DrawSeries(Serie, graphics);
                return;

            }
            if (Interest != null)
            {
                DrawInterest(Interest, graphics);
                return;
            }
            Redraw(graphics);
        }

        #region -> Draw interest and plane
        private void ClearPanel()
        {
            Graphics graphics = graph.CreateGraphics();
            graphics.Clear(graph.BackColor);
        }
        public void DrawPlane(int TotalPeriod, Graphics graphics)
        {
            this.coord_y = (int)(graph.Height * .5);
            if (graphics == null)
            {
                graphics = graph.CreateGraphics();
            }
            //graphics = Graphics.FromImage(bitmap);

            int TotalPeriods = TotalPeriod + 1;
            int SpaceBetweenNumbers = 19;
            if ((SpaceBetweenNumbers * TotalPeriods) > graph.Width)
            {
                graph.Width = SpaceBetweenNumbers * TotalPeriods;
            }
            Point[] points =
             {
                new Point(Coord_x,coord_y),
                new Point(Coord_x+graph.Width,coord_y),
                new Point(Coord_x,coord_y)
            };

            graphics.DrawLines(new Pen(Color.DimGray), points);


            System.Drawing.Font drawFont = new System.Drawing.Font(lblInitial.Font.ToString(), 8);
            SolidBrush drawBrush = new SolidBrush(Color.DimGray);
            for (int i = 0; i < TotalPeriods; i++)
            {
                
                PointF point = new PointF((SpaceBetweenNumbers * i), coord_y - 15);
                graphics.DrawString($"{i}", drawFont, drawBrush, point);

            }
            //graph.BackgroundImage = bitmap;
        }

        private void DrawArrow(string flowType, Graphics graphic, Point initial, int size, Color color)
        {
            Pen Pen = new Pen(color);
            Point[] LeftPoints = new Point[2];
            Point[] RightPoints = new Point[2];
            if (flowType == FlowType.Exit.ToString())
            {
                LeftPoints[0] = new Point(initial.X - size, initial.Y - size);
                LeftPoints[1] = new Point(initial.X, initial.Y);
                RightPoints[0] = new Point(initial.X + size, initial.Y - size);
                RightPoints[1] = new Point(initial.X, initial.Y);
            }
            else
            {
                LeftPoints[0] = new Point(initial.X - size, initial.Y + size);
                LeftPoints[1] = new Point(initial.X, initial.Y);
                RightPoints[0] = new Point(initial.X + size, initial.Y + size);
                RightPoints[1] = new Point(initial.X, initial.Y);
            }
            graphic.DrawLine(Pen, LeftPoints[0], LeftPoints[1]);
            graphic.DrawLine(Pen, RightPoints[0], RightPoints[1]);

        }
        private bool ModifyPlane(string FlowTypeS, int HeightLine)
        {
            if (FlowTypeS == FlowType.Exit.ToString() && HeightLine >= graph.Height * .9)
            {
                graph.Height = graph.Height + 100;
                ClearPanel();
                return false;
            }
            else if (FlowTypeS == FlowType.Entry.ToString() && HeightLine <= graph.Height * .1)
            {
                graph.Height = graph.Height + 100;
                ClearPanel();
                return false;
            }
            return true;
        }
        private void DrawAnnuity(Annuity annuity, Graphics graphics)
        {
            int i = VerificateInterest(annuity);
            if (graphics == null)
            {
                graphics = graph.CreateGraphics();
            }

            //line configuration
            int space = 19;
            //int HeightLine = (int)(annuity.FlowType == FlowType.Entry.ToString() ? (graph.Height*.5)+Convert.ToInt32(-62.2 - (i * 20)) : Convert.ToInt32(248.8 + (i * 20)));
            int HeightLine = (int)(annuity.FlowType == FlowType.Entry.ToString() ? (graph.Height * .5) + Convert.ToInt32(-62.2 - (i * 20)) : (graph.Height * .5) + Convert.ToInt32(62.2 + (i * 20)));

            if (!ModifyPlane(annuity.FlowType.ToString(), HeightLine))
            {
                return;
            }
            //  int coord_y_entreLine = (int)(annuity.FlowType == FlowType.Entry.ToString() ? (coord_y - (15+(i*3))) : coord_y + 15+(i*3));
            int coord_y_entreLine = (int)(annuity.FlowType == FlowType.Entry.ToString() ? coord_y - 15 : coord_y + 15);
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
            DrawArrow(annuity.FlowType, graphics, InitialPoints[1], 5, color);

            // end line

            graphics.DrawLine(new Pen(Color.White), new Point(Coord_x, coord_y_entreLine),
               new Point((annuity.Initial * space) + 3, coord_y_entreLine));
            Point[] EndPoints =
            {
                new Point((annuity.End*space)+3,coord_y_entreLine),
                new Point((annuity.End*space)+3,HeightLine),
            };
            graphics.DrawLines(new Pen(color), EndPoints);
            DrawArrow(annuity.FlowType, graphics, EndPoints[1], 5, color);


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
            System.Drawing.Font drawFont = new System.Drawing.Font(lblInitial.Font.ToString(), 8);
            SolidBrush drawBrush = new SolidBrush(color);
            graphics.DrawString(annuity.Payment.ToString(), drawFont, drawBrush, ((middle * space)), positionPayment);

        }

        private void DrawInterest(Interest interest, Graphics graphics)
        {
            int i = VerificateInterest(interest);

            if (graphics == null)
            {
                graphics = graph.CreateGraphics();
            }

            int TotalPeriods = TotalPeriod + 1;


            int HeightLine = (int)(interest.FlowType == FlowType.Entry.ToString() ? (graph.Height * .5) + Convert.ToInt32(-62.2 - (i * 20)) : (graph.Height * .5) + Convert.ToInt32(62.2 + (i * 20)));

            if (!ModifyPlane(interest.FlowType.ToString(), HeightLine))
            {
                return;
            }
            //int coord_y_entreLine = (int)(interest.FlowType == FlowType.Entry.ToString() ? (coord_y - (15 + (i * 3))) : coord_y + 15 + (i * 3));
            int coord_y_entreLine = (int)(interest.FlowType == FlowType.Entry.ToString() ? coord_y - 15 : coord_y + 15);
            int space = 19;

            Color color = interest.FlowType == $"{FlowType.Entry}" ? Color.Green : Color.Red;


            // initial line

            graphics.DrawLine(new Pen(Color.White), new Point(Coord_x, coord_y_entreLine),
                new Point((interest.Initial * space) + 5, coord_y_entreLine));
            Point[] InitialPoints =
            {
                new Point((interest.Initial*space)+5,coord_y_entreLine),
                new Point((interest.Initial*space)+5,HeightLine),
            };
            DrawArrow(interest.FlowType, graphics, InitialPoints[1], 5, color);
            graphics.DrawLines(new Pen(color), InitialPoints);

            float positionStringPayment = ((float)(interest.Initial - 1) + (float)(interest.Initial + 1)) / (float)2;
            int positionPayment = interest.FlowType == $"{FlowType.Entry}" ? HeightLine - 18 : HeightLine + 12;
            System.Drawing.Font drawFont = new System.Drawing.Font(lblInitial.Font.ToString(), 8);
            SolidBrush drawBrush = new SolidBrush(color);
            graphics.DrawString(interest.Payment.ToString(), drawFont, drawBrush, ((positionStringPayment * space) - 10) + 5, positionPayment);
            //graph.BackgroundImage = bitmap;
        }

        private void DrawSeries(Serie serie, Graphics graphics)
        {
            int i = VerificateInterest(serie);

            if (graphics == null)
            {
                graphics = graph.CreateGraphics();
            }

            // line configurations
            int space = 19;
            int HeightLine = (int)(serie.FlowType == FlowType.Entry.ToString() ? (graph.Height * .5) + Convert.ToInt32(-62.2 - (i * 20)) : (graph.Height * .5) + Convert.ToInt32(62.2 + (i * 20)));
            if (!ModifyPlane(serie.FlowType.ToString(), HeightLine))
            {
                return;
            }
            //int HeightLine = serie.FlowType == FlowType.Entry.ToString() ? Convert.ToInt32((graph.Height) * .20) : Convert.ToInt32(graph.Height * .80);
            int coord_y_entreLine = serie.FlowType == FlowType.Entry.ToString() ? (coord_y - 15) : coord_y + 15;
            Color color = serie.FlowType == FlowType.Entry.ToString() ? Color.Green : Color.Red;
            int HeightInitialLine = serie.FlowType == FlowType.Entry.ToString() ? HeightLine + 20 : HeightLine - 20;

            // initial line
            graphics.DrawLine(new Pen(Color.White), new Point(Coord_x, coord_y_entreLine),
               new Point((serie.Initial * space) + 3, coord_y_entreLine));
            Point[] InitialPoints =
            {
                new Point((serie.Initial*space)+3,coord_y_entreLine),
               new Point((serie.Initial*space)+3,HeightInitialLine),
            };
            DrawArrow(serie.FlowType, graphics, InitialPoints[1], 5, color);
            graphics.DrawLines(new Pen(color), InitialPoints);

            // end line
            Point[] EndPoints =
            {
                new Point((serie.End*space)+3,coord_y_entreLine),
                new Point((serie.End*space)+3,HeightLine),
            };
            DrawArrow(serie.FlowType, graphics, EndPoints[1], 5, color);
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
            int curveLines = serie.FlowType == FlowType.Entry.ToString() ? HeightInitialLine + 30 : HeightInitialLine - 30;
            // payments
            float middle = Convert.ToSingle((serie.Initial + serie.End) / 2.0);
            int positionPayment = serie.FlowType == FlowType.Entry.ToString() ? curveLines - 16 : curveLines + 5; // -18 and +12
            System.Drawing.Font drawFont = new System.Drawing.Font(lblInitial.Font.ToString(), 8);
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

            try
            {
                if (Convert.ToInt64(txtQuantity.Texts) <= 0)
                {
                    lblNotifyQR.Visible = true;
                    return;
                }
                lblNotifyQR.Visible = false;
            }
            catch
            {
                lblNotifyQR.Visible = false;
            }
        }
        private void Redraw(Graphics graphics)
        {


            this.Invoke(new Action(() =>
            {

                foreach (Annuity annuity in AnnuityServices.GetIdProject(Project.Id))
                {
                    DrawAnnuity(annuity, graphics);
                }

            }));
            this.Invoke(new Action(() =>
            {

                foreach (Serie serie in SerieServices.GetIdProject(Project.Id))
                {
                    DrawSeries(serie, graphics);
                }
            }));

            this.Invoke(new Action(() =>
            {

                foreach (Interest interest in InterestServices.GetIdProject(Project.Id))
                {
                    DrawInterest(interest, graphics);
                }

            }));

        }
        private void lblPresent_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Serie = null;
            Annuity = null;
            Interest = null;
            lblValues(0, 0);

        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = Project.Name + "Flow graph";
            save.DefaultExt = ".png";
            if (save.ShowDialog() == DialogResult.OK)
            {
                Image = true;

                Bitmap bitmap = new Bitmap(graph.Width, graph.Height);
                graph.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0, 0, graph.Width, graph.Height));
                bitmap.Save(save.FileName);
                Image = false;
            }



        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            ExportarPDF(Project.Name + "Información");
        }
        private PdfPTable ListPDF<T>(List<T> list, T t)
        {

            // Creando tipo de fuente, UTF-8, tipo de diseño. 
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);

            // Añadiendo columnas que tendrá el PDF, margenes, tamaño, alineamiento, bordes.
            PdfPTable pdftable = new PdfPTable(t.GetType().GetProperties().Length);
            pdftable.DefaultCell.Padding = 2;
            pdftable.WidthPercentage = 100;
            pdftable.HorizontalAlignment = Element.ALIGN_CENTER;
            pdftable.DefaultCell.BorderWidth = 1;

            // Definiendo el tipo de fuente para el PDF.
            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 8, iTextSharp.text.Font.NORMAL);

            // Recorriendo nombres de las propiedades para hacerlos encabezados.
            foreach (PropertyInfo PropertyName in t.GetType().GetProperties())
            {

                if (PropertyName.Name != "Project")
                {
                    var ColorDeFuente = new BaseColor(255, 255, 255);
                    var TimesRoman = FontFactory.GetFont("Times-Roman", 8, ColorDeFuente);

                    PdfPCell cel = new PdfPCell(new Phrase(PropertyName.Name, TimesRoman));
                    cel.BackgroundColor = new iTextSharp.text.BaseColor(109, 122, 224);
                    cel.HorizontalAlignment = Element.ALIGN_CENTER;

                    pdftable.AddCell(cel);
                }

            }

            // Recorriendo filas y cada celdas de esas filas del DataGridView para ponerselas al PDF.
            foreach (T interest in list)
            {
                foreach (PropertyInfo PropertyName in interest.GetType().GetProperties())
                {

                    object obj = PropertyName.GetValue(interest, null);
                    pdftable.AddCell(new Phrase(obj.ToString(), text));
                }

            }
            return pdftable;
        }
        private void ExportarPDF(string FileName)
        {
            // Guardando el PDF, poniendo el nombre del PDF (Desde la nómina en la cuál esta el usuario)
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = FileName;
            save.DefaultExt = ".pdf";
            if (save.ShowDialog() == DialogResult.OK)
            {


                // Almacenando y creando el PDF con las especificaciones del tamaño de la hoja.
                FileStream stream = new FileStream(save.FileName, FileMode.Create);
                Document doc = new Document(PageSize.A4.Rotate(), 10f, 10f, 10f, 0);
                // Creando la instacia de dicho PDF con los parámetros del documento y guardando en la carpeta seleccionada por el usuario.
                PdfWriter.GetInstance(doc, stream);
                Image = true;
                Bitmap bitmap = new Bitmap(graph.Width, graph.Height);

                graph.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0, 0, graph.Width, graph.Height));
                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = new Size(800, 200);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Image = bitmap;
                pictureBox.BackColor = Color.White;
                Bitmap bitmapFinal= new Bitmap(pictureBox.Width,pictureBox.Height);
                pictureBox.DrawToBitmap(bitmapFinal, new System.Drawing.Rectangle(0, 0, pictureBox.Width, pictureBox.Height));
                Image = false;
                System.Drawing.Image image = bitmapFinal;
                //image = resizeImage(image, 580, 200);



                var ColorDeFuente = new BaseColor(Color.Black);
                var TimesRoman = FontFactory.GetFont("Times-Roman", 8, ColorDeFuente);
                doc.Open();
                List<AnualidadDTO> anualidadDTOs = new List<AnualidadDTO>();
                foreach (Annuity annuity in AnnuityServices.GetIdProject(Project.Id))
                {
                    anualidadDTOs.Add(new AnualidadDTO()
                    {
                        Id = annuity.Id,
                        Inicio = annuity.Initial,
                        Final = annuity.End,
                        Flujo = annuity.FlowType == "Entry" ? "Entrada" : "Salida",
                        Futuro = annuity.Future,
                        Pago = annuity.Payment,
                        Presente = annuity.Present,
                        Tasa = annuity.Rate,
                        Tipo = typeAnnuities[annuity.Type]
                    });
                }
                doc.Add(iTextSharp.text.Image.GetInstance(image, System.Drawing.Imaging.ImageFormat.Png));
                doc.Add(new Paragraph("\n"));
                doc.Add(new Paragraph("Anualidad", TimesRoman));
                doc.Add(new Paragraph("\n"));
                doc.Add(ListPDF(anualidadDTOs, new AnualidadDTO()));
                doc.Add(new Paragraph("\n"));
                doc.Add(new Paragraph("\n"));
                doc.Add(new Paragraph("\n"));
                doc.Add(new Paragraph("Series", TimesRoman));
                doc.Add(new Paragraph("\n"));
                List<SerieDTO> serieDTOs = new List<SerieDTO>();
                foreach (Serie serie in SerieServices.GetIdProject(Project.Id))
                {
                    serieDTOs.Add(new SerieDTO()
                    {
                        Id = serie.Id,
                        Inicio = serie.Initial,
                        Final = serie.End,
                        Flujo = serie.FlowType == "Entry" ? "Entrada" : "Salida",
                        Futuro = serie.Future,
                        Presente = serie.Present,
                        Tasa = serie.Rate,
                        Tipo = typeSerie[serie.Type],
                        Cantidad = serie.Quantity,
                        Incremental = serie.Incremental,
                        PagoFinal = serie.FinalPayment,
                        PagoInicial = serie.DownPayment
                    });
                }
                doc.Add(ListPDF(serieDTOs, new SerieDTO()));
                doc.Add(new Paragraph("\n"));
                doc.Add(new Paragraph("\n"));
                doc.Add(new Paragraph("\n"));
                doc.Add(new Paragraph("Interés", TimesRoman));
                doc.Add(new Paragraph("\n"));

                List<InteresDTO> interesDTOs = new List<InteresDTO>();
                foreach (Interest interest in InterestServices.GetIdProject(Project.Id))
                {
                    interesDTOs.Add(new InteresDTO()
                    {
                        Id = interest.Id,
                        Inicio = interest.Initial,
                        Final = interest.End,
                        Flujo = interest.FlowType == "Entry" ? "Entrada" : "Salida",
                        Futuro = interest.Future,
                        Pago = interest.Payment,
                        Presente = interest.Present,
                        Tasa = interest.Rate,
                    });
                }
                
                doc.Add(ListPDF(interesDTOs, new InteresDTO()));
                doc.Close();
                stream.Close();

            }
        }
        public static System.Drawing.Image resizeImage(System.Drawing.Image image, int width, int height)
        {
            var destinationRect = new System.Drawing.Rectangle(0, 0, width, height);
            var destinationImage = new Bitmap(width, height);

            destinationImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destinationImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destinationRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return (System.Drawing.Image)destinationImage;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PbClose_Click(object sender, EventArgs e)
        {
            if (TotalPeriod == 0 || Rate(Project)==0)
            {
                projectServices.Delete(Project);
            }
            this.Close();
  
        }
        private decimal Rate(Project project)
        {
            decimal Value = 0;

            if (AnnuityServices.GetIdProject(project.Id).Count > 0)
            {
                Value = AnnuityServices.GetIdProject(project.Id)[0].Rate;
            }
            else if (InterestServices.GetIdProject(project.Id).Count > 0)
            {
                Value = InterestServices.GetIdProject(project.Id)[0].Rate;
            }
            else if (SerieServices.GetIdProject(project.Id).Count > 0)
            {
                Value = SerieServices.GetIdProject(project.Id)[0].Rate;
            }
            return Value;
        }

        private void dgvInterest_DoubleClick(object sender, EventArgs e)
        {


            ClearPanel();
            if (selection >= 0)
            {


                int InterestId = (int)dgvInterest.Rows[selection].Cells[0].Value;
                if (cmbTypeIdgv.SelectedIndex == 0)
                {
                    Annuity annuity = AnnuityServices.GetIdProject(Project.Id).Where(x => x.Id == InterestId).FirstOrDefault();
                    lblValues((decimal)annuity.Present, (decimal)annuity.Future);
                    DoNull(null, annuity, null);

                }
                if (cmbTypeIdgv.SelectedIndex == 1)
                {
                    Serie serie = SerieServices.GetIdProject(Project.Id).Where(x => x.Id == InterestId).FirstOrDefault();

                    lblValues((decimal)serie.Present, (decimal)serie.Future);

                    DoNull(serie, null, null);
                }
                if (cmbTypeIdgv.SelectedIndex == 2)
                {
                    Interest interest = InterestServices.GetIdProject(Project.Id).Where(x => x.Id == InterestId).FirstOrDefault();

                    lblValues((decimal)interest.Present, (decimal)interest.Future);
                    DoNull(null, null, interest);
                }
            }
        }

        private void txtEnd__TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtEnd.Texts) > TotalPeriod)
                {
                    lblNotify.Text = "El valor final debe ser menor que el período total.";
                    lblNotify.Visible = true;
                    return;
                }
                if (Convert.ToInt64(txtEnd.Texts) <= 0)
                {
                    lblNotify.Text = "El valor final no puede ser 0";
                    lblNotify.Visible = true;
                    return;
                }
                if (Convert.ToInt32(txtInitial.Texts) > Convert.ToInt32(txtEnd.Texts))
                {
                    lblNotify.Text = "El valor inicial no puede ser mayor que el valor final.";
                    lblNotify.Visible = true;
                    return;
                }
               
                lblNotify.Visible = false;
            }
            catch
            {
                lblNotify.Visible = false;
            }


        }

        private void txtInitial__TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (Convert.ToInt32(txtInitial.Texts) > TotalPeriod)
                {
                    lblNotify.Text = "El valor inicial debe ser menor que el período total.";
                    lblNotify.Visible = true;
                    return;
                }
                if (Convert.ToInt32(txtInitial.Texts) > Convert.ToInt32(txtEnd.Texts))
                {
                    lblNotify.Text = "El valor inicial no puede ser mayor que el valor final.";
                    lblNotify.Visible = true;
                    return;
                }

                lblNotify.Visible = false;
            }
            catch
            {
                lblNotify.Visible = false;
            }

        }

        private void txtDuration__TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt64(txtDuration.Texts) < 2)
                {
                    lblNotifyDuration.Visible = true;
                    return;
                }
                lblNotifyDuration.Visible = false;
            }
            catch
            {
                lblNotifyDuration.Visible = false;
            }
        }

        private void txtRate__TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt64(txtRate.Texts) <= 0)
                {
                    lblNotifyTasaPrincipal.Visible = true;
                    return;
                }
                lblNotifyTasaPrincipal.Visible = false;
            }
            catch
            {
                lblNotifyTasaPrincipal.Visible = false;
            }
        }

        private void FadeIn_Tick(object sender, EventArgs e)
        {
            if (this.Opacity == 1)
            {
                FadeIn.Stop();
            }
            this.Opacity += 0.2;
        }

        private void txtDownPayment__TextChanged(object sender, EventArgs e)
        {
            if (txtDownPayment.Texts.Length > 0)
            {
                txtFinalPayment.Enabled = false;
            }
            else
            {
                txtFinalPayment.Enabled = true;
            }
        }

        private void txtFinalPayment__TextChanged(object sender, EventArgs e)
        {
            if (txtFinalPayment.Texts.Length > 0)
            {
                txtDownPayment.Enabled = false;
            }
            else
            {
                txtDownPayment.Enabled = true;
            }
        }

        private void pbDelete_DragOver(object sender, DragEventArgs e)
        {
            pbDelete.Image = Properties.Resources.DumpDrop;
        }

        private void pbDelete_DragLeave(object sender, EventArgs e)
        {
            pbDelete.Image = Properties.Resources.dump;
        }

        private void pbDelete_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
                e.Effect = DragDropEffects.Copy;
        }

        private void dgvInterest_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            /*
             * 
             * Anualidad
                Serie
                Interés
             * 
             */
            var objects = new List<object>();
            foreach (DataGridViewRow row in dgvInterest.SelectedRows)
            {
                if (cmbTypeIdgv.SelectedIndex == 0)
                {
                    objects.Add(AnnuityServices.GetIdProject(Project.Id).Where(x => x.Id == (int)row.Cells[0].Value).FirstOrDefault());
                }
                else if (cmbTypeIdgv.SelectedIndex == 1)
                {
                    objects.Add(SerieServices.GetIdProject(Project.Id).Where(x => x.Id == (int)row.Cells[0].Value).FirstOrDefault());
                }
                else if (cmbTypeIdgv.SelectedIndex == 2)
                {
                    objects.Add(InterestServices.GetIdProject(Project.Id).Where(x => x.Id == (int)row.Cells[0].Value).FirstOrDefault());
                }
                
            }
            dgvInterest.DoDragDrop(objects, DragDropEffects.Copy);
        }

        private void pbDelete_DragDrop(object sender, DragEventArgs e)
        {
            try
            {

                pbDelete.Image = Properties.Resources.dump;
                var objects = (List<object>)e.Data.GetData(typeof(List<object>));
                foreach (object ob in objects)
                {
                    if (cmbTypeIdgv.SelectedIndex==0)
                    {
                        Annuity annuity = AnnuityServices.GetIdProject(Project.Id).Where(x=>x.Id==(int)ob.GetType().GetProperty("Id").GetValue(ob)).FirstOrDefault();
                        AnnuityServices.Delete(annuity);
                    }
                    else if (cmbTypeIdgv.SelectedIndex == 1)
                    {
                        Serie serie= SerieServices.GetIdProject(Project.Id).Where(x => x.Id == (int)ob.GetType().GetProperty("Id").GetValue(ob)).FirstOrDefault();
                        SerieServices.Delete(serie);
                    }
                    else if (cmbTypeIdgv.SelectedIndex == 2)
                    {
                        Interest interest= InterestServices.GetIdProject(Project.Id).Where(x => x.Id == (int)ob.GetType().GetProperty("Id").GetValue(ob)).FirstOrDefault();
                        InterestServices.Delete(interest);
                    }

                }
                FillDGV();
                ClearPanel();
                lblValues(0, 0);
                graph_Paint(null, null);
            }
            catch
            {

            }

        }

        private void pbChanged_Click(object sender, EventArgs e)
        {
            DesactiveForm();
        }

        private void DoNull(Serie serie = null, Annuity annuity = null, Interest interest = null)
        {
            this.Serie = serie;
            this.Annuity = annuity;
            this.Interest = interest;

        }
    }
}
