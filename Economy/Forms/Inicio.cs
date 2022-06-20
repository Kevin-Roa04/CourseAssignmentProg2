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
    public partial class Inicio : Form
    {

        ISimpleService sim;
        ICompuestoService com;
        IConvertService con;
        IDepreciationService dep;
        public FormCreateProject FormCreateProject; 
        public Inicio()
        {
            InitializeComponent();
        }
        public Inicio(ISimpleService sim, ICompuestoService com, IConvertService con, IDepreciationService dep)
        {
            this.dep = dep;
            this.com = com;
            this.con = con;
            this.sim = sim;
            InitializeComponent();
            this.dep = dep;

        }
        int x;

        private void button1_Click(object sender, EventArgs e)
        {
            CalculateInt x = new CalculateInt(sim, com, con);
            x.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Depreciacion x = new Depreciacion(dep);
            x.Show();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }
    }
}
