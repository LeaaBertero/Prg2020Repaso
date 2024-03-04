using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using repasoLista.Cls;


namespace repasoLista
{
    public partial class repaso : Form
    {
        //instanciando el objeto persona
        public repasoLista.Cls.Persona[] Personas { get; set; } = new repasoLista.Cls.Persona[2];
        public int posicion = 0;

        public repaso()
        {
            InitializeComponent();
        }

        private void btcargar_Click(object sender, EventArgs e)
        {
            repasoLista.Cls.Persona persona = new repasoLista.Cls.Persona();
            Personas[0].Nombre = txnombre.Text;
            Personas[0].añoNacimiento = Convert.ToInt32(txedad.Text);
            posicion = posicion + 1;
            Personas[posicion] = persona;
        }

        private void txmostrar_Click(object sender, EventArgs e)
        {
            foreach (Persona item in Personas)
            {
                lbLista.Text = "Lista de personas cargadas: " + "\r\n" + "\r\n"
                + "Nombre: " + Personas[0].Nombre + "\r\n"
                + "Año Nacimiento: " + Personas[0].añoNacimiento.ToString();
            }


            lbLista.Visible = true;
        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}
