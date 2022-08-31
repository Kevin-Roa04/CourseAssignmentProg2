﻿using Appcore.Interface;
using Economy.AppCore.Helper;
using Economy.AppCore.IServices;
using Proto1._0;
using System;
using System.Windows.Forms;

namespace Economy.Forms
{
    public partial class FormFNE : Form
    {
        bool calculated = false;

        private IAmortizacionServices amortizacionServices;
        private IDepreciationService depreciationService;

        private FormAddProfit addProfit;
        private FormAddCosts addCost;
        private FmrCalendarioDePago fmrCalendarioDePago;
        private Depreciacion depreciacion;
        public FormFNE( IAmortizacionServices amortizacionServices, IDepreciationService depreciationService)
        {
            InitializeComponent();
            addProfit = new FormAddProfit((int)txtYears.Value, dgvFNE);
            addCost = new FormAddCosts((int)txtYears.Value, dgvFNE);
            this.amortizacionServices = amortizacionServices;
            this.depreciationService = depreciationService;
            fmrCalendarioDePago = new FmrCalendarioDePago(amortizacionServices, (int)txtYears.Value, dgvFNE);
            depreciacion = new Depreciacion(depreciationService, (int)txtYears.Value, dgvFNE);
        }

        private void FormFNE_Load(object sender, EventArgs e)
        {
            LoadFNETable();
        }

        private void LoadDGV(int columns)
        {
            for (int i = 0; i < columns+2; i++)
            {
                if (i == 0)
                {
                    dgvFNE.Columns.Add("", "");
                    continue;
                }
                dgvFNE.Columns.Add((i - 1).ToString(), (i - 1).ToString());
            }
            for (int i = 0; i < 15; i++)
            {
                dgvFNE.Rows.Add();
            }
            dgvFNE.Rows[0].Cells[0].Value = "Ingresos";
            dgvFNE.Rows[1].Cells[0].Value = "Costos";
            dgvFNE.Rows[2].Cells[0].Value = "Intereses";
            dgvFNE.Rows[3].Cells[0].Value = "Depreciacion";
            dgvFNE.Rows[4].Cells[0].Value = "Utilidad antes de impuestos";
            dgvFNE.Rows[5].Cells[0].Value = "IR";
            dgvFNE.Rows[6].Cells[0].Value = "Utilidad despues de impuestos";
            dgvFNE.Rows[7].Cells[0].Value = "Depreciacion";
            dgvFNE.Rows[8].Cells[0].Value = "Valor de rescate";
            dgvFNE.Rows[9].Cells[0].Value = "Prestamo";
            dgvFNE.Rows[10].Cells[0].Value = "Amortizacion del prestamo";
            dgvFNE.Rows[11].Cells[0].Value = "Inversiones Totales";
            dgvFNE.Rows[12].Cells[0].Value = "FNE";
            FNEnotFinanced();
            calculateFNE();
        }

        private void FNEFinanced()
        {
            SetIngresos();
            SetCostos();
            setInterest(true);
            setDepreciation(3);
            //setUtilidadAntesDeImpuestos();
            //setIR();
            //setUtilidadDespuesDeImpuestos();
            setDepreciation(7);
            setVR();
            setPrestamo(true);
            setAmortizacionDelPrestamo(true);
            setInersionesTotales();
            //calculateFNE();
        }

        private void FNEnotFinanced()
        {
            SetIngresos();
            SetCostos();
            setInterest(false);
            setDepreciation(3);
            //setUtilidadAntesDeImpuestos();
            //setIR();
            //setUtilidadDespuesDeImpuestos();
            setDepreciation(7);
            setVR();
            setPrestamo(false);
            setAmortizacionDelPrestamo(false);
            setInersionesTotales();
            //calculateFNE();
        }


        private void rjButton5_Click(object sender, EventArgs e)
        {
            calculateFNE();
            calculated = true;
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            addProfit.ShowDialog();
        }

        private void txtYears_ValueChanged(object sender, EventArgs e)
        {
            ResetFNEDataValues();
            LoadFNETable();
        }

        #region Funcionamiento del FNE
        private void SetIngresos()
        {
            for(int i=0; i<txtYears.Value; i++)
            {
                if (FNEData.Profit == null)
                {
                    dgvFNE.Rows[0].Cells[i + 2].Value = (decimal)0;
                    continue;
                };
                decimal[] array = FNEData.Profit.ToArray();
                if (array == null) return;
                dgvFNE.Rows[0].Cells[i + 2].Value = array[i];
            }
        }
        private void SetCostos()
        {
            for (int i = 0; i < txtYears.Value; i++)
            {
                if (FNEData.Cost == null)
                {
                    dgvFNE.Rows[1].Cells[i + 2].Value = (decimal)0;
                    continue;
                };
                decimal[] array = FNEData.Cost.ToArray();
                if (array == null) return;
                dgvFNE.Rows[1].Cells[i + 2].Value = array[i];
            }
        }

        private void setInterest(bool financed)
        {
            for (int i = 0; i < txtYears.Value; i++)
            {
                if (FNEData.Interest == null || financed == false)
                {
                    dgvFNE.Rows[2].Cells[i + 2].Value = (decimal)0;
                    continue;
                };
                decimal[] array = FNEData.Interest.ToArray();
                if (array == null) return;
                dgvFNE.Rows[2].Cells[i + 2].Value = array[i];
            }
        }

        private void setDepreciation(int n)
        {
            for (int i = 0; i < txtYears.Value; i++)
            {
                if (FNEData.Depreciacion == null)
                {
                    dgvFNE.Rows[n].Cells[i + 2].Value = (decimal)0;
                    continue;
                };
                decimal[] array = FNEData.Depreciacion.ToArray();
                if (array == null) return;
                dgvFNE.Rows[n].Cells[i + 2].Value = array[i];
            }
        }

        private void setUtilidadAntesDeImpuestos()
        {
            decimal montoAcumulado;
            for (int i = 0; i < (int)txtYears.Value; i++) // cells
            {
                montoAcumulado = (decimal)dgvFNE.Rows[0].Cells[i + 2].Value;
                for (int j = 0; j < 4; j++) // rows
                {
                    dgvFNE.Rows[4].Cells[i + 2].Value = montoAcumulado;
                    if (j == 3) continue;
                    montoAcumulado -= (decimal)dgvFNE.Rows[j + 1].Cells[i + 2].Value;
                }
            }
        }

        private void setIR()
        {
            for (int j = 0; j < (int)txtYears.Value; j++) // rows
            {
                dgvFNE.Rows[5].Cells[j + 2].Value = Math.Abs((decimal)dgvFNE.Rows[4].Cells[j + 2].Value * (decimal)0.3);
            }
        }

        private void setUtilidadDespuesDeImpuestos()
        {
            for (int j = 0; j < (int)txtYears.Value; j++) // rows
            {
                dgvFNE.Rows[6].Cells[j + 2].Value = ((decimal)dgvFNE.Rows[4].Cells[j + 2].Value - (decimal)dgvFNE.Rows[5].Cells[j + 2].Value);
            }
        }
        private void setVR()
        {
            dgvFNE.Rows[8].Cells[(int)txtYears.Value + 1].Value = (decimal)FNEData.ValorDeRescate;
        }

        private void setPrestamo(bool financed)
        {
            if(financed == false)
            {
                dgvFNE.Rows[9].Cells[1].Value = (decimal)0;
                return;
            }
            dgvFNE.Rows[9].Cells[1].Value = (decimal)FNEData.Prestamo;
        }

        private void setAmortizacionDelPrestamo(bool financed)
        {
            for (int i = 0; i < txtYears.Value; i++)
            {
                if (FNEData.Amortization == null || financed == false)
                {
                    dgvFNE.Rows[10].Cells[i + 2].Value = (decimal)0;
                    continue;
                };
                decimal[] array = FNEData.Amortization.ToArray();
                if (array == null) return;
                dgvFNE.Rows[10].Cells[i + 2].Value = array[i];
            }
        }

        private void setInersionesTotales()
        {
            dgvFNE.Rows[11].Cells[1].Value = (decimal)FNEData.Inversion;
        }

        private void calculateFNE() // 6 - 9
        {
            setUtilidadAntesDeImpuestos();
            setIR();
            setUtilidadDespuesDeImpuestos();
            decimal montoAcumulado =0;
            for (int i = 0; i <= (int)txtYears.Value; i++) // cells
            {
                if(dgvFNE.Rows[6].Cells[i + 1].Value == null) montoAcumulado = (decimal)0;
                if(dgvFNE.Rows[6].Cells[i + 1].Value != null) montoAcumulado = (decimal)dgvFNE.Rows[6].Cells[i + 1].Value;
                for (int j = 6; j <= 11; j++) // rows
                {
                    dgvFNE.Rows[12].Cells[i + 1].Value = montoAcumulado;
                    if (j == 3) continue;
                    if (j <= 9)
                    {
                        if(dgvFNE.Rows[j + 1].Cells[i + 1].Value == null) montoAcumulado += 0;
                        if(dgvFNE.Rows[j + 1].Cells[i + 1].Value != null) montoAcumulado += (decimal)dgvFNE.Rows[j + 1].Cells[i + 1].Value;
                    }
                    if (j > 9)
                    {
                        if (dgvFNE.Rows[j + 1].Cells[i + 1].Value == null) montoAcumulado -= 0;
                        if (dgvFNE.Rows[j + 1].Cells[i + 1].Value != null) montoAcumulado -= (decimal)dgvFNE.Rows[j + 1].Cells[i + 1].Value;
                    }

                }
            }
        }

        #endregion

        private void rjButton2_Click(object sender, EventArgs e)
        {
            addCost.ShowDialog();
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            depreciacion.ShowDialog();
        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            fmrCalendarioDePago.ShowDialog();
        }

        private void txtYears_KeyUp(object sender, KeyEventArgs e)
        {
            ResetFNEDataValues();
            LoadFNETable();
        }

        private void LoadFNETable()
        {
            if (dgvFNE.Rows.Count > 0)
            {
                dgvFNE.Columns.Clear();
                dgvFNE.Rows.Clear();
            }
            LoadDGV((int)txtYears.Value);
        }

        private void ResetFNEDataValues()
        {
            addProfit = new FormAddProfit((int)txtYears.Value, dgvFNE);
            fmrCalendarioDePago = new FmrCalendarioDePago(amortizacionServices, (int)txtYears.Value, dgvFNE);
            depreciacion = new Depreciacion(depreciationService, (int)txtYears.Value, dgvFNE);
            addCost = new FormAddCosts((int)txtYears.Value, dgvFNE);
            //reesetear valores de FNEData
            FNEData.resetValues();
        }

        private void rbCF_CheckedChanged(object sender, EventArgs e)
        {
            if(rbCF.Checked == true)
            {
                FNEFinanced();
                if(calculated == true) calculateFNE();
            }
        }

        private void rbSF_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSF.Checked == true)
            {
                FNEnotFinanced();
                if (calculated == true) calculateFNE();
            }

        }
    }
}
