using Economy.AppCore.IServices;
using InteresPratica;
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
    public partial class FmrMenu : Form
    {
        public INominalServices interestServices;
        public FormCreateProject FormCreateProject;
        public FmrMenu(INominalServices services)
        {
            InitializeComponent();
            this.interestServices = services;
            this.cmbmenu.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cmbmenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbmenu.SelectedIndex == 0)
            {
                FmrInteres fmr = new FmrInteres(interestServices);
                fmr.ShowDialog();
            }
            else
            {
                if (cmbmenu.SelectedIndex == 1)
                {
                    FmrInteresNosemejante1 fmrInteresNosemejante =  new FmrInteresNosemejante1(interestServices);
                    fmrInteresNosemejante.ShowDialog();
                }
            }
        }
    }
}
