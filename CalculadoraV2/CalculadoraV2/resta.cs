using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraV2
{
    public partial class Resta : Form
    {
        public Resta()
        {
            InitializeComponent();
        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btrestar_Click(object sender, EventArgs e)
        {

            int numResta1;
            int numResta2;
            int resultadoResta;

            numResta1 = Convert.ToInt32(txres1.Text);
            numResta2 = Convert.ToInt32(txres2.Text);

            resultadoResta = numResta1 - numResta2;

            //lbres.Text = Convert.ToString(resultado);
            lbresta.Text = Convert.ToString (resultadoResta);
        }
    }
}
