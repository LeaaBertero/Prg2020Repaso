using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HolaMundo.Clases;



namespace HolaMundo
{
    public partial class HolaMundo : Form
    {
        //La clase persona esta inicializada
        public Clases.Persona personas = new Clases.Persona();

        public HolaMundo()
        {
            InitializeComponent();
        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btcargar_Click(object sender, EventArgs e)
        {
            personas.Nombre = txnombre.Text;
            personas.documento = Convert.ToInt32(txdocumento.Text);
            personas.edad = Convert.ToInt32(txedad.Text);
            personas.altura = Convert.ToDecimal(txaltura.Text);

            txdocumento.Text = "";
            txnombre.Text = "";
            txedad.Text = "";
            txnombre.Focus();
            txnombre.SelectAll();
            dksfmfmskdfsdfms.dfm.sdmf.s

            

            MessageBox.Show("Carga correcta");
        }

        private void btmostrar_Click(object sender, EventArgs e)
        {
            //lbLista.Text = "";
            lbLista.Text = "\r\n" + "Lista de personas cargadas: " + "\r\n" + "\r\n" + "Nombre: "
                + " " + personas.Nombre + " " + "\r\n"
                + "Documento: " + personas.documento + "\r\n"
                + "Edad:" + " " + personas.edad + " " + "Años" + " " + "\r\n" + "Altura:" + " " + personas.altura;

            lbLista.Visible = true;
        }

        private void btlimpiar_Click(object sender, EventArgs e)
        {
            lbLista.Text = "";
        }
    }
}
