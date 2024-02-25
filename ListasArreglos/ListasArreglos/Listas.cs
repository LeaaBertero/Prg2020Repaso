using ListasArreglos.PersonaCls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListasArreglos
{
    public partial class Listas : Form
    {
        //{ get; set; } <-. (Puede estar o no en la instancia de un objeto)
        //no genera error si no está
        public PersonaCls.Persona[] Personas { get; set; } = new PersonaCls.Persona[2];
        int posicion = -1;


        public Listas()
        {
            InitializeComponent();
        }

        //método para dimensionar la cantidad de nombres
        private void btDimension_Click(object sender, EventArgs e)
        {

        }

        //método para cargar una lista de nombres
        private void btcargar_Click(object sender, EventArgs e)
        {
            //clase - variable --Instancia(Hace nacer un objeto)
            //la sintaxis es lo mismo que llamar a un formulario
            //desde otro formulario.
            Persona persona = new PersonaCls.Persona();
            posicion = posicion + 1;
            persona.Nombre = txNombre.Text;
            Personas[posicion] = persona;  
            
        }


        private void btMostrar_Click(object sender, EventArgs e)
        {
            lbLista.Text = "Nombres cargados: \r\n" + "\r\n";
            foreach (Persona incremento in Personas)
            {
                lbLista.Text = lbLista.Text + incremento.Nombre + " " + "\r\n";
            }
        }

        //método para salir del formulario
        private void btsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }


}
