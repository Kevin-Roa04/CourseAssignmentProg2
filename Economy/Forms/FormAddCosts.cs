using Economy.AppCore.Helper;
using Economy.AppCore.IServices;
using Economy.AppCore.Services;
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
    public partial class FormAddCosts : Form
    {
        public ICostService costService { get; set; }

        int years;
        int type;
        int profitNumber = 0;
        bool edit = false;
        public bool BringingDataFromDB = false;
        string NombreAnterior;
        DataGridView dgvFNE;
        Project project;
        public FormAddCosts(Project project, int years, DataGridView dgvFNE)
        {
            InitializeComponent();
            this.years = years;
            LoadDGV(years);
            this.dgvFNE = dgvFNE;
            this.project = project;
        }


        #region -> form movement

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

        private void LoadDGV(int columns)
        {
            for (int i = 0; i < columns + 2; i++)
            {
                if (i == 0)
                {
                    dgvProfit.Columns.Add("", "NombreCosto");
                    continue;
                }
                dgvProfit.Columns.Add((i - 1).ToString(), (i - 1).ToString());
            }
            for (int i = 0; i < 20; i++)
            {
                dgvProfit.Rows.Add();
            }
        }
        private void BringingDBData()
        {
            List<Cost> costs = costService.GetListByProjectId(project.Id);
            foreach (Cost cost in costs)
            {
                txtProfitName.Text = cost.Nombre;
                txtAmount.Value = cost.ValorInicial;
                if (cost.TipoIncremento == 0) radioButton1.Checked = true;
                else if (cost.TipoIncremento == 1) radioButton2.Checked = true;
                else if (cost.TipoIncremento == 2) radioButton3.Checked = true;
                numericUpDown1.Value = cost.ValorIncremento;

                NewCost(profitNumber); // nueva ganancia
                profitNumber += 1;
                TotalProfits(); // calculando el total de las ganancias
                //SetIngresos();
                ResetValues(); // reseteando el valor de los campos
            }
            BringingDataFromDB = false;
            this.Close();
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
            if (txtAmount.Value == 0)
            {
                MessageBox.Show("Digite un valor valido en el campo \"monto\"");
                return false;
            }
            if (radioButton2.Checked || radioButton3.Checked)
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
            if (!IsValidated())
            {
                return;
            }

            if (edit)
            {
                Cost cost = costService.GetByName(NombreAnterior, project.Id);
                costService.Update(new Cost
                {
                    Id = cost.Id,
                    Nombre = txtProfitName.Text,
                    ValorInicial = decimal.Parse(txtAmount.Text),
                    TipoIncremento = (short)this.type,
                    ValorIncremento = (decimal)numericUpDown1.Value,
                    ProjectId = project.Id,
                });

                NewCost(dgvProfit.CurrentRow.Index); // editando un Costo

                TotalProfits(); // calculando el total de los Costos
                SetCostos();
                ResetValues(); // reseteando el valor de los campos
                edit = false;
                return;
            }

            foreach (Cost cost in costService.GetListByProjectId(project.Id))
            {
                if (cost.Nombre == txtProfitName.Text)
                {
                    MessageBox.Show("No se puede ingresar un nombre repetido.");
                    return;
                }
            }

            costService.Create(new Cost
            {
                Nombre = txtProfitName.Text,
                ValorInicial = decimal.Parse(txtAmount.Text),
                TipoIncremento = (short)this.type,
                ValorIncremento = (decimal)numericUpDown1.Value,
                ProjectId = project.Id,
            });

            NewCost(profitNumber);

            profitNumber += 1;
            TotalProfits();// calculando el total de los Costos
            SetCostos();
            ResetValues();// reseteando el valor de los campos
        }

        private void NewCost(int row)
        {
            decimal montoAcumulado = txtAmount.Value;
            dgvProfit.Rows[row].Cells[0].Value = txtProfitName.Text;
            for (int i = 0; i < years; i++)
            {
                if (type == 0)
                {
                    dgvProfit.Rows[row].Cells[i + 2].Value = Math.Round(txtAmount.Value,2);
                }
                else if (type == 1)
                {
                    dgvProfit.Rows[row].Cells[i + 2].Value = Math.Round(montoAcumulado,2);
                    montoAcumulado = montoAcumulado + numericUpDown1.Value;
                }
                else if (type == 2)
                {
                    dgvProfit.Rows[row].Cells[i + 2].Value = Math.Round(montoAcumulado,2);
                    montoAcumulado = montoAcumulado + ((montoAcumulado * numericUpDown1.Value) / 100);
                }
            }
        }

        private void SetCostos()
        {
            for (int i = 0; i < years; i++)
            {
                if (FNEData.Cost == null || FNEData.Cost.Count == 0)
                {
                    dgvFNE.Rows[1].Cells[i + 2].Value = (decimal)0;
                    continue;
                };
                decimal[] array = FNEData.Cost.ToArray();
                if (array == null) return;
                dgvFNE.Rows[1].Cells[i + 2].Value = array[i];
            }
        }

        private void TotalProfits()
        {
            decimal montoAcumulado;
            dgvProfit.Rows[profitNumber].Cells[0].Value = "Total";
            for (int i = 0; i < years; i++) // cells
            {
                montoAcumulado = (decimal)dgvProfit.Rows[0].Cells[i + 2].Value;
                for (int j = 0; j <= profitNumber - 1; j++) // rows
                {
                    dgvProfit.Rows[profitNumber].Cells[i + 2].Value = montoAcumulado;
                    if (j == profitNumber - 1) continue;
                    montoAcumulado += (decimal)dgvProfit.Rows[j + 1].Cells[i + 2].Value;
                }
            }

            // enviando los datos a FormFNE
            decimal[] array = new decimal[years];
            for (int i = 0; i < years; i++)
            {
                array[i] = (decimal)dgvProfit.Rows[profitNumber].Cells[i + 2].Value;
            }
            FNEData.Cost = array.ToList();
        }

        private void PbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void FormAddCosts_MouseDown(object sender, MouseEventArgs e)
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

        private void txtAmount_KeyUp(object sender, KeyEventArgs e)
        {
            ValidateNegativeNumber(e, 0, txtAmount);
        }

        private void numericUpDown1_KeyUp(object sender, KeyEventArgs e)
        {
            ValidateNegativeNumber(e, 0, numericUpDown1);
        }

        private void editarToolStripMenuItem1_Click(object sender, EventArgs e)
        {// Editar
            Cost cost= costService.GetByName(getNombre(), project.Id);
            txtProfitName.Text = cost.Nombre;
            //txtProfitName.Text = dgvProfit.CurrentRow.Cells[0].Value.ToString();
            txtAmount.Value = cost.ValorInicial;
            //txtAmount.Value = decimal.Parse(dgvProfit.CurrentRow.Cells[2].Value.ToString());
            //txtAmount.UpButton();
            //txtAmount.DownButton();
            //radioButton1.Checked = true;
            if (cost.TipoIncremento == 0) radioButton1.Checked = true;
            else if (cost.TipoIncremento == 1) radioButton2.Checked = true;
            else if (cost.TipoIncremento == 2) radioButton3.Checked = true;
            numericUpDown1.Value = cost.ValorIncremento;
            edit = true;
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {// Eliminar
            costService.Delete(new Cost
            {
                Nombre = getNombre(),
                ProjectId = project.Id
            });

            dgvProfit.Rows.RemoveAt(dgvProfit.CurrentRow.Index);
            profitNumber--;
            if (profitNumber == 0)
            {
                dgvProfit.Rows.RemoveAt(0);
                FNEData.Cost.Clear();
                SetCostos();
                return;
            }
            TotalProfits(); //calculando el total de las ganancias
            SetCostos();
        }

        private void dgvProfit_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) return;
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (profitNumber == 0) return;
            if (e.RowIndex >= profitNumber) return;

            dgvProfit.CurrentCell = dgvProfit.Rows[e.RowIndex].Cells[e.ColumnIndex];
            contextMenuStrip1.Show(Cursor.Position);
        }
        private string getNombre()
        {
            NombreAnterior = dgvProfit.Rows[dgvProfit.CurrentRow.Index].Cells[0].Value.ToString();
            return NombreAnterior;
        }

        private void FormAddCosts_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            if (BringingDataFromDB) BringingDBData();
        }
    }
}
