using Appcore.Interface;
using Economy.AppCore.Helper;
using Economy.AppCore.IServices;
using Economy.Domain.Entities;
using Economy.Domain.Entities.DTO;
using Economy.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Proto1._0
{
    public partial class FrmDepreciacion : Form
    {
        #region -> FormShadow

        private const int CS_DropShadow = 0x00020000;

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
        public IDepreciacionService depreciationService { get; set; }
        private Project project;
        public bool flag = false;
        public bool tmp = false;

        IDepreciationService dep;
        int years;
        DataGridView dgvFNE;
        public FrmDepreciacion(IDepreciationService dep, int years, DataGridView dataGridView, Project project)
        {
            this.dep = dep;
            this.years = years;
            InitializeComponent();
            this.project = project;
            if (years > 0) // solo cuoando se ocupa en el FNE
            {
                nudYears.Value = years;
            }
            this.dgvFNE = dataGridView;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Validations())
            {
                FillDgv();
                if (years == 0) return; // si es diferente de 0, es parte del FNE
                ExtraerData();
                //colocando valores en la tabla FNE
                setDepreciation(3);
                setDepreciation(7);
                setInersionesTotales();
                setVR();
                //ingresando valores a la base de datos
                if (depreciationService.GetByProjectId(project.Id) == null)
                {
                    depreciationService.Create(new Depreciacion
                    {
                        TipoDepreciacion = (short)cmbMethod.SelectedIndex,
                        Valor = FNEData.Inversion,
                        ValorResidual = FNEData.ValorDeRescate,
                        ProjectId = project.Id,
                    });
                }
                else
                {
                    depreciationService.Update(new Depreciacion
                    {
                        TipoDepreciacion = (short)cmbMethod.SelectedIndex,
                        Valor = FNEData.Inversion,
                        ValorResidual = FNEData.ValorDeRescate,
                        ProjectId = project.Id,
                    });

                }
            }
        }
        private void setVR()
        {
            dgvFNE.Rows[8].Cells[years + 1].Value = (decimal)FNEData.ValorDeRescate;
        }

        private void ExtraerData()
        {
            //FNEData.Inversion = decimal.Parse(nudInitialValue.Text);
            FNEData.ValorDeRescate = decimal.Parse(nudResidualValue.Text);
            List<decimal> depreciacion = new List<decimal>();
            for (int i = 0; i < (int)nudYears.Value; i++)
            {
                depreciacion.Add(decimal.Parse(DgvDepreciation.Rows[i + 1].Cells[1].Value.ToString()));
            }
            FNEData.Depreciacion = depreciacion;
        }

        private void setDepreciation(int n)
        {
            for (int i = 0; i < years; i++)
            {
                if (FNEData.Depreciacion == null)
                {
                    dgvFNE.Rows[n].Cells[i + 2].Value = (decimal)0;
                    continue;
                };
                decimal[] array = FNEData.Depreciacion.ToArray();
                if (array == null) return;
                dgvFNE.Rows[n].Cells[i + 2].Value = array[i];
            }
        }
        private void setInersionesTotales()
        {
            dgvFNE.Rows[11].Cells[1].Value = (decimal)FNEData.Inversion;
        }

        private void Depreciacion_Load(object sender, EventArgs e)
        {
            if (flag == true) this.Close();
            if (cmbMethod.DataSource == null) cmbMethod.DataSource = Enum.GetValues(typeof(Depreciation));
            //cmbMethod.Items.AddRange(Enum.GetValues(typeof(Depreciation)).Cast<object>().ToArray());


            cmbMethod.SelectedIndex = -1;

            //if (FNEData.DepreciableAssetsValue == 0) return;
            //colocando valores para hacer la depreciacion
            nudInitialValue.Enabled = false;
            nudInitialValue.Value = FNEData.DepreciableAssetsValue;
            nudYears.Enabled = false;
            nudYears.Value = years;
            cmbMethod.SelectedIndex = 0;
            FillDgv();
            if (years == 0) return; // si es diferente de 0, es parte del FNE
            if (tmp) // traer datos de la base de datos
            {
                Depreciacion inv = depreciationService.GetByProjectId(project.Id);
                if (inv == null)
                {
                    this.tmp = false;
                    this.Close();
                    return;
                }

                nudResidualValue.Value = inv.ValorResidual;
                FNEData.ValorDeRescate = inv.ValorResidual;
                cmbMethod.SelectedIndex = inv.TipoDepreciacion;

                FillDgv();
                ExtraerData();
                //colocando valores en la tabla FNE
                setDepreciation(3);
                setDepreciation(7);
                setInersionesTotales();
                setVR();
                this.tmp = false;
                this.Close();
                return;
            }
            ExtraerData();
            //colocando valores en la tabla FNE
            setDepreciation(3);
            setDepreciation(7);
            setInersionesTotales();
            setVR();
            //ingresando valores a la base de datos
            if (depreciationService.GetByProjectId(project.Id) == null)
            {
                depreciationService.Create(new Depreciacion
                {
                    TipoDepreciacion = (short)cmbMethod.SelectedIndex,
                    Valor = FNEData.Inversion,
                    ValorResidual = FNEData.ValorDeRescate,
                    ProjectId = project.Id,
                });
            }
            else
            {
                depreciationService.Update(new Depreciacion
                {
                    TipoDepreciacion = (short)cmbMethod.SelectedIndex,
                    Valor = FNEData.Inversion,
                    ValorResidual = FNEData.ValorDeRescate,
                    ProjectId = project.Id,
                });

            }
            if(UserAssets.UAssets.Count == 0)// si no hay activos, vr = 0
            {
                depreciationService.Update(new Depreciacion
                {

                        TipoDepreciacion = (short)cmbMethod.SelectedIndex,
                        Valor = FNEData.Inversion,
                        ValorResidual = 0,
                        ProjectId = project.Id,
                });
                nudResidualValue.Value = 0;
                FillDgv();
                ExtraerData();
                //colocando valores en la tabla FNE
                setDepreciation(3);
                setDepreciation(7);
                setInersionesTotales();
                setVR();
            }
        }


        private bool Validations()
        {
            if(years > 0) // cuando se usa dentro del FNE
            {
                if(nudYears.Value < years)
                {
                    MessageBox.Show("Los años no pueden ser mayores a los años del proyecto del Flujo Neto de Efectivo (FNE)", "Error in the data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            if(nudInitialValue.Value < nudResidualValue.Value)
            {
                MessageBox.Show("The Initial Value don't be less than the Residual Value", "Error in the data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(cmbMethod.SelectedIndex == 2 && nudCoeficiente.Value < 2)
            {
                MessageBox.Show("The coeficiente don't be less than 2", "Error in the data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(nudInitialValue.Value == 0 || cmbMethod.SelectedIndex == -1 || nudYears.Value == 0)
            {
                MessageBox.Show("Must fill all the data", "Error in the Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
      
        private void FillDgv()
        {
            DgvDepreciation.Rows.Clear();
            DepreciationDTO depreciationDTO = new DepreciationDTO();
            depreciationDTO.Valor_Libro = double.Parse(nudInitialValue.Value.ToString());
            if (cmbMethod.SelectedIndex == 0)
            {
                depreciationDTO.Depreciation = dep.Depreciacion(double.Parse(nudInitialValue.Value.ToString()),
                    double.Parse(nudResidualValue.Value.ToString()), Int32.Parse(nudYears.Value.ToString()));
                for (int i = 0; i <= nudYears.Value; i++)
                {
                    if (i == 0)
                    {
                        this.DgvDepreciation.Rows.Add(0, 0, 0, depreciationDTO.Valor_Libro);
                        continue;
                    }
                    depreciationDTO.Depreciation_Acumulada = depreciationDTO.Depreciation + Math.Round(depreciationDTO.Depreciation_Acumulada, 2);
                    depreciationDTO.Year = i;
                    depreciationDTO.Valor_Libro = Math.Round(depreciationDTO.Valor_Libro, 2) - depreciationDTO.Depreciation;
                    this.DgvDepreciation.Rows.Add(depreciationDTO.Year, depreciationDTO.Depreciation, depreciationDTO.Depreciation_Acumulada,
                        depreciationDTO.Valor_Libro);
                }
            }
            else if (cmbMethod.SelectedIndex == 1)
            {
                for (int i = 0; i <= nudYears.Value; i++)
                {
                    if (i == 0)
                    {
                        this.DgvDepreciation.Rows.Add(0, 0, 0, depreciationDTO.Valor_Libro);
                        continue;
                    }
                    depreciationDTO.Depreciation = dep.DepreciationSDA(double.Parse(nudInitialValue.Value.ToString()),
                    double.Parse(nudResidualValue.Value.ToString()), Int32.Parse(nudYears.Value.ToString()), i);
                    depreciationDTO.Depreciation_Acumulada = depreciationDTO.Depreciation + Math.Round(depreciationDTO.Depreciation_Acumulada, 2);
                    depreciationDTO.Year = i;
                    depreciationDTO.Valor_Libro = Math.Round(depreciationDTO.Valor_Libro, 2) - depreciationDTO.Depreciation;
                    this.DgvDepreciation.Rows.Add(depreciationDTO.Year, depreciationDTO.Depreciation, depreciationDTO.Depreciation_Acumulada,
                       depreciationDTO.Valor_Libro);
                }
            }
            else if(cmbMethod.SelectedIndex == 2)
            {
                for(int i = 0; i <= nudYears.Value; i++)
                {
                    if (i == 0)
                    {
                        this.DgvDepreciation.Rows.Add(0, 0, 0, depreciationDTO.Valor_Libro);
                        continue;
                    }
                    depreciationDTO.Depreciation = dep.DepreciationDDB(double.Parse(nudResidualValue.Value.ToString()), depreciationDTO.Valor_Libro,
                        Int32.Parse(nudYears.Value.ToString()), Int32.Parse(nudCoeficiente.Value.ToString()));
                    depreciationDTO.Year = i;
                    if (i == nudYears.Value && 
                        (depreciationDTO.Valor_Libro - depreciationDTO.Depreciation) != double.Parse(nudResidualValue.Value.ToString()))
                    {
                        depreciationDTO.Depreciation = depreciationDTO.Valor_Libro - double.Parse(nudResidualValue.Value.ToString());
                    }
                    depreciationDTO.Depreciation_Acumulada = depreciationDTO.Depreciation + Math.Round(depreciationDTO.Depreciation_Acumulada, 2);
                    depreciationDTO.Valor_Libro = Math.Round(depreciationDTO.Valor_Libro, 2) - depreciationDTO.Depreciation;
                    this.DgvDepreciation.Rows.Add(depreciationDTO.Year, depreciationDTO.Depreciation, depreciationDTO.Depreciation_Acumulada,
                       depreciationDTO.Valor_Libro);
                    
                }
            }
        }

        private void cmbMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbMethod.SelectedIndex == 2)
            {
                lblCoeficiente.Visible = true;
                nudCoeficiente.Visible = true;
                return;
            }
            lblCoeficiente.Visible = false;
            nudCoeficiente.Visible = false;
        }

        private void nudResidualValue_ValueChanged(object sender, EventArgs e)
        {
            if (nudResidualValue.Value == 0)
            {
                return;
            }
            if (tmp) return;
            if (years > 0) // solo cuando se ocupa en el FNE
            {
                if (Validations())
                {
                    FillDgv();
                    if (years == 0) return;
                    ExtraerData();
                    //colocando valores en la tabla FNE
                    setDepreciation(3);
                    setDepreciation(7);
                    setInersionesTotales();
                    setVR();
                    //ingresando valores a la base de datos
                    if (depreciationService.GetByProjectId(project.Id) == null)
                    {
                        depreciationService.Create(new Depreciacion
                        {
                            TipoDepreciacion = (short)cmbMethod.SelectedIndex,
                            Valor = FNEData.Inversion,
                            ValorResidual = FNEData.ValorDeRescate,
                            ProjectId = project.Id,
                        });
                    }
                    else
                    {
                        depreciationService.Update(new Depreciacion
                        {
                            TipoDepreciacion = (short)cmbMethod.SelectedIndex,
                            Valor = FNEData.Inversion,
                            ValorResidual = FNEData.ValorDeRescate,
                            ProjectId = project.Id,
                        });

                    }
                }
            }

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (Validations())
            {
                FillDgv();
                if (years == 0) return;
                ExtraerData();
                //colocando valores en la tabla FNE
                setDepreciation(3);
                setDepreciation(7);
                setInersionesTotales();
                setVR();
            }
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
        private void FrmDepreciacion_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FadeIn_Tick(object sender, EventArgs e)
        {
            if (this.Opacity == 1)
            {
                FadeIn.Stop();
            }
            this.Opacity += 0.2;
        }
    }
}
