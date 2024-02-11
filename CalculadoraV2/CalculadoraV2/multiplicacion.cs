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
    public partial class multiplicacion : Form
    {
        public multiplicacion()
        {
            InitializeComponent();
        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtDivResultado_Click(object sender, EventArgs e)
        {
            int numDiv1;
            int numDiv2;
            int resultadoDiv;

            numDiv1 = Convert.ToInt32(txnumDiv1.Text);
            numDiv2 = Convert.ToInt32(txnumDiv2.Text);

            resultadoDiv = numDiv1 * numDiv2;

            labelResultado.Text = Convert.ToString(resultadoDiv);

        }
    }
}
