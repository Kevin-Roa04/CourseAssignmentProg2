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
        ICalculateServices<Serie> calculateServicesSerie;
        private int Rows;
        private int ColumnsIndex;
        private int RowsFunction;
        private int ColumsnFunction;
        private Singleton singleton;
        
        public FormExcel(ICalculateServices<Annuity> calculateServices, ICalculateServices<Interest> calculateServices1,
            ICalculateServices<Serie> calculateServiceSerie)
        {
            InitializeComponent();
            Columns = new List<string>();
            indexColumns = 8;
            index = 0;
            AuxColumns = new List<string>();
            NumberOfColumns = 8;
            this.calculateServicesAnnuity = calculateServices;
            this.CalculateServicesInterest = calculateServices1;
            this.calculateServicesSerie = calculateServiceSerie;
            Rows = 0;
            ColumnsIndex = 0;
            singleton = Singleton.instance1;
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
                if (dgvExcel.CurrentRow == null)
                    return;

                int column = dgvExcel.CurrentCell.ColumnIndex;
                int row = dgvExcel.CurrentCell.RowIndex;
                int lastrow = dgvExcel.Rows.Count - 1;
                int lastColumn = dgvExcel.Columns.Count - 1;
                Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "FormFunction").SingleOrDefault<Form>();
                if (existe != null)
                {
                    if (singleton.Selection)
                    {
                        if (singleton.MinRow == singleton.MaxRow)
                        {
                            singleton.MinRow = row;
                        }
                        else
                        {
                            singleton.MaxRow = row;
                        }

                        if (singleton.MinColumn == 0 && singleton.MaxColumn == 0)
                        {
                            singleton.MinColumn = column;
                        }
                        else
                        {
                            singleton.MaxColumn = column;
                        }
                    }
                    return;
                }
                GetRowAndColumn();
                if (dgvExcel.Rows[Rows].Cells[ColumnsIndex].Value is null)
                {
                    btnFX.Visible = true;
                }
                else
                {
                    btnFX.Visible = false;
                }

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
            singleton.MinRow = dgvExcel.CurrentCell.RowIndex;
            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "FormFunction").SingleOrDefault<Form>();
            try
            {
                if (existe != null)
                {
                    if (!singleton.Selection)
                    {
                        GetRowAndColumn();
                        double ValueCell = double.Parse((string)dgvExcel.Rows[Rows].Cells[ColumnsIndex].Value);
                        if (dgvExcel.Rows[Rows].Cells[ColumnsIndex].Value is null)
                        {
                            throw new ArgumentException();
                        }
                        singleton.ValueTask = Double.Parse((string)dgvExcel.Rows[Rows].Cells[ColumnsIndex].Value);
                        existe.Activate();
                    }

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
            if (dgvExcel.Rows[Rows].Cells[ColumnsIndex].Value != null)
            {
                MessageBox.Show("Select an empty cell", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnFX.Visible = false;
                return;
            }
            singleton.MinRow = Rows;
            singleton.MinColumn = ColumnsIndex;
            ColumsnFunction = ColumnsIndex;
            RowsFunction = Rows;
            FormFX formsFX = new FormFX(this, calculateServicesAnnuity, CalculateServicesInterest, calculateServicesSerie);
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
            if (singleton.Selection)
            {
                if (singleton.ValueFunctionList.Count > 0)
                {
                    if (dgvExcel.Columns.Count < (ColumsnFunction + singleton.MaxColumn))
                    {
                        MessageBox.Show("First you must create more columns before doing this operation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    int sumatoria = 0;
                    for (int j = singleton.MinColumn; j <= singleton.MaxColumn; j++)
                    {
                        dgvExcel.Rows[RowsFunction].Cells[(ColumsnFunction + sumatoria)].Value = singleton.ValueFunctionList[sumatoria];
                        sumatoria++;
                    }
                    singleton.ValueFunctionList.Clear();
                    singleton.MaxColumn = 0;
                    singleton.MaxRow = 0;
                    singleton.MinRow = 0;
                    singleton.MinColumn = 0;
                    singleton.Selection = false;
                    return;
                }
            }
            if (singleton.ValueFunction == 0)
            {
                return;
            }
            dgvExcel.Rows[RowsFunction].Cells[ColumsnFunction].Value = singleton.ValueFunction;
            singleton.ValueFunction = 0;
            singleton.ValueTask = 0;
            singleton.Index = 0;
        }

        private void dgvExcel_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "FormFunction").SingleOrDefault<Form>();
            try
            {
                if (existe != null)
                {
                    if (singleton.Selection)
                    {
                        if (singleton.Type)
                        {
                            singleton.Entry.Clear();
                            for (int i = singleton.MinRow; i <= singleton.MaxRow; i++)
                            {
                                for (int j = singleton.MinColumn; j <= singleton.MaxColumn; j++)
                                {
                                    singleton.Entry.Add(double.Parse(dgvExcel.Rows[i].Cells[j].Value.ToString()));
                                }
                            }
                            existe.Activate();
                            return;
                        }
                        else
                        {
                            singleton.Exit.Clear();
                            for (int i = singleton.MinRow; i <= singleton.MaxRow; i++)
                            {
                                for (int j = singleton.MinColumn; j <= singleton.MaxColumn; j++)
                                {
                                    singleton.Exit.Add(double.Parse((string)dgvExcel.Rows[i].Cells[j].Value));
                                }
                            }
                            existe.Activate();
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormExcel_Deactivate(object sender, EventArgs e)
        {
            this.Close();
           
        }
    }
}
