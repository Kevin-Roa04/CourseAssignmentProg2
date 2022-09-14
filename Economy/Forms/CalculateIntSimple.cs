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
    public partial class CalculateIntSimple : Form
    {
        ISimpleService sim;
        ICompuestoService com;
        IConvertService con;


        public CalculateIntSimple(ISimpleService Simp, ICompuestoService Com, IConvertService Con)
        {
            this.sim = Simp;
            this.com = Com;
            this.con = Con;
            InitializeComponent();
        }
        //regresar
        private void button5_Click(object sender, EventArgs e)
        {
           this.Close();
           
        }
        // pressente
        private void button1_Click(object sender, EventArgs e)
        {
            double f = (double)numf.Value;
            int n = (int)numperiodo.Value;
            decimal i = (decimal)numinteres.Value;
            if (f == 0 || n == 0 || i == 0)
            {
                MessageBox.Show("Llene las casillas correctamente");
            }
            else
            {
                double x = sim.CalculateVP(f, n, i);
                R1.Text = $"Respuesta = {x}C$";
            }

        }
        //futuro
        private void button2_Click(object sender, EventArgs e)
        {
            double p = (double)nump.Value;
            decimal i = (decimal)numinteres.Value;
            int n = (int)numperiodo.Value;
            if (p == 0 || n == 0 || i == 0)
            {
                MessageBox.Show("Llene las casillas correctamente");
            }
            else
            {
                double x = sim.CalculateVF(p, n, i);
                R2.Text = $"Respuesta = {x}C$";
            }

        }
        //Interes
        private void button3_Click(object sender, EventArgs e)
        {
            double p = (double)nump.Value;
            double f = (double)numf.Value;
            int n = (int)numperiodo.Value;
            if (p == 0 || n == 0 || f == 0)
            {
                MessageBox.Show("Llene las casillas correctamente");
            }
            else
            {
                decimal x = sim.CalculateInteres(f, n, p);
                R3.Text = $"Respuesta = {(x) * 100}%";
            }


        }

        //Periodo
        private void button4_Click(object sender, EventArgs e)
        {
            double p = (double)nump.Value;
            double f = (double)numf.Value;
            decimal i = (decimal)numinteres.Value;
            if (p == 0 || i == 0 || f == 0)
            {
                MessageBox.Show("Llene las casillas correctamente");
            }
            else
            {
                int x = sim.CalculatePeriodo(f, p, i);
                R4.Text = $"Respuesta = {x}";
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("rellene las casillas con los datos obtenidos y " +
                "deje en 0 la casilla que desea encontrar, luego de click en el boton calcular del campo que dejo en 0 ");
        }
    }
}
