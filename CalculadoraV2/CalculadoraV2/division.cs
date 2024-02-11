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
    public partial class division : Form
    {
        public division()
        {
            InitializeComponent();
        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btDivResultado_Click(object sender, EventArgs e)
        {
            decimal numeroDiv1;
            decimal numeroDiv2;

            decimal ResultadoDivision;


            numeroDiv1 = Convert.ToDecimal(TxNumDiv2.Text);
            numeroDiv2 = Convert.ToDecimal(TxNumDiv2.Text);

            ResultadoDivision = numeroDiv1 / numeroDiv2;

            //labelDivResultado.Text = Convert.ToString(ResultadoDivision);
            labelDivResultado.Text = ResultadoDivision.ToString();
           
        }
    }
}
