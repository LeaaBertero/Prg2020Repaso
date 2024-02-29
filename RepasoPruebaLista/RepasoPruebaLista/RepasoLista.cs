using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepasoPruebaLista
{
    public partial class RepasoLista : Form
    {

        Persona persona = new Persona();
        string nombre = "nombre";

        public RepasoLista()
        {
            InitializeComponent();
        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btcargar_Click(object sender, EventArgs e)
        {
          
           
            if (txcnombreCarga.Text == "")
            {
                MessageBox.Show("No puede dejar campos vacios");
            }
            else
            {
                persona.Nombre = txcnombreCarga.Text;
                txcnombreCarga.Focus();
            }

        }

        private void btmostrar_Click(object sender, EventArgs e)
        {

            if (txcnombreCarga.Text == "")
            {
                MessageBox.Show("Error");
            }
            else
            {
                labellista.Text = "Lista de personas:" + "\r\n" + "\r\n" + nombre + " :" + persona.Nombre;
                //labellista.Text = persona.Nombre;
            }

           
        }

        private void btlimpiar_Click(object sender, EventArgs e)
        {
            if (txcnombreCarga.Text == "")
            {
                MessageBox.Show("No hay elementos para borrar");
            }
            else
            {
                txcnombreCarga.Text = "";
                labellista.Text = "";
            }

           
        }
    }
}
