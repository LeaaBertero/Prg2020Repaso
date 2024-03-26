using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio
{
    public partial class EjercicioArreglo : Form
    {
        public Persona[] personas = new Persona[1];
        int pos = 0;
        public EjercicioArreglo()
        {
            InitializeComponent();
        }

        private void btCargar_Click(object sender, EventArgs e)
        {
            try
            {
                Persona persona = new Persona();

                persona.Nombre = txNombre.Text;
                persona.Materia = txMateria.Text;
                persona.Año = Convert.ToInt32(txAño.Text);

                txNombre.Text = "";
                txMateria.Text = "";
                txAño.Text = "";

                pos = pos + 1;
                personas[pos - 1] = persona;
            }
            catch (Exception)
            {

                MessageBox.Show("no puede dejar los campos vacios");
            }
        }

        private void btMostrar_Click(object sender, EventArgs e)
        {
            lbLista.Text = "Lista de personas cargadas: " + "\r\n" + "\r\n"
                + "Nombre: " + personas[0].Nombre + "\r\n"
                + "Materia: " + personas[0].Materia + "\r\n"
                + "Año: " + personas[0].Año;

            lbLista.Visible = true;
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
