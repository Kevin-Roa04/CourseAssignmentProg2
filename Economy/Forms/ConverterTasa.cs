using Appcore.Interface;
using Dominio.Enum;
using Proto1._0;
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
    public partial class ConverterTasa : Form
    {
        ISimpleService sim;
        ICompuestoService com;
        IConvertService con;


        public ConverterTasa(ISimpleService Simp, ICompuestoService Com, IConvertService Con)
        {
            this.sim = Simp;
            this.com = Com;
            this.con = Con;
            InitializeComponent();
        }


        private int CalculateM()
        {

            if (cmbTiempo.SelectedIndex == 0)
            {
                int m = 52;
                return m;
            }
            else
            {
                if (cmbTiempo.SelectedIndex == 1)
                {
                    return 12;
                }
                else
                {
                    if (cmbTiempo.SelectedIndex == 2)
                    {
                        return 6;
                    }
                    else
                    {
                        if (cmbTiempo.SelectedIndex == 3)
                        {
                            return 4;
                        }
                        else
                        {
                            if (cmbTiempo.SelectedIndex == 4)
                            {
                                return 3;
                            }
                            else
                            {
                                if (cmbTiempo.SelectedIndex == 5)
                                {
                                    return 2;
                                }
                                else
                                {
                                    return 1;
                                }
                            }
                        }
                    }
                }

            }

        }

        private void button11_Click_1(object sender, EventArgs e)
        {

            if (numconvert.Value == 0)
            {
                MessageBox.Show("La tasa no puede ser 0");
            }
            else
            {
                int m = CalculateM();
                decimal i = numconvert.Value;

                decimal IP = con.ConvertNominalToPeriodicEfective(i, m);
                Result1.Text = $"Ip = {IP * 100}";
            }

        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            if (numconvert.Value == 0)
            {
                MessageBox.Show("La tasa no puede ser 0");
            }
            else
            {
                int m = CalculateM();
                decimal i = numconvert.Value;

                decimal J = con.ConvertPeriodicEfectiveToNominal(i, m);
                Result2.Text = $"J = {J * 100}";
            }
        }

        private void button12_Click_1(object sender, EventArgs e)
        {

            if (numconvert.Value == 0)
            {
                MessageBox.Show("La tasa no puede ser 0");
            }
            else
            {
                int m = CalculateM();
                decimal i = numconvert.Value;

                decimal I = con.ConvertNomialToEfective(i, m);
                Result3.Text = $"I = {I * 100}";
            }

        }

        private void ConverterTasa_Load(object sender, EventArgs e)
        {
            cmbTiempo.Items.AddRange(Enum.GetValues(typeof(PeriodTime)).Cast<object>().ToArray());
            cmbTiempo.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("rellene las casillas con los datos obtenidos y " +
                "deje en 0 la casilla que desea encontrar, luego de click en el boton calcular del campo que dejo en 0 ");
        }
    }
}
