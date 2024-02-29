using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
        string nombre = "Nombre";

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
            else if (txcnombreCarga.Text == txcnombreCarga.Text)
            {
                labellista.Visible = true;
                labellista.Text = "Lista de personas:" + "\r\n" + "\r\n" + nombre + ": " + persona.Nombre + "\r\n" + "\r\n" + "Para cargar, presione el botón!!";
                //labellista.Text = persona.Nombre;
                labellista.BackColor = Color.Black;
            }
            else
            {
                labellista.Visible = true;
                labellista.Text = "Lista de personas:" + "\r\n" + "\r\n" + nombre + ": " + persona.Nombre + "\r\n" + "\r\n" + "Operación realizada con éxito";
                //labellista.Text = persona.Nombre;
                labellista.BackColor = Color.Black;
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
