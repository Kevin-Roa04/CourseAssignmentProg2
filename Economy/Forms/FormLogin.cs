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
using System.Runtime.CompilerServices;
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
        //private int borderRadius = 10;

        //private GraphicsPath GetCustomPanelPath(RectangleF rectangle, float radius)
        //{
        //    float curveSize = radius * 2F;
        //    GraphicsPath graphicsPath = new GraphicsPath();
        //    graphicsPath.StartFigure();
        //    graphicsPath.AddArc((rectangle.Width - curveSize), rectangle.Height - curveSize, curveSize, curveSize, 0, 90);
        //    graphicsPath.AddArc(rectangle.X, (rectangle.Height - curveSize), curveSize, curveSize, 90, 90);
        //    graphicsPath.AddArc(rectangle.X, rectangle.Y, curveSize, curveSize, 180, 90);
        //    graphicsPath.AddArc((rectangle.Width - curveSize), rectangle.Y, curveSize, curveSize, 270, 90);
        //    graphicsPath.CloseFigure();
        //    return graphicsPath;
        //}
        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    base.OnPaint(e);

        //    RectangleF rectangleF = new RectangleF(0, 0, this.Width, this.Height);

        //    if (borderRadius > 2)
        //    {
        //        using (GraphicsPath graphicsPath = GetCustomPanelPath(rectangleF, borderRadius))
        //        using (Pen pen = new Pen(this.BackColor, 2))
        //        {

        //            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        //            this.Region = new Region(graphicsPath);

        //            e.Graphics.DrawPath(pen, graphicsPath);
        //        }

        //    }
        //    else this.Region = new Region(rectangleF);

        //}

        #endregion
        public IUsersServices UsersServices { get; set; }
        public IProjectServices projectServices { get; set; }

     
        public bool blocked = false;
        public int seconds = 0;
        public int intents = 0;
        public bool onPassword = false;
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
        private IAmortizacionServices amortizacionServices;
        private IProfitService profitService;
        private ICostService costService;
        private IInversionFNEService inversionFNEService;
        private IActivosService activosService;
        private IDepreciacionService depreciacionService;
        private IAmorizacionService amorizacionService;
        private IFNEService FneService;
        public FormLogin(IUsersServices services, IProjectServices project, IInterestServices<Annuity> annuity,
            IInterestServices<Serie> Serie, IInterestServices<Interest> interest,
            ICalculateServices<Annuity> calculateServicesAnnuity,
            ICalculateServices<Interest> calculateServicesInterest, INominalServices nominal,
            ICalculateServices<Serie> calculateServicesSerie, ISimpleService simpleService, ICompuestoService compuestoService,
            IConvertService convertService, IDepreciationService depreciationService, IAmortizacionServices amortizacionServices,
            IProfitService profitService, ICostService costService, IInversionFNEService inversionFNEService, IActivosService activosService,
            IDepreciacionService depreciacionService, IAmorizacionService amorizacionService, IFNEService FneService
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
            this.amortizacionServices = amortizacionServices;
            this.profitService = profitService;
            this.costService = costService;
            this.inversionFNEService = inversionFNEService;
            this.activosService = activosService;
            this.depreciacionService = depreciacionService;
            this.amorizacionService = amorizacionService;
            this.FneService = FneService;

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
            this.FadeOut.Enabled = true;
            FadeOut.Start();
            this.Hide();
            FormCreateUser formCreateUser = new FormCreateUser();
            formCreateUser.UsersServices = this.UsersServices;
            formCreateUser.ShowDialog();
            this.Opacity = 0;
            this.Show();
            this.FadeIn.Enabled = true;
            this.FadeIn.Start();
          
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                MessageBox.Show("Rellene todos el formulario, por favor.");
                return;
            }

            User user = UsersServices.Registration(txtName.Texts, txtPassword.Texts);
            if (user == null)
            {
                intents++;

                if (intents == 3)
                {
                    btnSignIn.Visible = false;
                    lblNotifyDuration.Text = "Has hecho 3 intentos. Espera un minuto.";
                    lblNotifyDuration.Visible = true;
                    txtName.Texts = "";
                    txtPassword.Texts = "";
                    tLock.Enabled = true;
                    intents = 0;
                }
                MessageBox.Show("El usuario no se encuentra registrado.");
                return;
            }
            else
            {

                User = user;
                FadeOut.Start();
               // this.Hide();
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
                formCreateProject.amortizacionServices = this.amortizacionServices;
                formCreateProject.profitService = this.profitService;
                formCreateProject.costService = this.costService;
                formCreateProject.inversionFNEService = this.inversionFNEService;
                formCreateProject.activosService = this.activosService;
                formCreateProject.depreciacionService = this.depreciacionService;
                formCreateProject.amortizacionService = this.amorizacionService;
                formCreateProject.fneService = this.FneService;

                formCreateProject.ShowDialog();

            }
        }


        private void PbClose_Click(object sender, EventArgs e)
        {
            tLock.Enabled = false;
            Application.Exit();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void tLock_Tick(object sender, EventArgs e)
        {
            seconds++;
            if (seconds >= 60)
            {
                lblNotifyDuration.Visible = false;
                btnSignIn.Visible = true;
                lblSeconds.Visible = false;
                tLock.Enabled = false;
                seconds = 0;
                intents = 0;
                return;
            }
            lblSeconds.Visible = true;
            lblSeconds.Text = "00:"+seconds.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            onPassword = !onPassword;
            if (onPassword)
            {
                txtPassword.PasswordChar = true;
            }
            else
            {
                txtPassword.PasswordChar = false;
            }
        }

        private void FadeOut_Tick(object sender, EventArgs e)
        {
            if (this.Opacity <= 0)
            {
                this.Hide();
                FadeOut.Stop();
            }
            this.Opacity -= 0.2;
        }

        private void FadeIn_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                FadeIn.Stop();
            }
            this.Opacity += .2;
        }

        private void txtPassword_TabIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!lblSeconds.Visible)
            {
                if (Convert.ToInt32(e.KeyChar) == 13)
                {
                    btnSignIn_Click(null, null);
                }
            }

        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
           
        }
    }
}
