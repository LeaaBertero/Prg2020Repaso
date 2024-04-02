using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstruccionFor
{
    public partial class ForIni : Form
    {
        int contador;

        public ForIni()
        {
            InitializeComponent();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

       

        private void btIniciar_Click(object sender, EventArgs e)
        {
            //Convert.ToInt32(TXDesde.Text);

            for (Convert.ToInt32(TXDesde.Text);
                    contador <= Convert.ToInt32(TxHasta.Text);
                    contador = contador + Convert.ToInt32(TxPaso.Text))
            {
                //MessageBox.Show("Contando") = contador.ToString();
                LbResultado.Visible = true; ;
                LbResultado.Text = contador.ToString();
                this.Refresh();

            }

           


           
        }
    }
}
