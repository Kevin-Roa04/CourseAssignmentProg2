using Economy.AppCore.IServices;
using Economy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Economy.Forms
{

    public partial class FormLogin : Form
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
        public IUsersServices UsersServices { get; set; }
        private User User;
        public FormLogin(IUsersServices services)
        {
            this.UsersServices = services;
            InitializeComponent();
        }
        public FormLogin()
        {
            InitializeComponent();
        }

        #region -> form movement

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion
        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private bool ValidateForm()
        {
            if(string.IsNullOrEmpty(txtName.Texts) || String.IsNullOrEmpty(txtPassword.Texts))
            {
                return false;
            }
            return true;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {

            this.Hide();
            FormCreateUser formCreateUser = new FormCreateUser();
            formCreateUser.UsersServices = this.UsersServices;
            formCreateUser.ShowDialog();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                MessageBox.Show("Fill in the entire form, please");
                return;
            }

            User user = UsersServices.Registration(txtName.Texts, txtPassword.Texts);
            if (user == null)
            {
                MessageBox.Show("User is not registered");
                return;
            }
            else
            {
                User = user;

            }
        }
    }
}
