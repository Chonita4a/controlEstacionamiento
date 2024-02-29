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
    public partial class ReporteVentas : Form
    {
        public ReporteVentas()
        {
            InitializeComponent();
        }

        private void ReporteVentas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bD_EstacionamientoDataSet.Registro' Puede moverla o quitarla según sea necesario.
            this.registroTableAdapter.Fill(this.bD_EstacionamientoDataSet.Registro);


        }
    }
}
