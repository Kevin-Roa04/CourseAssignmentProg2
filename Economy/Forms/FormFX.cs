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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Economy.Forms
{
    public partial class FormFX : Form
    {
        public ICalculateServices<Annuity> calculateServicesAnnuity;
        public ICalculateServices<Interest> CalculateServicesInterest;
        public ICalculateServices<Serie> CalculateServicesSerie;
        private FormExcel FormExcel;
        public FormFX(FormExcel formExcel, ICalculateServices<Annuity> calculateServices, ICalculateServices<Interest> calculateService,
            ICalculateServices<Serie> calculateServicesSerie)
        {
            InitializeComponent();
            this.FormExcel = formExcel;
            this.calculateServicesAnnuity = calculateServices;
            this.CalculateServicesInterest = calculateService;
            this.CalculateServicesSerie = calculateServicesSerie;
        }

        private void FormFX_Load(object sender, EventArgs e)
        {
            String[] TypeFunction = Enum.GetNames(typeof(TypeFunctions));
            foreach (string function in TypeFunction)
            {
                this.lbFX.Items.Add(function);
            }
        }

        private void lbFX_DoubleClick(object sender, EventArgs e)
        {
            if ((int)lbFX.SelectedIndex >= 7)
            {
                Singleton singleton = Singleton.instance1;
                singleton.Selection = true;
            }
            FormFunction formFunction = new FormFunction(this.FormExcel, (int)lbFX.SelectedIndex, calculateServicesAnnuity,
                CalculateServicesInterest, CalculateServicesSerie);
            formFunction.Show();
            formFunction.BringToFront();
            this.Close();
        }
    }
}
