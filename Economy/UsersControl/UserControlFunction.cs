using Economy.AppCore.IServices;
using Economy.AppCore.Singleton;
using Economy.Domain.Entities;
using Economy.Forms;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Economy.UsersControl
{
    public partial class UserControlFunction : UserControl
    {
        private ICalculateServices<Annuity> calculateServicesAnnuity;
        private ICalculateServices<Interest> CalculateServicesInterest;
        private ICalculateServices<Serie> calculateServicesSerie;
        private FormFunction FormFunction;
        private int Index;
        private int TypeIndex;
        private FormExcel FormExcel;
        private Singleton singleton;
        private bool bandera;
        public UserControlFunction(int Index, FormExcel formExcel, ICalculateServices<Annuity> calculateServicesAnnuity,
            ICalculateServices<Interest> calculateServicesInterest, FormFunction formFunction, ICalculateServices<Serie> calculateServicesSerire, int typeIndex)
        {
            InitializeComponent();
            this.FormExcel = formExcel;
            this.Index = Index;
            this.TypeIndex = typeIndex;
            this.calculateServicesAnnuity = calculateServicesAnnuity;
            this.CalculateServicesInterest = calculateServicesInterest;
            this.FormFunction = formFunction;
            this.calculateServicesSerie = calculateServicesSerire;
            singleton = Singleton.instance1;
            singleton.Index = Index;
            CleanTextboxs();
            ValidateIndex();
            bandera = false;
        }

        private void ValidateIndex()
        {
            ShowAllCamps();
            if (TypeIndex == 0)
            {
                switch (Index)
                {
                    case 0: // To_Effective_Rate
                        lbString1.Text = "Tasa nominal";
                        lbString2.Text = "Periodo de la tasa nominal";
                        lbString3.Text = "Capitalizaciones de la tasa nominal";
                        lbString4.Text = "Periodo de la tasa efectiva";
                        lbString5.Visible = false;
                        txbString5.Visible = false;
                        txbString1.ReadOnly = false;
                        txbString2.ReadOnly = false;
                        txbString3.ReadOnly = false;
                        txbString4.ReadOnly = false;
                        break;
                    case 1: //To-Nominal_Rate
                        lbString1.Text = "Tasa efectica";
                        lbString2.Text = "Periodo de la tasa efectiva";
                        lbString3.Text = "Periodo de la tasa nominal";
                        lbString4.Text = "Capitalizaciones de la tasa nominal";
                        lbString5.Visible = false;
                        txbString5.Visible = false;
                        txbString1.ReadOnly = false;
                        txbString2.ReadOnly = false;
                        txbString3.ReadOnly = false;
                        txbString4.ReadOnly = false;
                        break;
                    case 2: // Annuities
                        lbString1.Text = "Presente";
                        lbString2.Text = "Futuro";
                        lbString3.Text = "Tasa";
                        lbString4.Text = "Periodo de la serie";
                        lbString5.Text = "Tipo de anualidad";
                        txbString1.ReadOnly = false;
                        txbString2.ReadOnly = false;
                        txbString3.ReadOnly = false;
                        txbString4.ReadOnly = false;
                        txbString5.ReadOnly = false;
                        txbInfo.Text = "Si desea trabajar con una anualidad ordinaria ingrese \"0\", " +
                            "anualidad anticipada \"1\" o anualidad diferida \"2\". El valor si deja vacio será 0";
                        break;
                    case 4: //Future Annuities
                        lbString1.Text = "Anualidad";
                        lbString2.Text = "Tasa";
                        lbString3.Text = "Periodo de la serie";
                        lbString4.Text = "Periodo de gracia";
                        lbString4.Visible = false;
                        txbString4.Visible = false;
                        lbString5.Text = "Tipo";
                        txbString1.ReadOnly = false;
                        txbString2.ReadOnly = false;
                        txbString3.ReadOnly = false;
                        txbString4.ReadOnly = false;
                        txbString5.ReadOnly = false;
                        txbInfo.Text = "Si desea trabajar con una anualidad ordinaria ingrese \"0\", " +
                            "anualidad ordinaria \"1\" o anualidad diferida \"2\". El valor si deja vaccio será 0";
                        break;
                    case 3: //Present Annuities
                        lbString1.Text = "Anualidad"; 
                        lbString2.Text = "Tasa";
                        lbString3.Text = "Periodo de la serie";
                        lbString4.Text = "Periodo de gracia";
                        lbString4.Visible = false;
                        txbString4.Visible = false;
                        lbString5.Text = "Tipo";
                        txbString1.ReadOnly = false;
                        txbString2.ReadOnly = false;
                        txbString3.ReadOnly = false;
                        txbString4.ReadOnly = false;
                        txbString5.ReadOnly = false;
                        txbInfo.Text = "Si desea trabajar con una anualidad ordinaria ingrese \"0\", " +
                            "anualidad ordinaria \"1\" o anualidad diferida \"2\". El valor si deja vaccio será 0";
                        break;
                    case 5: //Present Series
                        lbString1.Text = "Pago inicial";
                        lbString2.Text = "Gradiente";
                        lbString3.Text = "Tasa";
                        lbString4.Text = "Periodo de la serie";
                        lbString5.Text = "Tipo";
                        txbString1.ReadOnly = false;
                        txbString2.ReadOnly = false;
                        txbString3.ReadOnly = false;
                        txbString5.ReadOnly = false;
                        txbInfo.Text = "Si desea trabajar con la serie aritmetica ingrese \"0\" " +
                            "o serie geometrica \"1\". El valor si deja vacio será 0";
                        break;
                    case 6: //Future Series
                        lbString1.Text = "Pago inical";
                        lbString2.Text = "Tasa";
                        lbString3.Text = "Periodo de la serie";
                        lbString4.Visible = false;
                        txbString4.Visible = false;
                        lbString5.Text = "Tipo";
                        txbString1.ReadOnly = false;
                        txbString2.ReadOnly = false;
                        txbString3.ReadOnly = false;
                        txbString5.ReadOnly = false;
                        txbInfo.Text = "Si desea trabajar con la serie aritmetica ingrese \"0\" " +
                            "o serie geometrica \"1\". El valor si deja vacio será 0";
                        break;
                    case 7: //FNE
                        lbString1.Text = "Entradas";
                        lbString2.Text = "Salidas";
                        lbString3.Visible = false;
                        lbString4.Visible = false;
                        lbString5.Visible = false;
                        txbString3.Visible = false;
                        txbString4.Visible = false;
                        txbString5.Visible = false;
                        txbTypeEntry.Visible = true;
                        txbTypeExit.Visible = true;
                        break;
                    case 8: //VPN
                        lbString1.Text = "FNE";
                        lbString2.Text = "Inversion";
                        lbString3.Text = "Tasa";
                        lbString4.Visible = false;
                        lbString5.Visible = false;
                        txbString4.Visible = false;
                        txbString5.Visible = false;
                        txbTypeEntry.Visible = false;
                        txbTypeExit.Visible = false;
                        break;
                    case 9: //TIR
                        lbString1.Text = "Inversion y FNE";
                        lbString2.Text = "Tasa";
                        lbString3.Visible = false;
                        lbString4.Visible = false;
                        lbString5.Visible = false;
                        txbString2.ReadOnly = false;
                        txbString3.Visible = false;
                        txbString4.Visible = false;
                        txbString5.Visible = false;
                        txbTypeEntry.Visible = false;
                        txbTypeExit.Visible = false;
                        txbInfo.Text = "Valor estimado. El valor si deja vacio será 10%";
                        break;
                    case 10: //Depreciacion Linea Recta
                        lbString1.Text = "Valor del activo";
                        lbString2.Text = "Valor residual";
                        lbString3.Text = "Vida útil";
                        lbString4.Visible = false;
                        lbString5.Visible = false;
                        txbString4.Visible = false;
                        txbString5.Visible = false;
                        txbString1.ReadOnly = false;
                        txbString2.ReadOnly = false;
                        txbString3.ReadOnly = false;
                        txbTypeEntry.Visible = false;
                        txbTypeExit.Visible = false;
                        break;
                    case 11: //Depreciacion Doble Saldo Decreciente
                        lbString1.Text = "Valor del activo";
                        lbString2.Text = "Valor residual";
                        lbString3.Text = "Vida útil";
                        lbString4.Text = "Periodo";
                        lbString5.Text = "Factor";
                        txbString1.ReadOnly = false;
                        txbString2.ReadOnly = false;
                        txbString3.ReadOnly = false;
                        txbString4.ReadOnly = false;
                        txbString5.ReadOnly = false;
                        txbTypeEntry.Visible = false;
                        txbTypeExit.Visible = false;
                        txbInfo.Visible = false;
                        txbInfo.Text = "Tipo de disminución del saldo. Si se omite el valor será de 2";
                        break;
                    case 12: //Depreciacion Suma Digito de los años
                        lbString1.Text = "Valor del activo";
                        lbString2.Text = "Valor residual";
                        lbString3.Text = "Vida útil";
                        lbString4.Text = "Periodo";
                        lbString5.Visible = false;
                        txbString5.Visible = false;
                        txbString1.ReadOnly = false;
                        txbString2.ReadOnly = false;
                        txbString3.ReadOnly = false;
                        txbString4.ReadOnly = false;
                        txbTypeEntry.Visible = false;
                        txbTypeExit.Visible = false;
                        break;
                    case 13: //TMAR_Mixta
                        lbString1.Text = "Tasa del inversionista";
                        lbString2.Text = "Porcentaje de aportacion";
                        lbString3.Text = "Tasa de la institución financiera";
                        lbString4.Text = "Porcentaje de la institución financiera";
                        lbString5.Visible = false;
                        txbString1.ReadOnly = false;
                        txbString2.ReadOnly = false;
                        txbString3.ReadOnly = false;
                        txbString4.ReadOnly = false;
                        txbString5.Visible = false;
                        txbTypeEntry.Visible = false;
                        txbTypeExit.Visible = false;
                        txbInfo.Text = "Si no se posee una tasa de una institución financiera deje " +
                            "vacio los campo de tasa y porcentaje de la institución financiera";
                        break;

                }
            }
            else if (TypeIndex == 1)
            {
                switch (Index)
                {
                    case 0: //Suma
                        lbString1.Text = "Números a sumar";
                        lbString2.Visible = false;
                        lbString3.Visible = false;
                        lbString4.Visible = false;
                        lbString5.Visible = false;
                        txbString2.Visible = false;
                        txbString3.Visible = false;
                        txbString4.Visible = false;
                        txbString5.Visible = false;
                        txbTypeEntry.Visible = false;
                        txbTypeExit.Visible = false;
                        break;
                    case 1: //Resta
                        lbString1.Text = "Primer número";
                        lbString2.Text = "Segundo número";
                        lbString3.Visible = false;
                        lbString4.Visible = false;
                        lbString5.Visible = false;
                        txbString3.Visible = false;
                        txbString4.Visible = false;
                        txbString5.Visible = false;
                        txbString1.ReadOnly = false;
                        txbString2.ReadOnly = false;
                        txbTypeEntry.Visible = false;
                        txbTypeExit.Visible = false;
                        break;
                    case 2: //Multiplicacion
                        lbString1.Text = "Números a multiplicar";
                        lbString2.Visible = false;
                        lbString3.Visible = false;
                        lbString4.Visible = false;
                        lbString5.Visible = false;
                        txbString2.Visible = false;
                        txbString3.Visible = false;
                        txbString4.Visible = false;
                        txbString5.Visible = false;
                        txbTypeEntry.Visible = false;
                        txbTypeExit.Visible = false;
                        break;
                    case 3: //Division
                        lbString1.Text = "Numerador";
                        lbString2.Text = "Denominador";
                        lbString3.Visible = false;
                        lbString4.Visible = false;
                        lbString5.Visible = false;
                        txbString3.Visible = false;
                        txbString4.Visible = false;
                        txbString5.Visible = false;
                        txbString1.ReadOnly = false;
                        txbString2.ReadOnly = false;
                        txbTypeEntry.Visible = false;
                        txbTypeExit.Visible = false;
                        break;
                }
            }
        }

        private void ShowAllCamps()
        {
            txbString1.Visible = true;
            lbString1.Visible = true;
            txbString2.Visible = true;
            lbString2.Visible = true;
            txbString3.Visible = true;
            lbString3.Visible = true;
            txbString4.Visible = true;
            lbString4.Visible = true;
            txbString5.Visible = true;
            lbString5.Visible = true;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            
        }
        public void FillTextBox()
        {
            switch (singleton.Index)
            {
                case 1:
                    if (singleton.Selection && singleton.Entry.Count > 0)
                    {
                        txbString1.Text = $"{singleton.Entry.First()} - {singleton.Entry.Last()}";
                        break;
                    }
                    else if (singleton.ValueTask > 0)
                    {
                        txbString1.Text = singleton.ValueTask.ToString();
                        break;
                    }
                    txbString1.Text = string.Empty;
                    break;
                case 2:
                    if (singleton.Selection && singleton.Exit.Count > 0)
                    {
                        txbString2.Text = $"{singleton.Exit.First()} - {singleton.Exit.Last()}";
                        break;
                    }
                    else if (singleton.ValueTask != 0)
                    {
                        txbString2.Text = singleton.ValueTask.ToString();
                        break;
                    }
                    txbString2.Text = string.Empty;
                    break;
                case 3:
                    if (singleton.ValueTask > 0)
                    {
                        txbString3.Text = singleton.ValueTask.ToString();
                        break;
                    }
                    txbString3.Text = string.Empty;
                    break;
                case 4:
                    if (singleton.ValueTask > 0)
                    {
                        txbString4.Text = singleton.ValueTask.ToString();
                        break;
                    }
                    txbString4.Text = string.Empty;
                    break;
            }
        }

        private void txbString1_Click(object sender, EventArgs e)
        {
            if ((TypeIndex == 0 && (Index <= 6 || Index == 10 || Index == 11 || Index == 12)) 
                || (TypeIndex == 1 && (Index == 1 || Index == 3)))
            {
                txbInfo.Visible = false;
                return;
            }
            if (TypeIndex == 0 && Index == 13)
            {
                return;
            }
            if (singleton.Selection)
            {
                singleton.Type = true;
                singleton.MinRow = 0;
                singleton.MinColumn = 0;
                singleton.MaxRow = 0;
                singleton.MaxColumn = 0;
            }
            singleton.Index = 1;
            txbInfo.Visible = false;
            FormExcel.Activate();
        }

        private void txbString2_Click(object sender, EventArgs e)
        {
            if((TypeIndex == 0 && (Index <= 6 || Index == 10 || Index == 11 || Index == 12)) 
                || (TypeIndex == 1 && (Index == 1 || Index == 3)))
            {
                txbInfo.Visible = false;
                return;
            }
            else if (TypeIndex == 0 && (Index == 9 || Index == 13))
            {
                return;
            }
            if (singleton.Selection && Index == 7)
            {
                singleton.Type = false;
                singleton.MinRow = 0;
                singleton.MinColumn = 0;
                singleton.MaxRow = 0;
                singleton.MaxColumn = 0;
            }
            else
            {
                singleton.Selection = false;
            }
            singleton.Index = 2;
            FormExcel.Activate();
            txbInfo.Visible = false;
        }

        private void txbString3_Click(object sender, EventArgs e)
        {
            if (TypeIndex == 0 && (Index <= 6 || Index == 10 || Index == 11 || Index == 12))
            {
                txbInfo.Visible = false;
                return;
            }
            if (TypeIndex == 0 && Index == 13)
            {
                return;
            }
            singleton.Index = 3;
            FormExcel.Activate();
            txbInfo.Visible = false;
        }

        private void txbString4_Click(object sender, EventArgs e)
        {
            if (TypeIndex == 0 && (Index <= 2 || Index == 4 || Index == 3 || Index == 10 || Index == 11 || Index == 12))
            {
                txbInfo.Visible = false;
                return;
            }
            if (TypeIndex == 0 && Index == 13)
            {
                return;
            }
            singleton.Index = 4;
            FormExcel.Activate();
            txbInfo.Visible = false;
        }

        private void txbString5_Click(object sender, EventArgs e)
        {
            if (TypeIndex == 0 && Index == 11)
            {
                txbInfo.Visible = true;
                return;
            }
            else if (txbString5.ReadOnly == false)
            {
                txbInfo.Visible = true;
                return;
            }
            txbInfo.Visible = false;
        }

        private void txbString5_TextChanged(object sender, EventArgs e)
        {
            if (txbString5.Text == "2" && TypeIndex == 0)
            {
                lbString4.Visible = true;
                txbString4.Visible = true;
                return;
            }
            if (txbString5.Text == "2" && TypeIndex == 0 && (Index == 3 || Index == 4))
            {
                lbString4.Text = "Periodo de gracia";
                lbString4.Visible = true;
                txbString4.Visible = true;
                return;
            }
            if (TypeIndex == 0 && (Index == 11 || Index == 3))
            {
                return;
            }
            txbString4.Visible = false;
            lbString4.Visible = false;
        }

        private void txbString5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txbString5.ReadOnly == false)
            {
                if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == Convert.ToChar(Keys.Back)))
                {
                    e.Handled = true;
                }
                if ( e.KeyChar == '.')
                {
                    e.Handled = false;
                }
            }
        }

        private void txbString2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txbString2.ReadOnly == false)
            {
                if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == Convert.ToChar(Keys.Back)))
                {
                    e.Handled = true;
                }
                if (e.KeyChar == '.')
                {
                    e.Handled = false;
                }
            }
        }

        private void txbString1_DoubleClick(object sender, EventArgs e)
        {
            if ((TypeIndex == 0 && Index <= 6) || (TypeIndex == 1 && (Index == 1 || Index == 3)))
            {
                singleton.Index = 1;
                txbInfo.Visible = false;
                FormExcel.Activate();
            }
        }
        private void CleanTextboxs()
        {
            txbString1.Text = string.Empty;
            txbString2.Text = string.Empty;
            txbString3.Text = string.Empty;
            txbString4.Text = string.Empty;
            txbString5.Text = string.Empty;
        }

        private void txbString2_DoubleClick(object sender, EventArgs e)
        {
            if((TypeIndex == 0 && Index <= 6) || (TypeIndex == 1 && (Index == 1 || Index == 3)))
            {
                singleton.Index = 2;
                txbInfo.Visible = false;
                FormExcel.Activate();
            }
            if (TypeIndex == 0 && Index == 9)
            {
                singleton.Index = 2;
                FormExcel.Activate();
            }
        }

        private void txbString3_DoubleClick(object sender, EventArgs e)
        {
            if (TypeIndex == 0 && Index <= 6)
            {
                singleton.Index = 3;
                txbInfo.Visible = false;
                FormExcel.Activate();
            }
        }

        private void txbString4_DoubleClick(object sender, EventArgs e)
        {
            if (TypeIndex == 0 && Index <= 2)
            {
                singleton.Index = 4;
                txbInfo.Visible = false;
                FormExcel.Activate();
            }
        }

        private void txbString1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txbString1.ReadOnly == false)
            {
                if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == Convert.ToChar(Keys.Back)))
                {
                    e.Handled = true;
                }
                if (e.KeyChar == '.')
                {
                    e.Handled = false;
                }
            }
        }

        private void txbString3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txbString3.ReadOnly == false)
            {
                if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == Convert.ToChar(Keys.Back)))
                {
                    e.Handled = true;
                }
                if (e.KeyChar == '.' && Index != 4)
                {
                    e.Handled = false;
                }
            }
        }

        private void txbString4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txbString4.ReadOnly == false)
            {
                if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == Convert.ToChar(Keys.Back)))
                {
                    e.Handled = true;
                }
                if (e.KeyChar == '.')
                {
                    e.Handled = false;
                }
            }
        }

        private void txbString5_DoubleClick(object sender, EventArgs e)
        {
            if (TypeIndex == 0 && Index == 11)
            {
                singleton.Index = 5;
                txbInfo.Visible = false;
                FormExcel.Activate();
            }
        }

        private void txbString1_TextChanged(object sender, EventArgs e)
        {
            if(TypeIndex == 0 && Index == 2 && !string.IsNullOrEmpty(txbString1.Text))
            {
                lbString2.Visible = false;
                txbString2.Visible = false;
            }
            else if (string.IsNullOrEmpty(txbString1.Text))
            {
                lbString2.Visible = true;
                txbString2.Visible = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int type;
            double tasa = 0;
            try
            {
                type = Int32.Parse(txbString5.Text);
            }
            catch
            {
                type = 0;
            }
            if (TypeIndex == 0)
            {
                switch (Index)
                {
                    case 0: // To_Effective_Rate
                        if (txbString1.Text == null)
                        {
                            MessageBox.Show("Debe de ingresar un tasa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (double.Parse(txbString1.Text) > 1 || double.Parse(txbString1.Text) < 100)
                        {
                            tasa = double.Parse(txbString1.Text) / 100;
                        }
                        else if (double.Parse(txbString1.Text) < 1)
                        {
                            tasa = double.Parse(txbString1.Text);
                        }
                        else if (double.Parse(txbString1.Text) <= 0)
                        {
                            MessageBox.Show("La tasa no puede ser negativa o igual a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Esta no es una tasa válida", "ErroR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        if (string.IsNullOrEmpty(txbString1.Text) || string.IsNullOrEmpty(txbString2.Text) || string.IsNullOrEmpty(txbString3.Text) || string.IsNullOrEmpty(txbString4.Text))
                        {
                            MessageBox.Show("No puede haber campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        if (double.Parse(txbString2.Text) <= 0 || double.Parse(txbString3.Text) <= 0 || double.Parse(txbString4.Text) <= 0)
                        {
                            MessageBox.Show("Ingresar informacion válida para los calculos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        int NominalRatePeriod = int.Parse(txbString2.Text);
                        int NominalRateCapitalization = int.Parse(txbString3.Text);
                        int EffectiveRatePEriod = int.Parse(txbString4.Text);

                        float m = (float)(EffectiveRatePEriod * 30) / (float)(NominalRateCapitalization * 30);
                        if (NominalRatePeriod != EffectiveRatePEriod)
                        {
                            tasa = (float)tasa / (float)NominalRatePeriod;
                        }
                        double a = 1 + (tasa / m);

                        double EffectiveRate = Math.Round(Math.Pow(a, m) - 1, 4);
                        singleton.ValueFunction = (decimal)EffectiveRate;
                        bandera = true;
                        FormExcel.Activate();
                        break;
                    case 1:// To_Nominal_Rate
                        if (txbString1.Text == null)
                        {
                            MessageBox.Show("Debe de ingresar un tasa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (double.Parse(txbString1.Text) > 1 || double.Parse(txbString1.Text) < 100)
                        {
                            tasa = double.Parse(txbString1.Text) / 100;
                        }
                        else if (double.Parse(txbString1.Text) < 1)
                        {
                            tasa = double.Parse(txbString1.Text);
                        }
                        else if (double.Parse(txbString1.Text) <= 0)
                        {
                            MessageBox.Show("La tasa no puede ser nagativa o igual a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Esta no es una tasa válida", "ErroR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        if (string.IsNullOrEmpty(txbString1.Text) || string.IsNullOrEmpty(txbString2.Text) || string.IsNullOrEmpty(txbString3.Text) || string.IsNullOrEmpty(txbString4.Text))
                        {
                            MessageBox.Show("No puede haber campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        if (double.Parse(txbString2.Text) <= 0 || double.Parse(txbString3.Text) <= 0 || double.Parse(txbString4.Text) <= 0)
                        {
                            MessageBox.Show("Ingresar informacion válida para los calculos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        double _EffectiveRate = double.Parse(txbString1.Text);
                        int _EffectiveRatePeriod = int.Parse(txbString2.Text);
                        int _NominalRatePeriod = int.Parse(txbString3.Text);
                        int _NominalRateCapitalization = int.Parse(txbString4.Text);

                        float _m = (float)(_NominalRatePeriod * 30) / (float)(_NominalRateCapitalization * 30);
                        float NominalRate = (float)(Math.Pow(1 + _EffectiveRate, (float)(_NominalRateCapitalization * 30) / (float)(_EffectiveRatePeriod * 30)) - 1);
                        singleton.ValueFunction = (decimal)Math.Round(NominalRate * _m, 4);
                        bandera = true;
                        FormExcel.Activate();
                        break;
                    case 2://Annuities
                        if (txbString1.Text == null)
                        {
                            MessageBox.Show("Debe de ingresar un tasa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (double.Parse(txbString1.Text) > 1 || double.Parse(txbString1.Text) < 100)
                        {
                            tasa = double.Parse(txbString1.Text) / 100;
                        }
                        else if (double.Parse(txbString1.Text) < 1)
                        {
                            tasa = double.Parse(txbString1.Text);
                        }
                        else if (double.Parse(txbString3.Text) <= 0 || double.Parse(txbString3.Text) > 1)
                        {
                            MessageBox.Show("La tasa no puede ser nagativa o igual a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Esta no es una tasa válida", "ErroR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        if (!string.IsNullOrWhiteSpace(txbString1.Text) && !string.IsNullOrWhiteSpace(txbString2.Text))
                        {
                            MessageBox.Show("El presente y el futuro no pueden estar llenos al mismo tiempo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        if ((string.IsNullOrEmpty(txbString1.Text) && string.IsNullOrEmpty(txbString2.Text)) || string.IsNullOrEmpty(txbString3.Text) || (string.IsNullOrEmpty(txbString4.Text) && double.Parse(txbString5.Text) == 2))
                        {
                            MessageBox.Show("No puede haber campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        try
                        {
                            if ((double.Parse(txbString1.Text) <= 0 || double.Parse(txbString2.Text) <= 0) || double.Parse(txbString4.Text) <= 0)
                            {
                                MessageBox.Show("Ingresar informacion válida para los calculos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            }
                        }
                        catch
                        {
                            if (type == 2 && string.IsNullOrEmpty(txbString4.Text))
                            {
                                MessageBox.Show("Ingresar informacion válida para los calculos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            }
                        }
                        if (double.Parse(txbString3.Text) > 1)
                        {
                            tasa = double.Parse(txbString3.Text) / 100;
                        }
                        else
                        {
                            tasa = double.Parse(txbString3.Text);
                        }
                        Annuity _annuity;
                        if (string.IsNullOrWhiteSpace(txbString1.Text)) // if the present is empty
                        {
                            _annuity = new Annuity
                            {
                                Future = decimal.Parse(txbString2.Text),
                                Rate = decimal.Parse(txbString3.Text),
                                End = Int32.Parse(txbString4.Text),

                            };
                        }
                        else
                        {
                            _annuity = new Annuity
                            {
                                Present = decimal.Parse(txbString1.Text),
                                Rate = decimal.Parse(txbString3.Text),
                                End = Int32.Parse(txbString4.Text),

                            };
                        }
                        if (type == 0)
                            _annuity.Type = "Ordinary";
                        else if (type == 1)
                            _annuity.Type = "Anticipated";
                        else
                        {
                            _annuity.Type = "Deferred";
                            _annuity.Initial = Int32.Parse(txbString4.Text);
                        }
                        singleton.ValueFunction = Math.Round(calculateServicesAnnuity.Annuity(_annuity), 2);
                        bandera = true;
                        FormExcel.Activate();
                        break;
                    case 4: //Future Annuities
                        if (string.IsNullOrEmpty(txbString1.Text) || string.IsNullOrEmpty(txbString2.Text) || string.IsNullOrEmpty(txbString3.Text))
                        {
                            MessageBox.Show("No puede haber campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        if (double.Parse(txbString1.Text) < 0 || double.Parse(txbString2.Text) < 0 ||
                            double.Parse(txbString3.Text) < 0)
                        {
                            MessageBox.Show("Ingresar informacion válida para los calculos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        if (type > 2 && type < 0)
                        {
                            MessageBox.Show("Debes de escoger un tipo de serie valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        if (type == 2 && double.Parse(txbString3.Text) < double.Parse(txbString4.Text))
                        {
                            MessageBox.Show("El periodo de gracia no puede ser mayor al periodo de la serie", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        if (double.Parse(txbString2.Text) > 1)
                        {
                            tasa = double.Parse(txbString2.Text) / 100;
                        }
                        else
                        {
                            tasa = double.Parse(txbString2.Text);
                        }
                        Annuity annuity = new Annuity
                        {
                            Payment = decimal.Parse(txbString1.Text),
                            Rate = (decimal)tasa,
                            End = Int32.Parse(txbString3.Text)

                        };
                        if (type == 0)
                            annuity.Type = "Ordinary";
                        else if (type == 1)
                        {
                            annuity.Type = "Anticipated";
                        }
                        else
                        {
                            annuity.Type = "Deferred";
                            annuity.Initial = Int32.Parse(txbString4.Text);
                        }
                        singleton.ValueFunction = Math.Round(calculateServicesAnnuity.Future(annuity), 2);
                        bandera = true;
                        FormExcel.Activate();
                        break;
                    case 3: //Present Annuities
                        if (string.IsNullOrEmpty(txbString1.Text) || string.IsNullOrEmpty(txbString2.Text) || string.IsNullOrEmpty(txbString3.Text))
                        {
                            MessageBox.Show("No puede haber campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        if (double.Parse(txbString1.Text) < 0 || double.Parse(txbString2.Text) < 0 ||
                            double.Parse(txbString3.Text) < 0)
                        {
                            MessageBox.Show("Ingresar informacion válida para los calculos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        if (type > 2 && type < 0)
                        {
                            MessageBox.Show("Debes de escoger un tipo de serie válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        if (double.Parse(txbString2.Text) > 1)
                        {
                            tasa = double.Parse(txbString2.Text) / 100;
                        }
                        else
                        {
                            tasa = double.Parse(txbString2.Text);
                        }
                        Annuity annuitys = new Annuity
                        {
                            Payment = decimal.Parse(txbString1.Text),
                            Rate = (decimal)tasa,
                            End = Int32.Parse(txbString3.Text),

                        };
                        if (type == 0)
                            annuitys.Type = "Ordinary";
                        else if (type == 1)
                            annuitys.Type = "Anticipated";
                        else
                        {
                            annuitys.Type = "Deferred";
                            annuitys.Initial = Int32.Parse(txbString4.Text);
                        }
                        singleton.ValueFunction = Math.Round(calculateServicesAnnuity.Present(annuitys), 2);
                        bandera = true;
                        FormExcel.Activate();
                        break;
                    case 5: //Present Series
                        if (string.IsNullOrEmpty(txbString1.Text) || string.IsNullOrEmpty(txbString2.Text) || string.IsNullOrEmpty(txbString3.Text))
                        {
                            MessageBox.Show("No puede haber campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        if (double.Parse(txbString1.Text) < 0 || double.Parse(txbString2.Text) < 0 ||
                           double.Parse(txbString3.Text) < 0)
                        {
                            MessageBox.Show("Ingresar informacion válida para los calculos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        if (type < 0 || type > 2)
                        {
                            MessageBox.Show("Debes de escoger un tipo de serie válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        if (type == 2 && (double.Parse(txbString4.Text) < 0 ||
                            double.Parse(txbString4.Text) > double.Parse(txbString3.Text)))
                        {
                            MessageBox.Show("El periodo de la anualidad es incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        if (double.Parse(txbString3.Text) > 1)
                        {
                            tasa = double.Parse(txbString3.Text) / 100;
                        }
                        else
                        {
                            tasa = double.Parse(txbString3.Text);
                        }
                        Serie series = new Serie
                        {
                            DownPayment = decimal.Parse(txbString1.Text),

                            Rate = (decimal)tasa,
                            End = Int32.Parse(txbString3.Text),

                        };
                        if (type == 0)
                            series.Type = "Arithmetic";
                        else if (type == 1)
                            series.Type = "Geometric";
                        singleton.ValueFunction = Math.Round(calculateServicesSerie.Present(series), 2);
                        bandera = true;
                        FormExcel.Activate();
                        break;
                    case 6: //Future Annuities
                        if (string.IsNullOrEmpty(txbString1.Text) || string.IsNullOrEmpty(txbString2.Text) || string.IsNullOrEmpty(txbString3.Text))
                        {
                            MessageBox.Show("No puede haber campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        if (double.Parse(txbString1.Text) < 0 || double.Parse(txbString2.Text) < 0 ||
                           double.Parse(txbString3.Text) < 0)
                        {
                            MessageBox.Show("Ingrese informacion válida para los calculos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        if (type < 0 || type > 2)
                        {
                            MessageBox.Show("Debes de escoger un tipo de serie válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        if (type == 2 && (double.Parse(txbString4.Text) < 0 ||
                            double.Parse(txbString4.Text) > double.Parse(txbString3.Text)))
                        {
                            MessageBox.Show("El periodo de la anualidad es incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        Serie serie = new Serie
                        {
                            DownPayment = decimal.Parse(txbString1.Text),
                            Rate = decimal.Parse(txbString2.Text),
                            End = Int32.Parse(txbString2.Text),

                        };
                        if (type == 0)
                            serie.Type = "Ordinary";
                        else if (type == 1)
                            serie.Type = "Anticipated";
                        else
                        {
                            serie.Type = "Deferred";
                            serie.Initial = Int32.Parse(txbString4.Text);
                        }
                        singleton.ValueFunction = Math.Round(calculateServicesSerie.Future(serie), 2);
                        bandera = true;
                        FormExcel.Activate();
                        break;
                    case 7: //FNE
                        if (string.IsNullOrEmpty(txbString1.Text) || string.IsNullOrEmpty(txbString2.Text))
                        {
                            MessageBox.Show("No puede haber campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        int counter = 0;
                        bool succes = true;
                        while (succes)
                        {
                            if (counter >= singleton.Entry.Count && counter >= singleton.Exit.Count)
                            {
                                succes = false;
                            }
                            else
                            {
                                if (singleton.Entry.Count - 1 < counter)
                                {
                                    singleton.ValueFunctionList.Add(singleton.Exit[counter]);
                                }
                                else if (singleton.Exit.Count - 1 < counter)
                                {
                                    singleton.ValueFunctionList.Add(singleton.Entry[counter]);
                                }
                                else
                                {
                                    singleton.ValueFunctionList.Add(singleton.Entry[counter] - singleton.Exit[counter]);
                                }
                            }
                            counter++;
                        }
                        bandera = true;
                        FormExcel.Activate();
                        break;
                    case 8: //VPN
                        if (string.IsNullOrEmpty(txbString1.Text))
                        {
                            MessageBox.Show("No puede haber campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        Double[] value = new Double[singleton.Entry.Count + 1];
                        if (double.Parse(txbString2.Text) < 0)
                        {
                            value[0] = double.Parse(txbString2.Text);
                        }
                        else if (double.Parse(txbString2.Text) > 0)
                        {
                            value[0] = -(double.Parse(txbString2.Text));
                        }
                        for (int i = 0; i < singleton.Entry.Count; i++)
                        {
                            value[i + 1] = singleton.Entry[i];
                        }
                        singleton.ValueFunction = Math.Round(Convert.ToDecimal(Financial.NPV((double.Parse(txbString3.Text) / 100), ref value)), 2);
                        bandera = true;
                        FormExcel.Activate();
                        break;
                    case 9: //TIR
                        if (string.IsNullOrEmpty(txbString1.Text))
                        {
                            MessageBox.Show("No puede haber campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        Double[] values = new Double[singleton.Entry.Count];
                        for (int i = 0; i < singleton.Entry.Count; i++)
                        {
                            if (i == 0)
                            {
                                if (singleton.Entry[i] < 0)
                                {
                                    values[i] = singleton.Entry[i];
                                }
                                else if (singleton.Entry[i] > 0)
                                {
                                    values[i] = -(singleton.Entry[i]);
                                }
                                continue;
                            }
                            values[i] = singleton.Entry[i];
                        }
                        try
                        {
                            double Rate = double.Parse(txbString2.Text);
                            singleton.ValueFunction = Math.Round((decimal)Financial.IRR(ref values, (double.Parse(txbString2.Text) / 100)) * 100, 2);
                        }
                        catch
                        {
                            singleton.ValueFunction = Math.Round((decimal)Financial.IRR(ref values, 0.10) * 100, 2);
                        }
                        bandera = true;
                        FormExcel.Activate();
                        break;
                    case 10: // Depreciacion Linea Recta
                        if (string.IsNullOrEmpty(txbString1.Text) || string.IsNullOrEmpty(txbString2.Text) || string.IsNullOrEmpty(txbString3.Text))
                        {
                            MessageBox.Show("No puede haber campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        if (double.Parse(txbString1.Text) <= 0 || double.Parse(txbString2.Text) < 0 ||
                           double.Parse(txbString3.Text) <= 0)
                        {
                            MessageBox.Show("Ingrese informacion válida para los calculos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        if (double.Parse(txbString1.Text) < double.Parse(txbString2.Text))
                        {
                            MessageBox.Show("El valor residual no puede ser mayor al valor del activo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        singleton.ValueFunction = Math.Round((decimal)Financial.SLN(double.Parse(txbString1.Text), double.Parse(txbString2.Text), double.Parse(txbString3.Text)), 2);
                        singleton.MaxColumn = Int32.Parse(txbString3.Text);
                        bandera = true;
                        FormExcel.Activate();
                        break;
                    case 11: // Depreciacion Doble Saldo Decreciente
                        if (string.IsNullOrEmpty(txbString1.Text) || string.IsNullOrEmpty(txbString2.Text) ||
                            string.IsNullOrEmpty(txbString3.Text) || string.IsNullOrEmpty(txbString4.Text))
                        {
                            MessageBox.Show("No puede haber campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        if (double.Parse(txbString1.Text) <= 0 || double.Parse(txbString2.Text) < 0 ||
                           double.Parse(txbString3.Text) <= 0)
                        {
                            MessageBox.Show("Ingrese informacion válida para los calculos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        if (!string.IsNullOrEmpty(txbString5.Text) && double.Parse(txbString5.Text) <= 0)
                        {
                            MessageBox.Show("El factor debe de ser mayor a 0");
                            break;
                        }
                        if (double.Parse(txbString3.Text) < double.Parse(txbString4.Text))
                        {
                            MessageBox.Show("El periodo no puede ser mayor a la vida útil", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        if (double.Parse(txbString1.Text) < double.Parse(txbString2.Text))
                        {
                            MessageBox.Show("El valor residual no puede ser mayor al valor del activo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        if (double.Parse(txbString4.Text) == 0)
                        {
                            MessageBox.Show("El periodo debe ser mayor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        if (type == 0)
                            type = 2;

                        double piv = 0;
                        for (int i = Int32.Parse(txbString4.Text); i <= double.Parse(txbString3.Text); i++)
                        {
                            if (double.Parse(txbString2.Text) == 0 && i == double.Parse(txbString3.Text))
                            {
                                piv = Math.Round(double.Parse(txbString1.Text) - singleton.ValueFunctionList.Sum(), 2);
                                singleton.ValueFunctionList.Add(piv);
                                break;
                            }
                            piv = Math.Round(Financial.DDB(double.Parse(txbString1.Text),
                                double.Parse(txbString2.Text), double.Parse(txbString3.Text), i,
                                type), 2);
                            singleton.ValueFunctionList.Add(piv);
                        }
                        bandera = true;
                        FormExcel.Activate();
                        break;
                    case 12: // Depreciacion Suma Digito de los Años
                        if (string.IsNullOrEmpty(txbString1.Text) || string.IsNullOrEmpty(txbString2.Text) ||
                           string.IsNullOrEmpty(txbString3.Text) || string.IsNullOrEmpty(txbString4.Text))
                        {
                            MessageBox.Show("No puede haber campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        if (double.Parse(txbString1.Text) <= 0 || double.Parse(txbString2.Text) < 0 ||
                           double.Parse(txbString3.Text) <= 0 || double.Parse(txbString4.Text) <= 0)
                        {
                            MessageBox.Show("Ingrese informacion válida para los calculos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        if (double.Parse(txbString1.Text) < double.Parse(txbString2.Text))
                        {
                            MessageBox.Show("El valor residual no puede ser mayor al valor del activo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        if (double.Parse(txbString3.Text) < double.Parse(txbString4.Text))
                        {
                            MessageBox.Show("El periodo no pude ser mayor a la vida útil", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }

                        double aux;
                        for (int i = Int32.Parse(txbString4.Text); i <= double.Parse(txbString3.Text); i++)
                        {
                            if (double.Parse(txbString2.Text) == 0 && i == double.Parse(txbString3.Text))
                            {
                                aux = Math.Round(double.Parse(txbString1.Text) - singleton.ValueFunctionList.Sum(), 2);
                                singleton.ValueFunctionList.Add(aux);
                                break;
                            }
                            aux = Math.Round(Financial.SYD(double.Parse(txbString1.Text), double.Parse(txbString2.Text),
                                double.Parse(txbString3.Text), i), 2);
                            singleton.ValueFunctionList.Add(aux);
                        }
                        bandera = true;
                        FormExcel.Activate();
                        break;
                    case 13: //TMAR_Mixta
                        if (string.IsNullOrEmpty(txbString1.Text) && string.IsNullOrEmpty(txbString3.Text) &&
                            (string.IsNullOrEmpty(txbString2.Text) || string.IsNullOrEmpty(txbString4.Text)))
                        {
                            MessageBox.Show("No puede haber campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        if (!string.IsNullOrEmpty(txbString2.Text) && !string.IsNullOrEmpty(txbString4.Text) &&
                            (double.Parse(txbString2.Text) + double.Parse(txbString4.Text) != 100))
                        {
                            MessageBox.Show("La suma de los dos porcentajes debe de ser igual a 100, debe de cambiar " +
                                "los valores o dejar vacio uno de los porcentajes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        if (string.IsNullOrEmpty(txbString2.Text))
                        {
                            singleton.ValueFunction = (decimal)((double.Parse(txbString1.Text) * ((100 - double.Parse(txbString4.Text)) / 100)) +
                                (double.Parse(txbString3.Text) * double.Parse(txbString4.Text)));
                        }
                        else if (string.IsNullOrEmpty(txbString4.Text))
                        {
                            singleton.ValueFunction = (decimal)((double.Parse(txbString1.Text) * (double.Parse(txbString2.Text))) +
                                (double.Parse(txbString3.Text) * ((100 - double.Parse(txbString2.Text)) / 100)));
                        }
                        else
                        {
                            singleton.ValueFunction = (decimal)((double.Parse(txbString1.Text) * (double.Parse(txbString2.Text) / 100)) +
                                (double.Parse(txbString3.Text) * (double.Parse(txbString4.Text) / 100)));
                        }
                        bandera = true;
                        FormExcel.Activate();
                        break;
                }
            }
            else if (TypeIndex == 1)
            {
                switch (Index)
                {
                    case 0:
                        if (txbString1.Text == string.Empty)
                        {
                            MessageBox.Show("Debes de llenar todos los datos");
                            break;
                        }
                        double sum = 0;
                        foreach (double value in singleton.Entry)
                        {
                            sum = sum + value;
                        }
                        singleton.ValueFunction = decimal.Parse(sum.ToString());
                        bandera = true;
                        FormExcel.Activate();
                        break;
                    case 1:
                        if (txbString1.Text == string.Empty || txbString2.Text == string.Empty)
                        {
                            MessageBox.Show("Debes de llenar todos los datos");
                            break;
                        }
                        singleton.ValueFunction = decimal.Parse(txbString1.Text) - decimal.Parse(txbString2.Text);
                        bandera = true;
                        FormExcel.Activate();
                        break;
                    case 2:
                        if (txbString1.Text == string.Empty)
                        {
                            MessageBox.Show("Debes de llenar todos los datos");
                            break;
                        }
                        double mul = 1;
                        foreach (double value in singleton.Entry)
                        {
                            mul = mul * value;
                        }
                        singleton.ValueFunction = decimal.Parse(mul.ToString());
                        bandera = true;
                        FormExcel.Activate();
                        break;
                    case 3:
                        if (txbString1.Text == string.Empty || txbString2.Text == string.Empty)
                        {
                            MessageBox.Show("Debes de llenar todos los datos");
                            break;
                        }
                        if (decimal.Parse(txbString2.Text) == 0)
                        {
                            MessageBox.Show("No se puede dividir entre 0");
                            break;
                        }
                        singleton.ValueFunction = Math.Round(decimal.Parse(txbString1.Text) / decimal.Parse(txbString2.Text), 2);
                        bandera = true;
                        FormExcel.Activate();
                        break;
                }
            }
            if (bandera)
            {
                singleton.Entry.Clear();
                singleton.Exit.Clear();
                singleton.Type = false;
                bandera = false;
                FormFunction.Close();
            }
        }
    }
}
