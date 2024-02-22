using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer_prueba
{
    public partial class Timer : Form
    {
        //int contador;
        public Timer()
        {
            InitializeComponent();
            timer1.Start(); //inicializa el temporizador del reloj
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //contador = contador + 1;
            lbTimer.Text = "La hora es:" + " " + DateTime.Now.ToString("hh:mm:ss");
            //lbTimer.Text = DateTime.Now.ToString();
            lbTimer.Visible = true;
        }

      

        private void btcerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btmovimiento_Click(object sender, EventArgs e)
        {
            Form formulariolabelMov = new pruebaLblRun();
            formulariolabelMov.ShowDialog();
        }
    }
}
