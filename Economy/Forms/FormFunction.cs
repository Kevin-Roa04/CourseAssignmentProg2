using Economy.AppCore.IServices;
using Economy.Domain.Entities;
using Economy.UsersControl;
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
    public partial class FormFunction : Form
    {

        public ICalculateServices<Annuity> calculateServicesAnnuity;
        public ICalculateServices<Interest> CalculateServicesInterest;
        public ICalculateServices<Serie> CalculateServicesSerie;
        public int Index;
        private UserControlFunction UserControlFunction;
        public FormFunction(FormExcel formExcel, int Index, ICalculateServices<Annuity> calculateServices, ICalculateServices<Interest> calculateService,
            ICalculateServices<Serie> calculateServicesSerie, int typeIndex)
        {
            InitializeComponent();
            this.Index = Index;
            this.calculateServicesAnnuity = calculateServices;
            this.CalculateServicesInterest = calculateService;
            this.CalculateServicesSerie = calculateServicesSerie;
            this.UserControlFunction = new UserControlFunction(Index, formExcel, this.calculateServicesAnnuity, this.CalculateServicesInterest, this, calculateServicesSerie, typeIndex);
        }

        private void FormFunction_Load(object sender, EventArgs e)
        {
            flpFunction.Controls.Add(UserControlFunction);
        }

        private void FormFunction_Activated(object sender, EventArgs e)
        {
            UserControlFunction.FillTextBox();
        }
    }
}
