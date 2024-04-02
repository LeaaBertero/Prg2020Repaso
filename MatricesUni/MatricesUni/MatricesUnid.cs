using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatricesUni
{
    public partial class MatricesUnid : Form
    {
        string[] lista; //Matriz (lista)
        int posicion; //variable entera (posición)

        //constructor
        public MatricesUnid()
        {
            InitializeComponent();
            btiniciar.Enabled = false;
            btlistar.Enabled = false;
        }

       
        private void btDimensionar_Click(object sender, EventArgs e)
        {
            lista = new string[Convert.ToUInt32(TxCantidad.Text)];
            posicion = 0;
            btiniciar.Enabled = true;
            btlistar.Enabled = true;
        }

        //botón para cargar lista
        private void btiniciar_Click(object sender, EventArgs e)
        {
            lista[posicion] = TxNombre.Text;
            posicion = posicion + 1;

            TxNombre.Text = "";
            TxNombre.Focus();
        }

        private void btlistar_Click(object sender, EventArgs e)
        {
            
            for (int contador = 0; contador < lista.Length; contador++)
            {
                lblista.Text = "Lista de personas: " + "\r\n" + TxNombre.Text + lista[contador];
            }

            lblista.Visible = true;
        }



        private void btprueba_Click(object sender, EventArgs e)
        {
            Form prueba = new Prueba();
            prueba.Show();
        }

        //botón cerrar
        private void btcerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}


           



          
