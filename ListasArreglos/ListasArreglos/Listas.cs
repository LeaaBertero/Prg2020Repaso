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

        //public PersonaCls.Persona[] Personas { get; set; } 
        private PersonaCls.ListaPersonas Lista { get; set; } = new PersonaCls.ListaPersonas();
        //int posicion = -1;



        public Listas()
        {
            InitializeComponent();
        }

        //método para dimensionar la cantidad de nombres
        private void btDimension_Click(object sender, EventArgs e)
        {

        }

        //método para cargar una lista de nombres
        public void btcargar_Click(object sender, EventArgs e)
        {
            ////clase - variable --Instancia(Hace nacer un objeto)
            ////la sintaxis es lo mismo que llamar a un formulario
            ////desde otro formulario.
            //Persona persona = new PersonaCls.Persona();

            ////posicion = posicion + 1;
            //Lista.Redimensionar();
            //persona.Nombre = txNombre.Text;
            ////Personas[Personas.Length - 1] = persona;
            //Lista.Personas[Lista.Personas.Length - 1] = persona;
            //persona.añoNacimiento = Convert.ToInt32(txAñoNacimiento.Text);
            //persona.Documento = Convert.ToInt32(txDocumento.Text);

            Lista.AddPersona(txNombre.Text, txAñoNacimiento.Text, txDocumento.Text);

        }


        private void btMostrar_Click(object sender, EventArgs e)
        {
            //lbLista.Text = "Personas cargadas: \r\n" + "\r\n";
            //foreach (Persona incremento in Lista.Personas)
            //{
            //    lbLista.Text = lbLista.Text + "Nombre:" + " "
            //        + incremento.Nombre + " " + "\r\n"
            //        + "Año de nacimiento:" + " "
            //        + incremento.añoNacimiento + " " + "\r\n"
            //        + "Documento:" + " "
            //        + incremento.Documento + " " + "\r\n";
            //}
        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        //public void redimensionar()
        //{
        //    if (personas == null)
        //    {
        //        personas = new personacls.persona[1];
        //    }
        //    else
        //    {
        //        personacls.persona[] arraux = new personacls.persona[personas.length + 1];

        //        for (int incremento = 0; incremento < personas.length; incremento++)
        //        {
        //            arraux[incremento] = personas[incremento];
        //        }

        //        personas = arraux;
        //    }
        //}
    }
}
