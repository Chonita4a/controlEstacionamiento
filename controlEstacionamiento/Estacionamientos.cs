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
    public partial class Estacionamientos : Form
    {
        public Estacionamientos()
        {
            InitializeComponent();
        }

        private void Estacionamientos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bD_EstacionamientoDataSet1.Estacionamiento' Puede moverla o quitarla según sea necesario.
            this.estacionamientoTableAdapter.Fill(this.bD_EstacionamientoDataSet1.Estacionamiento);

        }
    }
}
