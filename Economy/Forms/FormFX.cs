using Economy.AppCore.IServices;
using Economy.AppCore.Singleton;
using Economy.Domain.Entities;
using Economy.Domain.Enums;
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
    public partial class FormFX : Form
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
        private FormExcel FormExcel;
        private int index;
        
        Dictionary<string,string> typeFunctionsDictionary = new Dictionary<string,string>();
        public FormFX(FormExcel formExcel, ICalculateServices<Annuity> calculateServices, ICalculateServices<Interest> calculateService,
            ICalculateServices<Serie> calculateServicesSerie, int index)
        {
            InitializeComponent();
            this.FormExcel = formExcel;
            this.calculateServicesAnnuity = calculateServices;
            this.CalculateServicesInterest = calculateService;
            this.CalculateServicesSerie = calculateServicesSerie;
            this.index = index;
            TypeFunctions();
        }

        public void TypeFunctions()
        {
            typeFunctionsDictionary.Add("A_Tasa_Efectiva", "Tasa efectiva");
            typeFunctionsDictionary.Add("A_Tasa_Nominal", "Tasa nominal");
            typeFunctionsDictionary.Add("Anualidades", "Anualidades");
            typeFunctionsDictionary.Add("Presente_Anualidades", "Presente de anualidades");
            typeFunctionsDictionary.Add("Futuro_Anualidades", "Futuro de anualidades");
            typeFunctionsDictionary.Add("Presente_Series", "Presente de series");
            typeFunctionsDictionary.Add("Futuro_Series", "Futuro de series");
            typeFunctionsDictionary.Add("FNE", "Flujo neto de efectivo");
            typeFunctionsDictionary.Add("VPN", "Valor Presente Neto");
            typeFunctionsDictionary.Add("TIR", "Tasa Interna de Retorno");
            typeFunctionsDictionary.Add("Depreciacion_Linea_Recta", "Depreciación línea recta");
            typeFunctionsDictionary.Add("Depreciacion_Doble_Saldo_Decreciente", "Depreciación de doble saldo decreciente");
            typeFunctionsDictionary.Add("Depreciacion_Suma_Digito_De_Años", "Depreciación de suma de los digítos de los años");
        }
        private void FormFX_Load(object sender, EventArgs e)
        {
            if (index == 0)
            {
                String[] TypeFunction = Enum.GetNames(typeof(TypeFunctions));
                foreach (string function in TypeFunction)
                {
                    this.lbFX.Items.Add(typeFunctionsDictionary[function]);
                }
                this.Text = "Funciones especiales";
            }
            else if (index == 1)
            {
                String[] TypeFunction = Enum.GetNames(typeof(TypeBasicFunction));
                foreach (string function in TypeFunction)
                {
                    this.lbFX.Items.Add(function);
                }
                this.Text = "Funciones básicas";
            }
        }

        private void lbFX_DoubleClick(object sender, EventArgs e)
        {
            if (((int)lbFX.SelectedIndex >= 7 && index == 0) || ((int)lbFX.SelectedIndex == 0 && index == 1)
                || ((int)lbFX.SelectedIndex == 2 && index == 1))
            {
                Singleton singleton = Singleton.instance1;
                singleton.Selection = true;
            }
            FormFunction formFunction = new FormFunction(this.FormExcel, (int)lbFX.SelectedIndex, calculateServicesAnnuity,
                CalculateServicesInterest, CalculateServicesSerie, index);
            formFunction.Show();
            formFunction.BringToFront();
            this.Close();
        }

        private void PbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbFX_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
          
        }

        private void FormFX_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
