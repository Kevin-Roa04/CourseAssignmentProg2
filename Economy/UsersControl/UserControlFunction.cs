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

            ValidateIndex();
        }

        private void ValidateIndex()
        {
            ShowAllCamps();
            switch (Index)
            {
                case 0: // To_Effective_Rate
                    lbString1.Text = "Nomninal rate";
                    lbString2.Text = "Nominal rate Period";
                    lbString3.Text = "Nominal rate capitalization";
                    lbString4.Text = "Effective rate period";
                    lbString5.Visible = false;
                    txbString5.Visible = false;
                    txbInfo.Text = "If you wish to work with ordinary annuity enter \"0\", anticipated annuity \"1\" or deferred annuity \"2\". The default value is 0";
                    break;
                case 1: //To-Nominal_Rate
                    lbString1.Text = "Effective rate";
                    lbString2.Text = "Effective rate Period";
                    lbString3.Text = "Nominal rate period";
                    lbString4.Text = "Nominal rate capitalization";
                    lbString5.Visible = false;
                    txbString5.Visible = false;
                    txbInfo.Text = "If you wish to work with ordinary annuity enter \"0\", anticipated annuity \"1\" or deferred annuity \"2\". The default value is 0";
                    break;
                case 2: // Annuities
                    lbString1.Text = "Present";
                    lbString2.Text = "Future";
                    lbString3.Text = "Rate";
                    lbString4.Text = "Period";
                    lbString5.Text = "Annuity type";
                    txbString5.ReadOnly = false;
                    txbInfo.Text = "If you wish to work with ordinary annuity enter \"0\", anticipated annuity \"1\" or deferred annuity \"2\". The default value is 0";
                    break;
                case 4: //Future Annuities
                    lbString1.Text = "Payment";
                    lbString2.Text = "Rate";
                    lbString3.Text = "End";
                    lbString4.Visible = false;
                    txbString4.Visible = false;
                    lbString5.Text = "Type";
                    txbString5.ReadOnly = false;
                    txbInfo.Text = "If you wish to work with ordinary annuity enter \"0\", anticipated annuity \"1\" or deferred annuity \"2\". The default value is 0";
                    break;
                case 3: //Present Annuities
                    lbString1.Text = "DownPayment";
                    lbString2.Text = "Rate";
                    lbString3.Text = "End";
                    lbString4.Visible = false;
                    txbString4.Visible = false;
                    lbString5.Text = "Type";
                    txbString5.ReadOnly = false;
                    txbInfo.Text = "If you wish to work with the arithmetic series enter \"0\" or geometric series \"1\". The default value is 0";
                    break;
                case 5: //Present Series
                    lbString1.Text = "DownPayment";
                    lbString2.Text = "Rate";
                    lbString3.Text = "End";
                    lbString4.Visible = false;
                    txbString4.Visible = false;
                    lbString5.Text = "Type";
                    txbString5.ReadOnly = false;
                    txbInfo.Text = "If you wish to work with the arithmetic series enter \"0\" or geometric series \"1\". The default value is 0";
                    break;
                case 6: //Future Series
                    lbString1.Text = "Payment";
                    lbString2.Text = "Rate";
                    lbString3.Text = "End";
                    lbString4.Visible = false;
                    txbString4.Visible = false;
                    lbString5.Text = "Type";
                    txbString5.ReadOnly = false;
                    txbInfo.Text = "If you wish to work with the arithmetic series enter \"0\" or geometric series \"1\". The default value is 0";
                    break;
                case 7: //FNE
                    lbString1.Text = "Entry";
                    lbString2.Text = "Exit";
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
                    lbString3.Text = "Rate";
                    lbString4.Visible = false;
                    lbString5.Visible = false;
                    txbString4.Visible = false;
                    txbString5.Visible = false;
                    txbTypeEntry.Visible = false;
                    txbTypeExit.Visible = false;
                    break;
                case 9: //TIR
                    lbString1.Text = "Inversion and FNE";
                    lbString2.Text = "Rate";
                    lbString3.Visible = false;
                    lbString4.Visible = false;
                    lbString5.Visible = false;
                    txbString2.ReadOnly = false;
                    txbString3.Visible = false;
                    txbString4.Visible = false;
                    txbString5.Visible = false;
                    txbTypeEntry.Visible = false;
                    txbTypeExit.Visible = false;
                    txbInfo.Text = "Estimated value, if omitted it is 10%";
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
                    if (double.Parse(txbString1.Text) <= 0 || double.Parse(txbString1.Text) > 1)
                    {
                        MessageBox.Show("The rate cannot be negative, cero or higher than one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    if (double.Parse(txbString2.Text) <= 0 || double.Parse(txbString3.Text) <= 0 || double.Parse(txbString4.Text) <= 0)
                    {
                        MessageBox.Show("Insert valid data, try again...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    if (string.IsNullOrEmpty(txbString1.Text) || string.IsNullOrEmpty(txbString2.Text) || string.IsNullOrEmpty(txbString3.Text) || string.IsNullOrEmpty(txbString4.Text))
                    {
                        MessageBox.Show("There can't be empty spaces, try again...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    double rate = double.Parse(txbString1.Text);
                    int NominalRatePeriod = int.Parse(txbString2.Text);
                    int NominalRateCapitalization = int.Parse(txbString3.Text);
                    int EffectiveRatePEriod = int.Parse(txbString4.Text);

                    float m = (float)(EffectiveRatePEriod * 30) / (float)(NominalRateCapitalization * 30);
                    if (NominalRatePeriod != EffectiveRatePEriod)
                    {
                        rate = (float)rate / (float)NominalRatePeriod;
                    }
                    double a = 1 + (rate / m);

                    double EffectiveRate = Math.Round(Math.Pow(a, m) - 1, 4);
                    singleton.ValueFunction = (decimal)EffectiveRate;
                    FormExcel.Activate();
                    break;
                case 1:// To_Nominal_Rate
                    if (double.Parse(txbString1.Text) <= 0 || double.Parse(txbString1.Text) > 1)
                    {
                        MessageBox.Show("The rate cannot be negative, cero or higher than one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    if (double.Parse(txbString2.Text) <= 0 || double.Parse(txbString3.Text) <= 0 || double.Parse(txbString4.Text) <= 0)
                    {
                        MessageBox.Show("Insert valid data, try again...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    if (string.IsNullOrEmpty(txbString1.Text) || string.IsNullOrEmpty(txbString2.Text) || string.IsNullOrEmpty(txbString3.Text) || string.IsNullOrEmpty(txbString4.Text))
                    {
                        MessageBox.Show("There can't be empty spaces, try again...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    double _EffectiveRate = double.Parse(txbString1.Text);
                    int _EffectiveRatePeriod = int.Parse(txbString2.Text);
                    int _NominalRatePeriod = int.Parse(txbString3.Text);
                    int _NominalRateCapitalization = int.Parse(txbString4.Text);

                    float _m = (float)(_NominalRatePeriod * 30) / (float)(_NominalRateCapitalization * 30);
                    float NominalRate = (float)(Math.Pow(1 + _EffectiveRate, (float)(_NominalRateCapitalization * 30) / (float)(_EffectiveRatePeriod * 30)) - 1);
                    singleton.ValueFunction = (decimal)Math.Round(NominalRate * _m, 4);
                    FormExcel.Activate();
                    break;
                case 2://Annuities
                    lbString1.Text = "Present";
                    lbString2.Text = "Future";
                    lbString3.Text = "Rate";
                    lbString4.Text = "Period";
                    lbString5.Text = "Annuity type";
                    txbString5.ReadOnly = false;
                    if (double.Parse(txbString3.Text) <= 0 || double.Parse(txbString3.Text) > 1)
                    {
                        MessageBox.Show("The rate cannot be negative, cero or higher than one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    if (!string.IsNullOrWhiteSpace(txbString1.Text) && !string.IsNullOrWhiteSpace(txbString2.Text))
                    {
                        MessageBox.Show("Present and future textbox can't be filled at the same time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (double.Parse(txbString1.Text) <= 0 || double.Parse(txbString2.Text) <= 0 || double.Parse(txbString4.Text) <= 0)
                    {
                        MessageBox.Show("Insert valid data, try again...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    if (string.IsNullOrEmpty(txbString1.Text) || string.IsNullOrEmpty(txbString2.Text) || string.IsNullOrEmpty(txbString3.Text) || string.IsNullOrEmpty(txbString4.Text))
                    {
                        MessageBox.Show("There can't be empty spaces, try again...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
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
                    FormExcel.Activate();
                    break;
                case 4: //Future Annuities
                    if (double.Parse(txbString1.Text) < 0 || double.Parse(txbString2.Text) < 0 ||
                        double.Parse(txbString3.Text) < 0)
                    {
                        MessageBox.Show("Data cannot be negative.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (type < 0 || type > 1)
                    {
                        MessageBox.Show("You must choose a valid series type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                    }
                    if (type == 1 && (double.Parse(txbString4.Text) < 0 ||
                        double.Parse(txbString4.Text) > double.Parse(txbString3.Text)))
                    {
                        MessageBox.Show("The series period is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Annuity annuity = new Annuity
                    {
                        Payment = decimal.Parse(txbString1.Text),
                        Rate = decimal.Parse(txbString2.Text),
                        End = Int32.Parse(txbString2.Text),

                    };
                    if (type == 0)
                        annuity.Type = "Ordinary";
                    else if (type == 1)
                        annuity.Type = "Anticipated";
                    else
                    {
                        annuity.Type = "Deferred";
                        annuity.Initial = Int32.Parse(txbString4.Text);
                    }
                    singleton.ValueFunction = Math.Round(calculateServicesAnnuity.Future(annuity), 2);
                    FormExcel.Activate();
                    break;
                case 3: //Present Annuities
                    if (double.Parse(txbString1.Text) < 0 || double.Parse(txbString2.Text) < 0 ||
                        double.Parse(txbString3.Text) < 0)
                    {
                        MessageBox.Show("Data cannot be negative.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    if (type < 0 || type > 1)
                    {
                        MessageBox.Show("You must choose a valid series type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    if (type == 1 && (double.Parse(txbString4.Text) < 0 ||
                        double.Parse(txbString4.Text) > double.Parse(txbString3.Text)))
                    {
                        MessageBox.Show("The series period is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    Annuity annuitys = new Annuity
                    {
                        Payment = decimal.Parse(txbString1.Text),
                        Rate = decimal.Parse(txbString2.Text),
                        End = Int32.Parse(txbString2.Text),

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
                    FormExcel.Activate();
                    break;
                case 5: //Present Series
                    if (double.Parse(txbString1.Text) < 0 || double.Parse(txbString2.Text) < 0 ||
                       double.Parse(txbString3.Text) < 0)
                    {
                        MessageBox.Show("Data cannot be negative.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    if (type < 0 || type > 2)
                    {
                        MessageBox.Show("You must choose a valid annuity type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    if (type == 2 && (double.Parse(txbString4.Text) < 0 ||
                        double.Parse(txbString4.Text) > double.Parse(txbString3.Text)))
                    {
                        MessageBox.Show("The annuity period is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    Serie series = new Serie
                    {
                        DownPayment = decimal.Parse(txbString1.Text),
                        Rate = decimal.Parse(txbString2.Text),
                        End = Int32.Parse(txbString2.Text),

                    };
                    if (type == 0)
                        series.Type = "Ordinary";
                    else if (type == 1)
                        series.Type = "Anticipated";
                    else
                    {
                        series.Type = "Deferred";
                        series.Initial = Int32.Parse(txbString4.Text);
                    }
                    singleton.ValueFunction = Math.Round(calculateServicesSerie.Present(series), 2);
                    FormExcel.Activate();
                    break;
                case 6: //Future Annuities
                    if (double.Parse(txbString1.Text) < 0 || double.Parse(txbString2.Text) < 0 ||
                       double.Parse(txbString3.Text) < 0)
                    {
                        MessageBox.Show("Data cannot be negative.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    if (type < 0 || type > 2)
                    {
                        MessageBox.Show("You must choose a valid annuity type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    if (type == 2 && (double.Parse(txbString4.Text) < 0 ||
                        double.Parse(txbString4.Text) > double.Parse(txbString3.Text)))
                    {
                        MessageBox.Show("The annuity period is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    FormExcel.Activate();
                    break;
                case 7: //FNE
                    if (txbString1.Text == string.Empty || txbString2.Text == string.Empty)
                    {
                        MessageBox.Show("You must fill the data");
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
                    FormExcel.Activate();
                    break;
                case 8: //VPN
                    if (txbString1.Text == string.Empty)
                    {
                        MessageBox.Show("You must fill the data");
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
                    singleton.ValueFunction = Math.Round((decimal)Financial.NPV((double.Parse(txbString3.Text) / 100), ref value), 2);
                    break;
                case 9: //TIR
                    if (txbString1.Text == string.Empty)
                    {
                        MessageBox.Show("You must fill the data");
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
                    break;
            }
            singleton.Index = -1;
            singleton.Entry.Clear();
            singleton.Exit.Clear();
            singleton.Type = false;
            FormFunction.Close();
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
                    txbString1.Text = singleton.ValueTask.ToString();
                    break;
                case 2:
                    if (singleton.Selection && singleton.Exit.Count > 0)
                    {
                        txbString2.Text = $"{singleton.Exit.First()} - {singleton.Exit.Last()}";
                        break;
                    }
                    txbString2.Text = singleton.ValueTask.ToString();
                    break;
                case 3:
                    txbString3.Text = singleton.ValueTask.ToString();
                    break;
                case 4:
                    txbString4.Text = singleton.ValueTask.ToString();
                    break;
            }
        }

        private void txbString1_Click(object sender, EventArgs e)
        {
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
            if (Index == 9)
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
            singleton.Index = 3;
            FormExcel.Activate();
            txbInfo.Visible = false;
        }

        private void txbString4_Click(object sender, EventArgs e)
        {
            singleton.Index = 4;
            FormExcel.Activate();
            txbInfo.Visible = false;
        }

        private void txbString5_Click(object sender, EventArgs e)
        {
            if (txbString5.ReadOnly == false)
            {
                txbInfo.Visible = true;
                return;
            }

            txbInfo.Visible = false;
        }

        private void txbString5_TextChanged(object sender, EventArgs e)
        {
            if (txbString5.Text == "2" && (Index == 1 || Index == 2))
            {
                lbString4.Text = "Initial";
                lbString4.Visible = true;
                txbString4.Visible = true;
                return;
            }
            if (txbString5.Text == "1" && (Index == 3 || Index == 4))
            {
                lbString4.Text = "Initial";
                lbString4.Visible = true;
                txbString4.Visible = true;
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
            }
        }

        private void UserControlFunction_Load(object sender, EventArgs e)
        {
            txbString1.Text = string.Empty;
            txbString2.Text = string.Empty;
            txbString3.Text = string.Empty;
            txbString4.Text = string.Empty;
            txbString5.Text = string.Empty;
        }


    }
}
