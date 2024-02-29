using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace controlEstacionamiento
{
    public partial class FrmLogin : Form
    {
        bool zz = false; //variable de validación

        public FrmLogin()
        {
            InitializeComponent();
            
        }

        SqlConnection conexion = new SqlConnection("server=DESKTOP-A7CHIM7\\SQLEXPRESS; database=BD_Estacionamiento; integrated security=true");
        //conexion al servidor y a la base de datos

        

        private void btn_ini_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string consulta = "select * from usuario where usuario='"+txt_usu.Text+"' and contraseña='"+txt_pas.Text+"'";
            SqlCommand comando = new SqlCommand(consulta,conexion);
            SqlDataReader lector;
            lector=comando.ExecuteReader();

            if (txt_usu.Text.Length == 0 || txt_pas.Text.Length == 0) {

                MessageBox.Show("Debes rellenar los campos antes de continuar","Error de ingreso",MessageBoxButtons.OK,MessageBoxIcon.Warning);

            }
            else if(lector.HasRows == true){

                zz = true;
                Home ventana2 = new Home();
                this.Close();
                ventana2.Show();
            }
            else
            { 
                MessageBox.Show("Usuario y/o contraseña incorrectos","Error de autenticación",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }conexion.Close();
            

        }//boton iniciar sesion

        private void btn_can_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }//boton salir de la aplicación



        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (zz == false)
            {
                Application.Exit();
            }
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (zz == false)
            {
                DialogResult dr = MessageBox.Show("¿Desea salir de la aplicación?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                switch (dr)
                {
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            }
            
        }
    }
}
