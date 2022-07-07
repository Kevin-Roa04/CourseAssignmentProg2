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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Economy.Forms
{
    public partial class FormAddCosts : Form
    {
        int years;
        int type;
        int profitNumber = 0;
        public FormAddCosts(int years)
        {
            InitializeComponent();
            this.years = years;
            LoadDGV(years);
        }

        private void LoadDGV(int columns)
        {
            for (int i = 0; i < columns + 2; i++)
            {
                if (i == 0)
                {
                    dgvProfit.Columns.Add("", "");
                    continue;
                }
                dgvProfit.Columns.Add((i - 1).ToString(), (i - 1).ToString());
            }
            for (int i = 0; i < 20; i++)
            {
                dgvProfit.Rows.Add();
            }
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            label4.Text = "Amount to grow";
            numericUpDown1.Enabled = true;
            type = 1;
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Maximum = 100000000;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label4.Text = "Growth Rate %";
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

        private void rjButton1_Click(object sender, EventArgs e)
        {
            decimal montoAcumulado = txtAmount.Value;
            dgvProfit.Rows[profitNumber].Cells[0].Value = txtProfitName.Text;
            for (int i = 0; i < years; i++)
            {
                if (type == 0)
                {
                    dgvProfit.Rows[profitNumber].Cells[i + 2].Value = txtAmount.Value;
                }
                else if (type == 1)
                {
                    dgvProfit.Rows[profitNumber].Cells[i + 2].Value = montoAcumulado;
                    montoAcumulado = montoAcumulado + numericUpDown1.Value;
                }
                else if (type == 2)
                {
                    dgvProfit.Rows[profitNumber].Cells[i + 2].Value = montoAcumulado;
                    montoAcumulado = montoAcumulado + ((montoAcumulado * numericUpDown1.Value) / 100);
                }
            }

            profitNumber += 1;
            TotalProfits();
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
    }
}
