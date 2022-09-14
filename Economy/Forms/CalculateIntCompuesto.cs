using Appcore.Interface;
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
    public partial class CalculateIntCompuesto : Form
    {
        ISimpleService sim;
        ICompuestoService com;
        IConvertService con;


        public CalculateIntCompuesto(ISimpleService Simp, ICompuestoService Com, IConvertService Con)
        {
            this.sim = Simp;
            this.com = Com;
            this.con = Con;
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            double f = (double)numfut.Value;
            decimal i = (decimal)(numint.Value);
            int n = (int)numpe.Value;
            if (f == 0 || n == 0 || i == 0)
            {
                MessageBox.Show("Llene las casillas correctamente(Futuro, Interes, Periodo). No pueden ser 0");
            }
            else
            {
                double x = com.CalñculateVP(f, n, i);
                R5.Text = $"Respuesta = {x}C$";
            }

        }
        // futuro
        private void button8_Click_1(object sender, EventArgs e)
        {
            double p = (double)numpre.Value;
            decimal i = (decimal)(numint.Value);
            int n = (int)numpe.Value;
            if (p == 0 || n == 0 || i == 0)
            {
                MessageBox.Show("Llene las casillas correctamente(Presente, Interes, Periodo). No pueden ser 0");
            }
            else
            {
                double x = com.CalculateVF(p, n, i);
                R6.Text = $"Respuesta = {x}C$";
            }

        }
        //interes
        private void button6_Click_1(object sender, EventArgs e)
        {
            double p = (double)numpre.Value;
            double f = (double)(numfut.Value);
            int n = (int)numpe.Value;
            if (p == 0 || n == 0 || f == 0)
            {
                MessageBox.Show("Llene las casillas correctamente(Presente, Futuro, Periodo). No pueden ser 0");
            }
            else
            {

                decimal x = com.CalculateInteres(f, n, p);
                R7.Text = $"Respuesta = {(x * 100)}%";
            }
        }
        //periodo
        private void button7_Click_1(object sender, EventArgs e)
        {
            double p = (double)(numpre.Value);
            double f = (double)(numfut.Value);
            decimal i = (decimal)(numint.Value);
            if (p == 0 || i == 0 || f == 0)
            {
                MessageBox.Show("Llene las casillas correctamente(Presente, Futuro, Interes). No pueden ser 0" +
                    "");
            }
            else
            {
                decimal x = com.CalculatePeriodo(f, p, i);
                R8.Text = $"Respuesta redondeada= {(x)}";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Seleccione el el tiempo del periodo, " +
                "llene la casilla Tasa inicial y luego de click en cualquier boton que desee calcular  ");
        }
    }
}
