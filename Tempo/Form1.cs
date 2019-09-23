using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tempo
{
    public partial class frmTemporizador : Form
    {
        int min;
        int seg;
        int opcionElegida;
        public frmTemporizador()
        {
            InitializeComponent();
            customizeDesing();
        }
        private void customizeDesing()
        {
            pnlAtajos.Visible = false;
            btnPausar.Enabled = false;
        }

        #region Derivando y reduciendo codigo
        private void metodoIniciarRestablecer(int enMinutos, int enSegundos)
        {
            timer1.Start();
            btnIniciar.ForeColor = Color.Firebrick;
            btnPausar.Enabled = true;
            min = enMinutos;
            seg = enSegundos;
            btnIniciar.Text = "Restablecer";
        }
        private void metodoPausaIniciar()
        {
            timer1.Stop();
            min = 0;
            seg = 0;
            lblTiempo.Text = "00:00";
            btnIniciar.ForeColor = Color.ForestGreen;
            btnPausar.Enabled = false;
            btnPausar.ForeColor = Color.RoyalBlue;
            cbxSegundos.SelectedIndex = 0;
            cbxMinutos.SelectedIndex = 0;
            btnPausar.Text = "Pausar";
            btnIniciar.Text = "Iniciar";
        }

        #endregion

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmTemporizador_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 60; i++)
            {
                cbxMinutos.Items.Add(i);
                cbxSegundos.Items.Add(i);
            }
            cbxSegundos.SelectedIndex = 0;
            cbxMinutos.SelectedIndex = 0;
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            if (pnlCustom.Visible == true)
            {
                if (btnIniciar.Text == "Iniciar")
                    metodoIniciarRestablecer(cbxMinutos.SelectedIndex, cbxSegundos.SelectedIndex);

                else
                    metodoPausaIniciar();
            }
            else if (pnlAtajos.Visible == true)
            {
                if (btnIniciar.Text == "Iniciar")
                    metodoIniciarRestablecer(opcionElegida - 1, 60);
                else
                    metodoPausaIniciar();
            }
        }
        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            if (btnPausar.Text == "Pausar")
            {
                timer1.Stop();
                btnPausar.ForeColor = Color.DarkOrange;
                btnPausar.Text = "Reanudar";
            }
            else
            {
                timer1.Start();
                btnPausar.ForeColor = Color.RoyalBlue;
                btnPausar.Text = "Pausar";
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            seg -= 1;
            string minutos = min.ToString();
            string segundos = seg.ToString();

            if (min < 10) { minutos = "0" + min.ToString(); }
            if (seg < 10) { segundos = "0" + seg.ToString(); }

            if (seg == 0 && min > 0)
            {
                min -= 1;
                seg = 60;
            }
            if (min == 0 && seg <= 0)
            {
                timer1.Stop();
                if (MessageBox.Show("Se ha terminado el tiempo.", "Temporizador", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    cbxSegundos.SelectedIndex = 0;
                    cbxMinutos.SelectedIndex = 0;
                    lblTiempo.Text = "00:00";
                    btnPausar.Enabled = false;
                    btnPausar.ForeColor = Color.RoyalBlue;
                    btnPausar.Text = "Pausar";
                    btnIniciar.Text = "Iniciar";
                }
            }
            else
            {
                lblTiempo.Text = minutos + ":" + segundos;
            }
        }

        private void BtnAtajos_Click(object sender, EventArgs e)
        {
            if (pnlAtajos.Visible == false)
            {
                btnAtajos.Text = "Personalizado";
                pnlCustom.Visible = false;
                pnlAtajos.Visible = true;
            }
            else
            {
                btnAtajos.Text = "Atajos";
                pnlAtajos.Visible = false;
                pnlCustom.Visible = true;
            }
        }

        #region Elegir opcion
        private void RbtnUno_CheckedChanged(object sender, EventArgs e)
        {
            opcionElegida = 1;
        }
        private void RbtnDos_CheckedChanged(object sender, EventArgs e)
        {
            opcionElegida = 2;
        }

        private void RbtnTres_CheckedChanged(object sender, EventArgs e)
        {
            opcionElegida = 3;
        }

        private void RbtnOcho_CheckedChanged(object sender, EventArgs e)
        {
            opcionElegida = 8;
        }
        private void RbtnDiez_CheckedChanged(object sender, EventArgs e)
        {
            opcionElegida = 10;
        }
        #endregion

    }
}
