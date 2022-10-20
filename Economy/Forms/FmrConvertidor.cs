
using Economy.AppCore.IServices;
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

namespace InteresPratica
{
    public partial class FmrConvertidor : Form
    {
        public INominalServices nominalServices;
        public FmrConvertidor(INominalServices services)
        {
            InitializeComponent();
            this.nominalServices = services;
            this.cmbactual.Items.AddRange(Enum.GetValues(typeof(Producto)).Cast<object>().ToArray());
            this.cmbdespues.Items.AddRange(Enum.GetValues(typeof(Producto)).Cast<object>().ToArray());
            this.cmbnominal.Items.AddRange(Enum.GetValues(typeof(Producto)).Cast<object>().ToArray());
            this.cmbactual.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbdespues.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbnominal.DropDownStyle = ComboBoxStyle.DropDownList;
            txtnominal1.KeyPress += new KeyPressEventHandler(txtnominal_KeyPress);
            txtxotranominal.KeyPress += new KeyPressEventHandler(txtxotranominal_KeyPress);
            txtefectivacontinua.KeyPress += new KeyPressEventHandler(txtefectivacontinua_KeyPress);
            txtefectiva.KeyPress += new KeyPressEventHandler(txtefectivacontinua_KeyPress);
        }



        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se pueden Letras");
            }
            else if (
           e.KeyChar == '+' || e.KeyChar == '¿' || e.KeyChar == '/' || e.KeyChar == '*' || e.KeyChar == '?' || e.KeyChar == '=' || e.KeyChar == ')'
           || e.KeyChar == '(' || e.KeyChar == '¡' || e.KeyChar == '-' || e.KeyChar == ',')
            {
                e.Handled = true;
                MessageBox.Show("No se acepatan caracteres");
            }

        }

       

       

        private void txtefectivacontinua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se pueden Letras");
            }
            else if (
           e.KeyChar == '+' || e.KeyChar == '¿' || e.KeyChar == '/' || e.KeyChar == '*' || e.KeyChar == '?' || e.KeyChar == '=' || e.KeyChar == ')'
           || e.KeyChar == '(' || e.KeyChar == '¡' || e.KeyChar == '-' || e.KeyChar == ',')
            {
                e.Handled = true;
                MessageBox.Show("No se acepatan caracteres");
            }

        }

        public double ConvertM()
        {

            if (cmbactual.SelectedIndex == 0)
            {
                double M = 1;
                return M;
            }
            else
            {
                if (cmbactual.SelectedIndex == 1)
                {
                    return 4;
                }
                else
                {
                    if (cmbactual.SelectedIndex == 2)
                    {
                        return 3;
                    }
                    else
                    {
                        if (cmbactual.SelectedIndex == 3)
                        {
                            return 12;
                        }
                        else
                        {
                            if (cmbactual.SelectedIndex == 4)
                            {
                                return 2;
                            }
                            else
                            {
                                if (cmbactual.SelectedIndex == 5)
                                {
                                    return 52;
                                }
                                else
                                {
                                    return -1;
                                }
                            }
                        }
                    }
                }
            }
        }
        public double ConvertM1()
        {

            if (cmbdespues.SelectedIndex == 0)
            {
                double M1 = 1;
                return M1;
            }
            else
            {
                if (cmbdespues.SelectedIndex == 1)
                {
                    return 4;
                }
                else
                {
                    if (cmbdespues.SelectedIndex == 2)
                    {
                        return 3;
                    }
                    else
                    {
                        if (cmbdespues.SelectedIndex == 3)
                        {
                            return 12;
                        }
                        else
                        {
                            if (cmbdespues.SelectedIndex == 4)
                            {
                                return 2;
                            }
                            else
                            {
                                if (cmbdespues.SelectedIndex == 5)
                                {
                                    return 52;
                                }
                                else
                                {
                                    return -1;
                                }
                            }
                        }
                    }
                }
            }
        }

        public double ConvertM2()
        {
            
            if (cmbnominal.SelectedIndex == 0)
            {
                double M2 = 1;
                return M2;
            }
            else
            {
                if (cmbnominal.SelectedIndex == 1)
                {
                    return 4;
                }
                else
                {
                    if (cmbnominal.SelectedIndex == 2)
                    {
                        return 3;
                    }
                    else
                    {
                        if (cmbnominal.SelectedIndex == 3)
                        {
                            return 12;
                        }
                        else
                        {
                            if (cmbnominal.SelectedIndex == 4)
                            {
                                return 2;
                            }
                            else
                            {
                                if (cmbnominal.SelectedIndex == 5)
                                {
                                    return 52;
                                }
                                else
                                {
                                    return -1;
                                }
                            }
                        }
                    }
                }
            }
        }


     

     

    

        public void Clean()
        {
            txtefectiva.Texts ="";
            txtefectivacontinua.Texts= "";
            txtxotranominal.Texts ="";
            txtnominal1.Texts = "";

            cmbactual.SelectedIndex = -1;
            cmbdespues.SelectedIndex = -1;
            cmbnominal.SelectedIndex = -1;
      
        }

      

        private void txtnominal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se pueden Letras");
            }
            else if (
          e.KeyChar == '+' || e.KeyChar == '¿' || e.KeyChar == '/' || e.KeyChar == '*' || e.KeyChar == '?' || e.KeyChar == '=' || e.KeyChar == ')'
          || e.KeyChar == '(' || e.KeyChar == '¡' || e.KeyChar == '-' || e.KeyChar == ',')
            {
                e.Handled = true;
                MessageBox.Show("No se acepatan caracteres");
            }
        }

        private void txtxotranominal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se pueden Letras");
            }
            else if (
           e.KeyChar == '+' || e.KeyChar == '¿' || e.KeyChar == '/' || e.KeyChar == '*' || e.KeyChar == '?' || e.KeyChar == '=' || e.KeyChar == ')'
           || e.KeyChar == '(' || e.KeyChar == '¡' || e.KeyChar == '-' || e.KeyChar == ',')
            {
                e.Handled = true;
                MessageBox.Show("No se acepatan caracteres");
            }
        }

        private void cmbTime_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label12.Text);
        }

        private void label16_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label16.Text);
        }

        private void lblrespuesta_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblrespuesta.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label2.Text);
        }

        private void PbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnnominal_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtnominal1.Texts))
            {
                MessageBox.Show("Tienes que rellenar todos los formularios.");
                return;
            }
            if (double.Parse(txtnominal1.Texts) <= 0)
            {
                MessageBox.Show("Los Datos No puede ser Negativos  y Tampoco Puden ser cero");
                return;
            }
            double M = ConvertM2();
            label12.Text = Math.Round(nominalServices.ConvertEfectiva(double.Parse(txtnominal1.Texts), M),2).ToString()+"% "+cmbnominal.SelectedItem.ToString();
            Clean();
        }


        private void btnotratasa_Click_1(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtxotranominal.Texts))
            {
                MessageBox.Show("Tienes que rellenar todos los formularios.");
                return;
            }
            if (double.Parse(txtxotranominal.Texts) <= 0)
            {
                MessageBox.Show("Los Datos No puede ser Negativos  y Tampoco Puden ser cero");
                return;
            }
            double m1 = ConvertM();
            double m2 = ConvertM1();
            label16.Text = Math.Round(nominalServices.ConvetNominal(double.Parse(txtxotranominal.Texts), m1, m2),2).ToString()+"% "+cmbdespues.SelectedItem.ToString();
            Clean();
        }

        private void btnefectiva_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtefectiva.Texts))
            {
                MessageBox.Show("Tienes que rellenar todos los formularios.");
                return;
            }
            if (double.Parse(txtefectiva.Texts) <= 0)
            {
                MessageBox.Show("Los Datos No puede ser Negativos  y Tampoco Puden ser cero");
                return;
            }
            lblrespuesta.Text = Math.Round(nominalServices.ConvertExponencial(double.Parse(txtefectiva.Text)),2).ToString()+" %";
            if (string.IsNullOrEmpty(txtefectiva.Texts))
            {
                MessageBox.Show("Tienes que rellenar todos los formularios.");
                return;
            }
            if (double.Parse(txtefectiva.Texts) <= 0)
            {
                MessageBox.Show("Los Datos No puede ser Negativos  y Tampoco Puden ser cero");
                return;

            }
            Clean();
        }

        private void bntcontefec_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtefectivacontinua.Texts))
            {
                MessageBox.Show("Tienes que rellenar todos los formularios.");
                return;
            }
            if (double.Parse(txtefectivacontinua.Texts) <= 0)
            {
                MessageBox.Show("Los Datos No puede ser Negativos  y Tampoco Puden ser cero");
                return;
            }
            label2.Text = Math.Round(nominalServices.EfectivaContinua(double.Parse(txtefectivacontinua.Text)),2).ToString()+"%";
            Clean();
        }

        private void pbClipBoardNominal_Click(object sender, EventArgs e)
        {
            label12_Click(null, null);
        }

        private void pbClipBoardNominalCapitalizable_Click(object sender, EventArgs e)
        {
            label16_Click(null, null);
        }

        private void pbClipBoardEfectiva_Click(object sender, EventArgs e)
        {
            lblrespuesta_Click(null, null);
        }

        private void pbClipBoardNominalEfectiva_Click(object sender, EventArgs e)
        {
            label2_Click(null, null);
        }
    }
}
