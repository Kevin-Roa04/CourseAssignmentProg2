using Economy.AppCore.IServices;
using InteresPratica;
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
    public partial class FmrMenu : Form
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
         
        }

        private void cmbmenu_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbmenu.SelectedIndex == 0)
            {
                FmrInteres fmr = new FmrInteres(interestServices);
                fmr.ShowDialog();
            }
         
             else   if (cmbmenu.SelectedIndex == 1)
                {
                    FmrInteresNosemejante1 fmrInteresNosemejante = new FmrInteresNosemejante1(interestServices);
                    fmrInteresNosemejante.ShowDialog();
                }
            else if (cmbmenu.SelectedIndex == 2)
            {
                FmrConvertidor fmr = new FmrConvertidor(interestServices);
                fmr.ShowDialog();

            }

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


        private void FmrMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
