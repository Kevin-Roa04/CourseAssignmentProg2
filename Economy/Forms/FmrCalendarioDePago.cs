using Economy.AppCore.Helper;
using Economy.AppCore.IServices;
using Economy.Domain.Entities;
using Economy.Domain.Entities.DTO;
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
    public partial class FmrCalendarioDePago : Form
    {
        public IAmorizacionService amorizacionService { get; set; }
        private Project project;

        public IAmortizacionServices amortizacionServices;
        int years;
        public bool BringingDataFromDB = false;
        DataGridView dgvFNE;
        public FmrCalendarioDePago(IAmortizacionServices services, int years, DataGridView dgvFNE, Project project)
        {
            InitializeComponent();
            this.amortizacionServices = services;
            this.cmelegir.DropDownStyle = ComboBoxStyle.DropDownList;
            this.years = years;
            this.dgvFNE = dgvFNE;
            this.project = project; 
        }


        #region -> FormBorder
        //private int borderRadius = 10;

        //private GraphicsPath GetCustomPanelPath(RectangleF rectangle, float radius)
        //{
        //    float curveSize = radius * 2F;
        //    GraphicsPath graphicsPath = new GraphicsPath();
        //    graphicsPath.StartFigure();
        //    graphicsPath.AddArc((rectangle.Width - curveSize), rectangle.Height - curveSize, curveSize, curveSize, 0, 90);
        //    graphicsPath.AddArc(rectangle.X, (rectangle.Height - curveSize), curveSize, curveSize, 90, 90);
        //    graphicsPath.AddArc(rectangle.X, rectangle.Y, curveSize, curveSize, 180, 90);
        //    graphicsPath.AddArc((rectangle.Width - curveSize), rectangle.Y, curveSize, curveSize, 270, 90);
        //    graphicsPath.CloseFigure();
        //    return graphicsPath;
        //}
        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    base.OnPaint(e);

        //    RectangleF rectangleF = new RectangleF(0, 0, this.Width, this.Height);

        //    if (borderRadius > 2)
        //    {
        //        using (GraphicsPath graphicsPath = GetCustomPanelPath(rectangleF, borderRadius))
        //        using (Pen pen = new Pen(this.BackColor, 2))
        //        {
        //            this.Region = new Region(graphicsPath);
        //            e.Graphics.DrawPath(pen, graphicsPath);
        //        }

        //    }
        //    else this.Region = new Region(rectangleF);

        //}

        #endregion

        #region -> form movement

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cmelegir.SelectedIndex == 0)
            {
                if (string.IsNullOrEmpty(txtinters.Text) || string.IsNullOrEmpty(txtknversion.Text) || string.IsNullOrEmpty(txtplazo.Text))
                {
                    MessageBox.Show("Tienes que rellenar todos los formularios.");
                    return;
                }
                if (double.Parse(txtinters.Text) <= 0
                    || double.Parse(txtknversion.Text) <= 0
                    || double.Parse(txtplazo.Text) <= 0)
                {
                    MessageBox.Show("Los Datos No puede ser Negativos  y Tampoco Puden ser cero");
                    return;
                }
                FillDGV(cmelegir.SelectedIndex);
            }
            else if(cmelegir.SelectedIndex == -1)
            {
                MessageBox.Show("You must fill the type of amortization", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (cmelegir.SelectedIndex == 1)
                {
                    if (string.IsNullOrEmpty(txtinters.Text) || string.IsNullOrEmpty(txtknversion.Text) || string.IsNullOrEmpty(txtplazo.Text))
                    {
                        MessageBox.Show("Tienes que rellenar todos los formularios.");
                        return;
                    }
                    if (double.Parse(txtinters.Text) <= 0
                        || double.Parse(txtknversion.Text) <= 0
                        || double.Parse(txtplazo.Text) <= 0)
                    {
                        MessageBox.Show("Los Datos No puede ser Negativos  y Tampoco Puden ser cero");
                        return;
                    }
                    FillDGV(cmelegir.SelectedIndex);
                }
            }

            //extrayendo datos para FNE
            InterestData();
            if (years == 0) return; // si es diferente de 0 , es parte del FNE
            setInterest();
            setPrestamo();
            setAmortizacionDelPrestamo();
            setInersionesTotales();
            SaveTasaInstitucionFinanciera();
            if(amorizacionService.GetByProjectId(project.Id) == null)
            {
                amorizacionService.Create(new Amortizacion
                {
                    TasaPrestamo = decimal.Parse(txtinters.Text),
                    ValorInversion = decimal.Parse(txtknversion.Text),
                    Plazo = int.Parse(txtplazo.Text),
                    TipoAmortizacion = (short)cmelegir.SelectedIndex,
                    ProjectId = project.Id
                });
            }
            else
            {
                amorizacionService.Update(new Amortizacion
                {
                    TasaPrestamo = decimal.Parse(txtinters.Text),
                    ValorInversion = decimal.Parse(txtknversion.Text),
                    Plazo = int.Parse(txtplazo.Text),
                    TipoAmortizacion = (short)cmelegir.SelectedIndex,
                    ProjectId = project.Id
                });
            }
        }

        private void SaveTasaInstitucionFinanciera()
        {
            FNEData.TasaInstitucionFinanciera = float.Parse(txtinters.Text) / 100;
        }

        private void setInterest()
        {
            for (int i = 0; i < years; i++)
            {
                if (FNEData.Interest == null)
                {
                    dgvFNE.Rows[2].Cells[i + 2].Value = (decimal)0;
                    continue;
                };
                decimal[] array = FNEData.Interest.ToArray();
                if (array == null) return;
                dgvFNE.Rows[2].Cells[i + 2].Value = array[i];
            }
        }
        private void setPrestamo()
        {
            dgvFNE.Rows[9].Cells[1].Value = (decimal)FNEData.Prestamo;
        }
        private void setAmortizacionDelPrestamo()
        {
            for (int i = 0; i < years; i++)
            {
                if (FNEData.Amortization == null)
                {
                    dgvFNE.Rows[10].Cells[i + 2].Value = (decimal)0;
                    continue;
                };
                decimal[] array = FNEData.Amortization.ToArray();
                if (array == null) return;
                dgvFNE.Rows[10].Cells[i + 2].Value = array[i];
            }
        }
        private void setInersionesTotales()
        {
            dgvFNE.Rows[11].Cells[1].Value = (decimal)FNEData.Inversion;
        }

        private void InterestData()
        {
            FNEData.Prestamo = decimal.Parse(txtknversion.Text);
            List<decimal> interest = new List<decimal>();
            List<decimal> amortization = new List<decimal>();
            for(int i=0; i<years; i++)
            {
                interest.Add(decimal.Parse(dgvAmortization.Rows[i+1].Cells[2].Value.ToString()));
                amortization.Add(decimal.Parse(dgvAmortization.Rows[i + 1].Cells[1].Value.ToString()));
            }
            FNEData.Interest = interest;
            FNEData.Amortization = amortization;
        }

        private void FmrCalendarioDePago_Load(object sender, EventArgs e)
        {
            if(years > 2)
            {
                txtplazo.Text = years.ToString();
                txtplazo.Enabled = false;
            }
            if(cmelegir.DataSource == null ) cmelegir.DataSource = Enum.GetValues(typeof(TypeAmortization));
            //cmelegir.SelectedIndex = -1;
            grpocaculos.Visible = true;
            //dgvAmortization.Visible = false;
            if (BringingDataFromDB)
            {
                Amortizacion amortizacion = amorizacionService.GetByProjectId(project.Id);
                if (amortizacion == null)
                {
                    BringingDataFromDB = false;
                    this.Close();
                    return;
                }

                cmelegir.SelectedIndex = (int)amortizacion.TipoAmortizacion;
                txtknversion.Text = Math.Round(amortizacion.ValorInversion, 2).ToString();
                txtinters.Text = Math.Round(amortizacion.TasaPrestamo, 2).ToString();
                txtplazo.Text = amortizacion.Plazo.ToString(); 

                FillDGV(cmelegir.SelectedIndex);
                //extrayendo datos para FNE
                InterestData();
                if (years == 0) return; // si es diferente de 0 , es parte del FNE
                setInterest();
                setPrestamo();
                setAmortizacionDelPrestamo();
                setInersionesTotales();
                SaveTasaInstitucionFinanciera();
                BringingDataFromDB = false;
                this.Close();
            }
        }
        private void FillDGV(int index)
        {
            dgvAmortization.Rows.Clear();
            dgvAmortization.Visible = true;
            Amortizacion amo = new Amortizacion()
            {
                TasaPrestamo = Convert.ToDecimal(txtinters.Text),
                ValorInversion = Convert.ToDecimal(txtknversion.Text),
                Plazo = Convert.ToInt32(txtplazo.Text),
            };
            double saldo = Convert.ToDouble(txtknversion.Text);
            AmortizationDTO amortizationDTO = new AmortizationDTO();
            for (int i = 0; i <= Convert.ToDouble(txtplazo.Text); i++)
            {
                if(i == 0)
                {
                    this.dgvAmortization.Rows.Add(0, 0, 0, 0, Convert.ToDouble(txtknversion.Text));
                    continue;
                }
                else
                {
                    if (index == 0)
                    {
                        amortizationDTO =  amortizacionServices.Metodo1(amo, saldo);
                        this.dgvAmortization.Rows.Add(i, Math.Round(amortizationDTO.Credit_memo, 2), Math.Round(amortizationDTO.interest, 2), Math.Round(amortizationDTO.payment, 2), Math.Round(amortizationDTO.outstanding_balance, 2));
                    }
                    else if (index == 1)
                    {
                        amortizationDTO = amortizacionServices.Metodo2(amo, saldo);
                        this.dgvAmortization.Rows.Add(i, Math.Round(amortizationDTO.Credit_memo, 2), Math.Round(amortizationDTO.interest, 2), Math.Round(amortizationDTO.payment, 2), Math.Round(amortizationDTO.outstanding_balance, 2));
                    }
                }
                saldo = amortizationDTO.outstanding_balance;
            }
        }

        private void PbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FmrCalendarioDePago_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
