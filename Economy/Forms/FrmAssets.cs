using Economy.AppCore.Helper;
using Economy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Economy.Forms
{
    public partial class FrmAssets : Form
    {
        AutoCompleteStringCollection source;
        public FrmAssets()
        {
            InitializeComponent();
            source = new AutoCompleteStringCollection();
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
        }

        private void calculateTotalAssets()
        {

        }
    }
}
