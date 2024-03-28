using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiprimerArreglo
{
    public partial class PrimerArreglo : Form
    {
        public Persona[] personas = new Persona[1];
        int pos = 0;

        public PrimerArreglo()
        {
            InitializeComponent();
        }

        private void btCargar_Click(object sender, EventArgs e)
        {
          
            try
            {
                Persona persona = new Persona();

                persona.Nombre = txNombre.Text;
                persona.Edad = Convert.ToInt32(txEdad.Text);
                persona.Documento = Convert.ToInt64(txDocumento.Text);
                persona.Ciudad = txCiudad.Text;


                txNombre.Text = "";
                txEdad.Text = "";
                txDocumento.Text = "";
                txCiudad.Text = "";

                pos = pos + 1;
                personas[pos - 1] = persona;
            }
            catch (Exception)
            {
                MessageBox.Show("Límite completo");
                //throw;
            }
        }
        
        private void btCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btMostrar_Click(object sender, EventArgs e)
        {
            lbLista.Visible = true;
            lbLista.Text = "Lista de personas: "
                + "\r\n" + "\r\n"

                + "Nombre: " + " "
                + personas[0].Nombre + "\r\n"

                + "Edad: " + " "
                + personas[0].Edad + " " + "Años" + "\r\n"

                + "Documento: " + " "
                + personas[0].Documento + "\r\n"

                + "Ciudad: " + " "
                + personas[0].Ciudad; ;
        }
        private void btBorrar_Click(object sender, EventArgs e)
        {
            txNombre.Text = "";
            txEdad.Text = "";
            txDocumento.Text = "";
            txCiudad.Text = "";

            lbLista.Text = "";
        }
    }
}





