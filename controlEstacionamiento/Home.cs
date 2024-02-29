using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controlEstacionamiento
{
    public partial class Home : Form
    {
        
        public Home()
        {
            InitializeComponent();
            
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Desea salir de la aplicación?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            switch (dr)
            {
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
            }

        }//controlar la salida

        private void btn_sal_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }//boton salir

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }//cerrar la aplicación

        private void btn_tent_Click(object sender, EventArgs e)
        {
            TicketEntrada ventana3 = new TicketEntrada();
            ventana3.Show();

        }//ventana ticketentrada

        private void btn_tsal_Click(object sender, EventArgs e)
        {

            TicketSalida ventana4 = new TicketSalida();
            ventana4.Show();

        }//ventana ticketsalida

        private void btn_rep_Click(object sender, EventArgs e)
        {
            ReporteVentas ventana5 = new ReporteVentas();
            ventana5.Show();

        }//ventana reporte de ventas

        private void btn_est_Click(object sender, EventArgs e)
        {
            Estacionamientos ventana6 = new Estacionamientos();
            ventana6.Show();
        }//ventana estacionamientos
    }
}
