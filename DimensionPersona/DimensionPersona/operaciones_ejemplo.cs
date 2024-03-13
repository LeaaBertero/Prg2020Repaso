using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DimensionPersona
{
    public partial class operaciones_ejemplo : Form
    {
        public operaciones_ejemplo()
        {
            InitializeComponent();
        }

        private void btcalcular_Click(object sender, EventArgs e)
        {
            //int primerNumero;
            //int segundoNumero;

            //int resultadoSuma;

            //primerNumero = Convert.ToInt32(txnumero1.Text);
            //segundoNumero = Convert.ToInt32(txnumero2.Text);

            //resultadoSuma = primerNumero + segundoNumero;

            resultado.Text = "Resultado:" + " " + Convert.ToString(CacularSuma());
        }

        public int CacularSuma()
        {
            int primerNumero;
            int segundoNumero;

            int resultadoSuma;

            primerNumero = Convert.ToInt32(txnumero1.Text);
            segundoNumero = Convert.ToInt32(txnumero2.Text);

            resultadoSuma = primerNumero + segundoNumero;

            //Retorna un valor
            return resultadoSuma;
        }
    }
}
