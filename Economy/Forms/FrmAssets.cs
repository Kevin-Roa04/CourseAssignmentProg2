using Appcore.Interface;
using Economy.AppCore.Helper;
using Economy.AppCore.IServices;
using Economy.Domain.Entities;
using Economy.Domain.Enums;
using Economy.Infraestructure.Repository;
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

        public bool BringingDataFromDB = false;

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
            UserAssets.UAssets = inversionFNEService.GetListByProjectId(project.Id);
            dgvAssets.DataSource = UserAssets.DataExtraction();
            AutocompleteAssetsData();

            calculateTotalAssets();
            notDepreciable.Text = FNEData.notDepreciableAssetsValue.ToString();
            Depreciable.Text = FNEData.DepreciableAssetsValue.ToString();
            total.Text = FNEData.Inversion.ToString();
            if (BringingDataFromDB)
            {
                depreciacion.depreciationService = this.depreciacionService;
                depreciacion.tmp = true;
                depreciacion.ShowDialog();
                BringingDataFromDB = false;
                this.Close();
            }
        }

        private void AutocompleteAssetsData()
        { // autocopletar el texbox para seleccionar activos
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
            UserAssets.UAssets = inversionFNEService.GetListByProjectId(project.Id);
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
                    Depreciable += double.Parse(dgvAssets.Rows[i].Cells[3].Value.ToString());
                }
                else // si no es depreciable
                {
                    notDepreciable += double.Parse(dgvAssets.Rows[i].Cells[3].Value.ToString());
                }
            }
            Total = notDepreciable + Depreciable;
            // colocando los resultados en los labels
            this.notDepreciable.Text = notDepreciable.ToString();
            this.Depreciable.Text = Depreciable.ToString();
            this.total.Text = Total.ToString();
            //setteando la inversion total
            FNEData.DepreciableAssetsValue = (decimal)Depreciable;
            FNEData.notDepreciableAssetsValue = (decimal)notDepreciable;
            FNEData.Inversion = (decimal)Total;
        }

        private void btnDepreciacion_Click(object sender, EventArgs e)
        {
            //if(FNEData.DepreciableAssetsValue == 0) return;
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

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InversionFne inversionFne = inversionFNEService.GetByName(seleccionarNombreActivo(), project.Id);
            inversionFNEService.Delete(inversionFne);
            UserAssets.UAssets = inversionFNEService.GetListByProjectId(project.Id);
            dgvAssets.DataSource = UserAssets.DataExtraction();
            calculateTotalAssets();
            depreciacion.flag = true;
            depreciacion.depreciationService = this.depreciacionService;
            depreciacion.ShowDialog();
            depreciacion.flag = false;
            txtAssets.Text = "";
        }

        private double seleccionarMonto()
        {
            return (double)dgvAssets.CurrentRow.Cells[3].Value;
        }

        private string seleccionarNombreActivo()
        {
            return dgvAssets.CurrentRow.Cells[0].Value.ToString();
        }

        private void dgvAssets_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) return;
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            dgvAssets.CurrentCell = dgvAssets.Rows[e.RowIndex].Cells[e.ColumnIndex];
            contextMenuStrip1.Show(Cursor.Position);
        }

        private void editarMontoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InversionFne activo = inversionFNEService.GetByName(seleccionarNombreActivo(), project.Id);
            FrmAssetAmount frm = new FrmAssetAmount(activo.Activo, project);
            frm.inversionFNEService = this.inversionFNEService;
            frm.edit = true;
            frm.ShowDialog();

            dgvAssets.DataSource = null;
            UserAssets.UAssets = inversionFNEService.GetListByProjectId(project.Id);
            dgvAssets.DataSource = UserAssets.DataExtraction();
            //colocar la sumatoria en pantalla
            calculateTotalAssets();
            depreciacion.flag = true;
            depreciacion.depreciationService = this.depreciacionService;
            depreciacion.tmp = true;
            depreciacion.ShowDialog();
            depreciacion.flag = false;
            txtAssets.Text = "";
        }
    }
}
