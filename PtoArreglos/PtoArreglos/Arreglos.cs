using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PtoArreglos.Clases;

namespace PtoArreglos
{
    public partial class Arreglos : Form
    {
        //inicializando el objeto persona
        public PtoArreglos.Clases.Persona[] Personas { get; set; }
        //int posicion = -1;

        public Arreglos()
        {
            InitializeComponent();
        }

        private void btcargar_Click(object sender, EventArgs e)
        {
            //variable local del objeto, para el arreglo persona
            Persona persona = new Persona();
            persona.Nombre = txnombre.Text;
            persona.AñoNacimiento = Convert.ToInt32(txAñonacimiento.Text);
            //posicion = posicion + 1;
            Redimensionar();
            Personas[Personas.Length -1] = persona;

        }

        private void Txmostrar_Click(object sender, EventArgs e)
        {
            //lbLista.Text = "Lista de personas:" + "\r\n" + "Nombre: " + personas[0].Nombre + "\r\n" + "Año: " + personas[0].AñoNacimiento;

            foreach (Persona contadorLista in Personas)
            {
                lbLista.Text = "Lista de personas:" + "\r\n" + "Nombre: " + Personas[0].Nombre + "\r\n" + "Año: " + Personas[0].AñoNacimiento.ToString();
            }
            
            lbLista.Visible = true;
        }

        private void Redimensionar()
        {
            if (Personas == null)
            {
                Personas = new Persona[0];
            }
            else 
            {
                Persona[] Auxiliar = new Persona[Personas.Length +1];

                for (int contadorArr = 0; contadorArr < Personas.Length; contadorArr++)
                {
                    Auxiliar[contadorArr] = Personas[contadorArr];
                }

                Personas = Auxiliar;
            }
        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
