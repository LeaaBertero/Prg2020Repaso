using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArraysV2
{
    public partial class ArreglosV2 : Form
    {
        string[] nombres;
        int posicionNombres;
        int cantidadNombres;


        public ArreglosV2()
        {
            InitializeComponent();
        }
       

        private void btDimensionar_Click(object sender, EventArgs e)
        {
            nombres = new string[cantidadNombres];
            cantidadNombres = Convert.ToInt32(txDimensionar.Text);
        }

        private void btcargar_Click(object sender, EventArgs e)
        {
            nombres[posicionNombres] = txNombre.Text;
            posicionNombres = posicionNombres + 1;
            txNombre.Focus();
            txNombre.SelectAll();
        }

        private void btmostrar_Click(object sender, EventArgs e)
        {
            foreach (string Incremen_tonombres in nombres)
            {
                lbLista.Text = " Lista de Nombres: " + "\r\n" + lbLista.Text + Incremen_tonombres + "\r\n";
                lbLista.Visible = true;
            }

        }

}
    }
       
