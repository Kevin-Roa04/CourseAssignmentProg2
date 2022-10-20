﻿using Economy.AppCore.IServices;
using Economy.AppCore.Singleton;
using Economy.Domain.Entities;
using iTextSharp.text;
using iTextSharp.text.pdf;
using org.mariuszgromada.math.mxparser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
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
        private string fileName;
        public Project project;
        private const int CS_DropShadow = 0x00020000;
        private bool first;
        private int? RowsExpression;
        private int? ColumnsExpression;
        private string cadena;

        #region Form shadow
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DropShadow;
                return cp;
            }
        }
#endregion
        public FormExcel(ICalculateServices<Annuity> calculateServices, ICalculateServices<Interest> calculateServices1,
            ICalculateServices<Serie> calculateServiceSerie, string fileName)
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
            this.fileName = fileName;
            this.lblName.Text += $" {fileName}";
            first = true;
            RowsExpression = null;
            ColumnsExpression = null;
        }

        private void FormExcel_Load(object sender, EventArgs e)
        {
            for (char c = 'A'; c <= 'Z'; c++)
            {
                Columns.Add(c.ToString());
            }
            AuxColumns = Columns.ToList();
            DirectoryInfo directory = new DirectoryInfo(Application.StartupPath + @"Excel");
            if (!directory.Exists)
            {
                Directory.CreateDirectory(Application.StartupPath + @"Excel");
                directory.Attributes = FileAttributes.Hidden;
            }
            int rows = 1;
            while (rows < 20)
            {
                dgvExcel.Rows.Add();
                rows++;
            }
            AddColummns();
            AddColummns();
            if (project != null)
            {
                ImportarExcel(Application.StartupPath + @"Excel" + $@"\{project.Name}");
            }
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
                        if (singleton.MinRow == singleton.MaxRow && first)
                        {
                            singleton.MinRow = row;
                        }
                        else
                        {
                            singleton.MaxRow = row;
                        }

                        if (singleton.MinColumn == singleton.MaxColumn && first)
                        {
                            singleton.MinColumn = column;
                            first = false;
                        }
                        else
                        {
                            singleton.MaxColumn = column;
                        }
                    }
                    return;
                }
                dgvExcel.EditMode = DataGridViewEditMode.EditOnEnter;
                GetRowAndColumn();
                if (RowsExpression != null && ColumnsExpression != null)
                {
                    if (!(row == RowsExpression && column == ColumnsExpression))
                    {
                        int Row = (int)RowsExpression;
                        int Column = (int)ColumnsExpression;
                        if (dgvExcel.Rows[Row].Cells[Column].Value != null && cadena != null)
                        {
                            try
                            {
                                double.Parse(cadena);
                                cadena = string.Empty;
                                RowsExpression = null;
                                ColumnsExpression = null;
                            }
                            catch
                            {
                                try
                                {
                                    double piv = double.Parse(dgvExcel.CurrentCell.Value.ToString());
                                    if (dgvExcel.Rows[Row].Cells[Column].Value.ToString().StartsWith("="))
                                    {
                                        dgvExcel.Rows[Row].Cells[Column].Value = cadena +
                                            dgvExcel.CurrentCell.Value;
                                        cellTextBox.Text = cadena + dgvExcel.CurrentCell.Value;
                                    }
                                }
                                catch
                                {
                                    if (dgvExcel.Rows[Row].Cells[Column].Value.ToString().StartsWith("="))
                                    {
                                        dgvExcel.Rows[Row].Cells[Column].Value = cadena;
                                        cellTextBox.Text = cadena;
                                    }
                                }
                            }
                        }
                    }
                }
                if (dgvExcel.Rows[Rows].Cells[ColumnsIndex].Value is null)
                {
                    btnFE.Visible = true;
                }
                else
                {
                    btnFE.Visible = false;
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
        private void AddColummns()
        {
            try
            {
                if (NumberOfColumns == 655)
                {
                    throw new ArgumentException("Ha llegado al límite de las columnas que se pueden crear");
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
                MessageBox.Show("Seleccione una celda vacía", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnFE.Visible = false;
                return;
            }
            singleton.MinRow = Rows;
            singleton.MinColumn = ColumnsIndex;
            ColumsnFunction = ColumnsIndex;
            RowsFunction = Rows;
            FormFX formsFX = new FormFX(this, calculateServicesAnnuity, CalculateServicesInterest, calculateServicesSerie);
            formsFX.Show();
            btnFE.Visible = false;
            dgvExcel.EditMode = DataGridViewEditMode.EditOnKeystroke;
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
                if (singleton.ValueFunctionList.Count > 0 && (singleton.Index != 10 && singleton.Index != 11 && singleton.Index != 12))
                {
                    int sumatoria = 0;
                    for (int j = singleton.MinColumn; j <= singleton.MaxColumn; j++)
                    {
                        if (singleton.MaxColumn - 1 == j)
                        {
                            AddColummns();
                        }
                        dgvExcel.Rows[RowsFunction].Cells[(ColumsnFunction + sumatoria)].Value = singleton.ValueFunctionList[sumatoria];
                        sumatoria++;
                    }
                    singleton.ValueFunctionList.Clear();
                    singleton.MaxColumn = 0;
                    singleton.MaxRow = 0;
                    singleton.MinRow = 0;
                    singleton.MinColumn = 0;
                    singleton.Selection = false;
                    singleton.Index = 0;
                    singleton.ValueFunction = 0;
                    singleton.ValueTask = 0;
                    return;
                }
                if (singleton.Index == 10)
                {
                    for (int j = singleton.MinColumn; j < (singleton.MaxColumn + singleton.MinColumn); j++)
                    {
                        if (dgvExcel.ColumnCount - 1 == j)
                        {
                            AddColummns();
                        }
                        dgvExcel.Rows[singleton.MinRow].Cells[j].Value = singleton.ValueFunction;
                    }
                    singleton.ValueFunctionList.Clear();
                    singleton.MaxColumn = 0;
                    singleton.MaxRow = 0;
                    singleton.MinRow = 0;
                    singleton.MinColumn = 0;
                    singleton.Selection = false;
                    singleton.Index = 0;
                    singleton.ValueFunction = 0;
                    singleton.ValueTask = 0;
                    return;
                }
                if (singleton.Index == 11 || singleton.Index == 12)
                {
                    int sumatoria = 0;
                    for (int j = singleton.MinColumn; j < (singleton.MinColumn + singleton.ValueFunctionList.Count); j++)
                    {
                        if (dgvExcel.ColumnCount - 1 == j)
                        {
                            AddColummns();
                        }
                        dgvExcel.Rows[singleton.MinRow].Cells[j].Value = singleton.ValueFunctionList[sumatoria];
                        sumatoria++;
                    }
                    singleton.ValueFunctionList.Clear();
                    singleton.MaxColumn = 0;
                    singleton.MaxRow = 0;
                    singleton.MinRow = 0;
                    singleton.MinColumn = 0;
                    singleton.Selection = false;
                    singleton.Index = 0;
                    singleton.ValueFunction = 0;
                    singleton.ValueTask = 0;
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
                            first = true;
                            singleton.Entry.Clear();
                            decimal ValueCell;
                            for (int i = singleton.MinRow; i <= singleton.MaxRow; i++)
                            {
                                for (int j = singleton.MinColumn; j <= singleton.MaxColumn; j++)
                                {
                                    ValueCell = decimal.Parse((string)dgvExcel.Rows[i].Cells[j].Value);
                                    singleton.Entry.Add(decimal.ToDouble(ValueCell));
                                }
                            }
                            existe.Activate();
                            return;
                        }
                        else
                        {
                            first = true;
                            singleton.Exit.Clear();
                            decimal ValueCell;
                            for (int i = singleton.MinRow; i <= singleton.MaxRow; i++)
                            {
                                for (int j = singleton.MinColumn; j <= singleton.MaxColumn; j++)
                                {

                                    ValueCell = decimal.Parse((string)dgvExcel.Rows[i].Cells[j].Value);
                                    singleton.Exit.Add(decimal.ToDouble(ValueCell));
                                }
                            }
                            existe.Activate();
                            return;
                        }
                    }
                    else
                    {
                        try
                        {
                            singleton.ValueTask = double.Parse(dgvExcel.CurrentCell.Value.ToString());
                            existe.Activate();
                        }
                        catch
                        {
                            singleton.ValueTask = 0;
                            existe.Activate();
                            MessageBox.Show("Ha seleccionado un dato inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Seleccione un dato válido para la operación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportarExcel(DataGridView data)
        {
            try
            {
                SaveFileDialog fichero = new SaveFileDialog();
                fichero.Filter = "Excel (*.xls)|*.xls";
                fichero.Title = "Seleccione la ruta en donde guardará el archivo";
                if (fichero.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application application;
                    Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                    Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                    application = new Microsoft.Office.Interop.Excel.Application();
                    libros_trabajo = application.Workbooks.Add();
                    hoja_trabajo = (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
                    for (int i = 0; i < data.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < data.Columns.Count; j++)
                        {
                            if (data.Rows[i].Cells[j].Value == null)
                            {
                                hoja_trabajo.Cells[i + 1, j + 1] = string.Empty;
                            }
                            else
                            {
                                hoja_trabajo.Cells[i + 1, j + 1] = data.Rows[i].Cells[j].Value.ToString();
                            }

                        }
                    }
                    libros_trabajo.SaveAs(fichero.FileName,
                    Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                    libros_trabajo.Close(true);
                    application.Quit();
                    MessageBox.Show("Información exportada correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ImportarExcel(string file)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook xlwoorkbook = xlapp.Workbooks.Open(file);
                Microsoft.Office.Interop.Excel.Worksheet xlworksheet = xlwoorkbook.Sheets[1];
                Microsoft.Office.Interop.Excel.Range xlrange = xlworksheet.UsedRange;

                int row = dgvExcel.Rows.Count;

                for (int xlrow = 1; xlrow <= xlrange.Rows.Count; xlrow++)
                {
                    if (row - 1 == xlrow)
                    {
                        dgvExcel.Rows.Add();
                    }
                    for (int xlcolumn = 1; xlcolumn <= xlrange.Columns.Count; xlcolumn++)
                    {
                        if ((NumberOfColumns - 1) == xlcolumn)
                        {
                            AddColummns();
                        }
                        dgvExcel.Rows[xlrow - 1].Cells[xlcolumn - 1].Value = Convert.ToString(xlrange.Cells[xlrow, xlcolumn].Value2);
                    }
                }
                xlwoorkbook.Close();
                xlapp.Quit();
                MessageBox.Show("Información importada correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Guardar(DataGridView data)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application application;
                Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                application = new Microsoft.Office.Interop.Excel.Application();
                libros_trabajo = application.Workbooks.Add();
                hoja_trabajo = (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
                for (int i = 0; i < data.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < data.Columns.Count; j++)
                    {
                        if (data.Rows[i].Cells[j].Value == null)
                        {
                            hoja_trabajo.Cells[i + 1, j + 1] = string.Empty;
                        }
                        else
                        {
                            hoja_trabajo.Cells[i + 1, j + 1] = data.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                }
                application.DisplayAlerts = false;

                libros_trabajo.SaveAs(Application.StartupPath + @"Excel" + $@"\{fileName}",
             Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                application.Quit();
                MessageBox.Show("Se ha guardado el archivo correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExportarPdf(DataGridView data)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF (*.pdf)|*.pdf";
            sfd.Title = "Seleccione la ruta en donde guardará el archivo";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    PdfPTable pdfTable = new PdfPTable(data.Columns.Count);
                    pdfTable.DefaultCell.Padding = 3;
                    pdfTable.WidthPercentage = 100;
                    pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                    foreach (DataGridViewColumn column in data.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                        pdfTable.AddCell(cell);
                    }

                    foreach (DataGridViewRow row in data.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if (cell.Value == null)
                            {
                                pdfTable.AddCell(string.Empty);
                            }
                            else
                            {
                                pdfTable.AddCell(cell.Value.ToString());
                            }
                        }
                    }

                    using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                    {
                        Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                        PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();
                        pdfDoc.Add(pdfTable);
                        pdfDoc.Close();
                        stream.Close();
                    }

                    MessageBox.Show("Información exportada satisfactoriamente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                }
            }
        }
        Panel p = new Panel();
        private void btnFX_MouseEnter(object sender, EventArgs e)
        {
            Button btn = new Button();
            //pnBotones.Controls.Add(p);
            p.BackColor = Color.FromArgb(0, 180, 185);
            p.Size = new Size(190, 3);
            p.Location = new Point(btn.Location.X + 392, btn.Location.Y + 35);

        }

        private void btnFX_MouseLeave(object sender, EventArgs e)
        {
           // pnBotones.Controls.Remove(p);
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Guardar(dgvExcel);
        }

        private void aExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportarExcel(dgvExcel);
        }

        private void pDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportarPdf(dgvExcel);
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Excel (*xlsx) | *.xlsx; *.xls;";
                ofd.Title = "Escoge el archivo excel";
                if (ofd.ShowDialog() == DialogResult.OK)
                    fileName = ofd.FileName;
            }
            ImportarExcel(fileName);
        }

        private void PbClose_Click(object sender, EventArgs e)
        {
            bool value = false;
            for(int i = 0; i < dgvExcel.RowCount; i ++)
            { 
                if(!value)
                {
                    for (int j = 0; j < dgvExcel.ColumnCount; j++)
                    {
                        if (dgvExcel.Rows[i].Cells[j].Value != null)
                        {
                            if (dgvExcel.Rows[i].Cells[j].Value.ToString() != string.Empty)
                            {
                                value = true;
                                break;
                            }
                        }
                    }
                }
                else
                {
                    break;
                }
            }
            if (value)
            {
                DialogResult result = MessageBox.Show("¿Desea guardar los datos ingresados?", "Información",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Guardar(dgvExcel);
                }
            }
            this.Close();
        }

        private void FadeIn_Tick(object sender, EventArgs e)
        {
            if (this.Opacity >= 1)
            {
                FadeIn.Stop();
            }
            this.Opacity += .2;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void FormExcel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        DataGridViewTextBoxEditingControl cellTextBox = new DataGridViewTextBoxEditingControl();
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            try
            {
                if (keyData == Keys.Enter)
                {
                    if (cellTextBox.Text.ToString().StartsWith("="))
                    {
                        Expression expression = new Expression(cellTextBox.Text.ToString().Substring(1));
                        //dgvExcel.Rows[dgvExcel.CurrentCell.RowIndex].Cells[dgvExcel.CurrentCell.ColumnIndex].Value
                        cellTextBox.Text = expression.calculate().ToString();
                        if (cellTextBox.Text == "NaN")
                        {
                            MessageBox.Show("Error en la fórmula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            cellTextBox.Text = "=" + expression.getExpressionString();
                            return base.ProcessCmdKey(ref msg, keyData);
                        }
                            cadena = dgvExcel.CurrentCell.Value.ToString();
                    }
                }
                return base.ProcessCmdKey(ref msg, keyData);
            }
            catch
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }
        private void dgvExcel_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            cellTextBox = e.Control as DataGridViewTextBoxEditingControl;
          }

        private void dgvExcel_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (cellTextBox != null)
            {
                if (cellTextBox.Text.ToString().StartsWith("="))
                {
                    try
                    {
                        if (cadena == string.Empty)
                        {
                            throw new ArgumentException();
                        }
                        double.Parse(cadena);
                    }
                    catch
                    {
                        cadena = cellTextBox.Text.ToString();
                        RowsExpression = dgvExcel.CurrentCell.RowIndex;
                        ColumnsExpression = dgvExcel.CurrentCell.ColumnIndex;
                    }
                }
            }
        }

        private void dgvExcel_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                if (!(dgvExcel.CurrentCell.Value is null))
                {
                    if (dgvExcel.CurrentCell.Value.ToString() != string.Empty)
                    {
                        SendKeys.Send("{Right}");
                    }
                }
            }
            catch
            {

            }
        }

        private void dgvExcel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (RowsExpression != null && ColumnsExpression != null)
            {
                int Row = (int)RowsExpression;
                int Column = (int)ColumnsExpression;
                DataGridViewCell cell = dgvExcel.Rows[Row].Cells[Column];
                if (!(cell.Value is null))
                {
                    if (cell.Value.ToString() != string.Empty && cadena.ToString().StartsWith("="))
                    {
                        dgvExcel.CurrentCell = cell;
                        dgvExcel.BeginEdit(true);
                    }
                }
            }
        }
    }
}
