using Economy.AppCore.Helper;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static iTextSharp.awt.geom.Point2D;

namespace Economy.Forms
{
    public partial class ConclusionFNE : Form
    {
        double VPNFinanciamiento;
        double VPNSinFinanciamiento;
        double TIRFinanciamiento;
        double TIRSinFinanciamiento;
        double RazonBeneficioCostoFinanciamiento;
        double RazonBeneficioCostoSinFinanciamiento;

        public ConclusionFNE(double VPNFinanciamiento, double VPNSinFinanciamiento, double TIRFinanciamiento,
            double TIRSinFinanciamiento, double RazonBeneficioCostoFinanciamiento, double RazonBeneficioCostoSinFinanciamiento)
        {
            InitializeComponent();
            this.VPNFinanciamiento = Math.Round(VPNFinanciamiento, 2);
            this.VPNSinFinanciamiento = Math.Round(VPNSinFinanciamiento, 2);
            this.TIRFinanciamiento = TIRFinanciamiento;
            this.TIRSinFinanciamiento = TIRSinFinanciamiento;
            this.RazonBeneficioCostoFinanciamiento = RazonBeneficioCostoFinanciamiento;
            this.RazonBeneficioCostoSinFinanciamiento = RazonBeneficioCostoSinFinanciamiento;
        }


        #region -> form movement

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

        private void PbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConclusionFNE_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private string financiamientoCabecera()
        {
            return $"\n -> PROYECTO CON FINANCIAMIENTO";
        }

        private string sinFinanciamientoCabecera()
        {
            return $"\n -> PROYECTO SIN FINANCIAMIENTO";
        }

        private string sinFinanciamientoConclusion(double vpn, double tir)
        {
            return $"\n    Podemos observar que en la tabla de Flujo Neto De Efectivo (FNE) hay un Valor Presente Neto (VPN) de {vpn} " +
                VPNSinFinanciamientoConclusion(vpn) + $", Por otro lado tenemos a la Tasa Interna de Retorno (TIR) que tiene un valor de {tir}% " +
                TIRSinFinanciemientoConclusion(tir);
        }

        private string VPNSinFinanciamientoConclusion(double vpn)
        {
            if(vpn < 0)
            {
                return $"lo que nos indica que el VPN es negativo, lo que significa que tendremos perdidas asi que no es conveniente realizar esta inversion tomando en cuenta el VPN";
            }
            else if(vpn > 0)
            {
                return $"lo que nos indica que el VPN es positivo, lo que significa que tendremos ganancias, asi que es conveniente realizar esta inversion tomando en cuenta el VPN";
            }
            return $"lo que nos indica que el VPN es nulo, lo que significa es que la decision si invertir o no, es indiferente y depende de la desicion que tome el usuario, esto tomando en cuenta el VPN";
        }

        private string TIRSinFinanciemientoConclusion(double tir)
        {
            if(tir < FNEData.TasaInversionista)
            {
                return $"esto nos da a entender que el porcentaje de ganancia que obtenemos al realizar la inversion es menor al porcentaje que esperabamos, ya que nuestra tasa esperada era de {Math.Round(FNEData.TasaInversionista * 100, 2)}%, y la tasa que realmente obtenemos es de {tir}%";
            }
            else if(tir > FNEData.TasaInversionista)
            {
                return $"esto nos da a entender que el porcentaje de ganancia que obtenemos al realizar esta inversion es mayor al porcentaje que esperabamos, ya que nuestra tasa esperada era de {Math.Round(FNEData.TasaInversionista * 100, 2)}% y la tasa que realmente tenemos es de {tir}%";
            }
            return $"esto nos da a entender que el porcentaje de ganancia que obtenemos al realizar esta inversion es igual al porcentaje que esperabamos, ya que nuestra tasa esperada era de {Math.Round(FNEData.TasaInversionista * 100, 2)}% y la tasa que realmente tenemos es de {tir}%";
        }


        private string FinanciamientoConclusion(double vpn, double tir)
        {
            return $"\n    En la parte del proyecto con financiamiento podemos observar que en la tabla de Flujo Neto De Efectivo (FNE) hay un Valor Presente Neto (VPN) de {vpn} " +
                VPNFinanciamientoConclusion(vpn) + $", Por otro lado tenemos a la Tasa Interna de Retorno (TIR) que tiene un valor de {tir}% " +
                TIRFinanciemientoConclusion(tir);
        }

        private string VPNFinanciamientoConclusion(double vpn)
        {
            if (vpn < 0)
            {
                return $"lo que nos indica que el VPN es negativo, lo que significa que tendremos perdidas asi que no es conveniente realizar esta inversion tomando en cuenta el VPN";
            }
            else if (vpn > 0)
            {
                return $"lo que nos indica que el VPN es positivo, lo que significa que tendremos ganancias, asi que es conveniente realizar esta inversion tomando en cuenta el VPN";
            }
            return $"lo que nos indica que el VPN es nulo, lo que significa es que la decision si invertir o no, es indiferente y depende de la desicion que tome el usuario, esto tomando en cuenta el VPN";
        }

        private string TIRFinanciemientoConclusion(double tir)
        {
            if (tir < FNEData.TasaInversionista)
            {
                return $"esto nos da a entender que el porcentaje de ganancia que obtenemos al realizar la inversion es menor al porcentaje que esperabamos, ya que nuestra tasa esperada era de {Math.Round(FNEData.TasaInversionista * 100, 2)}%, y la tasa que realmente obtenemos es de {tir}%";
            }
            else if (tir > FNEData.TasaInversionista)
            {
                return $"esto nos da a entender que el porcentaje de ganancia que obtenemos al realizar esta inversion es mayor al porcentaje que esperabamos, ya que nuestra tasa esperada era de {Math.Round(FNEData.TasaInversionista * 100, 2)}% y la tasa que realmente tenemos es de {tir}%";
            }
            return $"esto nos da a entender que el porcentaje de ganancia que obtenemos al realizar esta inversion es igual al porcentaje que esperabamos, ya que nuestra tasa esperada era de {Math.Round(FNEData.TasaInversionista * 100, 2)}% y la tasa que realmente tenemos es de {tir}%";
        }

        private void ConclusionFNE_Load(object sender, EventArgs e)
        {
            printConclusion();
        }

        private void printConclusion()
        {
            if (VPNFinanciamiento == 0)
            {
                richTextBox1.Text = sinFinanciamientoCabecera() +
                                sinFinanciamientoConclusion(VPNSinFinanciamiento, TIRSinFinanciamiento);
                return;
            }
            richTextBox1.Text = sinFinanciamientoCabecera() +
                                sinFinanciamientoConclusion(VPNSinFinanciamiento, TIRSinFinanciamiento) +

                                financiamientoCabecera() +
                                FinanciamientoConclusion(VPNFinanciamiento, TIRFinanciamiento);
        }
    }
}
