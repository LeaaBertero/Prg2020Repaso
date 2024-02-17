using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace If
{
    public partial class pruebaSwitch : Form
    {
        public pruebaSwitch()
        {
            InitializeComponent();
        }

        private void btsalirSwitch_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void biiniciarSwitch_Click(object sender, EventArgs e)
        {

            switch (txoperador.Text)
            {
                case "+":
                    int numero1;
                    int numero2;

                    int resultado;

                    numero1 = Convert.ToInt32(txnum1.Text);
                    numero2 = Convert.ToInt32(txnum2.Text);

                    resultado = numero1 + numero2;

                    lbresSwitch.Text = resultado.ToString();
                break;
                
                case "-":
                    int numeroRes1;
                    int numeroRes2;

                    int resultadoRes;

                    numeroRes1 = Convert.ToInt32(txnum1.Text);
                    numeroRes2 = Convert.ToInt32(txnum2.Text);

                    resultadoRes = numeroRes1 - numeroRes2;

                    lbresSwitch.Text = resultadoRes.ToString();
                break;

                case "*":
                    int numeroMult1;
                    int numeroMult2;

                    int resultadoMult;

                    numeroMult1 = Convert.ToInt32(txnum1.Text);
                    numeroMult2 = Convert.ToInt32(txnum2.Text);

                    resultadoMult = numeroMult1 * numeroMult2;

                    lbresSwitch.Text = resultadoMult.ToString();
                break;

                case "/":
                    int numeroDiv1;
                    int numeroDiv2;

                    int resultadoDiv;

                    numeroDiv1 = Convert.ToInt32(txnum1.Text);
                    numeroDiv2 = Convert.ToInt32(txnum2.Text);

                    resultadoDiv = numeroDiv1 / numeroDiv2;

                    lbresSwitch.Text = resultadoDiv.ToString();
                break;
            }

          
        }
    }
}
