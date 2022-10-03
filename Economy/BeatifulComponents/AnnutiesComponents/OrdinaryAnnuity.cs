using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Economy.BeatifulComponents.AnnutiesComponents
{
    public partial class OrdinaryAnnuity : UserControl
    {
        private int duration = 0;
        private string interest = "";
        private double pAO = 0;
        private string interestD = "";
        // Properties

        public int Duration
        {
            get => duration;
            set { duration = value; lbldurationD.Text = value.ToString(); lbldurationN.Text = value.ToString(); }
        }
        public string Interest
        {
            get => interest;
            set { interest = value;
            
                lblInterestN.Text = value;
                this.lbldurationN.Location = new Point(this.lblInterestN.Location.X * this.lblInterestN.Text.Length + 3, this.lbldurationN.Location.Y);
                this.lblNumber.Location = new Point(this.lblInterestN.Location.X + this.lblNumber.Location.X + 10, this.lblNumber.Location.Y);
                this.gbN.Size = new Size(this.lblInterestN.Size.Width + this.lbldurationN.Size.Width + 10 + lblNumber.Size.Width, this.gbN.Size.Height);
                this.panel1.Size = new Size(this.gbN.Width>this.gbD.Width ?this.gbN.Width + 2: this.gbD.Width + 2, this.panel1.Height);
                this.panel2.Size = new Size(this.panel1.Width + 2, this.panel2.Height);
                this.Size = new Size(this.lblP.Width + this.panel2.Width, this.Height);
                this.Invalidate(); }
        }
        public string InterestD
        {
            get => interestD;
            set { interestD = value;
                lblInterestD.Text = value;
                this.lbldurationD.Location = new Point((this.lblInterestD.Location.X * this.lblInterestD.Text.Length +6), this.lbldurationD.Location.Y);
                this.gbD.Size = new Size(this.lblInterestD.Width+10, this.gbD.Height);
                this.panel1.Size = new Size(this.gbN.Width > this.gbD.Width ? this.gbN.Width + 2 : this.gbD.Width + 2, this.panel1.Height);
                this.panel2.Size = new Size(this.panel1.Width + 2, this.panel2.Height);
                this.Size = new Size(this.lblP.Width + this.panel2.Width, this.Height);
                this.Invalidate();
            }
        }

        public double PAO
        {
            get=> pAO;
            set
            {
                pAO = value; this.lblP.Text = value.ToString() + "= "; this.Invalidate();
                this.panel2.Location = new Point(this.lblP.Width+10,this.panel2.Location.Y);
                this.Size = new Size(this.lblP.Width + this.panel2.Width, this.Height);
            }

        }
        public OrdinaryAnnuity()
        {
            InitializeComponent();
        }

        private void OrdinaryAnnuity_Load(object sender, EventArgs e)
        {

        }

        private void lblP_Click(object sender, EventArgs e)
        {

        }
    }
}
