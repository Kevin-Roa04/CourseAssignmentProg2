using Appcore.Interface;
using Autofac.Core;
using Economy.AppCore.IServices;
using Economy.Domain.Entities;
using Economy.Domain.Enums;
using InteresPratica;
using Proto1._0;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Economy.Forms
{
    public partial class FormCreateProject : Form
    {
        public IProjectServices projectServices { get; set; }

        #region -> Interests service
        public IInterestServices<Annuity> AnnuityServices { get; set; }
        public IInterestServices<Serie> SerieServices { get; set; }
        public IInterestServices<Interest> InterestServices { get; set; }
       
        #endregion

        #region -> Calculate service
        public ICalculateServices<Annuity> calculateServicesAnnuity;
        public ICalculateServices<Interest> CalculateServicesInterest;
        public ICalculateServices<Serie> CalculateServicesSerie;
        public INominalServices nominal;
        #endregion
        private User GlobalUser;
        private int Selection = -1;
        public ISimpleService simpleService;
        public ICompuestoService compuestoService1;
        public IConvertService convertService1;
        public IDepreciationService depreciationService;
        public IAmortizacionServices amortizacionServices;
        public FormCreateProject(User user)
        {
            this.GlobalUser = user;
            InitializeComponent();
        }

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
                    this.Region = new Region(graphicsPath);
                    e.Graphics.DrawPath(pen, graphicsPath);
                }

            }
            else this.Region = new Region(rectangleF);

        }

        #endregion

        #region -> form movement
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void FormCreateProject_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Selection = 0;
            pnCreateProject.Visible = true;

        }

        private void btnCreateProject_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtProjectName.Texts))
            {
                MessageBox.Show("Write project name");
                return;
            }
            Project project = new Project()
            {
                Name = txtProjectName.Texts,
                Creation = DateTime.Now,
                Type = ((TypeProject)Selection).ToString(),
                User = GlobalUser,
                UserId = GlobalUser.Id
            };
            projectServices.Create(project);
            this.Hide();
            if(Selection == 0)
            {
                FormGraphInterest formGraphInterest = new FormGraphInterest(project);
                formGraphInterest.InterestServices = this.InterestServices;
                formGraphInterest.SerieServices = this.SerieServices;
                formGraphInterest.AnnuityServices = this.AnnuityServices;
                formGraphInterest.FormCreateProject = this;
                formGraphInterest.ShowDialog();
            }
            else if(Selection == 1)
            {
                FormExcel formExcel = new FormExcel(calculateServicesAnnuity, CalculateServicesInterest, CalculateServicesSerie);
                formExcel.ShowDialog();

                
            }
            else if (Selection == 2)
            {

                FmrInteres fmrInteres = new FmrInteres(nominal);
                fmrInteres.FormCreateProject = this;
                fmrInteres.ShowDialog();

            }
            else if(Selection == 3)
            {
                Inicio ins = new Inicio(simpleService, compuestoService1, convertService1);
                ins.FormCreateProject = this;
                ins.ShowDialog();
            }
            else if(Selection == 4)
            {
                FmrCalendarioDePago fmrCalendarioDePago = new FmrCalendarioDePago(amortizacionServices);
                fmrCalendarioDePago.ShowDialog();
            }
            else if(Selection == 5)
            {
                Depreciacion depreciacion = new Depreciacion(depreciationService);
                depreciacion.ShowDialog();
            }
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Selection = 1;
            pnCreateProject.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void customPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Selection = 2;
            pnCreateProject.Visible = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Selection = 3;
            pnCreateProject.Visible = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Selection = 4;
            pnCreateProject.Visible = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Selection = 5;
            pnCreateProject.Visible = true;
        }
    }
}
