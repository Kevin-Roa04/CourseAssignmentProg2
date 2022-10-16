using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Economy.BeatifulComponents
{
    public partial class ProjectComponent : Panel
    {
        // Fields
        private int borderRadius = 30;
        private string letter = "";
        private string description = "";
        private string nameProject = "";
        private int fontDescription = 10;
        private int fontLetter = 30;

        // Labels
        public Label LabelDescription;
        public Label LabelLetter;
        public Label LabelNameProject;

        public ProjectComponent()
        {
            
            this.Cursor = Cursors.Hand;
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
            this.Size = new Size(150, 150);
            this.LabelDescription = new Label();
            this.LabelDescription.Size = new Size(12, 12);
            this.LabelDescription.Cursor = Cursors.Hand;
            this.LabelDescription.Location = new Point((int)(this.Width * .5), (int)(this.Height * .7));
            this.LabelDescription.Font = new Font(this.Font.FontFamily, fontDescription, FontStyle.Regular, GraphicsUnit.Pixel);
            this.LabelDescription.ForeColor = Color.Black;
            this.LabelDescription.AutoSize = true;


            this.LabelLetter = new Label();
            this.LabelLetter.Size = new Size(12, 12);
            this.LabelLetter.Location = new Point((int)(this.Width * .5), (int)(this.Height * .5));
            this.LabelLetter.Font = new Font(this.Font.FontFamily, fontLetter, FontStyle.Bold, GraphicsUnit.Pixel);
            this.LabelLetter.ForeColor = Color.Black;
            this.LabelLetter.AutoSize = true;
            this.LabelLetter.Cursor = Cursors.Hand;

            this.LabelNameProject = new Label();
            this.LabelNameProject.Size = new Size(12, 12);
            this.LabelNameProject.Location = new Point((int)(this.Width * .5), (int)(this.Height * .3));
            this.LabelNameProject.Font = new Font(this.Font.FontFamily, 10, FontStyle.Regular, GraphicsUnit.Pixel);
            this.LabelNameProject.ForeColor = Color.Black;
            this.LabelNameProject.AutoSize = true;
            this.LabelNameProject.Cursor = Cursors.Hand;

            this.Controls.Add(LabelNameProject);
            this.Controls.Add(LabelLetter);
            this.Controls.Add(LabelDescription);
        }

        // Properties
        public int FontDescription
        {
            get => fontDescription;
            set { fontDescription = value;
                LabelDescription.Font= new Font(this.Font.FontFamily, fontDescription, FontStyle.Regular, GraphicsUnit.Pixel);
                LabelDescription.Location = new Point((int)((this.Width - LabelDescription.Width) * .5), (int)((this.Height - LabelDescription.Height) * .7));
                this.Invalidate(); }
        }
        public int FontLetter
        {
            get => fontLetter;
            set { fontLetter = value; this.Invalidate(); 
                LabelLetter.Font = new Font(this.Font.FontFamily, fontLetter, FontStyle.Bold, GraphicsUnit.Pixel);
                LabelLetter.Location = new Point((int)((this.Width - LabelLetter.Width) * .5), (int)((this.Height - LabelLetter.Height) * .5));
                this.Invalidate();
            }
        }
        public int BorderRadius
        {
            get => borderRadius;
            set { borderRadius = value; this.Invalidate(); }
        }
        public string Letter
        {
            get => letter; set { letter = value; LabelLetter.Text = value; LabelLetter.Location = new Point((int)((this.Width - LabelLetter.Width) * .5), (int)((this.Height - LabelLetter.Height) * .5)); this.Invalidate(); }
        }
        public string NameProject
        {
            get => nameProject;
            set { nameProject = value; LabelNameProject.Text = value; LabelNameProject.Location = new Point((int)((this.Width - LabelNameProject.Width) * .5), (int)((this.Height - LabelLetter.Height) * .3)); this.Invalidate(); }
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
        }


        public string Description { get => description; set { description = value; LabelDescription.Text = value; LabelDescription.Location = new Point((int)((this.Width - LabelDescription.Width) * .5), (int)((this.Height - LabelDescription.Height) * .7)); this.Invalidate(); } }
        //Methods

        private GraphicsPath GetCustomPanelPath(RectangleF rectangle, float radius)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.StartFigure();
            graphicsPath.AddArc((rectangle.Width - radius), rectangle.Height - radius, radius, radius, 0, 90);
            graphicsPath.AddArc(rectangle.X, (rectangle.Height - radius), radius, radius, 90, 90);
            graphicsPath.AddArc(rectangle.X, rectangle.Y, radius, radius, 180, 90);
            graphicsPath.AddArc((rectangle.Width - radius), rectangle.Y, radius, radius, 270, 90);
            graphicsPath.CloseFigure();
            return graphicsPath;
        }

        // Overriden Method

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Gradient 

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Graphics graphicCustomPanel = e.Graphics;

            //  e.Graphics.DrawString(letter, this.Font,
            //  Brushes.White, Convert.ToSingle((this.Size.Width * .5) - this.Font.Size + 10), Convert.ToSingle((this.Size.Height * .5)) - this.Font.Size + 1);

            // e.Graphics.DrawString(description, new Font(this.Font.FontFamily, 10, FontStyle.Bold,GraphicsUnit.Pixel), Brushes.White, (float)(this.Size.Width*.5)-this.description.Length, (float)(this.Height * .7));
            // BorderRadius
            LabelDescription.Location = new Point((int)((this.Width - LabelDescription.Width) * .5), (int)((this.Height - LabelDescription.Height) * .7));
            LabelLetter.Location = new Point((int)((this.Width - LabelLetter.Width) * .5), (int)((this.Height - LabelLetter.Width) * .5));
            LabelNameProject.Location = new Point((int)((this.Width - LabelNameProject.Width) * .5), (int)((this.Height - LabelLetter.Height) * .3));
            RectangleF rectangleF = new RectangleF(0, 0, this.Width, this.Height);

            if (borderRadius > 2)
            {
                using (GraphicsPath graphicsPath = GetCustomPanelPath(rectangleF, borderRadius))
                using (Pen pen = new Pen(this.Parent.BackColor, 2))
                {
                    this.Region = new Region(graphicsPath);
                    e.Graphics.DrawPath(pen, graphicsPath);
                }

            }
            else this.Region = new Region(rectangleF);

        }
    }
}