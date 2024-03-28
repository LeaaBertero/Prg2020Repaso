using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carga
{
    public partial class CargaListaPers : Form
    {
        Persona[] Personas = new Persona[1];
        int pos = 0;

        public CargaListaPers()
        {
            InitializeComponent();
        }


        private void btCargar_Click(object sender, EventArgs e)
        {
            try
            {
                Persona persona = new Persona();


                persona.Nombre = txNombre.Text;
                persona.Apellido = txApellido.Text;
                persona.Documento = Convert.ToInt64(txDocumento.Text);
                persona.Cuil = Convert.ToInt64(txCuil.Text);

                txNombre.Focus();
                txNombre.SelectAll();

                txNombre.Text = "";
                txApellido.Text = "";
                txDocumento.Text = "";
                txCuil.Text = "";

                pos = pos + 1;
                Personas[pos - 1] = persona;


            }
            catch (Exception)
            {

                MessageBox.Show("No puede dejar campos vacios, complete los campos requeridos");
            }
        }

        private void btMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                lbLista.Visible = true;

                lbLista.Text = "Lista de personas cargadas: " + "\r\n" + "\r\n"
                    + "Nombre: " + Personas[0].Nombre + "\r\n"
                    + "Apellido: " + Personas[0].Apellido + "\r\n"
                    + "Documento: " + Personas[0].Documento + "\r\n"
                    + "Cuil: " + Personas[0].Cuil;
            }
            catch (Exception)
            {
                lbLista.Visible = false;
                MessageBox.Show("No hay nada que mostrar, complete los campos solicitados");
            }

        }
        private void btsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
