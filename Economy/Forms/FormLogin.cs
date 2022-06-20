using Appcore.Interface;
using Economy.AppCore.IServices;
using Economy.Domain.Entities;
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

    public partial class FormLogin : Form
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
        public IUsersServices UsersServices { get; set; }
        public IProjectServices projectServices { get; set; }

        #region -> Interests service
        private IInterestServices<Annuity> AnnuityServices { get; set; }
        private IInterestServices<Serie> SerieServices { get; set; }
        private IInterestServices<Interest> InterestServices { get; set; }
        private INominalServices nominalServices { get; set; }
        #endregion
        #region -> Calculate service
        private ICalculateServices<Annuity> calculateServicesAnnuity;
        private ICalculateServices<Interest> CalculateServicesInterest;
        private ICalculateServices<Serie> calculateServicesSerie;
        #endregion
        private User User;
        private ISimpleService simpleService;
        private ICompuestoService compuestoService1;
        private IConvertService convertService1;
        private IDepreciationService depreciationService;
        public FormLogin(IUsersServices services, IProjectServices project, IInterestServices<Annuity> annuity,
            IInterestServices<Serie> Serie, IInterestServices<Interest> interest,
            ICalculateServices<Annuity> calculateServicesAnnuity,
            ICalculateServices<Interest> calculateServicesInterest, INominalServices nominal,
            ICalculateServices<Serie> calculateServicesSerie, ISimpleService simpleService, ICompuestoService compuestoService,
            IConvertService convertService, IDepreciationService depreciationService
            )
        {
            this.InterestServices = interest;
            this.SerieServices = Serie;
            this.AnnuityServices = annuity;
            this.projectServices = project;
            this.UsersServices = services;
            this.calculateServicesAnnuity = calculateServicesAnnuity;
            this.CalculateServicesInterest = calculateServicesInterest;
            this.nominalServices = nominal;
            this.calculateServicesSerie = calculateServicesSerie;
            this.simpleService = simpleService;
            this.compuestoService1 = compuestoService;
            this.convertService1 = convertService;
            this.depreciationService = depreciationService;

            InitializeComponent();
        }
        public FormLogin()
        {
            InitializeComponent();
        }

        #region -> form movement

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion
        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private bool ValidateForm()
        {
            if (string.IsNullOrEmpty(txtName.Texts) || String.IsNullOrEmpty(txtPassword.Texts))
            {
                return false;
            }
            return true;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {

            this.Hide();
            FormCreateUser formCreateUser = new FormCreateUser();
            formCreateUser.UsersServices = this.UsersServices;
            formCreateUser.ShowDialog();
            this.ShowDialog();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                MessageBox.Show("Fill in the entire form, please");
                return;
            }

            User user = UsersServices.Registration(txtName.Texts, txtPassword.Texts);
            if (user == null)
            {
                MessageBox.Show("User is not registered");
                return;
            }
            else
            {

                User = user;
                this.Hide();
                FormCreateProject formCreateProject = new FormCreateProject(User);
                formCreateProject.projectServices = this.projectServices;
                formCreateProject.SerieServices = this.SerieServices;
                formCreateProject.AnnuityServices = this.AnnuityServices;
                formCreateProject.InterestServices = this.InterestServices;
                formCreateProject.calculateServicesAnnuity = this.calculateServicesAnnuity;
                formCreateProject.CalculateServicesInterest = this.CalculateServicesInterest;
                formCreateProject.nominal = this.nominalServices;
                formCreateProject.CalculateServicesSerie = this.calculateServicesSerie;
                formCreateProject.simpleService = this.simpleService;
                formCreateProject.compuestoService1 = this.compuestoService1;
                formCreateProject.convertService1 = this.convertService1;
                formCreateProject.depreciationService = this.depreciationService;
                formCreateProject.ShowDialog();

            }
        }
    }
}
