using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercitacionArreglos
{
    public partial class ClaveIndex : Form
    {
        public ClaveIndex()
        {
            InitializeComponent();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btIngresar_Click(object sender, EventArgs e)
        {
            if (txUsuario.Text == "usuario" && txContraseña.Text == "1234")
            {
                Form form_Datos = new Datos();
                form_Datos.Show();

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

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            txUsuario.Text = "";
            txContraseña.Text = "";
        }
    }
}
