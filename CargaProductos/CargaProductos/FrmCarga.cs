using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CargaProductos
{
    public partial class FrmCarga : Form
    {
        public Producto[] PRODUCTOS = new Producto[5];
        int pos = 0;

        public FrmCarga()
        {
            InitializeComponent();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btCargaProd_Click(object sender, EventArgs e)
        {
            Producto productos = new Producto();

            productos.Nombre = txNombreProd.Text;
            productos.precio = Convert.ToDecimal(txPrecioProd.Text);

            txNombreProd.Text = "";
            txPrecioProd.Text = "";
            txNombreProd.Focus();
            txNombreProd.SelectAll();

            pos = pos + 1;
            PRODUCTOS[pos - 1] = productos;

        }

        private void btCargar_Click(object sender, EventArgs e)
        {
            try
            {
                lbListaProd.Text = "Lista de productos: " + "\r\n" + "\r\n"
               + "Nombre de producto: "
               + PRODUCTOS[0].Nombre + "\r\n"
               + "Precio: $ " 
               + PRODUCTOS[0].precio + "\r\n"
               + "Nombre de producto: "
               + PRODUCTOS[1].Nombre + "\r\n"
               + "Precio: $ "
               + PRODUCTOS[1].precio + "\r\n"
               + "Nombre de producto: "
               + PRODUCTOS[2].Nombre + "\r\n"
               + "Precio: $ "
               + PRODUCTOS[2].precio + "\r\n"
               + "Nombre de producto: "
               + PRODUCTOS[3].Nombre + "\r\n"
               + "Precio: $ "
               + PRODUCTOS[3].precio + "\r\n"
               + "Nombre de producto: "
               + PRODUCTOS[4].Nombre + "\r\n"
               + "Precio: $ "
               + PRODUCTOS[4].precio;


                lbListaProd.Visible = true;

            }
            catch (Exception)
            {
                MessageBox.Show("limite de carga, hasta 5 productos");
                //throw;
            }

        }
    }
}
