using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiasDimension
{
    public partial class ArregloNombres : Form
    {
        public Persona[] Persona = new Persona[1];
        int pos = 0;

        public ArregloNombres()
        {
            InitializeComponent();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btCargar_Click(object sender, EventArgs e)
        {
            Persona personas = new Persona();

            personas.Nombre = txNombre.Text;

            txNombre.Text = "";


            pos = pos + 1;
            Persona[pos - 1] = personas; 
        }

        private void btMostrar_Click(object sender, EventArgs e)
        {
            LbLista.Visible = true;
            LbLista.Text = "Lista de personas " + "\r\n" + "\r\n" + "Nombre: " + Persona[0].Nombre;
        }
    }
}
