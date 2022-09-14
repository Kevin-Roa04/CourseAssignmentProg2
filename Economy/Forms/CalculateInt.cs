using Appcore.Interface;
using Dominio.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proto1._0
{
    public partial class CalculateInt : Form
    {
        ISimpleService sim;
        ICompuestoService com;
        IConvertService con;


        public CalculateInt(ISimpleService Simp, ICompuestoService Com, IConvertService Con)
        {
            this.sim = Simp;
            this.com = Com;
            this.con = Con;
            InitializeComponent();
        }



        #region Otros metodos y bottones

        private int CalculateM()
        { 
              
            if(cmbTiempo.SelectedIndex == 0) 
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
        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("para evitar errores al momento de calcular los interes rrellene las casillas correctas y deje en blanco las que no necesita", 
                "evite colocar numeros negativos o letras en las casillas numericas ");

        }
        private void label20_Click(object sender, EventArgs e)
        {
            Clean();
        }
        public void Clean()
        {
            //limpiar simple
            nump.Value = 0;
            numinteres.Value = 0;
            numf.Value = 0;
            numperiodo.Value = 0;
            R1.Text = "Respuesta = ";
            R2.Text = "Respuesta = ";
            R3.Text = "Respuesta = ";
            R4.Text = "Respuesta = ";

            //limpiar compuesto 
            numpre.Value = 0;
            numfut.Value = 0;
            numint.Value = 0;
            numpre.Value = 0;

            //Convert
            numconvert.Value = 0;
            Result1.Text = "Tasa final = ";
            Result2.Text = "Tasa final = ";
            Result3.Text = "Tasa final = ";


        }

        #endregion
        #region Simple
        //Presente
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

        //Futuro
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
                R3.Text = $"Respuesta = {(x)*100}%";
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

        #endregion
        #region Compuesto
        //Presente
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

        //Futuro
        private void button8_Click(object sender, EventArgs e)
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

        //Interes
        private void button6_Click(object sender, EventArgs e)
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
                R7.Text = $"Respuesta = {(x*100)}%";
            }
          
        }

        //Periodo
        private void button7_Click(object sender, EventArgs e)
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
                decimal x = com.CalculatePeriodo(f,p, i);
                R8.Text = $"Respuesta redondeada= {(x)}";
            }
           

        }
        #endregion
        #region Convert
        private void Form1_Load(object sender, EventArgs e)
        {
           
           
            cmbTiempo.Items.AddRange(Enum.GetValues(typeof(PeriodTime)).Cast<object>().ToArray());
            cmbTiempo.SelectedIndex = 0;
          
        }
        #region Converter

        private void button11_Click(object sender, EventArgs e)
        {
            if(numconvert.Value == 0)
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
        #endregion

        private void button10_Click(object sender, EventArgs e)
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
                Result2.Text = $"J = {J*100}";
            }

        }

        private void button12_Click(object sender, EventArgs e)
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
        #endregion
    }
}
