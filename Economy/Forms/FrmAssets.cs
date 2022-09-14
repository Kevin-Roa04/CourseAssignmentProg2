using Appcore.Interface;
using Economy.AppCore.Helper;
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
        AutoCompleteStringCollection source;
        Depreciacion depreciacion;
        public FrmAssets(Depreciacion depreciacion)
        {
            InitializeComponent();
            source = new AutoCompleteStringCollection();
            this.depreciacion = depreciacion;
            AutocompleteAssetsData(); 
        }
        private void FrmAssets_Load(object sender, EventArgs e)
        {
        }

        private void AutocompleteAssetsData()
        {
            foreach(Asset asset in AssetsData.assets)
            {
                source.Add(asset.AssetName);
            }

            this.txtAssets.AutoCompleteCustomSource = source;
        }

        private Asset findAsset()
        {
            foreach(var asset in AssetsData.assets)
            {
                if(asset.AssetName == txtAssets.Text)
                {
                    return asset;
                }
            }
            return null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Asset asset = findAsset();
            if (asset != null) {
                FrmAssetAmount frmAssetAmount = new FrmAssetAmount(asset);
                frmAssetAmount.ShowDialog();
            }
            else {
                return;
            }
            dgvAssets.DataSource = null;
            dgvAssets.DataSource = UserAssets.DataExtraction();
            //colocar la sumatoria en pantalla
            calculateTotalAssets();
            depreciacion.flag = true;
            depreciacion.ShowDialog();
            depreciacion.flag = false;
        }

        private void calculateTotalAssets()
        {
            double notDepreciable = 0;
            double Depreciable = 0;
            double Total = 0;


            for(int i = 0; i < dgvAssets.Rows.Count; i++)
            {
                if ((bool)dgvAssets.Rows[i].Cells[3].Value == true) // si es depreciable
                {
                    Depreciable += (double)dgvAssets.Rows[i].Cells[4].Value;
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
            depreciacion.ShowDialog();
        }
    }
}
