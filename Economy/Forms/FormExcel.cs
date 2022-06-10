using Economy.AppCore.IServices;
using Economy.AppCore.Singleton;
using Economy.Domain.Entities;
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
    public partial class FormExcel : Form
    {
        private List<string> Columns;
        private List<string> AuxColumns;
        private int indexColumns;
        private int index;
        private int NumberOfColumns;
        ICalculateServices<Annuity> calculateServicesAnnuity;
        ICalculateServices<Interest> CalculateServicesInterest;
        private int Rows;
        private int ColumnsIndex;
        public FormExcel(ICalculateServices<Annuity> calculateServices, ICalculateServices<Interest> calculateServices1)
        {
            InitializeComponent();
            Columns = new List<string>();
            indexColumns = 8;
            index = 0;
            AuxColumns = new List<string>();
            NumberOfColumns = 8;
            this.calculateServicesAnnuity = calculateServices;
            this.CalculateServicesInterest = calculateServices1;
            Rows = 0;
            ColumnsIndex = 0;
        }

        private void FormExcel_Load(object sender, EventArgs e)
        {
            for (char c = 'A'; c <= 'Z'; c++)
            {
                Columns.Add(c.ToString());
            }
            AuxColumns = Columns.ToList();
        }

        private void dgvExcel_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                GetRowAndColumn();
                if (dgvExcel.Rows[Rows].Cells[ColumnsIndex].Value is null)
                {
                    btnFX.Visible = true;
                }
                else
                {
                    btnFX.Visible = false;
                }

                if (dgvExcel.CurrentRow == null)
                    return;

                int column = dgvExcel.CurrentCell.ColumnIndex;
                int lastColumn = dgvExcel.Columns.Count - 1;

                if (column == lastColumn)
                {
                    AddColummns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvExcel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "FormFunction").SingleOrDefault<Form>();
            try
            {
                if (existe != null)
                {
                    GetRowAndColumn();
                    double ValueCell = double.Parse((string)dgvExcel.Rows[Rows].Cells[ColumnsIndex].Value);
                    if (dgvExcel.Rows[Rows].Cells[ColumnsIndex].Value is null)
                    {
                        throw new ArgumentException();
                    }
                    Singleton singleton = Singleton.instance1;
                    singleton.ValueTask = Double.Parse((string)dgvExcel.Rows[Rows].Cells[ColumnsIndex].Value);
                    existe.Activate();
                }
            }
            catch
            {
                MessageBox.Show("Please select a cell that contains a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                existe.BringToFront();
            }
        }
        private void AddColummns()
        {
            try
            {
                if (NumberOfColumns == 655)
                {
                    throw new ArgumentException("The number of allowed columns has been exceeded.");
                }
                string convertidor = null;
                if (indexColumns == 26)
                {
                    indexColumns = 0;
                    Columns.Clear();
                    for (char c = 'A'; c <= 'Z'; c++)
                    {
                        convertidor = c.ToString();
                        Columns.Add(($"{AuxColumns[index]}{convertidor}"));
                    }
                    dgvExcel.Columns.Add($"{Columns[indexColumns].ToString()}{dgvExcel.CurrentCell.RowIndex}", Columns[indexColumns].ToString());
                    indexColumns++;
                    index++;
                    NumberOfColumns++;
                    return;
                }
                dgvExcel.Columns.Add($"{Columns[indexColumns].ToString()}{dgvExcel.CurrentCell.RowIndex + 1}", Columns[indexColumns].ToString());
                indexColumns++;
                NumberOfColumns++;
            }
            catch
            {
                throw;
            }
        }

        private void buttonFX_Click(object sender, EventArgs e)
        {
            GetRowAndColumn();
            if(dgvExcel.Rows[Rows].Cells[ColumnsIndex].Value != null)
            {
                MessageBox.Show("Select an empty cell", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnFX.Visible = false;
                return;
            }
            Singleton singleton = Singleton.instance1;
            singleton.Row = Rows;
            singleton.Column = ColumnsIndex;
            FormFX formsFX = new FormFX(this, calculateServicesAnnuity, CalculateServicesInterest);
            formsFX.Show();
        }
        private void GetRowAndColumn()
        {
            int selectedCellCount = dgvExcel.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount == 1)
            {
                for (int i = 0;
                        i < selectedCellCount; i++)
                {
                    Rows = dgvExcel.SelectedCells[i].RowIndex;
                    ColumnsIndex = dgvExcel.SelectedCells[i].ColumnIndex;
                }
            }
        }

        private void FormExcel_Activated(object sender, EventArgs e)
        {
            Singleton singleton = Singleton.instance1;
            if (singleton.ValueFunction == 0)
            {
                return;
            }
            dgvExcel.Rows[singleton.Row].Cells[singleton.Column].Value = singleton.ValueFunction;
            singleton.ValueFunction = 0;
            singleton.ValueTask = 0;
            singleton.Index = 0;
        }
    }
}
