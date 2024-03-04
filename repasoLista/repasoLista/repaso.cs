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
        public repasoLista.Cls.Persona personas = new repasoLista.Cls.Persona();

        public repaso()
        {
            InitializeComponent();
        }

        private void btcargar_Click(object sender, EventArgs e)
        {
            personas.Nombre = txnombre.Text;
            personas.añoNacimiento = Convert.ToInt32(txedad.Text);
        }

        private void txmostrar_Click(object sender, EventArgs e)
        {
            lbLista.Text = "Lista de personas cargadas: " + "\r\n" + "\r\n" + "Nombre: " + personas.Nombre + "\r\n" + "Año Nacimiento: " + personas.añoNacimiento.ToString();
            lbLista.Visible = true;
        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
