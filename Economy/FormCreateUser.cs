using Economy.AppCore.Helper;
using Economy.AppCore.IServices;
using Economy.Domain.Entities;
using Economy.Domain.Entities.API_Object;
using Economy.Forms;
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

namespace Economy
{
    public partial class FormCreateUser : Form
    {

        private Email email;
        private Number number;
        public IUsersServices UsersServices { get; set; }
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
        public FormCreateUser()
        {
            InitializeComponent();

            email = new Email();
            number = new Number();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void customPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.UsersServices = this.UsersServices;
            formLogin.ShowDialog();
        }

        private bool ValidateUtil()
        {
            bool succes = true ? Validations.VerificationNumberAndEmail(number, email) > 0 : false;

            if (succes)
            {
                return true;
            }
            if (number.valid == false)
            {
                lblPhoneNE.Visible = true;
                return false;
            }
            if (email.syntax_valid == false)
            {
                lblEmailNE.Visible = true;
                return false;
            }
            return false;
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                Validations.ValidateEmptyFields(txtName.Texts, txtPassword.Texts, txtEmail.Texts, txtPhone.Texts);
                Task.Run(RequestEmailVerification).Wait();
                Task.Run(RequestNumberVerification).Wait();
                if (ValidateUtil())
                {

                    User user = new User()
                    {
                        Name = txtName.Texts,
                        Password = txtPassword.Texts,
                        Email = txtEmail.Texts,
                        Phone = txtPhone.Texts
                    };
                    bool succes = true ? UsersServices.Create(user) > 0 : false;

                    if (succes)
                    {
                        MessageBox.Show("The user has been successfully created", "User created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        return;
                    }
                    MessageBox.Show("An error occurred when creating the user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task RequestEmailVerification()
        {
            email = await UsersServices.ValidationEmailAsync(txtEmail.Texts);
        }
        private async Task RequestNumberVerification()
        {
            number = await UsersServices.ValidationNumberAsync($"505{txtPhone.Texts}");
        }

        private void PbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
