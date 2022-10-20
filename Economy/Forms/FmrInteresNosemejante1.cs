﻿using Economy.AppCore.IServices;
using Economy.AppCore.Services.InterestsServices;
using Economy.Domain.Enums;
using Economy.Domain.Enums.Interesnosemejante;
using InteresPratica;
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

namespace Economy.Forms
{
    public partial class FmrInteresNosemejante1 : Form
    {

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
        public INominalServices interestServices;
        public FmrInteresNosemejante1(INominalServices services)
        {
            InitializeComponent();
            this.interestServices = services;
            this.cmbanual.Items.AddRange(Enum.GetValues(typeof(Anual)).Cast<object>().ToArray());
            this.cmbcapital.Items.AddRange(Enum.GetValues(typeof(Producto)).Cast<object>().ToArray());
            this.cmbsemestral.Items.AddRange(Enum.GetValues(typeof(Semestre)).Cast<object>().ToArray());
            this.cmbtrismtral.Items.AddRange(Enum.GetValues(typeof(Trismestre)).Cast<object>().ToArray());
            this.cmbcuatrimestal.Items.AddRange(Enum.GetValues(typeof(Cuatrimestre)).Cast<object>().ToArray());
            this.cmbperiodo.Items.AddRange(Enum.GetValues(typeof(periodo)).Cast<object>().ToArray());
            groupBox1.Visible = false;
            cmbtrismtral.Visible = false;
            cmbsemestral.Visible = false;
            cmbanual.Visible = false;
            cmbcuatrimestal.Visible = false;
            this.cmbcapital.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbanual.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbcuatrimestal.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbmostrasr.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbcuatrimestal.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbperiodo.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbsemestral.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbtrismtral.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbperiodo.OnSelectedIndexChanged += new EventHandler(cmbperiodo_SelectedIndexChanged);
            txtfuturo.KeyPress+=new KeyPressEventHandler(txtfuturo_KeyPress);
            txtinteres.KeyPress+=new KeyPressEventHandler(txtinteres_KeyPress);
            txtpresente.KeyPress += new KeyPressEventHandler(txtpresente_KeyPress);
            txtxaños.KeyPress += new KeyPressEventHandler(txtxaños_KeyPress);
            
        }
        public decimal tiempo;
        public decimal CoTrimestral()
        {

            if (cmbtrismtral.SelectedIndex == 0)
            {

                return (decimal)(1 / 0.25); /*años*/
            }
            else
            {
                if (cmbtrismtral.SelectedIndex == 1)
                {

                    return (decimal)(1 / 0.5); /*semestres*/
                }
                else
                {
                    if (cmbtrismtral.SelectedIndex == 2)
                    {

                        return (decimal)(0.3333333333); /*meses*/
                    }
                    else
                    {
                        if (cmbtrismtral.SelectedIndex == 3)
                        {

                            return (decimal)(1 / 0.75); /*cuatrimestres*/
                        }
                        else
                        {
                            if (cmbtrismtral.SelectedIndex == 4)
                            {

                                return (decimal)(1 / 13.035714285714286); /*semanas*/
                            }
                            else
                            {

                                if (cmbtrismtral.SelectedIndex == 5)
                                {

                                    return (decimal)(1 / 91.25);/* dias*/
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

        public double ConvertM()
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

        public decimal semestral()
        {
            if (cmbsemestral.SelectedIndex == 0)
            {

                return (decimal)(1 / 0.5); /*años*/
            }
            else
            {
                if (cmbsemestral.SelectedIndex == 1)
                {

                    return (decimal)(1 / 1.5); /*cuatrimestres*/
                }
                else
                {
                    if (cmbsemestral.SelectedIndex == 2)
                    {

                        return Convert.ToDecimal((1 * 1.00) / (2 * 1.00));/*trimestres*/
                    }
                    else
                    {
                        if (cmbsemestral.SelectedIndex == 3)
                        {

                            return Convert.ToDecimal((1 * 1.00) / (6 * 1.00));/*meses*/
                        }
                        else
                        {
                            if (cmbsemestral.SelectedIndex == 4)
                            {

                                return (decimal)(1 / 26.071428571428573); /*semanas*/
                            }
                            else
                            {

                                if (cmbsemestral.SelectedIndex == 5)
                                {

                                    return (decimal)(1 / 182.5);/* dias*/
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

        public decimal cuatrimestral()
        {
            if (cmbcuatrimestal.SelectedIndex == 0)
            {

                return (decimal)(1 / 0.3333333333333333); /*años*/
            }
            else
            {
                if (cmbcuatrimestal.SelectedIndex == 1)
                {

                    return (decimal)(1 / 0.6666666666666666); /*semestres*/
                }
                else
                {
                    if (cmbcuatrimestal.SelectedIndex == 2)
                    {

                        return (decimal)(1 / 1.3333333333333333); /*trimestres*/
                    }
                    else
                    {
                        if (cmbcuatrimestal.SelectedIndex == 3)
                        {

                            return Convert.ToDecimal((1 * 1.00) / (4 * 1.00)); /*meses*/
                        }
                        else
                        {
                            if (cmbcuatrimestal.SelectedIndex == 4)
                            {

                                return (decimal)(1 / 17.38095238095238); /*semanas*/
                            }
                            else
                            {

                                if (cmbcuatrimestal.SelectedIndex == 5)
                                {

                                    return (decimal)(1 / 121.66666666666667);/* dias*/
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


        public decimal anual()
        {
            if (cmbanual.SelectedIndex == 0)
            {

                return Convert.ToDecimal((1 * 1.00) / (2 * 1.00)); /*semestres*/
            }
            else
            {
                if (cmbanual.SelectedIndex == 1)
                {

                    return Convert.ToDecimal((1 * 1.00) / (4 * 1.00)); /*trismestres*/
                }
                else
                {
                    if (cmbanual.SelectedIndex == 2)
                    {

                        return Convert.ToDecimal((1 * 1.00) / (3 * 1.00)); /*cuatrimestres*/
                    }
                    else
                    {
                        if (cmbanual.SelectedIndex == 3)
                        {

                            return Convert.ToDecimal((1 * 1.00) / (12 * 1.00)); /*Mensual*/
                        }
                        else
                        {
                            if (cmbanual.SelectedIndex == 4)
                            {

                                return Convert.ToDecimal((1 * 1.00) / (52 * 1.00)); /*semanas*/
                            }
                            else
                            {

                                if (cmbanual.SelectedIndex == 5)
                                {

                                    return Convert.ToDecimal((1 * 1.00) / (365 * 1.00));/* dias*/
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

        public void validar()
        {
            if (cmbtrismtral.SelectedIndex == -1 && cmbsemestral.SelectedIndex == -1 && cmbanual.SelectedIndex == -1)
            {
                tiempo = cuatrimestral();
            }
            else if (cmbcuatrimestal.SelectedIndex == -1 && cmbanual.SelectedIndex == -1 && cmbtrismtral.SelectedIndex == -1)
            {
                tiempo = semestral();
            }
            if (cmbsemestral.SelectedIndex == -1 && cmbcuatrimestal.SelectedIndex == -1 && cmbanual.SelectedIndex == -1)
            {
                tiempo = CoTrimestral();
            }
            else if (cmbcuatrimestal.SelectedIndex == -1 && cmbsemestral.SelectedIndex == -1 && cmbtrismtral.SelectedIndex == -1)
            {
                tiempo = anual();
            }
        }


        private void Clean()
        {
            txtfuturo.Texts ="";
            txtinteres.Texts ="";
            txtpresente.Texts = "";
            txtxaños.Texts = "";
            cmbtrismtral.SelectedIndex = -1;
            cmbcuatrimestal.SelectedIndex = -1;
            cmbperiodo.SelectedIndex = -1;
            cmbsemestral.SelectedIndex = -1;
            cmbanual.SelectedIndex = -1;
            cmbcapital.SelectedIndex = -1;


        }



        private void txtfuturo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("NO SE PUEDEN LETRAS");
            }
            else if (
           e.KeyChar == '+' || e.KeyChar == '¿' || e.KeyChar == '/' || e.KeyChar == '*' || e.KeyChar == '?' || e.KeyChar == '=' || e.KeyChar == ')'
           || e.KeyChar == '(' || e.KeyChar == '¡' || e.KeyChar == '-' || e.KeyChar == ',')
            {
                e.Handled = true;
                MessageBox.Show("No se acepatan caracteres");
            }

        }

        private void txtpresente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("NO SE PUEDEN LETRAS");
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
                MessageBox.Show("NO SE PUEDEN LETRAS");
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
                MessageBox.Show("NO SE PUEDEN LETRAS");
            }
            else if (
            e.KeyChar == '+' || e.KeyChar == '¿' || e.KeyChar == '/' || e.KeyChar == '*' || e.KeyChar == '?' || e.KeyChar == '=' || e.KeyChar == ')'
            || e.KeyChar == '(' || e.KeyChar == '¡' || e.KeyChar == '-' || e.KeyChar == ',')
            {
                e.Handled = true;
                MessageBox.Show("No se acepatan caracteres");
            }
        }

        private void cmbperiodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbperiodo.SelectedIndex == 0)
            {
                cmbtrismtral.Visible = false;
                cmbcuatrimestal.Visible = false;
                cmbsemestral.Visible = true;
                cmbanual.Visible = false;
            }
            else
            {
                if (cmbperiodo.SelectedIndex == 1)
                {
                    cmbtrismtral.Visible = false;
                    cmbsemestral.Visible = false;
                    cmbanual.Visible = false;
                    cmbcuatrimestal.Visible = true;
                }
                else
                {
                    if (cmbperiodo.SelectedIndex == 2)
                    {
                        cmbsemestral.Visible = false;
                        cmbtrismtral.Visible = true;
                        cmbanual.Visible = false;
                        cmbcuatrimestal.Visible = false;
                    }
                    else if (cmbperiodo.SelectedIndex == 3)
                    {
                        cmbtrismtral.Visible = false;
                        cmbsemestral.Visible = false;
                        cmbanual.Visible = true;
                        cmbcuatrimestal.Visible = false;
                    }
                }
            }
        }

        private void llbcapital_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label1.Text);
        }

        private void cmbmostrasr_OnSelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbmostrasr.SelectedIndex == 0)
            {
                txtfuturo.Visible = false;
                lblfuturo.Visible = false;
                llbpresente.Visible = true;
                txtpresente.Visible = true;
                lblaños.Visible = true;
                txtxaños.Visible = true;
                groupBox1.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                cmbanual.Visible = false;
                cmbcuatrimestal.Visible = false;
                cmbperiodo.Visible = true;
                cmbsemestral.Visible = false;
                cmbtrismtral.Visible = false;

            }
            else
            {
                if (cmbmostrasr.SelectedIndex == 1)
                {
                    txtpresente.Visible = false;
                    llbpresente.Visible = false;
                    lblfuturo.Visible = true;
                    txtfuturo.Visible = true;
                    lblaños.Visible = true;
                    txtxaños.Visible = true;
                    groupBox1.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    cmbanual.Visible = false;
                    cmbcuatrimestal.Visible = false;
                    cmbperiodo.Visible = true;
                    cmbsemestral.Visible = false;
                    cmbtrismtral.Visible = false;
                }
                else
                {
                    if (cmbmostrasr.SelectedIndex == 2)
                    {
                        groupBox1.Visible = true;
                        txtxaños.Visible = false;
                        lblaños.Visible = false;
                        txtfuturo.Visible = true;
                        lblfuturo.Visible = true;
                        llbpresente.Visible = true;
                        txtpresente.Visible = true;
                        label4.Visible = false;
                        label5.Visible = false;
                        cmbanual.Visible = false;
                        cmbcuatrimestal.Visible = false;
                        cmbperiodo.Visible = false;
                        cmbsemestral.Visible = false;
                        cmbtrismtral.Visible = false;
                    }
                   
                }
            }

        }

        private void PbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region -> form movement

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion
      

        private void FmrInteresNosemejante1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnacepatar_Click_1(object sender, EventArgs e)
        {
            double M = ConvertM();
            validar();

            if (cmbmostrasr.SelectedIndex == 0)
            {
                if (string.IsNullOrEmpty(txtpresente.Texts) || string.IsNullOrEmpty(txtinteres.Texts) || string.IsNullOrEmpty(txtxaños.Texts))
                {
                    MessageBox.Show("Tienes que rellenar todos los formularios.");
                    return;
                }
                if (double.Parse(txtpresente.Texts) <= 0
                    || double.Parse(txtinteres.Texts) <= 0
                    || double.Parse(txtxaños.Texts) <= 0)
                {
                    MessageBox.Show("Los Datos No puede ser Negativos  y Tampoco Puden ser cero");
                    return;
                }
                label1.Text = interestServices.GetfutuonoSemejante(double.Parse(txtinteres.Texts), M, double.Parse(txtxaños.Texts), double.Parse(txtpresente.Texts), decimal.ToDouble(tiempo)).ToString();
            }
            else
            {
                if (cmbmostrasr.SelectedIndex == 1)
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

                    label1.Text = interestServices.getPresentenosemejante(double.Parse(txtinteres.Texts), M, double.Parse(txtxaños.Texts), double.Parse(txtfuturo.Texts), decimal.ToDouble(tiempo)).ToString();
                }
                else
                {
                    if (cmbmostrasr.SelectedIndex == 2)
                    {

                        if (string.IsNullOrEmpty(txtpresente.Texts) || string.IsNullOrEmpty(txtinteres.Texts) || string.IsNullOrEmpty(txtpresente.Texts))
                        {
                            MessageBox.Show("Tienes que rellenar todos los formularios.");
                            return;
                        }
                        if (double.Parse(txtfuturo.Texts) <= 0
                            || double.Parse(txtinteres.Texts) <= 0
                            || double.Parse(txtpresente.Texts) <= 0)
                        {
                            MessageBox.Show("Los Datos No puede ser Negativos  y Tampoco Puden ser cero");
                            return;
                        }

                        label1.Text = interestServices.GeTPeriodo(double.Parse(txtinteres.Texts), M, double.Parse(txtpresente.Texts), double.Parse(txtfuturo.Texts)).ToString();
                        string v = Convert.ToString(double.Parse(txtinteres.Texts));
                        label4.Text = v;
                    }
                }
            }
            Clean();

        }
    }
}
