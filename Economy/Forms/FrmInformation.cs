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
    public partial class FrmInformation : Form
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
        private int type;
        public List<InterestInformation> interestInformations { get; set; }
        public class InterestInformation
        {
            public decimal Present { get; set; }
            public string Name { get; set; }

            public int NumberInterests { get; set; }
        }
        public FrmInformation(int Type)
        {
            this.type = Type;
            InitializeComponent();
        }
        private void AddInterestInformation()
        {
            rtbInformation.SelectionColor = Color.Black;
            rtbInformation.AppendText("\n \n Anualidad: ");
            rtbInformation.SelectionColor = Color.DimGray;
            rtbInformation.AppendText("Significa que los pagos serán constantes.\nPor ejemplo: año 1: 1000, año 2: 1000, año 3: 1000 \n \n \n ");

            rtbInformation.SelectionColor = Color.Black;
            rtbInformation.AppendText("Series: ");
            rtbInformation.SelectionColor = Color.DimGray;
            rtbInformation.AppendText("Significa que los pagos tendrán incrementos o decrementos monetarios o porcentuales. \nPor ejemplo: Aumento de 50 unidades monetarias: \nAño 1: 1000, año 2: 1050, año 3: 1100 \n \n \n ");


            rtbInformation.SelectionColor = Color.Black;
            rtbInformation.AppendText("Interés: ");
            rtbInformation.SelectionColor = Color.DimGray;
            rtbInformation.AppendText("Significa que es un único pago y no varios pagos. \nPor ejemplo: año 1: 20,000 ");



        }
        private void InterestInformationAscConclusion()
        {
            rtbInformation.AppendText($"\n \nEl análisis correspondiente a los: ");

            rtbInformation.SelectionColor = Color.Black;
            rtbInformation.AppendText($"{interestInformations.Count} ");
            rtbInformation.SelectionColor = Color.DimGray;
            rtbInformation.AppendText("Flujos de caja, indica que: ");

            rtbInformation.SelectionColor = Color.Black;
            rtbInformation.AppendText($"{interestInformations.OrderBy(x=>x.Present).FirstOrDefault().Name} ");
            rtbInformation.SelectionColor = Color.DimGray;
            rtbInformation.AppendText("Teniendo un valor presente de: ");

            rtbInformation.SelectionColor = Color.Black;
            rtbInformation.AppendText($"{interestInformations.OrderBy(x => x.Present).FirstOrDefault().Present} ");

            rtbInformation.SelectionColor = Color.DimGray;
            rtbInformation.AppendText("Nos resulta más barato y más eficiente");
            rtbInformation.SelectionColor = Color.Black;
            rtbInformation.AppendText($"\nPromedio de los presentes: ");
            rtbInformation.SelectionColor = Color.DimGray;
            rtbInformation.AppendText($"{interestInformations.Sum(x=>x.Present)*1.0M/interestInformations.Count}");
        }
        private void InterestInformationDescConclusion()
        {
            rtbInformation.AppendText($"\n \nEl análisis correspondiente a los: ");

            rtbInformation.SelectionColor = Color.Black;
            rtbInformation.AppendText($"{interestInformations.Count} ");
            rtbInformation.SelectionColor = Color.DimGray;
            rtbInformation.AppendText("Flujos de caja, indica que: ");

            rtbInformation.SelectionColor = Color.Black;
            rtbInformation.AppendText($"{interestInformations.OrderByDescending(x => x.Present).FirstOrDefault().Name} ");
            rtbInformation.SelectionColor = Color.DimGray;
            rtbInformation.AppendText("Teniendo un valor presente de: ");

            rtbInformation.SelectionColor = Color.Black;
            rtbInformation.AppendText($"{interestInformations.OrderByDescending(x => x.Present).FirstOrDefault().Present} ");

            rtbInformation.SelectionColor = Color.DimGray;
            rtbInformation.AppendText("Nos resulta mejor y más eficiente");
            rtbInformation.SelectionColor = Color.Black;
            rtbInformation.AppendText($"\nPromedio de los presentes: ");
            rtbInformation.SelectionColor = Color.DimGray;
            rtbInformation.AppendText($"{interestInformations.Sum(x => x.Present) * 1.0M / interestInformations.Count}");
        }
        private void FrmInformation_Load(object sender, EventArgs e)
        {
            ToolTip toolTipClipBoard = new ToolTip();
            toolTipClipBoard.SetToolTip(this.pbClipBoard, "Copiar información");
            if (type == 1)
            {
                AddInterestInformation();
            }
            else if (type == 2)
            {
                lblIntruction.Visible = true;
                cbIntruction.Visible = true;
                InterestInformationAscConclusion();
            }
        }

        #region -> form movement

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

        private void FrmInformation_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbClipBoard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtbInformation.Text);
        }

        private void cbIntruction_CheckedChanged(object sender, EventArgs e)
        {
            if (cbIntruction.Checked)
            {
                rtbInformation.Clear();
                InterestInformationAscConclusion();
            }
            else
            {
                rtbInformation.Clear();
                InterestInformationDescConclusion();
            }
        }
    }
}
