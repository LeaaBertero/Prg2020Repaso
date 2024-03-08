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
        //variables para la suma
        int numSuma1;
        int numSuma2;

        int resultadoSuma;

        //variables para la resta
        int numeroRes1;
        int numeroRes2;

        int resultadoRes;

        //variables para la multiplicación
        int numeroMult1;
        int numeroMult2;

        int resultadoMult;

        //Variables para división
        int numeroDiv1;
        int numeroDiv2;

        int resultadoDiv;

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
                   
                    numSuma1 = Convert.ToInt32(txnum1.Text);
                    numSuma2 = Convert.ToInt32(txnum2.Text);

                    resultadoSuma = numSuma1 + numSuma2;

                    lbresSwitch.Text = resultadoSuma.ToString();

                break;
                
                case "-":
                   
                    numeroRes1 = Convert.ToInt32(txnum1.Text);
                    numeroRes2 = Convert.ToInt32(txnum2.Text);

                    resultadoRes = numeroRes1 - numeroRes2;

                    lbresSwitch.Text = resultadoRes.ToString();

                break;

                case "*":
                   
                    numeroMult1 = Convert.ToInt32(txnum1.Text);
                    numeroMult2 = Convert.ToInt32(txnum2.Text);

                    resultadoMult = numeroMult1 * numeroMult2;

                    lbresSwitch.Text = resultadoMult.ToString();

                break;

                case "/":
                   
                    numeroDiv1 = Convert.ToInt32(txnum1.Text);
                    numeroDiv2 = Convert.ToInt32(txnum2.Text);

                    resultadoDiv = numeroDiv1 / numeroDiv2;

                    lbresSwitch.Text = resultadoDiv.ToString();

                break;
            }

          
        }
    }
}
