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
            if(txtAssetAmount.Value == 0) // no acepta que el monto sea igual a 0
            {
                MessageBox.Show("El valor no puede ser 0");
                return;
            }
            UserAssets.UAssets.Add(new UserAsset(asset, (double)txtAssetAmount.Value));
            this.Close();
        }

        private void ValidateNegativeNumber(KeyEventArgs e, decimal DefaultNum, NumericUpDown num)
        {
            if (e.KeyCode == Keys.Subtract)
            {
                MessageBox.Show("Ingrese un valor valido");
                num.ResetText();
                num.Value = DefaultNum;
                num.UpButton();
                num.DownButton();
                return;
            }
        }

        private void txtAssetAmount_KeyUp(object sender, KeyEventArgs e)
        {
            ValidateNegativeNumber(e, 0, txtAssetAmount);
        }
    }
}
