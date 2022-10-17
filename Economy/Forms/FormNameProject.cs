using Appcore.Interface;
using Economy.AppCore.IServices;
using Economy.Domain.Entities;
using Economy.Domain.Enums;
using Proto1._0;
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
    public partial class FormNameProject : Form
    {

        public IProjectServices projectServices { get; set; }

        public User GlobalUser;
        public int projectType { get; set; }
        private Dictionary<string, Color> ProjectColor = new Dictionary<string, Color>();
        private Dictionary<string, string> ProjectDescription = new Dictionary<string, string>();

        public bool create = false;
      
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

        public FormNameProject()
        {
            InitializeComponent();
        }

        private void PbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtProjectName__TextChanged(object sender, EventArgs e)
        {
            int count = txtProjectName.Texts.Length;

            if (count <= 20)
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

        private void FormNameProject_Load(object sender, EventArgs e)
        {
            DictionaryProjectColor();
            DictionaryProjectDescription();
            lblTypeProject.Text = ProjectDescription[((TypeProject)projectType).ToString()];
            lblTypeProject.ForeColor = ProjectColor[((TypeProject)projectType).ToString()];

        }
        public Project Project { get; set; }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtProjectName.Texts == "")
            {
                MessageBox.Show("Rellene el formulario.");
                return;
            }
            else if (txtProjectName.Texts.Length > 20)
            {
                MessageBox.Show("El nombre del proyecto tiene que tener 20 letras.");
                return;
            }
          
                Project project = new Project()
                {
                    Name = txtProjectName.Texts,
                    Creation = DateTime.Now,
                    Type = ((TypeProject)projectType).ToString(),
                    User = GlobalUser,
                    UserId = GlobalUser.Id
                };
                projectServices.Create(project);
                Project = project;
            create = true;
                this.Close();
            
        }

        private void txtProjectName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                this.btnCreate_Click(null, null);
            }
        }
    }
}
