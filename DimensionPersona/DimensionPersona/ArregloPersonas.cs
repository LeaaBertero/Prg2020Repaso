using System.Security.Cryptography;

namespace DimensionPersona
{
    public partial class ArregloPersonas : Form
    {
        public DimensionPersona.Persona[] personas { get; set; }



        public ArregloPersonas()
        {
            InitializeComponent();
        }

        private void btcargar_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Nombre = txnombre.Text;
            persona.AñoNacimiento = Convert.ToInt32(txaño.Text);
            Redimensionar();
            personas[personas.Length - 1] = persona;
        }

        private void btmostrar_Click(object sender, EventArgs e)
        {
            //lblista.Text = "Lista:\\r\\n\\";
            foreach (Persona item in personas)
            {
                lblista.Text = "Lista de personas cargadas" 
                    + "\r\n" 
                    + "\r\n" 
                    + "Nombre:" + " " 
                    + item.Nombre + "\r\n" 
                    + "Año:" + " " + item.AñoNacimiento.ToString();
            }
        }

        private void Redimensionar()
        {
            if (personas == null)
            {
                personas = new Persona[0];
            }
            else
            {
                Persona[] arregloAuxiliar = new Persona[personas.Length + 1];

                for (int incremneto = 0; incremneto < personas.Length; incremneto++)
                {
                    arregloAuxiliar[incremneto] = personas[incremneto];
                }

                personas = arregloAuxiliar;
            }
        }

        private void btOperaciones_Click(object sender, EventArgs e)
        {
            Form calcu = new Calcu();
            calcu.Show();
        }

        private void btcerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
