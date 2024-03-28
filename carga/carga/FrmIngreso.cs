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
                CargaLista.Show();

                txUsuario.Text = "";
                txContraseña.Text = "";

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
    }
}
