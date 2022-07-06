using Economy.AppCore.Helper;
using System;
using System.Windows.Forms;

namespace Economy.Forms
{
    public partial class FormFNE : Form
    {
        private FormAddProfit addProfit;
        public FormFNE()
        {
            InitializeComponent();
            addProfit = new FormAddProfit((int)txtYears.Value);
        }

        private void FormFNE_Load(object sender, EventArgs e)
        {
        }

        private void LoadDGV(int columns)
        {
            for (int i = 0; i < columns+2; i++)
            {
                if (i == 0)
                {
                    dgvFNE.Columns.Add("", "");
                    continue;
                }
                dgvFNE.Columns.Add((i - 1).ToString(), (i - 1).ToString());
            }
            for (int i = 0; i < 15; i++)
            {
                dgvFNE.Rows.Add();
            }
            dgvFNE.Rows[0].Cells[0].Value = "Ingresos";
            dgvFNE.Rows[1].Cells[0].Value = "Costos";
            dgvFNE.Rows[2].Cells[0].Value = "Intereses";
            dgvFNE.Rows[3].Cells[0].Value = "Depreciacion";
            dgvFNE.Rows[4].Cells[0].Value = "Utilidad antes de impuestos";
            dgvFNE.Rows[5].Cells[0].Value = "IR";
            dgvFNE.Rows[6].Cells[0].Value = "Utilidad despues de impuestos";
            dgvFNE.Rows[7].Cells[0].Value = "Depreciacion";
            dgvFNE.Rows[8].Cells[0].Value = "Valor de rescate";
            dgvFNE.Rows[9].Cells[0].Value = "Prestamo";
            dgvFNE.Rows[10].Cells[0].Value = "Amortizacion del prestamo";
            dgvFNE.Rows[11].Cells[0].Value = "Inversiones Totales";
            dgvFNE.Rows[12].Cells[0].Value = "FNE";
            SetIngresos();
        }

        private void rjButton5_Click(object sender, EventArgs e)
        {
            if(dgvFNE.Rows.Count > 0)
            {
                dgvFNE.Columns.Clear();
                dgvFNE.Rows.Clear();
            }
            LoadDGV((int)txtYears.Value);
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            addProfit.ShowDialog();
        }

        private void txtYears_ValueChanged(object sender, EventArgs e)
        {
            addProfit = new FormAddProfit((int)txtYears.Value);
        }

        private void SetIngresos()
        {
            for(int i=0; i<txtYears.Value; i++)
            {
                decimal[] array = FNEData.Profit.ToArray();
                if (array == null) return;
                dgvFNE.Rows[0].Cells[i + 2].Value = array[i];
            }
        }
    }
}
