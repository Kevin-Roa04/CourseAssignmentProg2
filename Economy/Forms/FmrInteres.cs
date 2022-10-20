﻿
using Economy.AppCore.IServices;
using Economy.Domain.Enums;
using Economy.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InteresPratica
{
    public partial class FmrInteres : Form
    {
        public INominalServices nominalServices ;

        #region -> FormShadow

        private const int CS_DropShadow = 0x00020000;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DropShadow;
                return cp;
            }
        }
        #endregion
        public FmrInteres(INominalServices services)
        {
            
            InitializeComponent();
            this.cmbcapital.Items.AddRange(Enum.GetValues(typeof(Producto)).Cast<object>().ToArray());
            this.nominalServices = services;
            this.cmbmostrasr.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbcapital.DropDownStyle = ComboBoxStyle.DropDownList;
            txtfuturo.KeyPress+=new KeyPressEventHandler(txtfuturo_KeyPress);
            txtinteres.KeyPress += new KeyPressEventHandler(txtinteres_KeyPress);
            txtpresente.KeyPress += new KeyPressEventHandler(txtfuturo_KeyPress);
            txtxaños.KeyPress += new KeyPressEventHandler(txtinteres_KeyPress);
            button1.Click += new EventHandler(button1_Click);
            cmbmostrasr.OnSelectedIndexChanged += new EventHandler(cmbmostrasr_SelectedIndexChanged);
            groupBox1.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        public double  ConvertM()
        {

            if (cmbcapital.SelectedIndex == 0)
            {
                double M = 1;
                return M;
            }
            else
            {
                if (cmbcapital.SelectedIndex == 1)
                {
                    return 4;
                }
                else
                {
                    if (cmbcapital.SelectedIndex == 2)
                    {
                        return 3;
                    }
                    else
                    {
                        if (cmbcapital.SelectedIndex == 3)
                        {
                            return 12;
                        }
                        else
                        {
                            if (cmbcapital.SelectedIndex == 4)
                            {
                                return 2;
                            }
                            else
                            {
                                if (cmbcapital.SelectedIndex == 5)
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

        private void button1_Click(object sender, EventArgs e)
        {
            
            double m = ConvertM();
            if (cmbmostrasr.SelectedIndex == 0)
            {
                if (string.IsNullOrEmpty(txtpresente.Texts) || string.IsNullOrEmpty(txtinteres.Texts) || string.IsNullOrEmpty(txtxaños.Texts))
                {
                    MessageBox.Show("Tienes que rellenar todos los formularios.");
                    return;
                }
                if (double.Parse(txtpresente.Text) <= 0
                    || double.Parse(txtinteres.Text) <= 0
                    || double.Parse(txtxaños.Text) <= 0)
                {
                    MessageBox.Show("Los Datos No puede ser Negativos  y Tampoco Puden ser cero");
                    return;
                }
                label1.Text = nominalServices.Getfuturo(double.Parse(txtinteres.Texts), m, double.Parse(txtpresente.Texts), double.Parse(txtxaños.Texts)).ToString();
            }
            else
            {
                if(cmbmostrasr.SelectedIndex == 1)
                {

                    if (string.IsNullOrEmpty(txtfuturo.Texts) || string.IsNullOrEmpty(txtinteres.Texts) || string.IsNullOrEmpty(txtxaños.Texts))
                    {
                        MessageBox.Show("Tienes que rellenar todos los formularios.");
                        return;
                    }
                    if (double.Parse(txtfuturo.Texts) <= 0
                        || double.Parse(txtinteres.Texts) <= 0
                        || double.Parse(txtxaños.Texts) <= 0)
                    {
                        MessageBox.Show("Los Datos No puede ser Negativos  y Tampoco Puden ser cero");
                        return;
                    }

                    label1.Text = nominalServices.GetPresente(double.Parse(txtinteres.Texts), m, double.Parse(txtfuturo.Texts), double.Parse(txtxaños.Texts)).ToString();
                }
                else
                {
                    if(cmbmostrasr.SelectedIndex == 2)
                    {

                        if (string.IsNullOrEmpty(txtpresente.Text) || string.IsNullOrEmpty(txtinteres.Text) || string.IsNullOrEmpty(txtpresente.Text))
                        {
                            MessageBox.Show("Tienes que rellenar todos los formularios.");
                            return;
                        }
                        if (double.Parse(txtfuturo.Text) <= 0
                            || double.Parse(txtinteres.Text) <= 0
                            || double.Parse(txtpresente.Text) <= 0)
                        {
                            MessageBox.Show("Los Datos No puede ser negativos  y tampoco Pueden ser cero");
                            return;
                        }

                        label1.Text = nominalServices.GeTPeriodo(double.Parse(txtinteres.Text), m, double.Parse(txtpresente.Text), double.Parse(txtfuturo.Text)).ToString();
                    }
                }
            }
            Clean();
            
            
          
        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show(" No se pueden Letras");
            }
            else if (
           e.KeyChar == '+' || e.KeyChar == '¿' || e.KeyChar == '/' || e.KeyChar == '*' || e.KeyChar == '?' || e.KeyChar == '=' || e.KeyChar == ')'
           || e.KeyChar == '(' || e.KeyChar == '¡' || e.KeyChar == '-' || e.KeyChar == ',')
            {
                e.Handled = true;
                MessageBox.Show("No se acepatan caracteres");
            }

        }

    

        private void label13_Click(object sender, EventArgs e)
        {

        }

 

        private void cmbmostrasr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbmostrasr.SelectedIndex == 0)
            {
                 txtfuturo.Visible = false;
                lblfuturo.Visible = false;
                llbpresente.Visible = true;
                txtpresente.Visible = true;
                lblaños.Visible = true;
                txtxaños.Visible = true;
                groupBox1.Visible = true;

            }
            else
            {
                if(cmbmostrasr.SelectedIndex == 1)
                {
                    txtpresente.Visible = false;
                    llbpresente.Visible = false;
                    lblfuturo.Visible = true;
                    txtfuturo.Visible = true;
                    lblaños.Visible = true;
                    txtxaños.Visible = true;
                    groupBox1.Visible = true;
                }
                else
                {
                    if(cmbmostrasr.SelectedIndex == 2)
                    {
                        groupBox1.Visible = true;
                        txtxaños.Visible = false;
                        lblaños.Visible = false;
                        txtfuturo.Visible = true;
                        lblfuturo.Visible = true;
                        llbpresente.Visible = true;
                        txtpresente.Visible = true;

                    }
                    else
                    {
                        if(cmbmostrasr.SelectedIndex == 3)
                        {
                            groupBox1.Visible = false;
                            FmrConvertidor fmr = new FmrConvertidor(nominalServices);
                            fmr.ShowDialog();

                        }
                    }
                }
            }
        }

        private void Clean()
        {
            txtfuturo.Texts ="";
            txtinteres.Texts = "";
            txtpresente.Texts = "";
            txtxaños.Texts = "";
            cmbcapital.SelectedIndex =- 1;
        }

        private void txtfuturo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtinteres_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtxaños_KeyPress(object sender, KeyPressEventArgs e)
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

        private void FmrInteres_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label1.Text);
        }

        private void cmbmostrasr_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #region -> form movement

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion


        private void FmrInteres_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
