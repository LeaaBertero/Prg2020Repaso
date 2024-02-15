using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace holaMundo
{
    public partial class HolaMundo : Form
    {

        string frase = "Hola Mundo";

        public HolaMundo()
        {
            InitializeComponent();
        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btcomenzar_Click(object sender, EventArgs e)
        {
            lbTexto.Text = "Hola, éste es mi primer programa" + " " + frase;
        }

        private void btlimpiar_Click(object sender, EventArgs e)
        {
            lbTexto.Text = null;
        }

        private void btTextoIni_Click(object sender, EventArgs e)
        {
            lbTexto.Text = "click en comenzar para visualizar el texto";
        }

        private void btIniciar_Click(object sender, EventArgs e)
        {

            string saludo = txtexto.Text;

            if (txtexto.Text == "Hola")
            {
                lbresultado.Text = saludo + " " + "Es la palabra correcta";
                lbresultado.Visible = true;
            }
            else if (txtexto.Text == "Mundo")
            {
                lbresultado.Text = saludo + " " + "No es la palabra correcta";
                lbresultado.Visible = true;
            }
            else if (txtexto.Text == "Visual")
            {
                lbresultado.Text = saludo + " " + "No es la palabra correcta";
                lbresultado.Visible = true;
            } 
            else if (txtexto.Text == "" )
            {
                lbresultado.Text = "No se puede dejar campos vacios";
                lbresultado.Visible = true;
            }





        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            txtexto.Text = null;
            lbresultado.Text = null;
        }
    }
}
