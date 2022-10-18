using Economy.AppCore.Helper;
using Economy.AppCore.IServices;
using Economy.Domain.Entities;
using Economy.Infraestructure.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Economy.Forms
{
    public partial class FrmAssetAmount : Form
    {
        public IInversionFNEService inversionFNEService { get; set; }
        private Project project;

        public bool edit = false;

        Activo asset;
        public FrmAssetAmount(Activo asset, Project project)
        {
            InitializeComponent();
            this.asset = asset;
            this.project = project;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtAssetAmount.Value == 0) // no acepta que el monto sea igual a 0
            {
                MessageBox.Show("El valor no puede ser 0");
                return;
            }

            if (edit)
            {
                InversionFne fne = inversionFNEService.GetByName(asset.NombreActivo, project.Id);
                if (fne != null)
                {
                    inversionFNEService.Update(new InversionFne
                    {
                        Id = fne.Id,
                        Monto = txtAssetAmount.Value,
                    });
                    this.Close();
                    return;
                }
            }
            inversionFNEService.Create(new InversionFne
            {
                Monto = txtAssetAmount.Value,
                ActivoId = asset.Id,
                ProjectId = project.Id
            });
            //UserAssets.UAssets.Add(new UserAsset(asset, (double)txtAssetAmount.Value));
            UserAssets.UAssets.Add(new InversionFne
            {
                Monto = txtAssetAmount.Value,
                ActivoId = asset.Id,
                ProjectId = project.Id
            });
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
