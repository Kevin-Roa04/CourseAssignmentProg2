using Appcore.Interface;
using Economy.AppCore.Helper;
using Economy.AppCore.IServices;
using Economy.Domain.Entities;
using Economy.Domain.Enums;
using Proto1._0;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Economy.Forms
{
    public partial class FrmAssets : Form
    {
        public IInversionFNEService inversionFNEService { get; set; }
        public IActivosService activosService { get; set; }
        public IDepreciacionService depreciacionService { get; set; }
        private Project project;

        AutoCompleteStringCollection source;
        FrmDepreciacion depreciacion;
        public FrmAssets(FrmDepreciacion depreciacion, Project project)
        {
            InitializeComponent();
            source = new AutoCompleteStringCollection();
            this.depreciacion = depreciacion;
            this.project = project;
        }
        private void FrmAssets_Load(object sender, EventArgs e)
        {
            AssetsData.assets = activosService.GetAll();
            AutocompleteAssetsData();
        }

        private void AutocompleteAssetsData()
        {
            foreach(Activo asset in AssetsData.assets)
            {
                source.Add(asset.NombreActivo);
            }

            this.txtAssets.AutoCompleteCustomSource = source;
        }

        private Activo findAsset()
        {
            foreach(var asset in AssetsData.assets)
            {
                if(asset.NombreActivo == txtAssets.Text)
                {
                    return asset;
                }
            }
            return null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Activo asset = findAsset();
            if (asset != null) {
                FrmAssetAmount frmAssetAmount = new FrmAssetAmount(asset, project);
                frmAssetAmount.inversionFNEService = inversionFNEService;
                frmAssetAmount.ShowDialog();
            }
            else {
                MessageBox.Show("Ingrese un activo financiero valido");
                return;
            }
            dgvAssets.DataSource = null;
            dgvAssets.DataSource = UserAssets.DataExtraction();
            //colocar la sumatoria en pantalla
            calculateTotalAssets();
            depreciacion.flag = true;
            depreciacion.depreciationService = this.depreciacionService;
            depreciacion.ShowDialog();
            depreciacion.flag = false;
            txtAssets.Text = "";
        }

        private void calculateTotalAssets()
        {
            double notDepreciable = 0;
            double Depreciable = 0;
            double Total = 0;


            for(int i = 0; i < dgvAssets.Rows.Count; i++)
            {
                if ((bool)dgvAssets.Rows[i].Cells[2].Value == true) // si es depreciable
                {
                    Depreciable += (double)dgvAssets.Rows[i].Cells[3].Value;
                }
                else // si no es depreciable
                {
                    notDepreciable += (double)dgvAssets.Rows[i].Cells[4].Value;
                }
            }
            Total = notDepreciable + Depreciable;
            // colocando los resultados en los labels
            this.notDepreciable.Text = notDepreciable.ToString();
            this.Depreciable.Text = Depreciable.ToString();
            this.total.Text = Total.ToString();
            //setteando la inversion total
            FNEData.DepreciableAssetsValue = (decimal)Depreciable;
            FNEData.Inversion = (decimal)Total;
        }

        private void btnDepreciacion_Click(object sender, EventArgs e)
        {
            if(FNEData.DepreciableAssetsValue == 0) return;
            depreciacion.depreciationService = this.depreciacionService;
            depreciacion.ShowDialog();
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

        private void FrmAssets_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
