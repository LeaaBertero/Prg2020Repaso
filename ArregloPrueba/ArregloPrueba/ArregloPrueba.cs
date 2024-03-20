using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArregloPrueba
{
    public partial class ArregloPrueba : Form
    {
        public Persona[] personas = new Persona[3];
        public int pos = 0;

        public ArregloPrueba()
        {
            InitializeComponent();
        }

        private Label GetTxedad()
        {
            return txedad;
        }

        private void btCargar_Click(object sender, EventArgs e)
        {
            try
            {
                Persona persona = new Persona();

                persona.Nombre = txnombre.Text;
                persona.Barrio = txbarrio.Text;
                persona.Localidad = txlocalidad.Text;
                //persona.Edad = Convert.ToInt32(txedad.Text);

                txnombre.Text = "";
                txbarrio.Text = "";
                txlocalidad.Text = "";
                //txedad.Text = "";
                pos = pos + 1;
                personas[pos - 1] = persona;
            }
            catch (Exception)
            {

                MessageBox.Show("Límite completo");
            }
        }


        private void btMostrar_Click(object sender, EventArgs e)
        {

            foreach (Persona item in personas)
            {
                lbLista.Text = "Lista de personas: " + "\r\n" + "\r\n" +
              "Nombre: " + " " + personas[0].Nombre + "\r\n" +
              "Barrio: " + " " + personas[0].Barrio + "\r\n" +
              "Localidad: " + " " + personas[0].Localidad + "\r\n" + "\r\n" +
              "Nombre: " + " " + personas[1].Nombre + "\r\n" +
              "Barrio: " + " " + personas[1].Barrio + "\r\n" +
              "Localidad: " + " " + personas[1].Localidad + "\r\n" + "\r\n" +
              "Nombre: " + " " + personas[2].Nombre + "\r\n" +
              "Barrio: " + " " + personas[2].Barrio + "\r\n" +
              "Localidad: " + " " + personas[2].Localidad;
            }

            lbLista.Visible = true;
        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
