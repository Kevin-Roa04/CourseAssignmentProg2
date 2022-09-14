using Appcore.Interface;
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

namespace Proto1._0
{
    public partial class MenuInteres : Form
    {

        ISimpleService sim;
        ICompuestoService com;
        IConvertService con;
        public FormCreateProject FormCreateProject; 
        public MenuInteres()
        {
            InitializeComponent();
        }
        public MenuInteres(ISimpleService sim, ICompuestoService com, IConvertService con)
        {
            this.com = com;
            this.con = con;
            this.sim = sim;
            InitializeComponent();

        }
        // Accion hacia interes simple
        private void button1_Click(object sender, EventArgs e)
        {
         
            CalculateIntSimple x = new CalculateIntSimple(sim, com, con);
            x.Show();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }
       
        //Accion hacia interes compuesto

        private void button2_Click_1(object sender, EventArgs e)
        {
            
            CalculateIntCompuesto x = new CalculateIntCompuesto(sim, com, con);
            x.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
          
            ConverterTasa x = new ConverterTasa(sim, com, con);
            x.Show();
        }

        
        // Accion hacia el convertidor 

    }
}
