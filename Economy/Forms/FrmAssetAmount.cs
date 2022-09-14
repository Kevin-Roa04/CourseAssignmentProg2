using Economy.AppCore.Helper;
using Economy.Domain.Entities;
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
    public partial class FrmAssetAmount : Form
    {
        Asset asset;
        public FrmAssetAmount(Asset asset)
        {
            InitializeComponent();
            this.asset = asset;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserAssets.UAssets.Add(new UserAsset(asset, (double)txtAssetAmount.Value));
            this.Close();
        }
    }
}
