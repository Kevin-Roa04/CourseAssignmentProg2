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
        private FormExcel FormExcel;
        private Singleton singleton;
        private bool bandera;
        public UserControlFunction(int Index, FormExcel formExcel, ICalculateServices<Annuity> calculateServicesAnnuity,
            ICalculateServices<Interest> calculateServicesInterest, FormFunction formFunction, ICalculateServices<Serie> calculateServicesSerire)
        {
            InitializeComponent();
            this.FormExcel = formExcel;
            this.Index = Index;
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

            switch (Index)
            {
                case 0: // To_Effective_Rate
                    lbString1.Text = "Tasa nominal";
                    lbString2.Text = "Capitalizaciones de la tasa nominal";
                    lbString3.Visible = false;
                    lbString4.Visible = false;
                    lbString5.Visible = false;
                    txbString1.ReadOnly = false;
                    txbString2.ReadOnly = false;
                    txbString3.Visible = false;
                    txbString4.Visible = false;
                    txbString5.Visible = false;
                    lblPercent1.Visible = true;
                    txbString1.Left = 290;
                    txbString2.Left = 290;
                    lblPercent1.Left = 396;
                    break;
                case 1: //To-Nominal_Rate
                    lbString1.Text = "Tasa efectica";
                    lbString2.Text = "Capitalizaciones de la tasa nominal";
                    lbString5.Visible = false;
                    txbString5.Visible = false;
                    lbString4.Visible = false;
                    txbString4.Visible = false;
                    lbString3.Visible = false;
                    txbString3.Visible = false;
                    txbString1.ReadOnly = false;
                    txbString2.ReadOnly = false;
                    lblPercent1.Visible = true;
                    txbString1.Left = 290;
                    txbString2.Left = 290;
                    lblPercent1.Left = 396;
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
                    lblPercent3.Visible = true;
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
                    lblPercent2.Visible = true;
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
                    lblPercent2.Visible = true;
                    break;
                case 5: //Present Series
                    lbString1.Text = "Anualidad";
                    lbString2.Text = "Gradiente aritmético";
                    lbString3.Text = "Tasa";
                    lbString4.Text = "Periodo de la serie";
                    lbString5.Text = "Tipo";
                    txbString1.ReadOnly = false;
                    txbString2.ReadOnly = false;
                    txbString3.ReadOnly = false;
                    txbString4.ReadOnly = false;
                    txbString5.ReadOnly = false;
                    lblPercent3.Visible = true;
                    chbIncremento.Visible = true;
                    break;
                case 6: //Future Series
                    lbString1.Text = "Anualidad";
                    lbString2.Text = "Gradiente aritmético";
                    lbString3.Text = "Tasa";
                    lbString4.Text = "Periodo de la serie";
                    lbString5.Text = "Tipo";
                    txbString1.ReadOnly = false;
                    txbString2.ReadOnly = false;
                    txbString3.ReadOnly = false;
                    txbString4.ReadOnly = false;
                    txbString5.ReadOnly = false;
                    lblPercent3.Visible = true;
                    chbIncremento.Visible = true;
                    break;
                case 7: //FNE
                    lbString1.Text = "Entradas";
                    lbString2.Text = "Salidas";
                    lbString3.Visible = false;
                    lbString4.Visible = false;
                    lbString5.Visible = false;
                    txbString1.ReadOnly = true;
                    txbString2.ReadOnly = true;
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
                    txbString2.ReadOnly = false;
                    txbString3.ReadOnly = false;
                    txbString4.Visible = false;
                    txbString5.Visible = false;
                    txbTypeEntry.Visible = false;
                    txbTypeExit.Visible = false;
                    lblPercent3.Visible = true;
                    break;
                case 9: //TIR
                    lbString1.Text = "Inversion y FNE";
                    lbString2.Text = "Tasa";
                    lbString3.Visible = false;
                    lbString4.Visible = false;
                    lbString5.Visible = false;
                    txbString1.ReadOnly = true;
                    txbString2.ReadOnly = false;
                    txbString3.Visible = false;
                    txbString4.Visible = false;
                    txbString5.Visible = false;
                    txbTypeEntry.Visible = false;
                    txbTypeExit.Visible = false;
                    lblPercent2.Visible = true;
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
                    lblPercent1.Visible = true;
                    lblPercent2.Visible = true;
                    lblPercent3.Visible = true;
                    lblPercent4.Visible = true;
                    txbString1.Left = 310;
                    txbString2.Left = 310;
                    txbString3.Left = 310;
                    txbString4.Left = 310;
                    lblPercent1.Left = 420;
                    lblPercent2.Left = 420;
                    lblPercent3.Left = 420;
                    lblPercent4.Left = 420;
                    break;
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
            switch (Index)
            {
                case 0: // To_Effective_Rate
                    if (txbString1.Text == null)
                    {
                        MessageBox.Show("Debe de ingresar un tasa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (double.Parse(txbString1.Text) <= 0)
                    {
                        MessageBox.Show("La tasa no puede ser negativa o igual a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    if (string.IsNullOrEmpty(txbString1.Text) || string.IsNullOrEmpty(txbString2.Text))
                    {
                        MessageBox.Show("No puede haber campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    if (double.Parse(txbString2.Text) <= 0)
                    {
                        MessageBox.Show("El número de capitalizaciones no puede ser igual o menor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    tasa = double.Parse(txbString1.Text) / 100;
                    decimal effective = Convert.ToDecimal(Math.Pow((1 + (tasa / double.Parse(txbString2.Text))), double.Parse(txbString2.Text)) - 1);
                    singleton.ValueFunction = Math.Round(effective * 100, 4);
                    bandera = true;
                    FormExcel.Activate();
                    break;
                case 1:// To_Nominal_Rate
                    if (txbString1.Text == null)
                    {
                        MessageBox.Show("Debe de ingresar un tasa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (string.IsNullOrEmpty(txbString1.Text) || string.IsNullOrEmpty(txbString2.Text))
                    {
                        MessageBox.Show("No puede haber campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    if (double.Parse(txbString1.Text) <= 0)
                    {
                        MessageBox.Show("La tasa no puede ser nagativa o igual a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    if (double.Parse(txbString2.Text) <= 0)
                    {
                        MessageBox.Show("El número de capitalizaciones no puede ser igual o menor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    tasa = double.Parse(txbString1.Text) / 100;
                    decimal nominal = Convert.ToDecimal(((Math.Pow((1 + tasa), 1 / double.Parse(txbString2.Text))) - 1) * double.Parse(txbString2.Text));
                    singleton.ValueFunction = Math.Round(nominal * 100, 4);
                    bandera = true;
                    FormExcel.Activate();
                    break;
                case 2://Annuities
                    if (txbString1.Text == null)
                    {
                        MessageBox.Show("Debe de ingresar una Anualidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (txbString3.Text == null)
                    {
                        MessageBox.Show("Debe de ingresar una tasa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (double.Parse(txbString3.Text) <= 0)
                    {
                        MessageBox.Show("La tasa no puede ser nagativa o igual a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    tasa = double.Parse(txbString3.Text) / 100;
                    Annuity _annuity;
                    if (string.IsNullOrWhiteSpace(txbString1.Text)) // if the present is empty
                    {
                        _annuity = new Annuity
                        {
                            Future = decimal.Parse(txbString2.Text),
                            Rate = (decimal)tasa,
                            End = Int32.Parse(txbString4.Text),

                        };
                    }
                    else
                    {
                        _annuity = new Annuity
                        {
                            Present = decimal.Parse(txbString1.Text),
                            Rate = (decimal)tasa,
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
                    tasa = double.Parse(txbString2.Text);
                    Annuity annuity = new Annuity
                    {
                        Payment = decimal.Parse(txbString1.Text),
                        Rate = (decimal)tasa,
                        TotalPeriod = Int32.Parse(txbString3.Text)

                    };
                    if (type == 0)
                    {
                        annuity.Type = "Ordinary";
                        annuity.End = annuity.TotalPeriod;
                    }
                    else if (type == 1)
                    {
                        annuity.Type = "Anticipated";
                        annuity.End = annuity.TotalPeriod;
                        annuity.TotalPeriod = annuity.TotalPeriod + 1 + annuity.End;
                    }
                    else
                    {
                        annuity.Type = "Deferred";
                        annuity.Initial = Int32.Parse(txbString4.Text) + 1;
                        annuity.End = annuity.TotalPeriod;
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
                    tasa = double.Parse(txbString2.Text);
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
                        annuitys.Initial = Int32.Parse(txbString4.Text) + 1;
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
                    tasa = double.Parse(txbString3.Text);
                    Serie series = new Serie
                    {
                        DownPayment = decimal.Parse(txbString1.Text),
                        Rate = (decimal)tasa,
                        End = Int32.Parse(txbString4.Text),
                        Quantity = decimal.Parse(txbString2.Text)

                    };
                    if (type == 0)
                    {
                        series.Type = "Arithmetic";
                        series.Initial = 1;
                    }
                    else if (type == 1)
                    {
                        series.Type = "Geometric";
                        series.Initial = 1;
                    }
                    if(chbIncremento.Checked)
                    {
                        series.Incremental = true;
                    }
                    else
                    {
                        series.Incremental = false;
                    }
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
                    tasa = double.Parse(txbString3.Text);
                    Serie serie = new Serie
                    {
                        DownPayment = decimal.Parse(txbString1.Text),
                        Rate = (decimal)tasa,
                        End = Int32.Parse(txbString4.Text),
                        Quantity = decimal.Parse(txbString2.Text),
                        TotalPeriod = Int32.Parse(txbString4.Text)
                    };
                    if (type == 0)
                    {
                        serie.Type = "Arithmetic";
                        serie.Initial = 1;
                    }
                    else if (type == 1)
                    {
                        serie.Type = "Geometric";
                        serie.Initial = 1;
                    }
                    if (chbIncremento.Checked)
                    {
                        serie.Incremental = true;
                    }
                    else
                    {
                        serie.Incremental = false;
                    }
                    serie.Present = calculateServicesSerie.Present(serie);
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
                            else if (singleton.Exit[counter] < 1)
                            {
                                singleton.ValueFunctionList.Add(singleton.Entry[counter] + singleton.Exit[counter]);
                            }
                            else
                            {
                                singleton.ValueFunctionList.Add(singleton.Entry[counter] - singleton.Exit[counter]);
                            }
                        }
                        counter++;
                    }
                    singleton.Selection = true;
                    bandera = true;
                    FormExcel.Activate();
                    break;
                case 8: //VPN
                    if (string.IsNullOrEmpty(txbString1.Text) || string.IsNullOrEmpty(txbString2.Text) || string.IsNullOrEmpty(txbString3.Text))
                    {
                        MessageBox.Show("No puede haber campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    if (double.Parse(txbString3.Text) <= 0)
                    {
                        MessageBox.Show("La tasa no puede ser nagativa o igual a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    tasa = double.Parse(txbString3.Text) / 100;
                    Double[] value = new Double[singleton.Entry.Count + 1];
                    double inversion = 0;
                    if (double.Parse(txbString2.Text) < 0)
                    {
                        inversion = double.Parse(txbString2.Text);
                    }
                    else if (double.Parse(txbString2.Text) > 0)
                    {
                        inversion = -(double.Parse(txbString2.Text));
                    }
                    for (int i = 0; i < singleton.Entry.Count; i++)
                    {
                        value[i] = singleton.Entry[i];
                    }
                    singleton.ValueFunction = Math.Round(Convert.ToDecimal(Financial.NPV(tasa, ref value) + inversion), 2);
                    bandera = true;
                    FormExcel.Activate();
                    break;
                case 9: //TIR
                    if (string.IsNullOrEmpty(txbString1.Text))
                    {
                        MessageBox.Show("Debe de ingresar el FNE y la inversión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        tasa = double.Parse(txbString2.Text) / 100;
                        singleton.ValueFunction = Math.Round((decimal)Financial.IRR(ref values, tasa) * 100, 2);
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
                    singleton.Selection = true;
                    bandera = true;
                    singleton.Index = 10;
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
                    singleton.Index = 11;
                    singleton.Selection = true;
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
                    singleton.Index = 12;
                    singleton.Selection = true;
                    FormExcel.Activate();
                    break;
                case 13: //TMAR_Mixta
                    double tasaInversionista = 0;
                    double Porceninversionista = 0;
                    double PorcenInstitucion = 0;
                    if (string.IsNullOrEmpty(txbString1.Text) || string.IsNullOrEmpty(txbString3.Text))
                    {
                        MessageBox.Show("Debe de ingresar un valor para cada tasa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    if (string.IsNullOrEmpty(txbString2.Text) && string.IsNullOrEmpty(txbString4.Text))
                    {
                        MessageBox.Show("Debe de ingresar por lo menos el porcentaje de aportación de una tasa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    try
                    {
                        if (double.Parse(txbString1.Text) < 1 || (double.Parse(txbString2.Text) < 1) || double.Parse(txbString3.Text) < 1)
                        {
                            MessageBox.Show("No se admiten datos negativos en estas operaciones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    }
                    catch
                    {
                        if (double.Parse(txbString1.Text) < 1 || (double.Parse(txbString4.Text) < 1) || double.Parse(txbString3.Text) < 1)
                        {
                            MessageBox.Show("No se admiten datos negativos en estas operaciones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    }
                    tasa = double.Parse(txbString1.Text) / 100;
                    tasaInversionista = double.Parse(txbString3.Text) / 100;
                    if (string.IsNullOrEmpty(txbString2.Text))
                    {
                        if (double.Parse(txbString4.Text) > 1)
                        {
                            Porceninversionista = (100 - double.Parse(txbString4.Text)) / 100;
                            PorcenInstitucion = double.Parse(txbString4.Text) / 100;
                        }
                        else
                        {
                            Porceninversionista = 1 - double.Parse(txbString4.Text);
                            PorcenInstitucion = double.Parse(txbString4.Text);
                        }
                        singleton.ValueFunction = Math.Round(Convert.ToDecimal(((tasa * Porceninversionista) +
                            (tasaInversionista * PorcenInstitucion)) * 100), 2);
                    }
                    else if (string.IsNullOrEmpty(txbString4.Text))
                    {
                        if (double.Parse(txbString2.Text) > 1)
                        {
                            PorcenInstitucion = (100 - double.Parse(txbString2.Text)) / 100;
                            Porceninversionista = double.Parse(txbString2.Text) / 100;
                        }
                        else
                        {
                            PorcenInstitucion = 1 - double.Parse(txbString2.Text);
                            Porceninversionista = double.Parse(txbString2.Text);
                        }
                        singleton.ValueFunction = Math.Round(Convert.ToDecimal(((tasa * Porceninversionista) +
                            (tasaInversionista * PorcenInstitucion)) * 100), 2);
                    }
                    bandera = true;
                    FormExcel.Activate();
                    break;
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
                    else if (singleton.ValueTask != 0)
                    {
                        txbString1.Text = singleton.ValueTask.ToString();
                        singleton.ValueTask = 0;
                        break;
                    }
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
                        singleton.ValueTask = 0;
                        break;
                    }
                    break;
                case 3:
                    if (singleton.ValueTask != 0)
                    {
                        txbString3.Text = singleton.ValueTask.ToString();
                        singleton.ValueTask = 0;
                        break;
                    }
                    break;
                case 4:
                    if (singleton.ValueTask != 0)
                    {
                        txbString4.Text = singleton.ValueTask.ToString();
                        singleton.ValueTask = 0;
                        break;
                    }
                    break;
                case 5:
                    if(singleton.ValueTask != 0)
                    {
                        txbString5.Text = singleton.ValueTask.ToString();
                        singleton.ValueTask = 0;
                        break;
                    }
                    break;
            }
        }

        private void txbString1_Click(object sender, EventArgs e)
        {
            txbString1.Focus();
            FocusTexboxs();
            if (Index == 7 || Index == 8 || Index == 9)
            {
                singleton.Selection = true;
                singleton.Type = true;
                singleton.MinRow = 0;
                singleton.MinColumn = 0;
                singleton.MaxRow = 0;
                singleton.MaxColumn = 0;
            }
            singleton.Index = 1;
        }

        private void txbString2_Click(object sender, EventArgs e)
        {
            txbString2.Focus();
            FocusTexboxs();
            if (Index == 7)
            {
                singleton.Type = false;
                singleton.MinRow = 0;
                singleton.MinColumn = 0;
                singleton.MaxRow = 0;
                singleton.MaxColumn = 0;
            }
            if(Index == 8 || Index == 9)
            {
                singleton.Selection = false;
            }
            singleton.Index = 2;
        }

        private void txbString3_Click(object sender, EventArgs e)
        {
            txbString3.Focus();
            FocusTexboxs();
            singleton.Index = 3;
            if (Index == 8)
            {
                singleton.Selection = false;
            }
        }

        private void txbString4_Click(object sender, EventArgs e)
        {
            txbString4.Focus();
            FocusTexboxs();
            singleton.Index = 4;
        }

        private void txbString5_Click(object sender, EventArgs e)
        {
            txbString5.Focus();
            FocusTexboxs();
            singleton.Index = 5;
        }

        private void txbString5_TextChanged(object sender, EventArgs e)
        {
            if (txbString5.Text == "1" && (Index == 5 || Index == 6))
            {
                lbString2.Text = "Gradiente geometrico";
                return;
            }
            else if (txbString5.Text == "0" && (Index == 5 || Index == 6))
            {
                lbString2.Text = "Gradiente aritmético";
                return;
            }
            if (txbString5.Text == "2" && (Index == 3 || Index == 4))
            {
                lbString4.Text = "Periodo de gracia";
                lbString4.Visible = true;
                txbString4.Visible = true;
                return;
            }
            if (Index == 11 || Index == 3 || Index == 5 || Index == 6 || Index == 2)
            {
                return;
            }
            txbString4.Visible = false;
            lbString4.Visible = false;
        }

        private void txbString5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txbString1.Focus();
                FocusTexboxs();
                singleton.Index = 1;
                return;
            }
            if (txbString5.ReadOnly == false)
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

        private void txbString2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                if (Index == 0 || Index == 1 || Index == 7 || Index == 9)
                {
                    txbString1.Focus();
                    FocusTexboxs();
                    singleton.Index = 1;
                    return;
                }
                txbString3.Focus();
                FocusTexboxs();
                singleton.Index = 3;
                if (Index == 7)
                {
                    singleton.Type = false;
                    singleton.MinRow = 0;
                    singleton.MinColumn = 0;
                    singleton.MaxRow = 0;
                    singleton.MaxColumn = 0;
                }
                if (Index == 8 || Index == 9)
                {
                    singleton.Selection = false;
                }
                return;
            }
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
            if (Index == 7 || Index == 8 || Index == 9)
            {
                singleton.Selection = true;
                singleton.Type = true;
                singleton.MinRow = 0;
                singleton.MinColumn = 0;
                singleton.MaxRow = 0;
                singleton.MaxColumn = 0;
            }
            singleton.Index = 1;
            FormExcel.Activate();
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
            if (Index == 7)
            {
                singleton.Selection = true;
                singleton.Type = true;
                singleton.MinRow = 0;
                singleton.MinColumn = 0;
                singleton.MaxRow = 0;
                singleton.MaxColumn = 0;
            }
            else if (Index == 8 || Index == 9)
            {
                singleton.Selection = false;
            }
            singleton.Index = 2;
            FormExcel.Activate();
        }

        private void txbString3_DoubleClick(object sender, EventArgs e)
        {
            singleton.Index = 3;
            FormExcel.Activate();
        }

        private void txbString4_DoubleClick(object sender, EventArgs e)
        {
            singleton.Index = 4;
            FormExcel.Activate();
        }

        private void txbString1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                if (Index == 2)
                {
                    if(txbString2.Visible == false)
                    {
                        txbString3.Focus();
                        FocusTexboxs();
                        singleton.Index = 3;
                        return;
                    }
                }
                txbString2.Focus();
                FocusTexboxs();
                singleton.Index = 2;
                return;
            }
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
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                if (Index == 8 || Index == 10)
                {
                    txbString1.Focus();
                    FocusTexboxs();
                    singleton.Index = 1;
                    return;
                }
                if((Index == 4 || Index == 3) && txbString4.Visible == false)
                {
                    txbString5.Focus();
                    singleton.Index = 5;
                    FocusTexboxs();
                    return;
                }
                txbString4.Focus();
                FocusTexboxs();
                singleton.Index = 4;
                return;
            }
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
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                if (Index == 12 || Index == 13)
                {
                    txbString1.Focus();
                    FocusTexboxs();
                    singleton.Index = 1;
                    return;
                }
                txbString5.Focus();
                singleton.Index = 5;
                FocusTexboxs();
                return;
            }
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
            singleton.Index = 5;
            FormExcel.Activate();
        }

        private void txbString1_TextChanged(object sender, EventArgs e)
        {
            if (Index == 2 && !string.IsNullOrEmpty(txbString1.Text))
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

        private void txbString2_TextChanged(object sender, EventArgs e)
        {
            if (Index == 13)
            {
                if (string.IsNullOrEmpty(txbString2.Text))
                {
                    lbString4.Visible = true;
                    txbString4.Visible = true;
                }
                else
                {
                    lbString4.Visible = false;
                    txbString4.Visible = false;
                }
            }
            else if (Index == 2)
            {
                if (string.IsNullOrEmpty(txbString2.Text))
                {
                    lbString1.Visible = true;
                    txbString1.Visible = true;
                }
                else
                {
                    lbString1.Visible = false;
                    txbString1.Visible = false;
                }
            }
        }

        private void txbString4_TextChanged(object sender, EventArgs e)
        {

            if (Index == 13)
            {
                if (string.IsNullOrEmpty(txbString4.Text))
                {
                    lbString2.Visible = true;
                    txbString2.Visible = true;
                }
                else
                {
                    lbString2.Visible = false;
                    txbString2.Visible = false;
                }
            }
        }

        private void FocusTexboxs()
        {
            switch(Index)
            {
                case 0:
                    if(txbString1.Focused)
                    {
                        txbInfo.Text = "Indica la tasa capitalizable cada cierto periodo en porcentaje (%).";
                    }
                    if(txbString2.Focused)
                    {
                        txbInfo.Text = "Indica el número de las capitalizaciones que tiene la tasa en todo" +
                            " el período.";
                    }
                    break;
                case 1:
                    if (txbString1.Focused)
                    {
                        txbInfo.Text = "Indica la tasa efectiva no periodica (anual) en porcentaje (%).";
                    }
                    if (txbString2.Focused)
                    {
                        txbInfo.Text = "Indica el número de las capitalizaciones que tiene la tasa nominal" +
                            " a la que se quiere convertir.";
                    }
                    break;
                case 2:
                    if (txbString1.Focused)
                    {
                        txbInfo.Text = "Representa el valor del dinero al comienzo del período. Y solo se podrá" +
                            " ingresar el presente o el futuro.";
                    }
                    if (txbString2.Focused)
                    {
                        txbInfo.Text = "Representa el valor del dinero al final del período. Y solo se podrá" +
                            " ingresar el presente o el futuro.";
                    }
                    if (txbString3.Focused)
                    {
                        txbInfo.Text = "Indica la tasa efectiva (anual) del periodo en porcentaje (%).";
                    }
                    if (txbString4.Focused)
                    {
                        txbInfo.Text = "Indica el período en el que se realizó el último pago.";
                    }
                    if(txbString5.Focused)
                    {
                        txbInfo.Text = "Si desea trabajar con una anualidad ordinaria ingrese \"0\", " +
                            "anualidad anticipada \"1\". El valor si deja vaccio será 0.";
                    }
                    break;
                case 4:
                case 3:
                    if (txbString1.Focused)
                    {
                        txbInfo.Text = "Representa la cantidad de dinero que es pagada en todos los períodos " +
                            "de la serie.";
                    }
                    if (txbString2.Focused)
                    {
                        txbInfo.Text = "Indica la tasa efectiva (anual) del periodo en porcentaje (%).";
                    }
                    if (txbString3.Focused)
                    {
                        txbInfo.Text = "Indica el período en el que se realizo el último pago.";
                    }
                    if (txbString4.Focused)
                    {
                        txbInfo.Text = "Representa el período en el que no se realizo ningún pago.";
                    }
                    if (txbString5.Focused)
                    {
                        txbInfo.Text = "Si desea trabajar con una anualidad ordinaria ingrese \"0\", " +
                            "anualidad anticipada \"1\" o anualidad diferida \"2\". El valor si deja vaccio será 0.";
                    }
                    break;
                case 6:
                case 5:
                    if (txbString1.Focused)
                    {
                        txbInfo.Text = "Representa la cantidad de dinero que es pagada en todos los períodos " +
                            "de la serie.";
                    }
                    if (txbString2.Focused)
                    {
                        txbInfo.Text = "El gradiente aritmético o el gradiente geometrico representa el incremento o decremento " +
                            "de la anualidad durante todo el período de la serie. El gradiente aritmético es una" +
                            "cantidad de dinero constante, mientras que el gradiente geometrico es un porcentaje (%).";
                    }
                    if (txbString3.Focused)
                    {
                        txbInfo.Text = "Indica la tasa efectiva (anual) del periodo en porcentaje (%).";
                    }
                    if (txbString4.Focused)
                    {
                        txbInfo.Text = "Indica el período en el que se realizo el último pago.";
                    }
                    if (txbString5.Focused)
                    {
                        txbInfo.Text = "Si desea trabajar con la serie aritmética ingrese \"0\" " +
                             "o serie geometrica \"1\". El valor si deja vacio será 0.";
                    }
                    break;
                case 7:
                    if (txbString1.Focused)
                    {
                        txbInfo.Text = "Representa todos los ingresos obtenidos.";
                    }
                    if (txbString2.Focused)
                    {
                        txbInfo.Text = "Representa todas costos o gastos que se adquirieron.";
                    }
                    break;
                case 8:
                    if (txbString1.Focused)
                    {
                        txbInfo.Text = "Representa la ganancias obtenidas en el proyecto. Los resta de los ingresos y los" +
                            " gastos.";
                    }
                    if (txbString2.Focused)
                    {
                        txbInfo.Text = "Es la cantidad de dinero que se gasta al inicio del proyecto, " +
                            "para que pueda operarse el proyecto de una manera correcta.";
                    }
                    if (txbString3.Focused)
                    {
                        txbInfo.Text = "Indica la tasa efectiva (anual) del proyecto en porcentaje (%).";
                    }
                    break;
                case 9:
                    if (txbString1.Focused)
                    {
                        txbInfo.Text = "Representa todos los gastos o ingresos que se obtuvieron a lo " +
                            "largo de todo el proyecto.";
                    }
                    if (txbString2.Focused)
                    {
                        txbInfo.Text = "Indica la tasa efectiva (anual) del proyecto en porcentaje (%). Si " +
                            "se deja vacío el valor será de 10%.";
                    }
                    break;
                case 10:
                    if (txbString1.Focused)
                    {
                        txbInfo.Text = "Es la cantidad de dinero con la que se compra un activo fijo.";
                    }
                    if (txbString2.Focused)
                    {
                        txbInfo.Text = "Es la cantidad de dinero que valdrá el activo fijo cuando acabe" +
                            " la vida útil.";
                    }
                    if (txbString3.Focused)
                    {
                        txbInfo.Text = "Son los años que se depreciará el activo fijo.";
                    }
                    break;
                case 11:
                    if (txbString1.Focused)
                    {
                        txbInfo.Text = "Es la cantidad de dinero con la que se compra un activo fijo.";
                    }
                    if (txbString2.Focused)
                    {
                        txbInfo.Text = "Es la cantidad de dinero que valdrá el activo fijo cuando acabe" +
                            " la vida útil.";
                    }
                    if (txbString3.Focused)
                    {
                        txbInfo.Text = "Son los años que se depreciará el actvo fijo.";
                    }
                    if (txbString4.Focused)
                    {
                        txbInfo.Text = "Indica en que año quiere comenzar a depreciar el activo fijo. " +
                            "El período debe de ser menor a la vida útil.";
                    }
                    if (txbString5.Focused)
                    {
                        txbInfo.Text = "Tipo de disminución del activo. Si se omite el valor será de 2";
                    }
                    break;
                case 12:
                    if (txbString1.Focused)
                    {
                        txbInfo.Text = "Es la cantidad de dinero con la que se compra un activo fijo.";
                    }
                    if (txbString2.Focused)
                    {
                        txbInfo.Text = "Es la cantidad de dinero que valdrá el activo fijo cuando acabe" +
                            " la vida útil.";
                    }
                    if (txbString3.Focused)
                    {
                        txbInfo.Text = "Son los años que se depreciará el actvo fijo.";
                    }
                    if (txbString4.Focused)
                    {
                        txbInfo.Text = "Indica en que año quiere comenzar a depreciar el activo fijo. " +
                            "El período debe de ser menor a la vida útil.";
                    }
                    break;
                case 13:
                    if (txbString1.Focused)
                    {
                        txbInfo.Text = "Indica la tasa efectiva (anual) de la o las entidades que estan a " +
                            "cargo del proyecto, la tasa debe de estar en porcentaje (%).";
                    }
                    if (txbString2.Focused)
                    {
                        txbInfo.Text = "Es el porcentaje que la o las entidadades cubren del proyecto, " +
                            "esta debe de estar en porcentaje (%). Y sólo se podra ingresar datos en \"Porcentaje " +
                            "de aportación\" o \"Porcentaje de la institución financiera\".";
                    }
                    if (txbString3.Focused)
                    {
                        txbInfo.Text = "Indica la tasa efectiva (anual) de la institución a la que se pidió un " +
                            "prestamo para cubir la cantidad de inversión faltante del proyecto, la tasa debe de " +
                            "estar en porcentaje (%).";
                    }
                    if (txbString4.Focused)
                    {
                        txbInfo.Text = "Es el porcentaje que la o las entidadades cubren del proyecto, " +
                            "esta debe de estar en porcentaje (%). Y sólo se podra ingresar datos en \"Porcentaje " +
                            "de aportación\" o \"Porcentaje de la institución financiera\".";
                    }
                    break;
            }
        }

        private void gbData_Enter(object sender, EventArgs e)
        {
            txbString1.Focus();
            singleton.Index = 1;
            FocusTexboxs();
            if (Index == 7 || Index == 8 || Index == 9)
            {
                singleton.Type = true;
                singleton.Type = true;
                singleton.MinRow = 0;
                singleton.MinColumn = 0;
                singleton.MaxRow = 0;
                singleton.MaxColumn = 0;
            }
        }

        private void chbIncremento_MouseMove(object sender, MouseEventArgs e)
        {
            CheckBox chb = (CheckBox)sender;
            ttInfo.SetToolTip(chb, "Indica si la anualidad va a disminuir o aumentar a lo largo de la serie. " +
                "Si no se seleciona se asume que la anualidad va a disminuir");
        }
    }
}
