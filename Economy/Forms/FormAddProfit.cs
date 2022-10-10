using Economy.AppCore.Helper;
using Economy.AppCore.IServices;
using Economy.AppCore.Singleton;
using Economy.Domain.Entities;
using Economy.Domain.Enums;
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
    public partial class FormAddProfit : Form
    {
        int years;
        int type;
        int profitNumber = 0;
        bool edit = false;
        DataGridView dgvFNE;
        public FormAddProfit(int years, DataGridView dgvFNE)
        {
            InitializeComponent();
            this.years = years;
            LoadDGV(years);
            this.dgvFNE = dgvFNE;
        }

        private void LoadDGV(int columns)
        {
            for (int i = 0; i < columns + 2; i++)
            {
                if (i == 0)
                {
                    dgvProfit.Columns.Add("", "NombreGanancia");
                    continue;
                }
                dgvProfit.Columns.Add((i - 1).ToString(), (i - 1).ToString());
            }
            for(int i=0; i<20; i++)
            {
                dgvProfit.Rows.Add();
            }
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            label4.Text = "Monto Constante";
            numericUpDown1.Enabled = true;
            type = 1;
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Maximum = 100000000;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label4.Text = "Tasa de Crecimiento %";
            numericUpDown1.Enabled = true;
            type = 2;
            numericUpDown1.DecimalPlaces = 0;
            numericUpDown1.Maximum = 100;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label4.Text = "-------------";
            numericUpDown1.Value = 0;
            numericUpDown1.Enabled = false;
            type = 0;
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Maximum = 100000000;
        }

        private bool IsValidated()
        {
            // Validando que el nombre no vaya vacio
            if (txtProfitName.Text.Trim() == "")
            {
                MessageBox.Show("Escriba un nombre valido para la ganancia");
                return false;
            }
            if(txtAmount.Value == 0)
            {
                MessageBox.Show("Digite un valor valido en el campo \"monto\"");
                return false;
            }
            if(radioButton2.Checked || radioButton3.Checked)
            {
                if (numericUpDown1.Value == 0)
                {
                    MessageBox.Show("Ingrese un valor valido para los gradientes");
                    return false;
                }
            }
            return true;
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            // Validando que los datos no esten vacios
            if(!IsValidated()){
                return;
            }

            if (edit) 
            {
                NewProfit(dgvProfit.CurrentRow.Index); // editando una ganancia

                TotalProfits(); // calculando el total de las ganancias
                SetIngresos();
                ResetValues(); // reseteando el valor de los campos
                edit = false;
                return;
            }

            NewProfit(profitNumber); // nueva ganancia

            profitNumber += 1;
            TotalProfits(); // calculando el total de las ganancias
            SetIngresos();
            ResetValues(); // reseteando el valor de los campos
        }

        private void NewProfit(int row)
        {
            decimal montoAcumulado = txtAmount.Value;
            dgvProfit.Rows[row].Cells[0].Value = txtProfitName.Text;
            for (int i = 0; i < years; i++)
            {
                if (type == 0)
                {
                    dgvProfit.Rows[row].Cells[i + 2].Value = txtAmount.Value;
                }
                else if (type == 1)
                {
                    dgvProfit.Rows[row].Cells[i + 2].Value = montoAcumulado;
                    montoAcumulado = montoAcumulado + numericUpDown1.Value;
                }
                else if (type == 2)
                {
                    dgvProfit.Rows[row].Cells[i + 2].Value = montoAcumulado;
                    montoAcumulado = montoAcumulado + ((montoAcumulado * numericUpDown1.Value) / 100);
                }
            }
        }

        private void ResetValues()
        {
            txtProfitName.Text = "";
            txtAmount.Value = 0;
            txtAmount.UpButton();
            txtAmount.DownButton();
            numericUpDown1.Value = 0;
            numericUpDown1.UpButton();
            numericUpDown1.DownButton();
        }

        private void SetIngresos()
        {
            for (int i = 0; i < years; i++)
            {
                if (FNEData.Profit == null || FNEData.Profit.Count == 0)
                {
                    dgvFNE.Rows[0].Cells[i + 2].Value = (decimal)0;
                    continue;
                };
                decimal[] array = FNEData.Profit.ToArray();
                if (array == null) return;
                dgvFNE.Rows[0].Cells[i + 2].Value = array[i];
            }
        }

        private void TotalProfits()
        {
            decimal montoAcumulado;
            dgvProfit.Rows[profitNumber].Cells[0].Value = "Total";
            for(int i=0; i<years; i++) // cells
            {
                montoAcumulado = (decimal)dgvProfit.Rows[0].Cells[i + 2].Value;
                for (int j=0; j<=profitNumber-1; j++) // rows
                {
                    dgvProfit.Rows[profitNumber].Cells[i + 2].Value = montoAcumulado;
                    if (j == profitNumber-1) continue;
                    montoAcumulado += (decimal)dgvProfit.Rows[j + 1].Cells[i + 2].Value;
                }
            }

            // enviando los datos a FormFNE
            decimal[] array = new decimal[years];
            for (int i=0; i<years; i++)
            {
                array[i] = (decimal)dgvProfit.Rows[profitNumber].Cells[i + 2].Value;
            }
            FNEData.Profit = array.ToList();
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

        private void FormAddProfit_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ValidateNegativeNumber(KeyEventArgs e, decimal DefaultNum, NumericUpDown num)
        {
            if (e.KeyCode == Keys.Subtract)
            {
                MessageBox.Show("Ingrese un valor valido");
                num.ResetText();
                num.Value = DefaultNum;
                num.UpButton();
                num.DownButton();
                return;
            }
        }

        private void txtAmount_KeyUp(object sender, KeyEventArgs e)
        {
            ValidateNegativeNumber(e, 0, txtAmount);
        }

        private void numericUpDown1_KeyUp(object sender, KeyEventArgs e)
        {
            ValidateNegativeNumber(e, 0, numericUpDown1);
        }

        private void dgvProfit_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) return;
            if(e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (profitNumber == 0) return;
            if (e.RowIndex >= profitNumber) return;

            dgvProfit.CurrentCell = dgvProfit.Rows[e.RowIndex].Cells[e.ColumnIndex];
            contextMenuStrip1.Show(Cursor.Position);
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {// Eliminar
            dgvProfit.Rows.RemoveAt(dgvProfit.CurrentRow.Index);
            profitNumber--;
            if (profitNumber == 0) 
            { 
                dgvProfit.Rows.RemoveAt(0);
                FNEData.Profit.Clear();
                SetIngresos();
                return;
            }
            TotalProfits(); //calculando el total de las ganancias
            SetIngresos();

        }

        private void editarToolStripMenuItem1_Click(object sender, EventArgs e)
        {// Editar
            txtProfitName.Text = dgvProfit.CurrentRow.Cells[0].Value.ToString();
            txtAmount.Value = decimal.Parse(dgvProfit.CurrentRow.Cells[2].Value.ToString());
            txtAmount.UpButton();
            txtAmount.DownButton();
            radioButton1.Checked = true;
            edit = true;
        }
    }
}
