﻿using Economy.AppCore.IServices;
using Economy.Domain.Entities;
using Economy.Domain.Entities.DTO;
using Economy.Domain.Enums;
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
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cmelegir.SelectedIndex == 0)
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
                FillDGV(cmelegir.SelectedIndex);
            }
            else if(cmelegir.SelectedIndex == -1)
            {
                MessageBox.Show("You must fill the type of amortization", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (cmelegir.SelectedIndex == 1)
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
                    FillDGV(cmelegir.SelectedIndex);
                }
            }
        }

        private void FmrCalendarioDePago_Load(object sender, EventArgs e)
        {
            cmelegir.DataSource = Enum.GetValues(typeof(TypeAmortization));
            cmelegir.SelectedIndex = -1;
            grpocaculos.Visible = true;
            dgvAmortization.Visible = false;
        }
        private void FillDGV(int index)
        {
            dgvAmortization.Rows.Clear();
            dgvAmortization.Visible = true;
            Amortizacion amo = new Amortizacion()
            {
                interes = Convert.ToDouble(txtinters.Text),
                inversion = Convert.ToDouble(txtknversion.Text),
                plazo = Convert.ToDouble(txtplazo.Text),
                Saldo = Convert.ToDouble(txtknversion.Text)
            };
            AmortizationDTO amortizationDTO = new AmortizationDTO();
            for (int i = 0; i <= Convert.ToDouble(txtplazo.Text); i++)
            {
                if(i == 0)
                {
                    this.dgvAmortization.Rows.Add(0, 0, 0, 0, Convert.ToDouble(txtknversion.Text));
                    continue;
                }
                else
                {
                    if (index == 0)
                    {
                        amortizationDTO =  amortizacionServices.Metodo1(amo);
                        this.dgvAmortization.Rows.Add(i, amortizationDTO.Credit_memo, amortizationDTO.interest, amortizationDTO.payment, amortizationDTO.outstanding_balance);
                    }
                    else if (index == 1)
                    {
                        amortizationDTO = amortizacionServices.Metodo2(amo);
                        this.dgvAmortization.Rows.Add(i, amortizationDTO.Credit_memo, amortizationDTO.interest, amortizationDTO.payment, amortizationDTO.outstanding_balance);
                    }
                }
                amo.Saldo = amortizationDTO.outstanding_balance;
            }
        }
    }
}
