using Economy.AppCore.IServices;
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
    public partial class FmrCalendarioDePago : Form
    {
        public IAmortizacionServices amortizacionServices;
        public FmrCalendarioDePago(IAmortizacionServices services )
        {
            InitializeComponent();
            this.amortizacionServices = services;
            this.cmelegir.DropDownStyle = ComboBoxStyle.DropDownList;
            grpocaculos.Visible = false;
            datacalendario.Visible = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(cmelegir.SelectedIndex == 0)
            {
                if (string.IsNullOrEmpty(txtinters.Text) || string.IsNullOrEmpty(txtknversion.Text) || string.IsNullOrEmpty(txtplazo.Text))
                {
                    MessageBox.Show("Tienes que rellenar todos los formularios.");
                    return;
                }
                if (double.Parse(txtinters.Text) <= 0
                    || double.Parse(txtknversion.Text) <= 0
                    || double.Parse(txtplazo.Text) <= 0)
                {
                    MessageBox.Show("Los Datos No puede ser Negativos  y Tampoco Puden ser cero");
                    return;
                }
                Amotizacion amo= new Amotizacion()
                {
                    interes  = Convert.ToDouble(txtinters.Text),
                    inversion = Convert.ToDouble(txtknversion.Text),
                    plazo = Convert.ToDouble(txtplazo.Text)
                };
                amortizacionServices.Metodo1(amo);
            }
            else
            {
                if(cmelegir.SelectedIndex == 1)
                {
                    if (string.IsNullOrEmpty(txtinters.Text) || string.IsNullOrEmpty(txtknversion.Text) || string.IsNullOrEmpty(txtplazo.Text))
                    {
                        MessageBox.Show("Tienes que rellenar todos los formularios.");
                        return;
                    }
                    if (double.Parse(txtinters.Text) <= 0
                        || double.Parse(txtknversion.Text) <= 0
                        || double.Parse(txtplazo.Text) <= 0)
                    {
                        MessageBox.Show("Los Datos No puede ser Negativos  y Tampoco Puden ser cero");
                        return;
                    }
                    Amotizacion amo = new Amotizacion()
                    {
                        interes = Convert.ToDouble(txtinters.Text),
                        inversion = Convert.ToDouble(txtknversion.Text),
                        plazo = Convert.ToDouble(txtplazo.Text)
                    };
                    amortizacionServices.Metodo2(amo);
                }
            }
        }
    }
}
