using Economy.AppCore.IServices;
using Economy.BeatifulComponents;
using Economy.Domain.Entities;
using Economy.Domain.Enums;
using Guna.Charts.WinForms;
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
using static Economy.Forms.FrmInformation;

namespace Economy.Forms
{
    public partial class FormAnalyst : Form
    {


        public IProjectServices projectServices { get; set; }
        public int GlobalUser;
        public List<int> ProjectIds = new List<int>();
        bool used = true;
        #region -> Interests service
        public IInterestServices<Annuity> AnnuityServices { get; set; }
        public IInterestServices<Serie> SerieServices { get; set; }
        public IInterestServices<Interest> InterestServices { get; set; }
        #endregion
        public FormAnalyst(int UserId)
        {
            this.GlobalUser = UserId;
            InitializeComponent();
        }
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

        private void projects()
        {
            flpProjects.Controls.Clear();

            foreach (Project project in projectServices.GetProjectByUser(GlobalUser).Where(x => x.Type == "InterestWithGraph"))
            {
                if (!ProjectIds.Any(x => x == project.Id))
                {
                    ProjectComponent projectComponent = new ProjectComponent()
                    {
                        NameProject = project.Name,
                        Description = "Interés y gráfica",
                        Letter = "IG",
                        BackColor = Color.FromArgb(224, 239, 255),
                        BorderRadius = 16,
                        Tag = project.Id,

                    };
                    Necessary necessary = CalculateNecessary(project);
                    string Tooltip = "";

                    Tooltip = $"Presente: {necessary.Present}, Futuro: {necessary.Future}, Periodos: {necessary.totalPeriod} {project.Period}";
                    System.Windows.Forms.ToolTip tooltip = new ToolTip();
                    tooltip.SetToolTip(projectComponent, Tooltip);
                    projectComponent.MouseDown += ProjectComponent_MouseDown;
                    projectComponent.Size = new Size(130, 130);
                    projectComponent.AllowDrop = true;
                    projectComponent.LabelDescription.Tag = project.Id;
                    projectComponent.LabelDescription.MouseDown += ProjectComponent_MouseDown;
                    projectComponent.LabelLetter.Tag = project.Id;
                    projectComponent.LabelLetter.MouseDown += ProjectComponent_MouseDown;
                    projectComponent.LabelNameProject.Tag = project.Id;
                    projectComponent.LabelNameProject.MouseDown += ProjectComponent_MouseDown;
                    flpProjects.Controls.Add(projectComponent);
                }

            }
        }

        private void ProjectComponent_MouseDown(object sender, MouseEventArgs e)
        {
            used = true;
            int id = -1;
            try
            {
                id = projectServices.FindbyId((int)Convert.ToUInt64((sender as Label).Tag.ToString()), GlobalUser).Id;
                (sender as Label).DoDragDrop(id, DragDropEffects.Copy);
            }
            catch
            {
                id = projectServices.FindbyId((int)Convert.ToUInt64((sender as ProjectComponent).Tag.ToString()), GlobalUser).Id;
                (sender as ProjectComponent).DoDragDrop(id, DragDropEffects.Copy);
            }
        }
        private void ProjectComponentUsed_MouseDown(object sender, MouseEventArgs e)
        {
            used = false;
            int id = -1;
            try
            {
                id = projectServices.FindbyId((int)Convert.ToUInt64((sender as Label).Tag.ToString()), GlobalUser).Id;
                (sender as Label).DoDragDrop(id, DragDropEffects.Copy);
            }
            catch
            {
                id = projectServices.FindbyId((int)Convert.ToUInt64((sender as ProjectComponent).Tag.ToString()), GlobalUser).Id;
                (sender as ProjectComponent).DoDragDrop(id, DragDropEffects.Copy);
            }
        }
        private void FormAnalyst_Load(object sender, EventArgs e)
        {
            ToolTip toolTipConclusion = new ToolTip();
            toolTipConclusion.SetToolTip(this.pbInterestInfomation,"Conclusión de los flujos de cajas");
            this.pbCompare.AllowDrop = true;
            //gcScatter.Datasets.Add(gunaScatterDataset1);
            gcScatter.Datasets.Add(gunaBarDataset1);
            gcScatter.YAxes.GridLines.Display = false;
            gcScatter.Legend.Display = false;
            // gcPolarArea.Legend.Position = Guna.Charts.WinForms.LegendPosition.Right;
            gcPolarArea.Legend.Display = false;
            gcPolarArea.YAxes.Display = false;
            gcPolarArea.XAxes.Display = false;
            gcPolarArea.Datasets.Add(gunaPolarAreaDataset1);
            this.lblFuture.TextAlign = ContentAlignment.TopLeft;
            this.flpUsedProject.Controls.Add(Project(projectServices.FindbyId(ProjectIds[0], GlobalUser)));

            DrawScatter(ProjectIds[0]);
            DrawPolarArea(ProjectIds[0]);
            projects();
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
            foreach (Project project in projectServices.GetProjectsByName(name, GlobalUser).Where(x => x.Type == "InterestWithGraph"))
            {
                if (!ProjectIds.Any(x => x == project.Id))
                {
                    ProjectComponent projectComponent = new ProjectComponent()
                    {
                        NameProject = project.Name,
                        Description = "Interés y gráfica",
                        Letter = "IG",
                        BackColor = Color.FromArgb(224, 239, 255),
                        BorderRadius = 16,
                        Tag = project.Id
                    };
                    Necessary necessary = CalculateNecessary(project);
                    string Tooltip = "";

                    Tooltip = $"Presente: {necessary.Present}, Futuro: {necessary.Future}, Periodos: {necessary.totalPeriod} {project.Period}";
                    System.Windows.Forms.ToolTip tooltip = new ToolTip();
                    tooltip.SetToolTip(projectComponent, Tooltip);
                    projectComponent.AllowDrop = true;
                    projectComponent.Size = new Size(130, 130);
                    projectComponent.MouseDown += ProjectComponent_MouseDown;
                    projectComponent.LabelDescription.Tag = project.Id;
                    projectComponent.LabelDescription.MouseDown += ProjectComponent_MouseDown;
                    projectComponent.LabelLetter.Tag = project.Id;
                    projectComponent.LabelLetter.MouseDown += ProjectComponent_MouseDown;
                    projectComponent.LabelNameProject.Tag = project.Id;
                    projectComponent.LabelNameProject.MouseDown += ProjectComponent_MouseDown;
                    flpProjects.Controls.Add(projectComponent);
                }

            }
        }

        private void pbCompare_DragDrop(object sender, DragEventArgs e)
        {
            var objects = e.Data.GetData(typeof(int));
            if ((int)objects == ProjectIds[0])
            {
                return;
            }
            if (used)
            {
                if (!ProjectIds.Any(x => x == ((int)objects)))
                {
                    ProjectIds.Add((int)objects);
                    this.flpUsedProject.Controls.Add(Project(projectServices.FindbyId((int)objects, GlobalUser)));
                    DrawScatter((int)objects);
                    DrawPolarArea((int)objects);
                    if (txtSearch.Texts.Length > 0)
                    {
                        ProjectByName(txtSearch.Texts);
                    }
                    else
                    {
                        projects();
                    }
                }
            }
            else
            {

                ProjectIds.Remove((int)objects);
                DeleteScatter((int)objects);
                DeletePolarArea((int)objects);
                UpdateUsedComponent();
                if (txtSearch.Texts.Length > 0)
                {
                    ProjectByName(txtSearch.Texts);
                }
                else
                {
                    projects();
                }

            }
            this.pbCompare.Image = Properties.Resources.notes__1_;

        }
        private void UpdateUsedComponent()
        {
            this.flpUsedProject.Controls.Clear();
            foreach (int i in ProjectIds)
            {
                this.flpUsedProject.Controls.Add(Project(projectServices.FindbyId(i, GlobalUser)));
            }

        }
        private ProjectComponent Project(Project project)
        {
            ProjectComponent projectComponent = new ProjectComponent()
            {
                NameProject = project.Name,
                Description = "Interés y gráfica",
                Letter = "IG",
                BackColor = Color.FromArgb(37, 109, 133),
                BorderRadius = 16,
                Tag = project.Id
            };
            Necessary necessary = CalculateNecessary(project);
            string Tooltip = "";

            Tooltip = $"Presente: {necessary.Present}, Futuro: {necessary.Future}, Periodos: {necessary.totalPeriod} {project.Period}";
            System.Windows.Forms.ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(projectComponent, Tooltip);
            projectComponent.MouseDown += ProjectComponentUsed_MouseDown;
            projectComponent.AllowDrop = true;
            projectComponent.Size = new Size(115, 115);
            projectComponent.LabelDescription.Tag = project.Id;
            projectComponent.LabelDescription.MouseDown += ProjectComponentUsed_MouseDown;
            projectComponent.LabelLetter.Tag = project.Id;
            projectComponent.LabelLetter.MouseDown += ProjectComponentUsed_MouseDown;
            projectComponent.LabelNameProject.Tag = project.Id;
            projectComponent.LabelNameProject.MouseDown += ProjectComponentUsed_MouseDown;
            return projectComponent;
        }

        private void DrawPolarArea(int id)
        {
            Project project = projectServices.FindbyId(id, GlobalUser);
            gunaPolarAreaDataset1.DataPoints.Add(project.Name, InterestNumber(id));
            gcPolarArea.Update();

        }
        private void DeletePolarArea(int id)
        {

            Project project = projectServices.FindbyId(id, GlobalUser);
            foreach (LPoint lPoint in gunaPolarAreaDataset1.DataPoints)
            {
                if (lPoint.Label == project.Name)
                {
                    gunaPolarAreaDataset1.DataPoints.Remove(lPoint);
                    return;
                }
            }
        }
        private int InterestNumber(int id)
        {
            int number = 0;
            number += SerieServices.GetIdProject(id).Count;
            number += AnnuityServices.GetIdProject(id).Count;
            number += InterestServices.GetIdProject(id).Count;
            return number;
        }

        private void DrawScatter(int id)
        {
            Project project = projectServices.FindbyId(id, GlobalUser);
            Necessary necessary = CalculateNecessary(project);
            gunaBarDataset1.DataPoints.Add(project.Name, (double)necessary.Present);
            gcScatter.Update();

        }
        private void DeleteScatter(int id)
        {

            Project project = projectServices.FindbyId(id, GlobalUser);
            Necessary necessary = CalculateNecessary(project);
            foreach (LPoint lPoint in gunaBarDataset1.DataPoints)
            {
                if (lPoint.Label == project.Name)
                {
                    gunaBarDataset1.DataPoints.Remove(lPoint);
                    return;
                }
            }

        }
        private Necessary CalculateNecessary(Project project)
        {
            Necessary necesary = new Necessary();
            decimal SeriePresent = (decimal)SerieServices.FindByOption(x => x.ProjectId == project.Id && x.FlowType == FlowType.Entry.ToString()).Sum(x => x.Present) - (decimal)SerieServices.FindByOption(x => x.ProjectId == project.Id && x.FlowType == FlowType.Exit.ToString()).Sum(x => x.Present);
            decimal InterestPresent = (decimal)InterestServices.FindByOption(x => x.ProjectId == project.Id && x.FlowType == FlowType.Entry.ToString()).Sum(x => x.Present) - (decimal)InterestServices.FindByOption(x => x.ProjectId == project.Id && x.FlowType == FlowType.Exit.ToString()).Sum(x => x.Present);
            decimal AnnuityPresent = (decimal)AnnuityServices.FindByOption(x => x.ProjectId == project.Id && x.FlowType == FlowType.Entry.ToString()).Sum(x => x.Present) - (decimal)AnnuityServices.FindByOption(x => x.ProjectId == project.Id && x.FlowType == FlowType.Exit.ToString()).Sum(x => x.Present);
            decimal TotalPresent = (decimal)SeriePresent + InterestPresent + AnnuityPresent;
            TotalPresent = Math.Abs(TotalPresent);

            int totalPeriod = TotalPeriod(project);
            decimal rate = Rate(project);

            decimal ratepercent = (Convert.ToDecimal(rate) / 100);
            decimal rateYear = ((decimal)Math.Pow((double)(1 + ratepercent), totalPeriod));
            decimal TotalFuture = TotalPresent * rateYear;
            TotalFuture = Math.Round(Math.Abs(TotalFuture), 2);
            necesary.Present = TotalPresent;
            necesary.Future = TotalFuture;
            necesary.ProjectName = project.Name;
            necesary.Id = project.Id;
            necesary.rate = rate;
            necesary.totalPeriod = totalPeriod;
            return necesary;
        }
        private decimal Rate(Project project)
        {
            decimal Value = 0;

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
        public class Necessary
        {
            public decimal Present { get; set; }
            public decimal Future { get; set; }
            public string ProjectName { get; set; }
            public int Id { get; set; }
            public int totalPeriod { get; set; }
            public decimal rate { get; set; }
        }
        private void pbCompare_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
                e.Effect = DragDropEffects.Copy;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FADE_Tick(object sender, EventArgs e)
        {
            if (this.Opacity >= 1)
            {
                FadeIn.Stop();
            }
            this.Opacity += .2;
        }

        private void PbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void FormAnalyst_MouseDown(object sender, MouseEventArgs e)
        {
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pbCompare_DragOver(object sender, DragEventArgs e)
        {
            if (used)
                this.pbCompare.Image = Properties.Resources.flick_to_right;
           

            else
                this.pbCompare.Image = Properties.Resources.flick_to_left;
        }

        private void pbCompare_DragLeave(object sender, EventArgs e)
        {
            this.pbCompare.Image = Properties.Resources.notes__1_;
        }

        private void pbInterestInfomation_Click(object sender, EventArgs e)
        {
            if (ProjectIds.Count == 1)
            {
                MessageBox.Show("Debes de agregar más flujos de caja para poner hacer la conclusión.");
            }
            else
            {
                List<InterestInformation> interestInformation = new List<InterestInformation>();
                foreach(int id in ProjectIds)
                {
                    Necessary necessary = CalculateNecessary(projectServices.FindbyId(id, GlobalUser));
                    interestInformation.Add(new InterestInformation()
                    {
                        Name = necessary.ProjectName,
                        Present = necessary.Present
                    }) ;
                }
                FrmInformation frmInformation = new FrmInformation(2);
                frmInformation.interestInformations = interestInformation;
                frmInformation.ShowDialog();
            }
        }
    }
}
