﻿using Appcore.Interface;
using Economy.AppCore.Helper;
using Economy.AppCore.IServices;
using Microsoft.VisualBasic;
using Org.BouncyCastle.Asn1.Cmp;
using Proto1._0;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Economy.Forms
{
    public partial class FormFNE : Form
    {
        bool calculated = false;
        double TMARMixtaTotal;

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
            for (int i = 0; i < 18; i++)
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
            VPN();
            TIR();
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
            VPN();
            TIR();
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
                    if (j < 9)
                    {
                        if(dgvFNE.Rows[j + 1].Cells[i + 1].Value == null) montoAcumulado += 0;
                        if(dgvFNE.Rows[j + 1].Cells[i + 1].Value != null) montoAcumulado += (decimal)dgvFNE.Rows[j + 1].Cells[i + 1].Value;
                    }
                    if (j >= 9)
                    {
                        if (dgvFNE.Rows[j + 1].Cells[i + 1].Value == null) montoAcumulado -= 0;
                        if (dgvFNE.Rows[j + 1].Cells[i + 1].Value != null) montoAcumulado -= (decimal)dgvFNE.Rows[j + 1].Cells[i + 1].Value;
                    }

                }
            }
            TIR();
            VPN();
        }

        #endregion

        private void VPN()
        {
            dgvFNE.Rows[15].Cells[0].Value = "VPN";
            dgvFNE.Rows[15].Cells[1].Value = CalculateVPNFinanced();
        }

        private void VPNnotFinanced()
        {
            dgvFNE.Rows[15].Cells[0].Value = "VPN";
            dgvFNE.Rows[15].Cells[1].Value = CalculateVPNnotFinanced();
        }

        private void TIR()
        {
            dgvFNE.Rows[16].Cells[0].Value = "TIR";
            dgvFNE.Rows[16].Cells[1].Value = CalculateTir();
        }

        private void SaveTMAR()
        {
            FNEData.TasaInversionista = (float)txtTMAR.Value / 100;
        }

        private void TMARMixta()
        {
            if(FNEData.Prestamo == 0 && FNEData.Inversion == 0) return;
            double PorcentajeAportacionInstitucionFinanciera = (double)FNEData.Prestamo / (double)FNEData.Inversion;
            double PorcentajeAportacionInversionista = 1 - PorcentajeAportacionInstitucionFinanciera;
            double TasaInversionista = (FNEData.TasaInversionista);
            double TasaInstitucionFinanciera = (FNEData.TasaInstitucionFinanciera);
            double TMARMixtaInversionista = PorcentajeAportacionInversionista * TasaInversionista;
            double TMARMixtaInstitucionFinanciera = PorcentajeAportacionInstitucionFinanciera * TasaInstitucionFinanciera;

            TMARMixtaTotal = TMARMixtaInversionista + TMARMixtaInstitucionFinanciera;
        }

        private Double[] SelectFNEValues()
        {
            List<Double> vpn = new List<Double>();
            for (int i = 1; i <= txtYears.Value + 1; i++)
            {
                if (dgvFNE.Rows[12].Cells[i].Value == null)
                {
                    vpn.Add(0);
                    continue;
                }
                double fne = Double.Parse(dgvFNE.Rows[12].Cells[i].Value.ToString());
                vpn.Add(fne);
            }
            return vpn.ToArray();
        }

        private double CalculateVPNFinanced()
        {
            TMARMixta();
            Double[] vpn = SelectFNEValues();

            Double Inversion = vpn[0];
            Double[] _vpn = new double[(int)txtYears.Value];
            Array.Copy(vpn, 1, _vpn, 0, (int)txtYears.Value);
            try
            {
                return (Financial.NPV(TMARMixtaTotal, ref _vpn) + Inversion);
            }
            catch(Exception ex)
            {
                return 0;
            }
        }


        private double CalculateVPNnotFinanced()
        {
            Double[] vpn = SelectFNEValues();

            Double Inversion = vpn[0];
            Double[] _vpn = new double[(int)txtYears.Value];
            Array.Copy(vpn, 1, _vpn, 0, (int)txtYears.Value);
            try
            {
                return (Financial.NPV(FNEData.TasaInversionista, ref _vpn) + Inversion);
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

            private double CalculateTir()
        {
            Double[] tir = SelectFNEValues();
            try
            {
                return Financial.IRR(ref tir);
            }catch(Exception ex)
            {
                return 0;
            }
        }

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
                if (calculated == true)
                {
                    calculateFNE();
                    CalculateVPNFinanced();
                }
            }
        }

        private void rbSF_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSF.Checked == true)
            {
                FNEnotFinanced();
                if (calculated == true)
                {
                    calculateFNE();
                    VPNnotFinanced();
                }
            }

        }

        private void txtTMAR_ValueChanged(object sender, EventArgs e)
        {
            SaveTMAR();
        }

        private void txtTMAR_KeyUp(object sender, KeyEventArgs e)
        {
            SaveTMAR();
        }
    }
}
