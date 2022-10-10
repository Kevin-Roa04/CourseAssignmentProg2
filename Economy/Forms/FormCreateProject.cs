using Appcore.Interface;
using Autofac.Core;
using Economy.AppCore.IServices;
using Economy.BeatifulComponents;
using Economy.Domain.Entities;
using Economy.Domain.Enums;
using Guna.Charts.WinForms;
using InteresPratica;
using Proto1._0;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Economy.Forms
{
    public partial class FormCreateProject : Form
    {
        public IProjectServices projectServices { get; set; }

        #region -> Interests service
        public IInterestServices<Annuity> AnnuityServices { get; set; }
        public IInterestServices<Serie> SerieServices { get; set; }
        public IInterestServices<Interest> InterestServices { get; set; }

        #endregion

        #region -> Calculate service
        public ICalculateServices<Annuity> calculateServicesAnnuity;
        public ICalculateServices<Interest> CalculateServicesInterest;
        public ICalculateServices<Serie> CalculateServicesSerie;
        public INominalServices nominal;
        #endregion
        private User GlobalUser;
        private int Selection = -1;
        public ISimpleService simpleService;
        public ICompuestoService compuestoService1;
        public IConvertService convertService1;
        public IDepreciationService depreciationService;
        public IAmortizacionServices amortizacionServices;

        #region Dictionaries
        private Dictionary<string, Color> ProjectColor = new Dictionary<string, Color>();
        private Dictionary<string, string> ProjectDescription = new Dictionary<string, string>();
        private Dictionary<string, string> ProjectLetter = new Dictionary<string, string>();
        private Dictionary<string, MouseEventHandler> ProjectClick = new Dictionary<string, MouseEventHandler>();
        #endregion


        public FormCreateProject(User user)
        {
            this.GlobalUser = user;
            InitializeComponent();
            DictionaryProjectColor();
            DictionaryProjectDescription();
            DictionaryProjectLetter();
            DictionaryProjectClick();
        }
        private void DictionaryProjectClick()
        {
            ProjectClick.Add("InterestWithGraph", PCInterest);
            ProjectClick.Add("Excel", PCExcel);
            ProjectClick.Add("RateConversion", null);
            ProjectClick.Add("InterestConversion",null);
            ProjectClick.Add("Amortization", null);
            ProjectClick.Add("Depreciation", null);
            ProjectClick.Add("FNE", null);
        }
        private void DictionaryProjectLetter()
        {

            ProjectLetter.Add("InterestWithGraph", "IG");
            ProjectLetter.Add("Excel", "FE");
            ProjectLetter.Add("RateConversion", "IN");
            ProjectLetter.Add("InterestConversion", "CI");
            ProjectLetter.Add("Amortization", "A");
            ProjectLetter.Add("Depreciation", "D");
            ProjectLetter.Add("FNE", "FNE");
        }
        private void DictionaryProjectDescription()
        {
            ProjectDescription.Add("InterestWithGraph", "Interés y gráfica");
            ProjectDescription.Add("Excel", "Funciones en excel");
            ProjectDescription.Add("RateConversion", "Intereses nominales");
            ProjectDescription.Add("InterestConversion", "Calcular interés");
            ProjectDescription.Add("Amortization", "Amortización");
            ProjectDescription.Add("Depreciation", "Depreciación");
            ProjectDescription.Add("FNE", "Flujo neto de efectivo");
        }
        private void DictionaryProjectColor()
        {
            ProjectColor.Add("InterestWithGraph", Color.FromArgb(224, 239, 255));
            ProjectColor.Add("Excel", Color.FromArgb(177, 215, 185));
            ProjectColor.Add("RateConversion", Color.FromArgb(250, 112, 112));
            ProjectColor.Add("InterestConversion", Color.FromArgb(100, 92, 170));
            ProjectColor.Add("Amortization", Color.FromArgb(255, 192, 144));
            ProjectColor.Add("Depreciation", Color.FromArgb(235, 199, 232));
            ProjectColor.Add("FNE", Color.FromArgb(125, 157, 156));
        }

        #region -> FormBorder
        private int borderRadius = 10;

        private GraphicsPath GetCustomPanelPath(RectangleF rectangle, float radius)
        {
            float curveSize = radius * 2F;
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.StartFigure();
            graphicsPath.AddArc((rectangle.Width - curveSize), rectangle.Height - curveSize, curveSize, curveSize, 0, 90);
            graphicsPath.AddArc(rectangle.X, (rectangle.Height - curveSize), curveSize, curveSize, 90, 90);
            graphicsPath.AddArc(rectangle.X, rectangle.Y, curveSize, curveSize, 180, 90);
            graphicsPath.AddArc((rectangle.Width - curveSize), rectangle.Y, curveSize, curveSize, 270, 90);
            graphicsPath.CloseFigure();
            return graphicsPath;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            RectangleF rectangleF = new RectangleF(0, 0, this.Width, this.Height);

            if (borderRadius > 2)
            {
                using (GraphicsPath graphicsPath = GetCustomPanelPath(rectangleF, borderRadius))
                using (Pen pen = new Pen(this.BackColor, 2))
                {
                    this.Region = new Region(graphicsPath);
                    e.Graphics.DrawPath(pen, graphicsPath);
                }

            }
            else this.Region = new Region(rectangleF);

        }

        #endregion

        #region -> form movement
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void FormCreateProject_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region --> Form shadow
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
        private void projects()
        {
            DirectoryInfo directory = new DirectoryInfo(Application.StartupPath + @"Excel");
            FileInfo[] files = null;
            if (directory.Exists)
            {
                files = directory.GetFiles();
            }
            flpProjects.Controls.Clear();
            foreach (Project project in projectServices.GetProjectByUser(GlobalUser.Id))
            {
             
                ProjectComponent projectComponent = new ProjectComponent()
                {
                    NameProject = project.Name,
                    Description = ProjectDescription[project.Type],
                    Letter = ProjectLetter[project.Type],
                    BackColor = ProjectColor[project.Type],
                    BorderRadius = 16,

                    Tag = project.Id,
                    
                };
                projectComponent.Size = new Size(130,130);
                projectComponent.MouseClick += ProjectClick[project.Type];
                projectComponent.LabelDescription.Tag = project.Id;
                projectComponent.LabelLetter.Tag = project.Id;
                projectComponent.LabelNameProject.Tag = project.Id;
                projectComponent.LabelDescription.MouseClick += ProjectClick[project.Type];
                projectComponent.LabelLetter.MouseClick += ProjectClick[project.Type];
                projectComponent.LabelNameProject.MouseClick += ProjectClick[project.Type];

                if (project.Type.Equals("Excel") && directory.Exists)
                {
                    if (files.Length == 0)
                    {
                        projectServices.Delete(project);
                        continue;
                    }
                    for (int i = 0; i < files.Length; i++)
                    {
                        if (files[i].Name == project.Name + ".xls")
                        {
                            flpProjects.Controls.Add(projectComponent);
                            break;
                        }
                        else if (!(files[i].Name == project.Name + "xls") && i == files.Length - 1)
                        {
                            projectServices.Delete(project);
                        }
                    }
                    continue;
                }
                flpProjects.Controls.Add(projectComponent);
            }
        }


        private void PbClose_Click(object sender, EventArgs e)
        {
          
            Application.Exit();
        }

        private void FadeIn_Tick(object sender, EventArgs e)
        {
            if (this.Opacity == 1)
            {
                FadeIn.Stop();
            }
            this.Opacity += .2;
        }

        private void txtSearch__TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearch.Texts.Length > 0)
                {
                    ProjectByName(txtSearch.Texts);
                }
                else if (txtSearch.Texts.Length <= 0)
                {
                    projects();
                }
            }
            catch 
            {
                projects();
            }
        }
        private void ProjectByName(string name)
        {
            flpProjects.Controls.Clear();
            foreach(Project project in projectServices.GetProjectsByName(name, GlobalUser.Id))
            {
                ProjectComponent projectComponent = new ProjectComponent()
                {
                    NameProject = project.Name,
                    Description = ProjectDescription[project.Type],
                    Letter = ProjectLetter[project.Type],
                    BackColor = ProjectColor[project.Type],
                    BorderRadius = 16,
                    Tag = project.Id
                };
                projectComponent.Size=new Size(130, 130);
                projectComponent.MouseClick += ProjectClick[project.Type];
                projectComponent.LabelDescription.Tag = project.Id;
                projectComponent.LabelLetter.Tag = project.Id;
                projectComponent.LabelNameProject.Tag = project.Id;
                projectComponent.LabelDescription.MouseClick += ProjectClick[project.Type];
                projectComponent.LabelLetter.MouseClick += ProjectClick[project.Type];
                projectComponent.LabelNameProject.MouseClick += ProjectClick[project.Type];
                flpProjects.Controls.Add(projectComponent);
            }
        }

       

        private void PCMouseClick(object sender, MouseEventArgs e)
        {
            
            Selection= (int)Convert.ToUInt64( ( sender as ProjectComponent).Name.Substring(2));
            if (Selection != -1)
            {
                txtProjectName.Visible = true;
                btnCreate.Visible = true;
                lblProjectName.Visible = true;
                lblTypeProject.Text = ProjectDescription[((TypeProject)Selection).ToString()];
                lblTypeProject.ForeColor = ProjectColor[((TypeProject)Selection).ToString()];
                lblTypeProject.Visible = true;
            }
        }
        private void PCInterest(object sender,MouseEventArgs e)
        {
            Project project;
            try
            {
                project = projectServices.FindbyId((int)Convert.ToUInt64((sender as ProjectComponent).Tag.ToString()), GlobalUser.Id);
            }
            catch
            {
                project = projectServices.FindbyId((int)Convert.ToUInt64((sender as Label).Tag.ToString()), GlobalUser.Id);
            }
          
            FormGraphInterest formGraphInterest = new FormGraphInterest(project);
            formGraphInterest.txtRate.Texts = Rate(project).ToString();
            formGraphInterest.rate= Convert.ToDecimal(Rate(project).ToString());
            formGraphInterest.TotalPeriod=TotalPeriod(project);
            formGraphInterest.txtDuration.Texts= TotalPeriod(project).ToString();
            formGraphInterest.ActivateForm();
            formGraphInterest.cmbTime.SelectedIndex = project.Period == null ? 0 : (int)Enum.Parse(typeof(Period), project.Period);
            formGraphInterest.pbChanged.Visible = true;
            formGraphInterest.customPanel1.Visible = true;
            formGraphInterest.lblTypeIdgv.Visible = true;
            formGraphInterest.cmbTypeIdgv.Visible = true;
            formGraphInterest.projectServices = this.projectServices;
            formGraphInterest.InterestServices = this.InterestServices;
            formGraphInterest.SerieServices = this.SerieServices;
            formGraphInterest.AnnuityServices = this.AnnuityServices;
            formGraphInterest.FormCreateProject = this;
            this.Opacity = 0;
            this.Hide();
            formGraphInterest.ShowDialog();
            Selection = -1;
            txtProjectName.Visible = false;
            lblLetters.Visible = false;
            lblProjectName.Visible = false;
            btnCreate.Visible = false;
            lblTypeProject.Text = "";
            lblTypeProject.Visible = false;
            this.FadeIn.Start();
            projects();
            this.Show();

        }
        private void PCExcel(object sender, MouseEventArgs e)
        {
            Project project;
            try
            {
                project = projectServices.FindbyId((int)Convert.ToUInt64((sender as ProjectComponent).Tag.ToString()), GlobalUser.Id);
            }
            catch
            {
                project = projectServices.FindbyId((int)Convert.ToUInt64((sender as Label).Tag.ToString()), GlobalUser.Id);
            }
            DirectoryInfo directory = new DirectoryInfo(Application.StartupPath + @"Excel");
            FileInfo[] files = directory.GetFiles();
            if (files.Length == 0)
            {
                projects();
                MessageBox.Show("Ha ocurrido un problema para cargar el archivo, se ha borrado el archivo donde se encontraba la información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            for (int i = 0; i < files.Length; i++)
            {
                if (files[i].Name == project.Name + ".xls")
                {
                    FormExcel formExcel = new FormExcel(calculateServicesAnnuity, CalculateServicesInterest, CalculateServicesSerie, project.Name);
                    formExcel.project = project;
                    formExcel.ShowDialog();
                    this.FadeIn.Start();
                    projects();
                    this.Show();
                    break;
                }
                else if (!(files[i].Name == project.Name + "xls") && i == files.Length - 1)
                {
                    projects();
                    MessageBox.Show("Ha ocurrido un problema para cargar el archivo, ha borrado el archivo donde se encontraba la información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void CreatePieChart()
        {

           
            gunaChart1.Datasets.Clear();
            var dataset = new Guna.Charts.WinForms.GunaPieDataset();
            gunaChart1.Legend.Position = Guna.Charts.WinForms.LegendPosition.Right;
            gunaChart1.XAxes.Display = false;
            gunaChart1.YAxes.Display = false;
            
            dataset.DataPoints.Add("IG",projectServices.GetProjectByUser(GlobalUser.Id).Where(x=>x.Type==TypeProject.InterestWithGraph.ToString()).Count());
            dataset.FillColors.Add(ProjectColor["InterestWithGraph"]);
            dataset.DataPoints.Add("FE", projectServices.GetProjectByUser(GlobalUser.Id).Where(x => x.Type == TypeProject.Excel.ToString()).Count());
            dataset.FillColors.Add(ProjectColor["Excel"]);
            dataset.DataPoints.Add("IN", projectServices.GetProjectByUser(GlobalUser.Id).Where(x => x.Type == TypeProject.RateConversion.ToString()).Count());
            dataset.FillColors.Add(ProjectColor["RateConversion"]); 
            dataset.DataPoints.Add("CI", projectServices.GetProjectByUser(GlobalUser.Id).Where(x => x.Type == TypeProject.InterestConversion.ToString()).Count());
            dataset.FillColors.Add(ProjectColor["InterestConversion"]);
            dataset.DataPoints.Add("A", projectServices.GetProjectByUser(GlobalUser.Id).Where(x => x.Type == TypeProject.Amortization.ToString()).Count());
            dataset.FillColors.Add(ProjectColor["Amortization"]);
            dataset.DataPoints.Add("D", projectServices.GetProjectByUser(GlobalUser.Id).Where(x => x.Type == TypeProject.Depreciation.ToString()).Count());
            dataset.FillColors.Add(ProjectColor["Depreciation"]);
            dataset.DataPoints.Add("FNE", projectServices.GetProjectByUser(GlobalUser.Id).Where(x => x.Type == TypeProject.FNE.ToString()).Count());
            dataset.FillColors.Add(ProjectColor["FNE"]);
            gunaChart1.Datasets.Add(dataset);
            gunaChart1.Update();
            lblNumberProject.Text ="Número de projectos: "+projectServices.GetProjectByUser(GlobalUser.Id).ToList().Count().ToString();
        }
        private void CreateLineChart()
        {
            gunaChart2.Datasets.Clear();
           //gunaChart2.XAxes.GridLines.Display = false;
           
            gunaChart2.YAxes.GridLines.Display = false;
            
            var dataset = new Guna.Charts.WinForms.GunaLineDataset();
            dataset.PointRadius = 3;
            
            dataset.PointStyle = PointStyle.Circle;
            var results=from date in projectServices.GetProjectByUser(GlobalUser.Id)
                       group date by date.Creation.Date.ToShortDateString();

            foreach(var r in results)
            {
                dataset.DataPoints.Add(r.Key.ToString(), r.Count());
            }
            gunaChart2.Datasets.Add(dataset);
            gunaChart2.Update();

        }
        private decimal Rate(Project project)
        {
            decimal Value=0;

            if (AnnuityServices.GetIdProject(project.Id).Count > 0)
            {
                Value = AnnuityServices.GetIdProject(project.Id)[0].Rate;
            }
            else if (InterestServices.GetIdProject(project.Id).Count > 0)
            {
                Value = InterestServices.GetIdProject(project.Id)[0].Rate;
            }
            else if (SerieServices.GetIdProject(project.Id).Count > 0)
            {
                Value = SerieServices.GetIdProject(project.Id)[0].Rate;
            }
            return Value;
        }
        private int TotalPeriod(Project project)
        {
            int Value = 0;
            if (AnnuityServices.GetIdProject(project.Id).Count > 0)
            {
                Value = AnnuityServices.GetIdProject(project.Id)[0].TotalPeriod;
            }
            else if (InterestServices.GetIdProject(project.Id).Count > 0)
            {
                Value = InterestServices.GetIdProject(project.Id)[0].TotalPeriod;
            }
            else if (SerieServices.GetIdProject(project.Id).Count > 0)
            {
                Value = SerieServices.GetIdProject(project.Id)[0].TotalPeriod;
            }
            return Value;
        }

        private void txtNameProject__TextChanged(object sender, EventArgs e)
        {
            int count = txtProjectName.Texts.Length;

            if (count<= 20)
            {
                lblLetters.ForeColor = Color.Silver;
                lblLetters.Visible = true;
                lblLetters.Text = $"{count}/20";
            }
            else
            {
                lblLetters.ForeColor = Color.Red;
                lblLetters.Text = $"{count}/20";
                return;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtProjectName.Texts =="")
            {
                MessageBox.Show("Rellene el formulario.");
                return;
            }
            else if (txtProjectName.Texts.Length > 20)
            {
                MessageBox.Show("El nombre del proyecto tiene que tener 20 letras.");
                return;
            }
            try
            {
                Project project = new Project()
                {
                    Name = txtProjectName.Texts,
                    Creation = DateTime.Now,
                    Type = ((TypeProject)Selection).ToString(),
                    User = GlobalUser,
                    UserId = GlobalUser.Id
                };
                projectServices.Create(project);
                this.Hide();
                if (Selection == 0)
                {
                    FormGraphInterest formGraphInterest = new FormGraphInterest(project);
                    formGraphInterest.InterestServices = this.InterestServices;
                    formGraphInterest.projectServices = this.projectServices;
                    formGraphInterest.SerieServices = this.SerieServices;
                    formGraphInterest.AnnuityServices = this.AnnuityServices;
                    formGraphInterest.FormCreateProject = this;
                    formGraphInterest.ShowDialog();
                }
                else if (Selection == 1)
                {
                    FormExcel formExcel = new FormExcel(calculateServicesAnnuity, CalculateServicesInterest, CalculateServicesSerie, txtProjectName.Texts);
                    formExcel.ShowDialog();


                }
                else if (Selection == 2)
                {

                    FmrInteres fmrInteres = new FmrInteres(nominal);
                    fmrInteres.FormCreateProject = this;
                    fmrInteres.ShowDialog();

                }
                else if (Selection == 3)
                {
                    Inicio ins = new Inicio(simpleService, compuestoService1, convertService1);
                    ins.FormCreateProject = this;
                    ins.ShowDialog();
                }
                else if (Selection == 4)
                {
                    FmrCalendarioDePago fmrCalendarioDePago = new FmrCalendarioDePago(amortizacionServices, 0, null);
                    fmrCalendarioDePago.ShowDialog();
                }
                else if (Selection == 5)
                {
                    Depreciacion depreciacion = new Depreciacion(depreciationService, 0, null);
                    depreciacion.ShowDialog();
                }
                else if (Selection == 6)
                {
                    FormFNE FNE = new FormFNE(amortizacionServices, depreciationService);
                    FNE.ShowDialog();
                }
                
                Selection = -1;
                txtProjectName.Visible = false;
                lblLetters.Visible = false;
                lblProjectName.Visible = false;
                btnCreate.Visible = false;
                lblTypeProject.Text = "";
                lblTypeProject.Visible = false;
                projects();
                this.Opacity = 0;
                this.FadeIn.Start();
                CreatePieChart();
                CreateLineChart();
                this.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void FormCreateProject_Load_1(object sender, EventArgs e)
        {

            this.PC0.MouseClick += new MouseEventHandler(PCMouseClick);
            this.PC1.MouseClick += new MouseEventHandler(PCMouseClick);
            this.PC2.MouseClick += new MouseEventHandler(PCMouseClick);
            this.PC3.MouseClick += new MouseEventHandler(PCMouseClick);
            this.PC4.MouseClick += new MouseEventHandler(PCMouseClick);
            this.PC5.MouseClick += new MouseEventHandler(PCMouseClick);
            this.PC6.MouseClick += new MouseEventHandler(PCMouseClick);
            CreatePieChart();
            CreateLineChart();
            projects();

        }
    }
}
