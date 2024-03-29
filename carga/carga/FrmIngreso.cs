using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace carga
{
    public partial class FrmIngreso : Form
    {
        public FrmIngreso()
        {
            InitializeComponent();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btIngresar_Click(object sender, EventArgs e)
        {
            if (txUsuario.Text == "usuario" && txContraseña.Text == "1234")
            {
                Form CargaLista = new CargaListaPers();
                CargaLista.ShowDialog();

                txUsuario.Text = "";
                txContraseña.Text = "";

                //MessageBox.Show("Usuario correcto, felicitaciones!!" + "\r\n" + "Ingresando..." ) ;

            }
            else if (txUsuario.Text == "" || txContraseña.Text == "")
            {
                MessageBox.Show("Complete todos los datos requeridos");
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }


        }

        private void txLimpiar_Click(object sender, EventArgs e)
        {
            txUsuario.Text = "";
            txContraseña.Text = "";
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txUsuario_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Ingreso correcto");
            if (txUsuario.Text == "1")
            {
                MessageBox.Show("No se adminten números");
            }

            if (txUsuario.Text == "2")
            {
                MessageBox.Show("No se adminten números");
            }

            if (txUsuario.Text == "3")
            {
                MessageBox.Show("No se adminten números");
            }

            if (txUsuario.Text == "4")
            {
                MessageBox.Show("No se adminten números");
            }

            if (txUsuario.Text == "5")
            {
                MessageBox.Show("No se adminten números");
            }

            if (txUsuario.Text == "6")
            {
                MessageBox.Show("No se adminten números");
            }

            if (txUsuario.Text == "7")
            {
                MessageBox.Show("No se adminten números");
            }

            if (txUsuario.Text == "8")
            {
                MessageBox.Show("No se adminten números");
            }

            if (txUsuario.Text == "9")
            {
                MessageBox.Show("No se adminten números");
            }

            if (txUsuario.Text == "0")
            {
                MessageBox.Show("No se adminten números");
            }

            if (txUsuario.Text == "?")
            {
                MessageBox.Show("No se adminten caracteres especiales");
            }

            if (txUsuario.Text == "'")
            {
                MessageBox.Show("No se adminten caraceres especiales");
            }

            if (txUsuario.Text == "¿")
            {
                MessageBox.Show("No se admiten caracteres especiales");
            }
        }
    }
}
