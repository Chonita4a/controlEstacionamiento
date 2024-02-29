using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controlEstacionamiento
{
    public partial class TicketEntrada : Form
    {
        public TicketEntrada()
        {
            DateTime dateTime = DateTime.Now;
            InitializeComponent();
            txt_fec.Text = dateTime.ToString();

            SqlConnection conexion = new SqlConnection("server=DESKTOP-A7CHIM7\\SQLEXPRESS; database=BD_Estacionamiento; integrated security=true");
            //conexion al servidor y a la base de datos

            conexion.Open();
            string consulta = "select * from estacionamiento";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataReader lector;
            lector = comando.ExecuteReader();

            if (lector.HasRows == true)
            {
                txt_dir.Text = "a";
            }
            else
            {
                MessageBox.Show("No se encontraron datos", "Error en la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conexion.Close();

        }
    }
}
