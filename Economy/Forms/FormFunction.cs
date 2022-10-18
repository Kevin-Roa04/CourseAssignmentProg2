using Economy.AppCore.IServices;
using Economy.Domain.Entities;
using Economy.UsersControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Economy.Forms
{
    public partial class FormFunction : Form
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
        public ICalculateServices<Annuity> calculateServicesAnnuity;
        public ICalculateServices<Interest> CalculateServicesInterest;
        public ICalculateServices<Serie> CalculateServicesSerie;
        public int Index;
        private UserControlFunction UserControlFunction;
        public FormFunction(FormExcel formExcel, int Index, ICalculateServices<Annuity> calculateServices, ICalculateServices<Interest> calculateService,
            ICalculateServices<Serie> calculateServicesSerie)
        {
            InitializeComponent();
            this.Index = Index;
            this.calculateServicesAnnuity = calculateServices;
            this.CalculateServicesInterest = calculateService;
            this.CalculateServicesSerie = calculateServicesSerie;
            this.UserControlFunction = new UserControlFunction(Index, formExcel, this.calculateServicesAnnuity, this.CalculateServicesInterest, this, calculateServicesSerie);
        }

        private void FormFunction_Load(object sender, EventArgs e)
        {
            flpFunction.Controls.Add(UserControlFunction);
        }

        private void FormFunction_Activated(object sender, EventArgs e)
        {
            UserControlFunction.FillTextBox();
        }

        private void PbClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
