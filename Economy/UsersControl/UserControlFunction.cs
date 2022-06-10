using Economy.AppCore.IServices;
using Economy.AppCore.Singleton;
using Economy.Domain.Entities;
using Economy.Forms;
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
        private FormFunction FormFunction;
        private int Index;
        private FormExcel FormExcel;
        private Singleton singleton;
        public UserControlFunction(int Index, FormExcel formExcel, ICalculateServices<Annuity> calculateServicesAnnuity, 
            ICalculateServices<Interest> calculateServicesInterest, FormFunction formFunction)
        {
            InitializeComponent();
            this.FormExcel = formExcel;
            this.Index = Index;
            this.calculateServicesAnnuity = calculateServicesAnnuity;
            this.CalculateServicesInterest = calculateServicesInterest;
            this.FormFunction = formFunction;
            singleton = Singleton.instance1;

            ValidateIndex();
        }

        private void txbString1_Click(object sender, EventArgs e)
        {
            singleton.Index = 1;
            FormExcel.BringToFront();
            txbInfo.Visible = false;

        }
        private void ValidateIndex()
        {
            switch (Index)
            {
                case 0:

                    break;
                case 2:
                case 1:
                    lbString1.Text = "Payment";
                    lbString2.Text = "Rate";
                    lbString3.Text = "End";
                    lbString4.Visible = false;
                    txbString4.Visible = false;
                    lbString5.Text = "Type";
                    txbString5.ReadOnly = false;
                    txbInfo.Text = "If you wish to work with ordinary annuity enter \"0\", anticipated annuity \"1\" or deferred annuity \"2\". The default value is 0";
                    break;
                case 4:
                case 3:
                    lbString1.Text = "DownPayment";
                    lbString2.Text = "Rate";
                    lbString3.Text = "End";
                    lbString4.Visible = false;
                    txbString4.Visible = false;
                    lbString5.Text = "Type";
                    txbString5.ReadOnly = false;
                    txbInfo.Text = "If you wish to work with the arithmetic series enter \"0\" or geometric series \"1\". The default value is 0";
                    break;
            }
                
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

        private void txbString2_Click(object sender, EventArgs e)
        {
            singleton.Index = 2;
            FormExcel.BringToFront();
            txbInfo.Visible = false;
        }

        private void txbString3_Click(object sender, EventArgs e)
        {
            singleton.Index = 3;
            FormExcel.BringToFront();
            txbInfo.Visible = false;
        }

        private void txbString4_Click(object sender, EventArgs e)
        {
            singleton.Index = 4;
            FormExcel.BringToFront();
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
                case 0:
                    break;
                case 2:
                case 1:
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
                    singleton.ValueFunction = Math.Round(calculateServicesAnnuity.Present(annuity), 2);
                    FormExcel.Activate();
                    break;
                case 4:
                case 3:
                    if (double.Parse(txbString1.Text) < 0 || double.Parse(txbString2.Text) < 0 ||
                       double.Parse(txbString3.Text) < 0)
                    {
                        MessageBox.Show("Data cannot be negative.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (type < 0 || type > 2)
                    {
                        MessageBox.Show("You must choose a valid annuity type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                    }
                    if (type == 2 && (double.Parse(txbString4.Text) < 0 ||
                        double.Parse(txbString4.Text) > double.Parse(txbString3.Text)))
                    {
                        MessageBox.Show("The annuity period is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    FormExcel.Activate();
                    break;
                case 5:
                    break;
            }
            FormFunction.Close();
        }
        public void FillTextBox()
        {
            switch (singleton.Index)
            {
                case 1:
                    txbString1.Text = singleton.ValueTask.ToString();
                    break;
                case 2:
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
    }
}
