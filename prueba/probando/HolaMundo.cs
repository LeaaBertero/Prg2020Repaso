using probando.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace probando
{
    public partial class HolaMundo : Form
    {
                        //clase //objeto
        probando.Clases.Persona persona = new probando.Clases.Persona();


        public HolaMundo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por clikearme, me haces sentir tan bien !!!!!");
        }

        private void HolaMundo_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Si te sientes bien hoy, presiona aceptar !! =D");
        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtCargar_Click(object sender, EventArgs e)
        {
            persona.Nombre = txnombre.Text;
            persona.Edad = Convert.ToInt32(txedad.Text);
        }

        private void btmostrar_Click(object sender, EventArgs e)
        {
            lbLista.Text = "Lista de personas cargadas" + "\r\n" + "\r\n" +  " Nombre: " + persona.Nombre + "\r\n" + " Edad: " + persona.Edad + " " + "años";
        }
    }
}
