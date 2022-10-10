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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Economy.Forms
{
    public partial class FormAnalyst : Form
    {


        public IProjectServices projectServices { get; set; }
        public int GlobalUser;
        public List<int> ProjectIds = new List<int>();
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
            foreach (Project project in projectServices.GetProjectByUser(GlobalUser).Where(x=>x.Type== "InterestWithGraph"))
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
                
                Tooltip = $"Presente: {necessary.Present}, Futuro: {necessary.Future}, Periodos: {necessary.totalPeriod} ${project.Period}";
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

        private void ProjectComponent_MouseDown(object sender, MouseEventArgs e)
        {
            int id = -1;
            try
            {
               id = projectServices.FindbyId((int)Convert.ToUInt64((sender as Label).Tag.ToString()), GlobalUser).Id;
                (sender as Label).DoDragDrop(id, DragDropEffects.Copy);
            }
            catch
            {
                id=projectServices.FindbyId((int)Convert.ToUInt64((sender as ProjectComponent).Tag.ToString()), GlobalUser).Id;
                (sender as ProjectComponent).DoDragDrop(id, DragDropEffects.Copy);
            }
        }

        private void FormAnalyst_Load(object sender, EventArgs e)
        {
            this.pbCompare.AllowDrop = true;
            gcScatter.Datasets.Add(gunaScatterDataset1);
            gcScatter.Legend.Display = false;
            this.lblFuture.TextAlign = ContentAlignment.TopLeft;
            this.flpUsedProject.Controls.Add(Project(projectServices.FindbyId(ProjectIds[0], GlobalUser)));
            DrawScatter(ProjectIds[0]);
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
            foreach (Project project in projectServices.GetProjectsByName(name, GlobalUser).Where(x=>x.Type== "InterestWithGraph"))
            {
                ProjectComponent projectComponent = new ProjectComponent()
                {
                    NameProject = project.Name,
                    Description = "Interés y gráfica",
                    Letter ="IG",
                    BackColor = Color.FromArgb(224, 239, 255),
                    BorderRadius = 16,
                    Tag = project.Id
                };
                Necessary necessary = CalculateNecessary(project);
                string Tooltip = "";

                Tooltip = $"Presente: {necessary.Present}, Futuro: {necessary.Future}, Periodos: {necessary.totalPeriod} ${project.Period}";
                System.Windows.Forms.ToolTip tooltip = new ToolTip();
                tooltip.SetToolTip(projectComponent, Tooltip);
                projectComponent.AllowDrop = true;
                projectComponent.Size = new Size(130, 130);
                projectComponent.LabelDescription.Tag = project.Id;
                projectComponent.LabelDescription.MouseDown += ProjectComponent_MouseDown;
                projectComponent.LabelLetter.Tag = project.Id;
                projectComponent.LabelLetter.MouseDown += ProjectComponent_MouseDown;
                projectComponent.LabelNameProject.Tag = project.Id;
                projectComponent.LabelNameProject.MouseDown += ProjectComponent_MouseDown;
                flpProjects.Controls.Add(projectComponent);
            }
        }

        private void pbCompare_DragDrop(object sender, DragEventArgs e)
        {
            var objects = e.Data.GetData(typeof(int));

            if (!ProjectIds.Any(x=>x==((int)objects)))
            {
                ProjectIds.Add((int)objects);
                this.flpUsedProject.Controls.Add(Project(projectServices.FindbyId((int)objects, GlobalUser)));
                DrawScatter((int)objects);
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

            Tooltip = $"Presente: {necessary.Present}, Futuro: {necessary.Future}, Periodos: {necessary.totalPeriod} ${project.Period}";
            System.Windows.Forms.ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(projectComponent, Tooltip);
            projectComponent.AllowDrop = true;
            projectComponent.Size = new Size(115, 115);
            projectComponent.LabelDescription.Tag = project.Id;
            projectComponent.LabelLetter.Tag = project.Id;
            projectComponent.LabelNameProject.Tag = project.Id;
            return projectComponent;
        }
        private void DrawScatter(int id)
        {
            Project project = projectServices.FindbyId(id, GlobalUser);
            Necessary necessary = CalculateNecessary(project);
            gunaScatterDataset1.DataPoints.Add(new ScatterPoint((double)necessary.Present, (double)necessary.Future));
            gc.Update();

        }
        private Necessary CalculateNecessary(Project project)
        {
            Necessary necesary = new Necessary(); 
            decimal SeriePresent = (decimal)SerieServices.FindByOption(x => x.ProjectId == project.Id&& x.FlowType == FlowType.Entry.ToString()).Sum(x => x.Present) - (decimal)SerieServices.FindByOption(x => x.ProjectId == project.Id&& x.FlowType == FlowType.Exit.ToString()).Sum(x => x.Present);
            decimal InterestPresent = (decimal)InterestServices.FindByOption(x => x.ProjectId == project.Id&& x.FlowType == FlowType.Entry.ToString()).Sum(x => x.Present) - (decimal)InterestServices.FindByOption(x => x.ProjectId ==project.Id && x.FlowType == FlowType.Exit.ToString()).Sum(x => x.Present);
            decimal AnnuityPresent = (decimal)AnnuityServices.FindByOption(x => x.ProjectId == project.Id&& x.FlowType == FlowType.Entry.ToString()).Sum(x => x.Present) - (decimal)AnnuityServices.FindByOption(x => x.ProjectId == project.Id&& x.FlowType == FlowType.Exit.ToString()).Sum(x => x.Present);
            decimal TotalPresent = (decimal)SeriePresent + InterestPresent + AnnuityPresent;
            TotalPresent = Math.Abs(TotalPresent);

            int totalPeriod = TotalPeriod(project);
            decimal rate = Rate(project);

            decimal ratepercent = (Convert.ToDecimal(rate) / 100);
            decimal rateYear = ((decimal)Math.Pow((double)(1 + ratepercent), totalPeriod));
            decimal TotalFuture = TotalPresent * rateYear;
            TotalFuture = Math.Round(Math.Abs(TotalFuture),2);
            necesary.Present = TotalPresent;
            necesary.Future = TotalFuture;
            necesary.ProjectName=project.Name;
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
            public decimal Future {get;set;}
            public string ProjectName {get;set;}
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
            if (this.Opacity == 1)
            {
                FadeIn.Stop();
            }
            this.Opacity += .2;
        }
    }
}
